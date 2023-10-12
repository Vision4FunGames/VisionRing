using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private CameraShake _cameraShake;
    private ParticleSystem _damageParticle;
    #region Singleton

    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
        _damageParticle = Instantiate(Resources.Load("ShadowExplosion", typeof(ParticleSystem))as ParticleSystem,new Vector3(0,2,0), Quaternion.identity,transform);
        _cameraShake = FindObjectOfType<CameraShake>();
    }


    #endregion

    public void KillPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void DamageHitParticle()
    {
        _damageParticle.Play();
    }

    public void CameraShakePlayer(float duration , float magnitude)
    {
        StartCoroutine(_cameraShake.ShakeVector(duration, magnitude));
    }

    public void CameraShakeCombo(float duration , float magnitude)
    {
        StartCoroutine(_cameraShake.Shake(.1f, magnitude*3));
    }
}
