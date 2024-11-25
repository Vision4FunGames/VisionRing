using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class DailyTimer : MonoBehaviour
{
    private DateTime currentTime;
    private DateTime lastCheckedDate;
    private TimeSpan targetTime = new TimeSpan(3, 0, 0); // 03:00 UTC

    void Start()
    {
        StartCoroutine(GetTimeFromInternet());

        // Son giriþ tarihini yükle
        if (PlayerPrefs.HasKey("LastLoginDate"))
        {
            lastCheckedDate = DateTime.Parse(PlayerPrefs.GetString("LastLoginDate")).ToUniversalTime();
        }
        else
        {
            lastCheckedDate = DateTime.UtcNow;
        }

        // Oyun baþlarken gün deðiþimi kontrolü yap
        if (DateTime.UtcNow.Date > lastCheckedDate.Date)
        {
            OnNewDay();
        }
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
        }
        else
        {
            Debug.LogError("Failed to get time from internet");
        }
    }

    void Update()
    {
        if (currentTime == null)
            return;

        currentTime = currentTime.AddSeconds(Time.deltaTime);

        // Gün deðiþimi kontrolü
        if (currentTime.Date > lastCheckedDate)
        {
            lastCheckedDate = currentTime.Date;
            OnNewDay();
        }

        // 03:00 UTC'ye kalan süreyi hesapla ve göster
        TimeSpan timeToTarget = targetTime - currentTime.TimeOfDay;
        if (timeToTarget < TimeSpan.Zero)
        {
            timeToTarget = timeToTarget.Add(new TimeSpan(24, 0, 0)); // Ertesi gün 03:00 UTC
        }

        Debug.Log("Time until 03:00 UTC: " + timeToTarget.ToString(@"hh\:mm\:ss"));
    }

    void OnNewDay()
    {
        Debug.Log("New day detected: " + currentTime.Date);
        // Günlük görevlerinizi burada yenileyebilirsiniz

        // Gün deðiþimi sonrasý lastCheckedDate güncelle
        lastCheckedDate = currentTime.Date;

        // Yeni günü kaydet
        PlayerPrefs.SetString("LastLoginDate", lastCheckedDate.ToString());
        PlayerPrefs.Save();
    }

    void OnApplicationQuit()
    {
        // Oyundan çýkarken son giriþ tarihini kaydet
        PlayerPrefs.SetString("LastLoginDate", currentTime.ToString());
        PlayerPrefs.Save();
    }
}

[Serializable]
public class WorldTimeAPIResponse
{
    public string datetime;
}


