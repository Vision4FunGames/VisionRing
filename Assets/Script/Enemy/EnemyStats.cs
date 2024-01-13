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
         mmProgressBar ??= Instantiate(Resources.Load<Canvas>("EnemyHealthBar"),new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity,transform).GetComponentInChildren<MMProgressBar>();
      }
   }

   public override void Die()
   {
      if (puzzleController != null)
      {
         puzzleController.EnemyDead();
      }

      if (_tutorialEnemies != null)
      {
         _tutorialEnemies.EnemyDied();
      }

      if (tutorial && tutoCage != null)
      {
         tutoCage.EnemyDied();
      }
      if (OnDie !=null)
      {
         OnDie();
         
      }
      base.Die();
   }
}
public enum EnemyType { skelet, Boss , kingSkelet,Ghost , bombSkelet}
