namespace ShoppingList.Data
{
    public class ShoppingListItem
    {
        public int Order { get; set; }
        public string? Item { get; set; } = string.Empty;

        public bool IsDone { get; set; } = false;

        public bool IsDragOver { get; set; }
    }
}
