
namespace TigerClicker
{
    public interface IDataProvider 
    {
        void Save();

        bool TryLoad();
    }
}
