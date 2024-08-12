using UnityEngine;


public class EnemyVariations : MonoBehaviour
{
    public GameObject eyes;

    public EnemyVariation EnemyVariation;

    public void VariationChange(int change)
    {
        if (eyes)
        {
            switch (change)
            {
                case 0:
                    eyes.SetActive(false);
                    break;
                case 1:
                    eyes.SetActive(true);
                    break;
            }
        }
    }
}