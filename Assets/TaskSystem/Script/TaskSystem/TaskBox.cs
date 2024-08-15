using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NaughtyAttributes;
using DG.Tweening;

namespace TaskSystem
{
    public class TaskBox : MonoBehaviour
    {
        [ReadOnly] public bool isMainTask;
        public TextMeshProUGUI infoText;
        public Image backgroundImage;
        public TaskPrefab connectedTask;
        public LayoutElement layoutElement;
        public TaskPanelController taskPanelController;
        [Button]
        public void Resize()
        {
            StartCoroutine(ResizeAsync());
        }
        public IEnumerator ResizeAsync()
        {
            backgroundImage.rectTransform.sizeDelta = new Vector2(taskPanelController.parentRectTransform.sizeDelta.x, 0);
            yield return new WaitUntil(() => infoText.textBounds.extents.y >= 1.0f);
            float msgHeight = infoText.textBounds.extents.y;
            Vector2 infoTextSizeDelta = new Vector2(infoText.rectTransform.sizeDelta.x, msgHeight * 2);
            Vector2 infoTextAnchoredPos = new Vector2(0, -msgHeight - 10.0f);
            Vector2 imageSizeDelta = new Vector2(backgroundImage.rectTransform.sizeDelta.x, msgHeight * 2 + 20.0f);

            infoText.rectTransform.sizeDelta = infoTextSizeDelta;
            infoText.rectTransform.anchoredPosition = infoTextAnchoredPos;

            backgroundImage.rectTransform.DOSizeDelta(imageSizeDelta, 0.5f);
        }
        public void Dispose()
        {
            layoutElement.enabled = true;
            layoutElement.flexibleHeight = 1;
            backgroundImage.rectTransform.DOSizeDelta(new Vector2(backgroundImage.rectTransform.sizeDelta.x, 0), 0.5f).OnComplete(() =>
            {
                taskPanelController.spawnedBoxes.Remove(this);
                Destroy(gameObject);
            });
        }
    }

}
