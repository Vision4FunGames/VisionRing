using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using GameAnalyticsSDK;

public class LoadingSCene : MonoBehaviour,IGameAnalyticsATTListener
{
   public GameObject tutorial, loading;
   private VideoPlayer videoPlayer;
   private void Awake()
   {
      if(Application.platform == RuntimePlatform.IPhonePlayer)
      {
         GameAnalytics.Initialize();
      }
      else
      {
         GameAnalytics.Initialize();
      }
      
      if (!PlayerPrefs.HasKey("watchvideo"))
      {
         GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start,"Cinematic","Cinematic00");
         videoPlayer = tutorial.GetComponent<VideoPlayer>();
         PlayerPrefs.SetInt("watchvideo",1);
         tutorial.SetActive(true);
         loading.SetActive(false);
      }
      else if (PlayerPrefs.HasKey("watchvideo"))
      {
       ShowLoadingScene();
      }
   }

   private void Update()
   {
      if (videoPlayer&&videoPlayer.frame+400 >= (long)videoPlayer.frameCount && tutorial.gameObject.activeSelf)
      {
         GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete,"Cinematic","Cinematic00");
         tutorial.gameObject.SetActive(false);
         ShowLoadingScene();
      }
   }

   public void ShowLoadingScene()
   {
      tutorial.SetActive(false);
      loading.SetActive(true);
      StartCoroutine(LoadSceneAsync());
   }

   IEnumerator LoadSceneAsync()
   {
      yield return new WaitForSeconds(.5f);
     
      AsyncOperation operation = SceneManager.LoadSceneAsync(1);
      
      while (!operation.isDone)
      {
         yield return null;
      }
    
   }
   

   public void GameAnalyticsATTListenerNotDetermined()
   {
      GameAnalytics.Initialize();
   }

   public void GameAnalyticsATTListenerRestricted()
   {
      GameAnalytics.Initialize();
   }

   public void GameAnalyticsATTListenerDenied()
   {
      GameAnalytics.Initialize();
   }

   public void GameAnalyticsATTListenerAuthorized()
   {
      GameAnalytics.Initialize();
   }
}
