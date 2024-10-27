using DG.Tweening;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public ParticleSystem gimletParticle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            BreakSphere();
        }
    }

    public void BreakSphere()
    {
        gimletParticle.Play();
        GetComponent<Waypoint_Indicator>().enabled = false;
        transform.DOScale(Vector3.zero, 1f);
        Invoke("CompleteTask",1);
    }
    
    
    public void CompleteTask()
    {
        GetComponentInParent<TaskPrefab>().isCompleted = true;
        Destroy(transform.parent.gameObject,1);
    }
}
