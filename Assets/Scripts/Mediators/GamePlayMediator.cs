using System;
using UnityEngine;

namespace TigerClicker
{
    public class GamePlayMediator : MonoBehaviour
    {
        public Action<BuildingType, Vector3> OnLootDropped;
        public void NotifyLootDropped(BuildingType buildingType,  Vector3 position)
        {
            OnLootDropped?.Invoke(buildingType, position);
        }
    }
}
