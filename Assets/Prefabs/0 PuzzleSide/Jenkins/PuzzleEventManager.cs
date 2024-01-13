using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class PuzzleEventManager
{
    public static UnityEvent<Vector3> OnNewRespawnPointObtained = new UnityEvent<Vector3>();
}
