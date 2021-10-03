
namespace StoreLib.Common
{
    public interface IOrderableItemSource
    {
        IOrderable GetItem(string title);
    }
}