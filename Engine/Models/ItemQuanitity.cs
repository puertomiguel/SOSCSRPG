namespace Engine.Models
{
    public class ItemQuanitity
    {
        public int ItemID { get; }
        public int Quantity { get; }

        public ItemQuanitity(int itemID, int quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}