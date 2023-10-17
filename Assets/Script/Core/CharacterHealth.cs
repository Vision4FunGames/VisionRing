using MoreMountains.Tools;
using UnityEngine;

public abstract class CharacterHealth : MonoBehaviour
{
    public delegate void DieDelegate();
    public DieDelegate OnDie;
    protected int health;
    public MMProgressBar mmProgressBar;
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
        UpdateHealthBar();
        if (health <= 0)
        {
            Die();
        }
    }
    public void UpdateHealthBar()
    {
        mmProgressBar.UpdateBar(health, 0, 100);
    }
    
    protected void Die()
    {
        OnDie?.Invoke();
    }
}