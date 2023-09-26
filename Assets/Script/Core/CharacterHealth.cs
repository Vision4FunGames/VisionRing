using UnityEngine;

public abstract class CharacterHealth : MonoBehaviour
{
    public delegate void DieDelegate();
    public DieDelegate OnDie;
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
    
    protected void Die()
    {
        OnDie?.Invoke();
    }
}