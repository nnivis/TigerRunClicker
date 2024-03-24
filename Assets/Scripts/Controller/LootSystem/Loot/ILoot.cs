namespace TigerClicker
{
    public interface ILoot
    {
        int Amount { get; }
        void GenerateLoot(Wallet wallet);

    }
}
