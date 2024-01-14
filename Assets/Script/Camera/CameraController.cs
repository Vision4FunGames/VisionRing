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
                if (hit.transform.gameObject.name == "Blacksmith")
                {
                  UiManager.instance.BlackSmithUI();
                }

                else if (hit.transform.gameObject.name == "pouch")
                {
                    hit.transform.gameObject.GetComponent<PouchManager>().OpenPouchPanel();
                    UiManager.instance.selectedPouch = hit.transform.gameObject;
                }
                else if (hit.transform.gameObject.name == "Chest")
                {
                    hit.transform.gameObject.GetComponent<ChestManager>().GoToCamera();
                    hit.transform.gameObject.GetComponent<BoxCollider>().enabled = false;

                }

                else if (hit.transform.gameObject.name == "Merchant")
                {
                    UiManager.instance.CloseAllUI();
                    UiManager.instance.ShopUI();
                }
                else if (hit.transform.gameObject.name == "Magician")
                {
                    UiManager.instance.MagicianUI();
                }
                
                
              
                

            }
        }
    }
}
