using Cinemachine;
using Exoa.TutorialEngine;
using PixelCrushers.QuestMachine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public GameObject StageBlocker1;


    public GameObject joystick;

    private readonly ManualResetEvent tuttiflag = new ManualResetEvent(false);


    public void Start()
    {
        TutorialEvents.OnTutorialComplete += TutorialCompleteHandler;
        var x = QuestMachine.GetQuestState("");
    }


    // Example function to be called when the button is pressed
    public void PlayerDown()
    {
        Player.instance._playerAnimator.Play("GetUp");
        Player.instance._playerAnimator.speed = 0;
        //_player._playerAnimator.Play("GetUp");
    }

    public void PlayerGetUp()
    {
        Player.instance._playerAnimator.speed = 1;

    }




    public void TutorialSequence(int seq)
    {
        switch (seq)
        {
            case 1:
                StartCoroutine(TutorialSequence1());
                break;
            default:
                break;
        }
    }

    IEnumerator TutorialSequence1()
    {

        PlayerDown();
        vcam.m_Lens.FieldOfView = 25;

        yield return new WaitForSeconds(5.0f);



        TutorialLoader.instance.Load("UITutorail1");
        joystick.SetActive(true);

        yield return new WaitUntil(() => flag);
        flag = false;

        PlayerGetUp();

        float timer = 0f;
        while (timer < 3f)
        {
            Debug.Log(Mathf.Lerp(25, 60, timer));
            vcam.m_Lens.FieldOfView = Mathf.Lerp(20, 60, timer);
            timer += Time.deltaTime;
            yield return null; 
        }
        vcam.m_Lens.FieldOfView = 60;



        //yield return new WaitForSeconds(3.0f);



    }

    bool flag = false;
    private void TutorialCompleteHandler()
    {
        flag = true;
    }
}

[UnityEditor.CustomEditor(typeof(ExampleScript))]
public class ExampleScriptEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ExampleScript myScript = (ExampleScript)target;




        if (GUILayout.Button("Tutorial Seq 1"))
        {
            myScript.TutorialSequence(1);
        }
    }
}
