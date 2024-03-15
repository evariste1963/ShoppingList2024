using System.Text.Json;

namespace ShoppingList.Data
    
{
    public class ShoppingListService
    {
        string file = string.Empty;

        public ShoppingListService()
        {
            file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "shoppingListItems.json");

        }

        public void SaveItems(IEnumerable<ShoppingListItem> shoppingListItems)
        {
            File.WriteAllText(file, JsonSerializer.Serialize(shoppingListItems));
        }

        public IEnumerable<ShoppingListItem> LoadItems()
        {
            if (!File.Exists(file))

                return Enumerable.Empty<ShoppingListItem>();

            var itemJson = File.ReadAllText(file);
            return JsonSerializer.Deserialize<IEnumerable<ShoppingListItem>>(itemJson) ??
                Enumerable.Empty<ShoppingListItem>();


        }
    }
}