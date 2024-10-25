using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;
using System.Collections.Generic;

namespace EasyUI.PickerWheelUI
{

    public class PickerWheel : MonoBehaviour
    {
        public RewardList rewardList;

        [Header("References :")]
        [SerializeField] private GameObject linePrefab;
        [SerializeField] private Transform linesParent;

        [Space]
        [SerializeField] private Transform PickerWheelTransform;
        [SerializeField] private Transform wheelCircle;
        [SerializeField] private GameObject wheelPiecePrefab;
        [SerializeField] private Transform wheelPiecesParent;

        [Space]
        [Header("Sounds :")]
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip tickAudioClip;
        [SerializeField][Range(0f, 1f)] private float volume = .5f;
        [SerializeField][Range(-3f, 3f)] private float pitch = 1f;

        [Space]
        [Header("Picker wheel settings :")]
        [Range(1, 20)] public int spinDuration = 8;
        [SerializeField][Range(.2f, 2f)] private float wheelSize = 1f;

        [Space]
        [Header("Picker wheel pieces :")]
        public List<Reward> rewards;

        // Events
        private UnityAction onSpinStartEvent;
        private UnityAction<Reward> onSpinEndEvent;
        public List<WheelItem> wheelItems;


        private bool _isSpinning = false;

        public bool IsSpinning { get { return _isSpinning; } }


        private Vector2 pieceMinSize = new Vector2(81f, 146f);
        private Vector2 pieceMaxSize = new Vector2(144f, 213f);
        private int piecesMin = 8;
        private int piecesMax = 8;

        private float pieceAngle;
        private float halfPieceAngle;
        private float halfPieceAngleWithPaddings;


        [SerializeField] private double accumulatedWeight;
        [SerializeField] private System.Random rand = new System.Random();

        [SerializeField] private List<int> nonZeroChancesIndices = new List<int>();
        public Toggle animToggle;
        private Reward resultReward;
        private Vector3 resultAngle;

        private void Start()
        {

            SetupAudio();
        }

        public void SetRewards(List<Reward> newRewards, int durationTime, UnityAction<Reward> resultAction)
        {
            /*  foreach (Transform child in wheelPiecesParent.transform)
              {
                  Destroy(child.gameObject);
              }*/
            rewards = newRewards;
            pieceAngle = 360 / rewards.Count;
            halfPieceAngle = pieceAngle / 2f;
            halfPieceAngleWithPaddings = halfPieceAngle - (halfPieceAngle / 4f);
            spinDuration = durationTime;
            OnSpinEnd(resultAction);

            for (int i = 0; i < wheelItems.Count; i++)
            {
                wheelItems[i].SetReward(rewards[i]);
            }


            //  Generate();

            CalculateWeightsAndIndices();
            if (nonZeroChancesIndices.Count == 0)
                Debug.LogError("You can't set all pieces chance to zero");
        }

        private void SetupAudio()
        {
            audioSource.clip = tickAudioClip;
            audioSource.volume = volume;
            audioSource.pitch = pitch;
        }

        private void Generate()
        {
            wheelPiecePrefab = InstantiatePiece();

            RectTransform rt = wheelPiecePrefab.transform.GetChild(0).GetComponent<RectTransform>();
            float pieceWidth = Mathf.Lerp(pieceMinSize.x, pieceMaxSize.x, 1f - Mathf.InverseLerp(piecesMin, piecesMax, rewards.Count));
            float pieceHeight = Mathf.Lerp(pieceMinSize.y, pieceMaxSize.y, 1f - Mathf.InverseLerp(piecesMin, piecesMax, rewards.Count));
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, pieceWidth);
            rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, pieceHeight);

            for (int i = 0; i < rewards.Count; i++)
                DrawPiece(i);

