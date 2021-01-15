using System.Globalization;

namespace Cap04
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double InventoryValue()
        {
            return Quantity * Price;
        }

        public void AddProductToInventory(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProductToInventory(int quantity)
        {
            Quantity -= quantity;
        }

        // Allow for the creation of a customized output of information about the Class.
        // Standard output is "Cap04.Product" where Cap04 is the Project that contains the Class and Product is the Class itself.
        public override string ToString()
        {
            return Name + ", $ " + Price.ToString("f2", CultureInfo.InvariantCulture) + ", " + 
                Quantity + " units. Total Inventory: $ " + InventoryValue().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
