using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using NaughtyAttributes;
using System;

namespace TaskSystem
{
    public class TaskManager : TaskSingleton<TaskManager>
    {
        public TaskGroup mainTasks;
        public TaskGroup manualTasks;

        private string MainTasksSaveKey => mainTasks.taskType.ToString() + "_Progress";

        public int LastMainTaskIndex;

        public new void Awake()
        {
            base.Awake();
            CheckForMainTasks();
        }

        public void CheckForMainTasks()
        {
            if (ES3.KeyExists(MainTasksSaveKey))
            {
                LastMainTaskIndex = ES3.Load(MainTasksSaveKey, 0);
            }

            Debug.Log("Task      " + LastMainTaskIndex);

            if (LastMainTaskIndex > 5 && LastMainTaskIndex < 11)
                LastMainTaskIndex = 5;
            else if (LastMainTaskIndex > 18 && LastMainTaskIndex < 21)
                LastMainTaskIndex = 18;
            
            var currentTask = mainTasks.taskData[LastMainTaskIndex];
            currentTask.MarkAsMainTask();
            var taskPrefab = Instantiate(currentTask.prefab, null);
            taskPrefab.taskManager = this;
            taskPrefab.isMainTask = true;
            TaskPanelController.instance.SpawnTaskUI(currentTask);
        }

        internal void OnMainTaskCompleted()
        {
            LastMainTaskIndex++;
            ES3.Save(MainTasksSaveKey, LastMainTaskIndex);

            var currentTask = mainTasks.taskData[LastMainTaskIndex];
            currentTask.MarkAsMainTask();
            var taskPrefab = Instantiate(currentTask.prefab, null);
            taskPrefab.taskManager = this;
            taskPrefab.isMainTask = true;

            TaskPanelController.instance.DestroyLastMainTask();
            TaskPanelController.instance.SpawnTaskUI(currentTask);
        }
    }

    [System.Serializable]
    public class TaskGroup
    {
        public TaskType taskType;
        public List<Task> taskData = new List<Task>();
    }

    [System.Serializable]
    public class Task
    {
        public string taskName;
        [Multiline] public string questDirections;
        [Multiline] public string hint;
        public DetailedInfo detailedInfo;
        public TaskPrefab prefab;
        private bool isMainTask;
        public void MarkAsMainTask() => isMainTask = true;
        public bool IsMainTask() => isMainTask;
    }

    [System.Serializable]
    public class DetailedInfo
    {
        [Multiline] public string onClickDescription;
        [Space(10)] public Sprite rewardIcon;
        [Space(10)] public int rewardAmount = 0;
    }

    public enum TaskType
    {
        Undefined,
        MainQuestLine,
        ManualCall
    }
}