            Destroy(wheelPiecePrefab);
        }

        private void DrawPiece(int index)
        {
            Reward reward = rewards[index];
            Transform pieceTrns = InstantiatePiece().transform.GetChild(0);
            // pieceTrns.GetChild(0).GetComponent<Image>().color = (index % 2 == 0) ? softColor : darkColor;
            pieceTrns.GetChild(1).GetComponent<Image>().sprite = rewardList.rewards[(int)reward.rewardType].sprite;
            pieceTrns.GetChild(2).GetComponent<Text>().text = rewardList.rewards[(int)reward.rewardType].rewardName;
            pieceTrns.GetChild(3).GetComponent<Text>().text = "10";//piece.Amount.ToString();

            //Line
            /*Transform lineTrns = Instantiate(linePrefab, linesParent.position, Quaternion.identity, linesParent).transform;
            lineTrns.RotateAround(wheelPiecesParent.position, Vector3.back, (pieceAngle * index) + halfPieceAngle);*/

            pieceTrns.RotateAround(wheelPiecesParent.position, Vector3.back, pieceAngle * index);
        }

        private GameObject InstantiatePiece()
        {
            return Instantiate(wheelPiecePrefab, wheelPiecesParent.position, Quaternion.identity, wheelPiecesParent);
        }

        public void AnimToggleAction()
        {
            Debug.Log(animToggle.isOn);

            if (!animToggle.isOn)
            {
                if (_isSpinning)
                {
                    wheelCircle.DOKill();
                    wheelCircle
               .DORotate(resultAngle, (!animToggle.isOn) ? 0 : spinDuration, RotateMode.FastBeyond360)
               .SetEase(Ease.InOutQuart)
               .OnComplete(() =>
               {

                   _isSpinning = false;
                   if (onSpinEndEvent != null)
                       onSpinEndEvent.Invoke(resultReward);

                   //onSpinStartEvent = null;
                   // onSpinEndEvent = null;
               });
                }
            }
        }


        public void Spin()
        {
            if (!_isSpinning)
            {
                _isSpinning = true;
                if (onSpinStartEvent != null)
                    onSpinStartEvent.Invoke();

                IapBundleManager.instance.RefresRewards();

                Invoke(nameof(SpinWheel), 0.1f);
            }
        }

        public void SpinWheel()
        {

            CalculateWeightsAndIndices();
            int index = GetRandomPieceIndex();
            Reward reward = rewards[index];

            if (reward.Chance == 0 && nonZeroChancesIndices.Count != 0)
            {
                index = nonZeroChancesIndices[Random.Range(0, nonZeroChancesIndices.Count)];
                reward = rewards[index];
            }

            resultReward = reward;
            float angle = -(pieceAngle * index);

            float rightOffset = (angle - halfPieceAngleWithPaddings) % 360;
            float leftOffset = (angle + halfPieceAngleWithPaddings) % 360;

            float randomAngle = Random.Range(leftOffset, rightOffset);

            Vector3 targetRotation = Vector3.back * (randomAngle + 2 * 360 * spinDuration);

            //float prevAngle = wheelCircle.eulerAngles.z + halfPieceAngle ;
            float prevAngle, currentAngle;
            prevAngle = currentAngle = wheelCircle.eulerAngles.z;

            bool isIndicatorOnTheLine = false;
            resultAngle = targetRotation;
            wheelCircle
            .DORotate(targetRotation, (!animToggle.isOn) ? 0 : spinDuration, RotateMode.FastBeyond360)
            .SetEase(Ease.InOutQuart)
            .OnUpdate(() =>
            {
                float diff = Mathf.Abs(prevAngle - currentAngle);
                if (diff >= halfPieceAngle)
                {
                    if (isIndicatorOnTheLine)
                    {
                        audioSource.PlayOneShot(audioSource.clip);
                    }
                    prevAngle = currentAngle;
                    isIndicatorOnTheLine = !isIndicatorOnTheLine;
                }
                currentAngle = wheelCircle.eulerAngles.z;
            })
            .OnComplete(() =>
            {

                _isSpinning = false;
                if (onSpinEndEvent != null)
                    onSpinEndEvent.Invoke(reward);

                //onSpinStartEvent = null;
                // onSpinEndEvent = null;
            });

        }

        public void OnSpinStart(UnityAction action)
        {
            onSpinStartEvent = action;
        }

        public void OnSpinEnd(UnityAction<Reward> action)
        {
            onSpinEndEvent = action;
        }


        private int GetRandomPieceIndex()
        {
            double r = rand.NextDouble() * accumulatedWeight;
            Debug.Log("r: " + r);
            for (int i = 0; i < rewards.Count; i++)
                if (rewards[i]._weight >= r)
                    return i;

            return 0;
        }

        private void CalculateWeightsAndIndices()
        {
            nonZeroChancesIndices.Clear();
            accumulatedWeight = 0;
            for (int i = 0; i < rewards.Count; i++)
            {
                Reward reward = rewards[i];

                //add weights:
                accumulatedWeight += reward.Chance;
                reward._weight = accumulatedWeight;

                //add index :
                reward.Index = i;

                //save non zero chance indices:
                if (reward.Chance > 0)
                    nonZeroChancesIndices.Add(i);
            }
        }




        private void OnValidate()
        {
            if (PickerWheelTransform != null)
                PickerWheelTransform.localScale = new Vector3(wheelSize, wheelSize, 1f);

            /*if (wheelPieces.Count > piecesMax || wheelPieces.Count < piecesMin)
                Debug.LogError("[ PickerWheelwheel ]  pieces length must be between " + piecesMin + " and " + piecesMax);*/
        }




    }
}