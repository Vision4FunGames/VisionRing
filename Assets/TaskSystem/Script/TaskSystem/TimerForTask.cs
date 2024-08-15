using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TaskSystem
{
    public class TimerForTask : MonoBehaviour
    {
        public float timer;
        public bool isActive;
        void Update()
        {
            if (isActive)
            {
                timer += Time.deltaTime;
            }
        }
    } 
}
