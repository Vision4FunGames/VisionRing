using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System;
using TMPro;

public class DailyTimer : MonoBehaviour
{
    public GameObject dailyPanel;
    public TextMeshProUGUI timerTxt;
    private DateTime currentTime;
    private DateTime lastCheckedDate;
    private TimeSpan targetTime = new TimeSpan(3, 0, 0); // 03:00 UTC
    private bool isTimeFetched = false;
    private float lastControlTime;
    void Start()
    {
        StartCoroutine(GetTimeFromInternet());

        // Son giri� tarihini y�kle
        if (PlayerPrefs.HasKey("LastLoginDate"))
        {
            lastCheckedDate = DateTime.Parse(PlayerPrefs.GetString("LastLoginDate")).ToUniversalTime();
        }
        else
        {
            lastCheckedDate = DateTime.UtcNow;
        }

        // Oyun ba�larken g�n de�i�imi kontrol� yap
        if (DateTime.UtcNow.Date > lastCheckedDate.Date)
        {
            OnNewDay();
        }
        lastControlTime = Time.time;
    }

    IEnumerator GetTimeFromInternet()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://worldtimeapi.org/api/ip");
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            string json = www.downloadHandler.text;
            WorldTimeAPIResponse response = JsonUtility.FromJson<WorldTimeAPIResponse>(json);
            currentTime = DateTime.Parse(response.datetime).ToUniversalTime();
            Debug.Log("Current UTC time: " + currentTime);
            isTimeFetched = true;
        }
        else
        {
            //Debug.LogError("Failed to get time from internet");
            yield return new WaitForSeconds(1);
            StartCoroutine(GetTimeFromInternet());
        }
    }

    void Update()
    {
        if (!isTimeFetched || !dailyPanel.activeSelf) return;

        if (Time.time < lastControlTime + 1) return;

        lastControlTime = Time.time;
        // G�n de�i�imi kontrol�
        if (currentTime.Date > lastCheckedDate)
        {
            lastCheckedDate = currentTime.Date;
            OnNewDay();
        }

        // 03:00 UTC'ye kalan s�reyi hesapla ve g�ster
        TimeSpan timeToTarget = targetTime - currentTime.TimeOfDay;
        if (timeToTarget < TimeSpan.Zero)
        {
            timeToTarget = timeToTarget.Add(new TimeSpan(24, 0, 0)); // Ertesi g�n 03:00 UTC
        }

        //Debug.Log("Time until 03:00 UTC: " + timeToTarget.ToString(@"hh\:mm\:ss"));
        timerTxt.text = timeToTarget.ToString(@"hh\:mm\:ss");
        // currentTime'� sadece deltaTime ile g�ncellemek yerine ger�ek zamanla e�itle
        currentTime = DateTime.UtcNow;
    }

    public void OnNewDay()
    {

        Debug.Log("New day detected: " + currentTime.Date);
        // G�nl�k g�revlerinizi burada yenileyebilirsiniz

        PlaytimeRewardsManager.instance.DayReset();
        DailyQuestManager.Instance.DayReset();
        DailyCheckinManager.Instance.NextDay();

        // G�n de�i�imi sonras� lastCheckedDate g�ncelle
        lastCheckedDate = currentTime.Date;

        // Yeni g�n� kaydet
        PlayerPrefs.SetString("LastLoginDate", lastCheckedDate.ToString());
        PlayerPrefs.Save();
    }

    void OnApplicationQuit()
    {
        // Oyundan ��karken son giri� tarihini kaydet
        PlayerPrefs.SetString("LastLoginDate", currentTime.ToString());
        PlayerPrefs.Save();
    }
}

[Serializable]
public class WorldTimeAPIResponse
{
    public string datetime;
}
