using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray,out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.gameObject.name == "Blacksmith")
                {
                  UiManager.instance.BlackSmithUI();
                }

                if (hit.transform.gameObject.name == "pouch")
                {
                    hit.transform.gameObject.GetComponent<PouchManager>().OpenPouchPanel();
                    UiManager.instance.selectedPouch = hit.transform.gameObject;
                }
                if (hit.transform.gameObject.name == "Chest")
                {
                    UiManager.instance.ChestPanelUI();
                    UiManager.instance.caseScroll.GetComponent<CaseScroll>().Scroll();
                }
                
                
              
                

            }
        }
    }
}
