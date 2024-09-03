using DG.Tweening;
using UnityEngine;

public class GrowTween : MonoBehaviour
{
    public Material[] materials;
    public float time = 2.0f;

    public float start;
    public float end;
    private float delta;
    private Material[] materialInstances;
    private bool _grow;

    public void StartGrowPurify()
    {
        delta = start - end;
        delta /= 3;
        materialInstances = new Material[materials.Length];
        for (int i = 0; i < materials.Length; i++)
        {
            materialInstances[i] = new Material(materials[i]);
        }

        GetComponent<Renderer>().materials = materialInstances;
        GetComponent<Outline>().enabled = true;
        GetComponent<Collider>().enabled = true;
    }

    public void Grow()
    {
        if (!_grow)
        {
            GetComponent<PurifyObject>().hitCount++;
            _grow = true;
            float val = start - delta;
            foreach (var item in materialInstances)
            {
                DOVirtual.Float(start, val, time, (z) => { item.SetFloat("_Grow", z); })
                    .OnComplete((() =>
                    {
                        start = val;
                        _grow = false;
                    }));
            }
        }
    }
}