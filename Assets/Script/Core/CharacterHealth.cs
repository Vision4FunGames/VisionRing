using UnityEngine;

public abstract class CharacterHealth : MonoBehaviour
{
    protected int health;

    public bool IsAlive()
    {
        return health > 0;
    }

    public int GetHealth()
    {
        return health;
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Die();
        }
    }

    protected abstract void Die();
}