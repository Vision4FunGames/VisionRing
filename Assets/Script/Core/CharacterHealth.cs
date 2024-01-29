using System;
using Exoa.TutorialEngine;
using MoreMountains.Tools;
using UnityEngine;

public abstract class CharacterHealth : MonoBehaviour
{
    public delegate void DieDelegate();

    public Player _player;
    public DieDelegate OnDie;
    protected float health;
    public MMProgressBar mmProgressBar;
    [HideInInspector] public bool useShield;
    public GameManager _gameManager;
    public bool IsAlive()
    {
        return health > 0;
    }

    public float GetHealth()
    {
        return health;
    }

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    public void TakeDamage(float damageAmount)
    {
        if (!useShield)
        {
            health -= damageAmount;
            UpdateHealthBar();
            if (health <=60 && !GameManager.instance.isHeal)
            {
                TutorialLoader.instance.Load("Heal");
                PlayerPrefs.SetInt("Heal",1);
                GameManager.instance.isHeal = true;
            }

            if (health <= 98 && !GameManager.instance.isDash)
            {
                TutorialLoader.instance.Load("Dash");
                PlayerPrefs.SetInt("Dash",1);
                GameManager.instance.isDash = true;
            }
            if (health <= 0)
            {
                Die();
            }
        }
    }

    public void UpdateHealthBar()
    {
        if (mmProgressBar)
            mmProgressBar.UpdateBar(health, 0, 300);
    }

    protected void Die()
    {
        _gameManager.UpdateGameState(GameState.GameOver);
        _player._playerAnimator.Play("Death");
        _player.StateMachine.ChangeState(new PlayerIdleState(_player,_player.StateMachine));
        OnDie?.Invoke();
        UiManager.instance.DeadUI();
    }
}