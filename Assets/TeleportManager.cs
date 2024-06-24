using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
   public Scene baseScene;


   public void TeleportScene(String sceneName)
   {
      String sceneKey = SceneManager.GetActiveScene().name;
      Debug.Log(sceneKey);
      SceneManager.LoadScene(sceneName);
   }

   public void DungeonScene(String sceneName)
   {
      String sceneKey = SceneManager.GetActiveScene().name;
      Debug.Log(sceneKey);
      SceneManager.LoadScene(sceneName);
   }

   public void BaseSceneReturn()
   {
      SceneManager.LoadScene(1);
   }
}
