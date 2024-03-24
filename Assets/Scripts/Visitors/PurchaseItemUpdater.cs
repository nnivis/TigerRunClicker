
namespace TigerClicker
{
    public class PurchaseItemUpdater : IPurchaseItemVisitors
    {
        private IPersistentData _persistentData;
        public PurchaseItemUpdater(IPersistentData persistentData) => _persistentData = persistentData;
        public void Visit(PurchaseItem purchaseItem)
        {
            _persistentData.PlayerData.UpdatePurchaseItemValue(purchaseItem.PurchaseItemType, purchaseItem.PriceIncreaseCountLimit);
        }
    }
}
