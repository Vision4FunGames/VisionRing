using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DoTweenAnimationController : MonoBehaviour
{
    [SerializeField] private Vector3 _targetLocation = Vector3.zero;
    private Vector3 _targetScale = Vector3.one;


    [Range(0f, 10.0f), SerializeField] private float _moveDuration = 1.0f;

    [SerializeField] private Ease _moveEase = Ease.Linear;

    [SerializeField] private DoTweenType _doTweenType = DoTweenType.MOVEMENT_ONE_WAY;

    private enum DoTweenType
    {
        MOVEMENT_ONE_WAY,
        MOVEMENT_ONE_TWOWAY
    }


    public void StartMove(float delay)
    {
        if (_doTweenType == DoTweenType.MOVEMENT_ONE_WAY)
        {
            if (_targetLocation == Vector3.zero)
                _targetLocation = new Vector3(transform.position.x, 0, transform.position.z);

            transform.DOLocalMove(_targetLocation, _moveDuration).SetEase(_moveEase).SetDelay(delay)
                .OnComplete((() =>
                {
                    ParticleSystem particleSystem = Instantiate(Resources.Load<ParticleSystem>("SmokeExplosionWhite"));
                    particleSystem.transform.SetParent(transform);
                    particleSystem.transform.localPosition = Vector3.zero;
                    particleSystem.transform.localScale = new Vector3(3, 3, 32);
                    particleSystem.Play();
                    Destroy(particleSystem.gameObject,3);
                }));
        }
        else if (_doTweenType == DoTweenType.MOVEMENT_ONE_TWOWAY)
        {
            if (_targetLocation == Vector3.zero)
                _targetLocation = transform.position;

            StartCoroutine(MoveWithBothWays());
        }
    }

    
    private IEnumerator MoveWithBothWays()
    {
        Vector3 originalLocation = transform.position;
        transform.DOMove(_targetLocation, _moveDuration).SetEase(_moveEase);
        yield return new WaitForSeconds(_moveDuration);
        transform.DOMove(originalLocation, _moveDuration).SetEase(_moveEase);
    }
}