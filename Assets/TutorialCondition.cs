using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TutorialType
{
    fox
}

public class TutorialCondition : MonoBehaviour
{
    public TutorialType tutorialType;

    [Header("Fox Tutorial")] public GameObject cage;
    
    public void TutorialComplete()
    {
        switch (tutorialType)
        {
            case TutorialType.fox:
                FoxComplete();
                break;
        }
    }

    public void FoxComplete()
    {
        cage.GetComponent<Animator>().SetTrigger("Open");
        GetComponentInChildren<FoxManager>().TutorialFoxFinish();
    }
}