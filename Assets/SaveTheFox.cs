using System;
using DG.Tweening;
using NaughtyAttributes;
using TaskSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveTheFox : MonoBehaviour
{
    public TaskSystem.TaskManager TaskManager;
    public GameObject canvas;
    public TextMeshProUGUI foxSpeecText;
    public String speechPartOne, speecPartTwo;
    private Player _playerController;
    public bool changeTxt;
    public float distance;
    private int _speechCount;
    bool _speechDone;

    private void Awake()
    {
        _playerController = FindObjectOfType<Player>();
    }

    private void Update()
    {
        distance = Vector3.Distance(_playerController.transform.position, transform.position);
        if (distance < 25 && !changeTxt)
        {
            var box = TaskPanelController.instance.GetLastMainTask();
            box.infoText.text = "Save the Fox";
            changeTxt = true;
        }

        if (_speechDone && Input.GetMouseButtonDown(0))
        {
            FoxSpeech();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Solar"))
        {
            GetComponent<Waypoint_Indicator>().enableSprite = true;
        }
    }

    public void FoxFree()
    {
        GetComponentInParent<TaskPrefab>().transform.GetComponentInChildren<UnityEngine.AI.NavMeshAgent>().enabled = true;
        GetComponentInParent<TaskPrefab>().transform.GetComponentInChildren<UnityEngine.AI.NavMeshAgent>().transform
            .SetParent(null);
        Invoke("FoxSpeech",2f);
    }
    [Button("Test")]
    public void FoxSpeech()
    { 
        canvas.SetActive(true);
        _speechDone = false;
        foxSpeecText.text = "";
        if (_speechCount == 0)
        {
            foxSpeecText.DOText(speechPartOne, 2f).OnComplete((() => _speechDone = true));
        }

        else if (_speechCount == 1)
        {
            foxSpeecText.DOText(speecPartTwo, 2f).OnComplete((() => _speechDone = true));
        }
        else if (_speechCount == 2)
        {
            CompleteTask();
        }

        _speechCount++;
    }

    public void CompleteTask()
    {
        canvas.SetActive(false);
        GetComponentInParent<TaskPrefab>().isCompleted = true;
        transform.parent.DOScale(Vector3.zero, 1);
        Destroy(transform.gameObject, 1f);
    }
}