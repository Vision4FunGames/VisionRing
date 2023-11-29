using System;
using UnityEngine;

namespace Script.CombatScript
{
    public class Arrow : MonoBehaviour
    {
        private PlayerAttack playerAttack;
        private GameObject targetEnemy;
        private bool arrowMove;

        public void ArrowStart(GameObject target)
        {
            playerAttack = FindObjectOfType<PlayerAttack>();
            targetEnemy = target;
            arrowMove = true;
            Invoke("CloseArrow",5);
        }
        
        private void FixedUpdate()
        {
            if (arrowMove)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetEnemy.transform.position+ new Vector3(0,2,0), 10);
                transform.LookAt(targetEnemy.transform);
            }
        }

        public void CloseArrow()
        {
            gameObject.SetActive(false);
            playerAttack.arrow.Add(gameObject);
            
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                Invoke("CloseArrow",1);
                other.GetComponent<EnemyStats>().TakeDamage(playerAttack.damage);
            }
        }
    }
}