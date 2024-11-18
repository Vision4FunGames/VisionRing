using AllIn1SpringsToolkit;
using DG.Tweening;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewChest : MonoBehaviour
{
    [MinMaxSlider(1, 10)]
    public Vector2 itemAmount = new Vector2(1, 3);
    public List<Reward> rewardPieces;
    public Transform[] rewardPoses;
    public Transform spawnPos;
    public AudioSource audioSource;
    public GameObject particle;
    public TransformSpringComponent chestSpring, lidSpring, baseSpring, openTxtTapSpring, claimTxtTapSpring;
    public bool idle;
    public float idleDelay;
    public bool ready;
    public double accumulatedWeight;
    public List<int> nonZeroChancesIndices = new List<int>();
    private System.Random rand = new System.Random();

    [ReadOnly] public List<ChestItem> rewards = new List<ChestItem>();

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    // Start is called before the first frame update
    void Start()
    {
        ready = false;
    }

    private void CalculateWeightsAndIndices()
    {
        nonZeroChancesIndices.Clear();
        accumulatedWeight = 0;
        for (int i = 0; i < rewardPieces.Count; i++)
        {
            Reward piece = rewardPieces[i];

            //add weights:
            accumulatedWeight += piece.Chance;
            piece._weight = accumulatedWeight;

            //add index :
            piece.Index = i;

            //save non zero chance indices:
            if (piece.Chance > 0)
                nonZeroChancesIndices.Add(i);
        }
    }

    public IEnumerator Idle()
    {
        yield return new WaitForSeconds(idleDelay);
        idle = true;
        while (idle && ready)
        {
            chestSpring.AddVelocityPosition(Vector3.up * 10f);
            chestSpring.AddVelocityScale(Vector3.one * 10);
            chestSpring.AddVelocityRotation(Vector3.up * Random.Range(-10, 10));
            audioSource.PlayOneShot(NewChestManager.instance.rewardManager.idleClip);
            openTxtTapSpring.AddVelocityScale(Vector3.up * 5);
            openTxtTapSpring.AddVelocityPosition(Vector3.up * -5);
            yield return new WaitForSeconds(idleDelay);
        }
    }

    public IEnumerator Open()
    {
        if (ready)
        {
            ready = false;
            idle = false;

            openTxtTapSpring.gameObject.SetActive(false);
            int r = Random.Range((int)itemAmount.x, (int)itemAmount.y);
            for (int i = 0; i < r; i++)
            {
                audioSource.PlayOneShot(NewChestManager.instance.rewardManager.openClip);
                yield return new WaitForSeconds(0.1f);
                baseSpring.AddVelocityScale(Vector3.up * 15);
                lidSpring.AddVelocityRotation(Vector3.right * 60);
                Instantiate(particle, transform);
                SelectItem(i);
                NewChestManager.instance.camSpring.AddVelocity(150f);
                yield return new WaitForSeconds(0.3f);
            }
            claimTxtTapSpring.gameObject.SetActive(true);
            claimTxtTapSpring.AddVelocityScale(Vector3.one * 10f);
            NewChestManager.instance.claimButton.SetActive(true);
            NewChestManager.instance.doubleButton.SetActive(true);
        }
    }
    public void SelectItem(int targetIndx)
    {
        CalculateWeightsAndIndices();

        int index = GetRandomPieceIndex();
        Reward piece = rewardPieces[index];

        if (piece.Chance == 0 && nonZeroChancesIndices.Count != 0)
        {
            index = nonZeroChancesIndices[UnityEngine.Random.Range(0, nonZeroChancesIndices.Count)];
            piece = rewardPieces[index];
        }

        ChestItem newItem = Instantiate(NewChestManager.instance.rewardManager.rewards[(int)piece.rewardType].prefab, spawnPos.position, Quaternion.identity).GetComponent<ChestItem>();

        newItem.SetAmount(this,piece.rewardType, PlaytimeRewardsManager.instance.rewardList.GetAmount(piece.rewardType), rewardPoses[targetIndx]);
        rewards.Add(newItem);
        rewardPieces.RemoveAt(index);
    }

    private int GetRandomPieceIndex()
    {
        double r = rand.NextDouble() * accumulatedWeight;

        for (int i = 0; i < rewardPieces.Count; i++)
            if (rewardPieces[i]._weight >= r)
                return i;

        return 0;
    }

    public void Show(Transform chestFirstPos, Transform chestLastPos)
    {
        StopCoroutine(Idle());
        audioSource.PlayOneShot(NewChestManager.instance.rewardManager.firstClip);
        transform.position = chestFirstPos.position;
        transform.DOMove(chestLastPos.position, 0.5f).SetEase(Ease.OutBack);
        StartCoroutine(Scale());
        IEnumerator Scale()
        {
            yield return new WaitForSeconds(0.15f);
            chestSpring.AddVelocityScale(Vector3.up * -15f);
            yield return new WaitForSeconds(0.15f);
            openTxtTapSpring.gameObject.SetActive(true);
            NewChestManager.instance.openButton.SetActive(true);
            openTxtTapSpring.AddVelocityPosition(Vector3.up * 10);
            yield return new WaitForSeconds(0.15f);
            ready = true;
            StartCoroutine(Idle());

        }
    }
    public void PlayDoubleSound()
    {
        audioSource.PlayOneShot(NewChestManager.instance.rewardManager.doubleSound);
    }
    public void PlayClaimSound()
    {
        audioSource.PlayOneShot(NewChestManager.instance.rewardManager.claimSound);
    }
}
