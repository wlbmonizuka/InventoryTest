using Rav3.Model;
using UnityEngine;

namespace Rav3.View
{
    [CreateAssetMenu(fileName = "InventoryItemConfig", menuName = "Configs/InventoryItemConfig")]
    public class InventoryItemConfig : ScriptableObject
    {
        public int ID;
        public InventorySlotType Type;
        public string Name;
        public int Weight;

        public InventoryItem CreateInventoryItem()
        {
            return new InventoryItem {
                ID = ID,
                Type = Type,
                Name = Name,
                Weight = Weight,
            };
        }
    }
}