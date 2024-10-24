using Microsoft.EntityFrameworkCore;
using Webbanhang.Components.Data;
using Webbanhang.Components.Data.Model;
using Webbanhang.Components.IService;

namespace Webbanhang.Components.Services
{
    public class ItemManagement : IItemManagement
    {
        private readonly AppDbContext db;
        public ItemManagement(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<List<Item>> GetAllItem()
        {
            return await db.Items.ToListAsync();
        }
        public async Task CreateItem(Item item)
        {
            await db.Items.AddAsync(item);
            await db.SaveChangesAsync();
        }
        public async Task DeleteItem(Item item)
        {
            db.Items.Remove(item);
            await db.SaveChangesAsync();
        }

        public async Task EditItem(Item item)
        {
            db.Items.Update(item);
            await db.SaveChangesAsync();
        }
        public async Task<Item?> GetItemById(int itemID)
        {
            return await db.Items.FirstOrDefaultAsync(p => p.ItemId == itemID);
        }
    }
}
