using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTestEnes : MonoBehaviour
{
   public void SceneLoad()
   { 
      int i = 0;
      i = PlayerPrefs.GetInt("level");
      i++;
      PlayerPrefs.SetInt("level",i);
      SceneManager.LoadScene(i%3);
   }
}
