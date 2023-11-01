using UnityEngine;
using UnityEngine.UI;

namespace Exoa.TutorialEngine
{
    public class TutorialStepAddBtn : MonoBehaviour
    {
        private Button btn;
        void Start()
        {
            btn = GetComponent<Button>();
            btn.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            TutorialStepEditorView.AddTutorialStep(new TutorialSession.TutorialStep());
        }

    }
}
