using UnityEngine;
using UnityEngine.PlayerLoop;
using MMProgressBar = MoreMountains.Tools.MMProgressBar;

public class EnemyStats : CharacterStats
{
   public event System.Action OnDie;
   private void Start()
   {
      mmProgressBar ??= Instantiate(Resources.Load<Canvas>("EnemyHealthBar"),new Vector3(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z), Quaternion.identity,transform).GetComponentInChildren<MMProgressBar>();
   }

   public override void Die()
   {
      if (OnDie !=null)
      {
         OnDie();
         
      }
      base.Die();
   }
   
}
