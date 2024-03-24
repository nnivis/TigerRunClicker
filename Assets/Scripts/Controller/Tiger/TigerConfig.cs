using System;
using UnityEngine;

namespace TigerClicker
{
    [Serializable]
    public class TigerConfig
    {
        [SerializeField] private Tiger _prefab;
        [SerializeField] private float _speed;

        public Tiger Prefab => _prefab;
        public float Speed => _speed;
    }
}
