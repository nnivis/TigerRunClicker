using UnityEngine;

namespace TigerClicker
{
    public class BootstrapComponents : MonoBehaviour
    {
        [SerializeField] FileDeletionExample _fileDeletionExample;
        [SerializeField] GameStateHandler _gameStateHandler;
        [SerializeField] LootHandler _lootHandler;
        private IDataProvider _dataProvider;
        private IPersistentData _persistentPlayerData;
        private Wallet _wallet;

        public void Awake()
        {
            _fileDeletionExample.DeleteJsonFile();

            InitializeData();

            InitializeWallet();

            InitializeGame();

            InitializeLoot();
        }

        private void InitializeData()
        {
            _persistentPlayerData = new PersistentData();
            _dataProvider = new DataLocalProvider(_persistentPlayerData);
            LoadDataOrInit();
        }

        private void InitializeWallet()
        {
            _wallet = new Wallet(_persistentPlayerData);
        }
        private void InitializeGame()
        {
            PurchaseItemCheker purchaseItemCheker = new PurchaseItemCheker(_persistentPlayerData);
            PurchaseItemUpdater purchaseItemUpdater = new PurchaseItemUpdater(_persistentPlayerData);

            _gameStateHandler.Initialize(_dataProvider, _wallet, purchaseItemCheker, purchaseItemUpdater);
        }
        private void InitializeLoot()
        {
            _lootHandler.Initialize(_dataProvider, _wallet);
        }
        private void LoadDataOrInit()
        {
            if (_dataProvider.TryLoad() == false)
                _persistentPlayerData.PlayerData = new PlayerData();
        }
    }
}
