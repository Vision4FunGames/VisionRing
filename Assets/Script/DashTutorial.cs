using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DashTutorial : MonoBehaviour
{
    public GameObject mask;
    public GameObject mickey;

    private Vector3 target;

    private Vector3 baseTarget;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Player>().isDashTutorial = true;
        Invoke("MaskClose", 3);
        target = mickey.transform.position - new Vector3(300, 0, 0);
        baseTarget = mickey.transform.position;
        MickeyAnimation();
    }

    public void MickeyAnimation()
    {
        mickey.transform.DOMove(
            target, 2).OnComplete((() =>
        {
            mickey.transform.position = baseTarget;
            MickeyAnimation();
        }));
    }
    public void CompleteTask()
    {
        GetComponent<TaskPrefab>().isCompleted = true;
        Destroy(gameObject,.5f);
    }
    public void MaskClose()
    {
        mask.SetActive(false);
    }
}