using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildVersionChecker : MonoBehaviour
{
    private const string BuildVersionKey = "BuildVersion";

    void Awake()
    {
        string currentVersion = Application.version;
        string savedVersion = PlayerPrefs.GetString(BuildVersionKey, "");

        if (savedVersion != currentVersion)
        {
            Debug.Log($"Yeni build algılandı! PlayerPrefs sıfırlanıyor. Eski Versiyon: {savedVersion}, Yeni Versiyon: {currentVersion}");
            PlayerPrefs.DeleteAll();
            ES3.DeleteFile();
            PlayerPrefs.SetString(BuildVersionKey, currentVersion);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.Log("Build versiyonu aynı, PlayerPrefs sıfırlanmadı.");
        }
    }
}
