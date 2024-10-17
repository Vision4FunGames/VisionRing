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
        Invoke("CompleteTask",1);
    }
    
    
    public void CompleteTask()
    {
        GetComponentInParent<TaskPrefab>().isCompleted = true;
        Destroy(transform.parent.gameObject,1);
    }
}
