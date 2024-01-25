using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoadingSCene : MonoBehaviour
{
   public GameObject tutorial, loading;
   private VideoPlayer videoPlayer;
   private void Awake()
   {
      if (!PlayerPrefs.HasKey("watchvideo"))
      {
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
      if (videoPlayer.frame-1 == (long)videoPlayer.frameCount && tutorial.gameObject.activeSelf)
      {
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
}
