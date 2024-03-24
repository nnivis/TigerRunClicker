
namespace TigerClicker
{
    public class MeatLoot : ILoot
    {
        private const int meatAmount = 7;
        public int Amount => meatAmount;
        public void GenerateLoot(Wallet wallet)
        {
            wallet.AddCurrency(meatAmount, CurrencyType.Meat);
        }
    }
}
