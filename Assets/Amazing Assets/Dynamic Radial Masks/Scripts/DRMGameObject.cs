using System;
using DG.Tweening;
using Exoa.TutorialEngine;
using UnityEngine;
using UnityEngine.UI;


namespace AmazingAssets.DynamicRadialMasks
{
    [ExecuteAlways]
    public class DRMGameObject : MonoBehaviour
    {
        public bool task;
        public bool staticDrm;
        private SphereCollider sphereCollider;
        public float waitTime;
        public float timer;
        private DrmEnemyChange _drmEnemyChange;
        public bool increaseEnes;
        [HideInInspector] public float radius = 5;
        [HideInInspector] public float intensity = 1;
        [HideInInspector] public float noiseStrength = 0;
        [HideInInspector][Min(0f)] public float edgeSize = 1;
        [HideInInspector] public int ringCount = 3;
        [HideInInspector] public float frequency = 10;
        [HideInInspector] public float phaseSpeed = 2;
        [HideInInspector] public float currentPhase = 0;
        [HideInInspector][Min(0.001f)] public float smooth = 1;
        public Slider slider;
        public float baseRadius;
        public float breafDuration;
        private Player _player;
        private BossRaidSpawnEnemy _bossRaidSpawnEnemy;
#if UNITY_EDITOR
        [HideInInspector] public bool displayAllProperties = true;
        [HideInInspector] public DynamicRadialMasks.Enum.MaskShape maskShape;
#endif
        public TerrainCollider ter1, ter2;
        public bool increase, decrease;

        void Start()
        {
            sphereCollider = GetComponent<SphereCollider>();
            _drmEnemyChange = GetComponent<DrmEnemyChange>();
            currentPhase = 0;
            timer = waitTime;
            if (staticDrm)
                BreafStart();

            _player = GetComponentInParent<Player>();
            _bossRaidSpawnEnemy = FindObjectOfType<BossRaidSpawnEnemy>();
        }

        void Update()
        {
            if (sphereCollider)
                sphereCollider.radius = radius;
            currentPhase += Time.deltaTime * phaseSpeed;
            timer += Time.deltaTime;
            //     
            //     if (increase)
            //     {
            //         radius += Time.deltaTime * phaseSpeed;
            //         if (radius >=100)
            //         {
            //             radius = 100;
            //             increase = false;
            //         }
            //     }
            //     if (decrease)
            //     {
            //         radius -= Time.deltaTime * phaseSpeed;
            //         if ( radius <= 0)
            //         {
            //             radius = 0;
            //             decrease = false;
            //         }
            //     }
        }

        public void SliderValueChanged()
        {
            if (timer > waitTime || TutorialLoader.instance.loadedTutorialName == "Ring" ||
                TutorialLoader.instance.loadedTutorialName == "0.5")
            {
                if (radius == 100)
                {
                    transform.GetChild(0).GetComponent<FogScale>().StartScale();
                    decrease = true;
                    increaseEnes = false;
                    ter1.enabled = true;
                    ter2.enabled = false;
                }

                if (radius != 100)
                {
                    transform.GetChild(0).GetComponent<FogScale>().StartScale();
                    increase = true;
                    increaseEnes = true;
                    ter1.enabled = false;
                    ter2.enabled = true;
                }
            }
        }


        public void BreafStart()
        {
            baseRadius = radius;
            BreafRadial();
        }

        public void BreafRadial()
        {
            DOTween.To(() => radius, x => radius = x, baseRadius + 0, breafDuration)
                .OnComplete(() =>
                {
                    DOTween.To(() => radius, x => radius = x, baseRadius - 0, breafDuration)
                        .OnComplete(() => { BreafRadial(); });
                });
        }

        public void OpenWorld()
        {
            if (radius > 99)
                DOTween.To(() => radius, x => radius = x, 0, 4f).OnComplete((() =>
                {
                    increaseEnes = true;
                    gameObject.SetActive(false);
                    if (_player)
                    {
                        _bossRaidSpawnEnemy.KillAllEnemy();
                    }
                }));
            else if (radius < 2)
            {
                DOTween.To(() => radius, x => radius = x, 100, 4f).OnComplete((() =>
                {
                    increaseEnes = false;
                    Debug.Log(_player);
                    if (_player && !_player.isBase)
                    {
                        Debug.Log("DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD");
                        _bossRaidSpawnEnemy.SpawnEnemy();
                    }
                }));
            }

            if (task && !increaseEnes)
            {
                FindObjectOfType<MerchantTutorial>().BarrierClose();
            }

            if (task && increaseEnes)
            {
                FindObjectOfType<MerchantTutorial>().BarrierOpen();
            }
        }
    }
}