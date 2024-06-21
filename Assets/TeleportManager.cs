using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
   public Scene baseScene;


   public void TeleportScene(String sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }

   public void BaseSceneReturn()
   {
      SceneManager.LoadScene(1);
   }
}
