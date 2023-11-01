using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Exoa.TutorialEngine
{
    public class TutorialStepDelBtn : MonoBehaviour
    {
        private Button btn;
        void Start()
        {
            btn = GetComponent<Button>();
            btn.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            DestroyImmediate(transform.parent.parent.gameObject);
        }

    }
}
