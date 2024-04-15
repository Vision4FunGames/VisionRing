using UnityEngine;
using UnityEngine.PlayerLoop;
using MMProgressBar = MoreMountains.Tools.MMProgressBar;

public class EnemyStats : CharacterStats
{
    public EnemyType enemyType;
    public SpawnEnemyType SpawnEnemyType;
    public bool tutorial;
    private PuzzleController puzzleController;
    private TutoCage tutoCage;
    private PuzzleConditionController puzzleConditionController;
    private TutorialEnemies _tutorialEnemies;
    public event System.Action OnDie;

    private void Start()
    {
        if (tutorial)
        {
            tutoCage = GetComponentInParent<TutoCage>();
            _tutorialEnemies = GetComponentInParent<TutorialEnemies>();
        }

        puzzleController = GetComponentInParent<PuzzleController>();
        if (enemyType is EnemyType.skelet or EnemyType.kingSkelet or EnemyType.Ghost)
        {
            mmProgressBar ??=
                Instantiate(Resources.Load<Canvas>("EnemyHealthBar"),
                    new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity,
                    transform).GetComponentInChildren<MMProgressBar>();
        }

        puzzleConditionController = GetComponentInParent<PuzzleConditionController>();
    }

    public override void Die()
    {
        if (OnDie != null)
        {
            OnDie();
        }
        die = true;

        if (GetComponent<CapsuleCollider>())
            GetComponent<CapsuleCollider>().enabled = false;
        
        if (GetComponentInParent<EndlessSkelet>())
        {
            GetComponentInParent<EndlessSkelet>().DeadEnemy();
        }
        Player.instance.GetComponent<PlayerLevel>().ExpCalculate(10);
        FindObjectOfType<DrmEnemyChange>().EnemyVariationsList.Remove(GetComponent<EnemyVariations>());
        
        if (puzzleController != null)
        {
            puzzleController.EnemyDead();
        }

        if (puzzleConditionController)
            puzzleConditionController.DeadEnemyPuzzle();

        if (_tutorialEnemies != null)
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
            _tutorialEnemies.EnemyDied();
        }

        if (tutorial && tutoCage != null)
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
            tutoCage.EnemyDied();
        }
        base.Die();
    }
}

public enum EnemyType
{
    skelet,
    Boss,
    kingSkelet,
    Ghost,
    bombSkelet
}