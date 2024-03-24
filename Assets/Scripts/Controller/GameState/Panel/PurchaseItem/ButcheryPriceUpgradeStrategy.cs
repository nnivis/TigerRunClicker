namespace TigerClicker
{
    public class ButcheryPriceUpgradeStrategy : IPriceUpgrade
    {
           public int CalculateNewPrice(int priceIncreaseCount)
        {
            return 150 * priceIncreaseCount;
        }

    }
}
