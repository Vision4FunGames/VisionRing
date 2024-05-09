using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPointNavmesh : MonoBehaviour
{
    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        bool isCorrect = false;
        while (!isCorrect)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            UnityEngine.AI.NavMeshHit hit;
            if (UnityEngine.AI.NavMesh.SamplePosition(randomPoint, out hit, 4.0f, UnityEngine.AI.NavMesh.AllAreas))
            {
                result = hit.position;
                isCorrect = true;
                return true;
            }
        }
        result = Vector3.zero;
        return false;
    }

    

    public Vector3 RandomPoint(float range)
    {
        Vector3 point;
        Debug.Log(range+"Range");
        if (RandomPoint(_player.transform.position, range, out point))
        {
            Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
        }

        return point;
    }
}
