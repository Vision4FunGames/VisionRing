using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TaskSystem
{
    public abstract class TaskChecker : MonoBehaviour
    {
        [ReadOnly] public bool done;
        global::TaskPrefab _taskInfo;
        public global::TaskPrefab TaskInfo { get { return (_taskInfo == null) ? _taskInfo = GetComponent<global::TaskPrefab>() : _taskInfo; } }

        public IEnumerator WaitForTask()
        {
            yield return new WaitUntil(() => done);
            TaskInfo.isCompleted = true;
        }
        public abstract void ConditionFounder();
    }

}