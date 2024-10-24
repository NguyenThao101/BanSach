using Webbanhang.Components.Data.Model;

namespace Webbanhang.Components.IService
{
    public interface IItemManagement
    {
        Task<List<Item>> GetAllItem();
        Task CreateItem(Item item);
        Task DeleteItem(Item item);
        Task EditItem(Item item);
        Task<Item?> GetItemById(int itemID);
    }
}
