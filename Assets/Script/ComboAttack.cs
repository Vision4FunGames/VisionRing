using UnityEngine;

public class ComboAttack : MonoBehaviour
{
    public GameObject mask;
    void Start()
    {
        FindObjectOfType<PlayerAttack>().isComboAttackBool = true;
        Invoke("maskClose",3f);
    }
    public void CompleteTask()
    {
        GetComponent<TaskPrefab>().isCompleted = true;
        Destroy(gameObject,.5f);
    }
    public void maskClose()
    {
        mask.SetActive(false);
    }
}
