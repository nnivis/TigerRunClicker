using System;
using UnityEngine;

namespace TigerClicker
{
    [Serializable]
    public class BuildingConfig 
    {
        [SerializeField] private Building _prefab;
        [SerializeField] private BuildingType _buildingType;
        public Building Prefab => _prefab;
        public BuildingType BuildingType => _buildingType;
    }
}
