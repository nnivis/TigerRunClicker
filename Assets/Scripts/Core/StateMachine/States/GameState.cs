using UnityEngine;

namespace TigerClicker
{
    public class GameState : StateMachineBehavior
    {
        [SerializeField] private GameStateHandler _gameStateHandler;
        protected override void OnEnter()
        {
            _gameStateHandler.StartWork();
        }

        protected override void OnExit()
        {
            _gameStateHandler.StopWork();
        }
    }
}
