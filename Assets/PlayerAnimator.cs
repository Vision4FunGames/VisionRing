using System.Collections;
using System.Collections.Generic;
using AmazingAssets.DynamicRadialMasks;
using Exoa.TutorialEngine;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerAnimator : MonoBehaviour
{
    private Player player;
    private Animator animator;
    // Start is called before the first frame update
    public GameObject DRM;
    public GameObject fog;
    public ParticleSystem ringParticle;
    public ParticleSystem tutorialBangParticle;
    private bool playerDrop;
    void Start()
    {
        player = GetComponentInParent<Player>();
        animator = GetComponent<Animator>();
    }


    public void RingBtn()
    {
        if (!player.ring)
        {
            if (TutorialLoader.instance.loadedTutorialName == "Ring")
            {
                tutorialBangParticle.gameObject.SetActive(true);
                GetComponentInParent<Player>().isMovement = false;
                StartCoroutine(PlayerDrop());
                Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = false;
                UiManager.instance.ringBtn.GetComponent<Button>().enabled = false;
                Invoke("RingSound",2f);
                player.ring = true;
            }
            else
            {
                animator.SetTrigger("Ring");
                Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = false;
                Invoke("RingSound",2f);
                player.ring = true;
            }
        }
        
        //ringParticle.Play();
    }

    public void RingSound()
    {
        GetComponent<AudioSource>().clip =  GetComponentInParent<PlayerSound>().ringSound;
        GetComponent<AudioSource>().Play();
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
        Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = true;
        player.ring = false;
    }
    public void RingAction()
    {
        DRM.GetComponent<DRMGameObject>().SliderValueChanged();
    }

    public void RingActionEnd()
    {
        Player.instance._fixedJoystick.GetComponent<DynamicJoystick>().enabled = true;
        GetComponentInParent<Player>().isMovement = true;
        player.ring = false;
        animator.speed = .1f;
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
