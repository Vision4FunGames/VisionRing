using DG.Tweening;
using UnityEngine;

public class wizardHealthSkill : MonoBehaviour
{
    public void MoveTarget(GameObject target)
    {
        transform.DOJump(
            new Vector3(target.transform.position.x, target.transform.position.y + 2f, target.transform.position.z),
            6f, 1, 1).SetEase(Ease.Linear).OnComplete((() =>
        {
            target.GetComponentInParent<CharacterStats>()
                .Heal((target.GetComponentInParent<CharacterStats>().currentHealth * 10) / 100);
            Destroy(gameObject);
        }));
    }
}