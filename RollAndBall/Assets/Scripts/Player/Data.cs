using System;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public struct Data 
    {
        private float speed;
    
        public float GetSpeed() => speed;
        public void SetSpeed(float speed) => this.speed = speed;
    
    }
}
