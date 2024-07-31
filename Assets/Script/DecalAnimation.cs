using System.Collections;
using Bearroll.UltimateDecals;
using UnityEngine;

public class DecalAnimation : MonoBehaviour
{
    private UltimateDecal _ultimateDecal;
    public float delay = 1.0f; // Delay süresi
    public int atlasLength;
    private void Start()
    {
        _ultimateDecal = GetComponent<UltimateDecal>();
        StartCoroutine(RotateArray());
    }

    private IEnumerator RotateArray()
    {
        int index = 0;

        while (true)
        {
            yield return new WaitForSeconds(delay);
            index++;
            UD_Manager.UpdateDecal(_ultimateDecal);
            _ultimateDecal.atlasIndex = index;
            if (index >= atlasLength)
            {
                index = 0;
            }
        }
    }
}
