using System;
using Exoa.TutorialEngine;
using Lofelt.NiceVibrations;
using UnityEngine;
using MMProgressBar = MoreMountains.Tools.MMProgressBar;

public abstract class CharacterHealth : MonoBehaviour
{
    public delegate void DieDelegate();
    // public Stat damage;
    // public Stat armor;
    public Player _player;
    public DieDelegate OnDie;
    protected float health;
    private float maxxHealth; 
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
        maxxHealth = 300;
        if (!useShield)
        {
            health -= damageAmount;
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
            UpdateHealthBar();
            if (health <= maxxHealth *.9f && !GameManager.instance.isHeal)
            {
                TutorialLoader.instance.Load("Heal");
                PlayerPrefs.SetInt("Heal",1);
                GameManager.instance.isHeal = true;
            }
            if (health <= maxxHealth-10 && !GameManager.instance.isDash)
            {
                TutorialLoader.instance.Load("Dash");
                TutorialController.instance.mask.transform.GetChild(0).transform.gameObject.SetActive(true);
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