using System.Collections;
using System.Collections.Generic;
using AmazingAssets.DynamicRadialMasks;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    public GameObject DRM;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void RingBtn()
    {
        animator.SetTrigger("Ring");
        Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = false;
    }
    public void RingAction()
    {
        DRM.GetComponent<DRMGameObject>().SliderValueChanged();
       
    }

    public void RingActionEnd()
    {
        Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
