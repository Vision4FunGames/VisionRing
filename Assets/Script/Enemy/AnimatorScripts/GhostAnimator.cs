using UnityEngine;

public class GhostAnimator : MonoBehaviour
{
    public GameObject rightHand;
    public PoolingObject ballPrefab;
    private Player player;
    public GameObject curr;
    public PoolingObjectSpawner poolingObjectSpawner;
    private void Start()
    {
        player = Player.instance;
        poolingObjectSpawner = GetComponent<PoolingObjectSpawner>();
    }

    public void Throw()
    {
        print("thrıw");
       // var currentBall = Instantiate(ballPrefab, rightHand.transform.position, Quaternion.identity);
       poolingObjectSpawner._pool.Get();
       GetComponent<DamageManager>().closeBallPart();
       // currentBall.transform.DOMove(new Vector3(player.transform.position.x, player.transform.position.y + 2f, player.transform.position.z),.2f).OnComplete(()=>Destroy(currentBall.gameObject));
    }
    public void DeathEnemy()
    {
        Destroy(transform.parent.gameObject);
    }
}
