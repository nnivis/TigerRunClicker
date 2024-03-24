using System.Collections.Generic;
using UnityEngine;

namespace TigerClicker
{
    public interface IStateMachine
    {
        void Init(StateMachine stateMachine);
        void Enter();
        void Exit();
        IReadOnlyList<GameObject> GetViews();

    }
}
