using System.Collections.Generic;

namespace Rav3.Model
{
    public class Inventory
    {
        public InventoryItem Helmet;
        public InventoryItem Robe;
        public InventoryItem Stockings;

        public List<InventoryItem> Items = new List<InventoryItem>();
    }
}