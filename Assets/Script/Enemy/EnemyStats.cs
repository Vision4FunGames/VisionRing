using UnityEngine;
using UnityEngine.PlayerLoop;
using MMProgressBar = MoreMountains.Tools.MMProgressBar;

public class EnemyStats : CharacterStats
{
   public EnemyType enemyType;

   private PuzzleController puzzleController;
   public event System.Action OnDie;
   private void Start()
   {
      puzzleController = GetComponentInParent<PuzzleController>();
      if (enemyType == EnemyType.skelet || enemyType == EnemyType.kingSkelet)
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
      if (OnDie !=null)
      {
         OnDie();
         
      }
      base.Die();
   }
}

public enum EnemyType { skelet, Boss , kingSkelet,Ghost , bombSkelet}
