using System;
using UnityEngine;

public class DetectEnemyCollider : MonoBehaviour
{
    private CharacterAnimator characterAnimator;
    private Enemy enemy;
    private EnemyStats _enemyStats;
    private PlayerAttack _playerAttack;
    private Player player;
    private Rigidbody rb;
    private float currentFlameTimer;

    private void Awake()
    {
        characterAnimator = GetComponent<CharacterAnimator>();
        rb = GetComponent<Rigidbody>();
        enemy = GetComponent<Enemy>();
        _enemyStats = GetComponent<EnemyStats>();
        _playerAttack = Player.instance.GetComponent<PlayerAttack>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tornado"))
        {
            enemy.TornadoStart(other.gameObject);
        }

        if (other.CompareTag("RotateFire"))
        {
            _enemyStats.TakeDamage(_playerAttack.CalculateDamage());
        }

        if (other.CompareTag("SwordCollider"))
        {
            Vector3 enemyPosition = transform.position;
            Vector3 playerPosition = _playerAttack.transform.position;

            Vector3 directionToPlayer = enemyPosition - playerPosition;

            float angle = Vector3.Angle(transform.forward, directionToPlayer);

            if (_enemyStats.enemyType == EnemyType.kingSkelet)
            {
                if (characterAnimator.shied)
                {
                    if (angle < 90)
                        _enemyStats.TakeDamage(_playerAttack.CalculateDamage(), _playerAttack.critChance);
                    else
                    {
                        Player.instance.BackDoMove(gameObject);
                    }
                }
                else
                    _enemyStats.TakeDamage(_playerAttack.CalculateDamage(), _playerAttack.critChance);
            }
            else
                _enemyStats.TakeDamage(_playerAttack.CalculateDamage(), _playerAttack.critChance);
        }

        if (other.CompareTag("Floor"))
        {
            rb.isKinematic = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Flame"))
        {
            if (currentFlameTimer > _playerAttack.flameDamageRateOfFire)
            {
                currentFlameTimer = 0;
                enemy.AddDomoveBack();
                _enemyStats.TakeDamage(_playerAttack.flameDamage);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.name == "ArrowRain")
        {
            print("aa");
            _enemyStats.TakeDamage(10);
        }
    }

    private void Update()
    {
        currentFlameTimer += Time.deltaTime;
    }
}