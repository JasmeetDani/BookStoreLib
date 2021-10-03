
namespace StoreLib.Common
{
    public interface IDiscountStrategy
    {
        IOrderable Apply(IOrderable item);
    }
}