using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class test2 : MonoBehaviour
{
    private Player _player;
    private bool attack;
    public float currentTime;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 3 && !attack)
        {
            Move();
        }
        //transform.Translate(Vector3.forward*Time.deltaTime*speed);

        if (!attack)
        {
            currentTime += Time.deltaTime;
            var lookPos = _player.transform.position- transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
        }
    }

    public void Move()
    {
        currentTime = 0;
        attack = true;
        transform.DOMove(Vector3.forward* 10, 2).SetEase(Ease.Linear).OnComplete((() => attack = false));
    }
}
