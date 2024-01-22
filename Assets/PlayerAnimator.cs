using System.Collections;
using System.Collections.Generic;
using AmazingAssets.DynamicRadialMasks;
using Exoa.TutorialEngine;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    public GameObject DRM;
    public GameObject fog;
    public ParticleSystem ringParticle;
    public ParticleSystem tutorialBangParticle;
    private bool playerDrop;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void RingBtn()
    {
        if (TutorialLoader.instance.loadedTutorialName == "Ring")
        {
            tutorialBangParticle.gameObject.SetActive(true);
            Invoke("MovementAvailbe",4);
            GetComponentInParent<Player>().isMovement = false;
            StartCoroutine(PlayerDrop());
            UiManager.instance.ringBtn.GetComponent<Button>().enabled = false;

        }
        else
        {
            animator.SetTrigger("Ring");
            Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = false;
        }
        
        //ringParticle.Play();
      
    }

    IEnumerator PlayerDrop()
    {
        if (!playerDrop)
        {
            playerDrop = true;
            yield return new WaitForSeconds(2f);
            animator.SetTrigger("Dusme");
            animator.speed = .44f;
            GameManager.instance.tutoCage.GetComponent<TutoCage>().AllEnemyDie();
         
        }
       
    }

    public void MovementAvailbe()
    {
        GetComponentInParent<Player>().isMovement = true;
    }
    public void RingAction()
    {
        DRM.GetComponent<DRMGameObject>().SliderValueChanged();
        
    }

    public void RingActionEnd()
    {
        Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = true;
        GetComponentInParent<Player>().isMovement = true;
        //ringParticle.Stop();
    }

    public void FogAction()
    {
        fog.GetComponent<FogScale>().StartScale();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
