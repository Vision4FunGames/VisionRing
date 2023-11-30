using System;
using UnityEngine;

namespace Script.CombatScript
{
    public class Arrow : MonoBehaviour
    {
        public Vector3 splitTarget;
        public bool splitBoolMove;
        private PlayerAttack playerAttack;
        private GameObject targetEnemy;
        private bool arrowMove;
        private bool _split;

        public void ArrowStart(GameObject target, bool split)
        {
            splitBoolMove = false;
            _split = split;
            playerAttack = FindObjectOfType<PlayerAttack>();
            targetEnemy = target;
            arrowMove = true;
            Invoke("CloseArrow", 5);
        }

        private void FixedUpdate()
        {
            if (arrowMove)
            {
                transform.position = Vector3.MoveTowards(transform.position,
                    targetEnemy.transform.position + new Vector3(0, 2, 0), 5);
                transform.LookAt(targetEnemy.transform.position+new Vector3(0,2,0));
            }

            if (splitBoolMove)
            {
                transform.position = Vector3.MoveTowards(transform.position, splitTarget + new Vector3(0, 2, 0), 5);
            }
        }

        public void CloseArrow()
        {
            gameObject.SetActive(false);
            playerAttack.arrow.Add(gameObject);
        }

        public void SetSplitTarget()
        {
            playerAttack = FindObjectOfType<PlayerAttack>();
            _split = false;
            splitTarget = transform.position + (transform.forward * 50);
            splitBoolMove = true;
            Invoke("CloseArrow", 5);
        }

        public void SplitArrowSpawn()
        {
            for (int i = 0; i < 2; i++)
            {
                if (i % 2 == 0)
                {
                    GameObject currentArrowObj = playerAttack.arrow[0].gameObject;
                    playerAttack.arrow.RemoveAt(0);
                    currentArrowObj.SetActive(true);
                    currentArrowObj.transform.position = transform.position;
                    currentArrowObj.transform.eulerAngles = new Vector3(transform.eulerAngles.x,
                        transform.eulerAngles.y+90, transform.eulerAngles.z);
                    currentArrowObj.GetComponent<Arrow>().SetSplitTarget();
                }
                else
                {
                    GameObject currentArrowObj = playerAttack.arrow[0].gameObject;
                    playerAttack.arrow.RemoveAt(0);
                    currentArrowObj.SetActive(true);
                    currentArrowObj.transform.position = transform.position;
                    currentArrowObj.transform.eulerAngles = new Vector3(transform.eulerAngles.x,
                        transform.eulerAngles.y-90, transform.eulerAngles.z);
                    currentArrowObj.GetComponent<Arrow>().SetSplitTarget();
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                print(_split);
                if (_split)
                {
                    print("split");
                    SplitArrowSpawn();
                }

                Invoke("CloseArrow", 1);
                other.GetComponent<EnemyStats>().TakeDamage(playerAttack.damage);
            }
        }
    }
}