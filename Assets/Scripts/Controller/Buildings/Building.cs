using UnityEngine;

namespace TigerClicker
{
    public class Building : MonoBehaviour
    {
        public BuildingType BuildingType => _buildingType;
        private BuildingType _buildingType;
        public void Initialize(BuildingType buildingType)
        {
            _buildingType = buildingType;
        }
    }
}
