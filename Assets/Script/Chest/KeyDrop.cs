using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDrop : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x,player.position.y+2f,player.position.z), 3f *2* Time.deltaTime);
        GetComponent<Collider>().isTrigger = true;
        // Eğer Player'a ulaşıldıysa Coin'i yok et
        if (Vector3.Distance(transform.position, new Vector3(player.position.x,player.position.y +2f,player.position.z)) < 0.1f)
        {
            GameManager.instance.TutorialLoad();
            Destroy(gameObject);
        }
    }
}
