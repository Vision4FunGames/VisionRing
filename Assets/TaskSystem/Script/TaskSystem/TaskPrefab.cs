using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using TaskSystem;


public class TaskPrefab : MonoBehaviour
{

    public Vector3 targetSpawnPoint;
    public bool isCompleted;
    //[ReadOnly] public TaskManager taskManager;
    [ReadOnly] public bool isMainTask;
    [ReadOnly] public TaskSystem.TaskManager taskManager;

    public void OnEnable()
    {
        taskManager = FindObjectOfType<TaskSystem.TaskManager>();
        StartCoroutine(WaitForComplete());
    }

    public IEnumerator WaitForComplete()
    {
        yield return new WaitUntil(() => isCompleted);
        taskManager.OnMainTaskCompleted();
    }
}
