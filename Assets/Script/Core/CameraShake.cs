    using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
    using NaughtyAttributes;
    using UnityEngine;
using Random = UnityEngine.Random;

public class CameraShake : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachineTransposer _cinemachineTransposer;
    public float magnitude, duration;
    private Vector3 _basePosition;
    private void Awake()
    {
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        _cinemachineTransposer = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>();
        _basePosition = _cinemachineTransposer.m_FollowOffset;
    }

    [Button("sss")]
    public void ShakeCam()
    {
        StartCoroutine(ShakeVector(duration, magnitude));
    }

    public void ShakeBoss()
    {
        StartCoroutine(Shake(2f, 2f));
    }
    public IEnumerator Shake(float duration, float magnitude)
    {
        float elapsed = 0f;
        
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;

            cinemachineVirtualCamera.m_Lens.Dutch = x;
            elapsed += Time.deltaTime;
            yield return 0;
        }
        cinemachineVirtualCamera.m_Lens.Dutch = 0;
    }
    public IEnumerator ShakeVector(float duration, float magnitude)
    {
        float elapsed = 0f;
        
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1, 1) * magnitude;
            _cinemachineTransposer.m_FollowOffset = _basePosition + new Vector3(x,0,y);
            elapsed += Time.deltaTime;
            yield return 0;
        }

        _cinemachineTransposer.m_FollowOffset = _basePosition;
    }

}
