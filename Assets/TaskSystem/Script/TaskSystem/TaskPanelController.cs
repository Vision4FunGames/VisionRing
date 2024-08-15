using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using NaughtyAttributes;
using System;
using System.Linq;
using Unity.VisualScripting;
namespace TaskSystem
{
    [DefaultExecutionOrder(-20)]
    public class TaskPanelController : MonoBehaviour
    {
        public static TaskPanelController instance;
        public List<TaskBox> spawnedBoxes = new List<TaskBox>();
        public List<Task> spawnedTasks = new List<Task>();
        public TaskBox taskBoxPrefab;
        public RectTransform parentRectTransform;
        public Button button;
        [ReadOnly] public bool isOpen = false;
        [Header("Options")]
        [Min(100)] public int headerSizeMulti;
        [Min(50)] public int hintSizeMulti;
        public float panelHiddenPosX;
        public float panelOpenPosX;
        public float buttonOpenPosX;
        public float buttonHiddenPosX;
        public float buttonAnimationTime = 0.1f;
        public float panelAnimationTime = 0.1f;
        Tween moveTweenPanel, moveTweenButton;
        public void Awake()
        {
            instance = this;
            OpenCloseTaskMenu();
        }
        public void OnEnable()
        {
            button.onClick.AddListener(OpenCloseTaskMenu);
        }
        private void OnDisable()
        {
            button.onClick.RemoveListener(OpenCloseTaskMenu);
        }
        public void OpenCloseTaskMenu()
        {
            isOpen = !isOpen;
            moveTweenPanel.Kill();
            moveTweenButton.Kill();
            moveTweenPanel = parentRectTransform.transform.DOMoveX(isOpen ? panelOpenPosX : panelHiddenPosX, panelAnimationTime).SetDelay(buttonAnimationTime);
            moveTweenButton = button.gameObject.transform.DOMoveX(isOpen ? buttonHiddenPosX : buttonOpenPosX, buttonAnimationTime);
        }
        public void SpawnTaskUI(Task task)
        {
            if (spawnedTasks.Contains(task))
            {
                Debug.Log("Already Spawned");
                return;
            }
            spawnedTasks.Add(task);
            // Set values for content & Spawn
            string msg = "";
            msg += "<size=" + headerSizeMulti + "%>" + task.questDirections;
            msg += "\n <size=" + hintSizeMulti + "%> -" + task.hint + "\n";
            TaskBox spawnedBox = Instantiate(taskBoxPrefab, parentRectTransform);
            spawnedBox.name = task.taskName;

            spawnedBox.taskPanelController = this;
            spawnedBoxes.Add(spawnedBox);

            // Child
            spawnedBox.transform.SetSiblingIndex(1);
            spawnedBox.isMainTask = task.IsMainTask();

            spawnedBox.infoText.text = msg;
            spawnedBox.Resize();
        }

        internal void DestroyLastMainTask()
        {
            TaskBox lastMain = spawnedBoxes.Where(t => t.isMainTask).FirstOrDefault();
            lastMain.Dispose();
        }
    }
}