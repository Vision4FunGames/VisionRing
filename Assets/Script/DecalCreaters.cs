using NaughtyAttributes;
using Unity.Mathematics;
using UnityEngine;

public class DecalCreaters : MonoBehaviour
{
    public GameObject decal;

    [Button("Test")]
    public void ThrowRaycast()
    {
        RaycastHit objectHit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, fwd * 50, Color.green);
        if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
        {
            GameObject curremt = Instantiate(decal, objectHit.point,quaternion.identity);
        }
    }
}