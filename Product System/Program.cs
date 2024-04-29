
public class Inventory
{
    public string Name { set; get; }
    public double Price { set; get; }
    public int Quantity { set; get; }
    public string Type { set; get; }

    public Inventory(string name, double price, int quantity, string type)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Type = type;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        List<Inventory> ProductDetails = new List<Inventory>();
        ProductDetails.Add(new Inventory("lettuce", 10.5, 50, "Leafy green"));
        ProductDetails.Add(new Inventory("cabbage", 20, 100, "Cruciferous"));
        ProductDetails.Add(new Inventory("pumpkin", 30, 30, "Marrow"));
        ProductDetails.Add(new Inventory("cauliflower", 10, 25, "Cruciferous"));
        ProductDetails.Add(new Inventory("zucchini", 20.5, 50, "Marrow"));
        ProductDetails.Add(new Inventory("yam", 30, 50, "Root"));
        ProductDetails.Add(new Inventory("spinach", 10, 100, "Leafy green"));
        ProductDetails.Add(new Inventory("broccoli", 20.2, 75, "Cruciferous"));
        ProductDetails.Add(new Inventory("garlic", 30, 20, "Leafy green"));
        ProductDetails.Add(new Inventory("silverbeet", 10, 50, "Marrow"));

        // Print the total number of products in the list.
        Console.WriteLine($"Total product in the list : {ProductDetails.Count}");

        //Add a new product (Potato,10RS, 50, Root). And print the list of all products and a total number of products(integer).
        ProductDetails.Add(new Inventory("Potato", 10, 50, "Root"));

        //Print all the products of which have the type Leafy green.
        List<Inventory> leafyGreenProducts=(ProductDetails.FindAll((data) => data.Type.Equals("Leafy green")));
        foreach(Inventory item in leafyGreenProducts)
        {
            Console.WriteLine(item.Name);
        }

        //As all the garlic is sold out, Remove Garlic from the list and print the total number of products that are left on the list.
        for (int i = 0; i < ProductDetails.Count; i++)
        {
            if (ProductDetails[i].Name.Equals("garlic"))
            {
                ProductDetails.RemoveAt(i);
                break;
            }
        }
        Console.WriteLine("Garlic removed from the list!");
        Console.WriteLine($"Total Product in the list : {ProductDetails.Count}");

        //If the user adds 50 cabbages to the inventory, print the final quantity of cabbage in the inventory.
        for (int i = 0; i < ProductDetails.Count; i++)
        {
            if (ProductDetails[i].Name.Equals("cabbage"))
            {
                ProductDetails[i].Quantity += 50;
                Console.WriteLine("50 cabbages Added in the list");
                Console.WriteLine($"Total Cabbages in the list : {ProductDetails[i].Quantity}");  
                break;
            }
        }

        //If a user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli the what is the round figure that the user needs to pay?
        double totalAmount = 0;
        for (int i = 0; i < ProductDetails.Count; i++)
        {
           
            if (ProductDetails[i].Name.Equals("lettuce") || ProductDetails[i].Name.Equals("broccoli"))
            {
                totalAmount += ProductDetails[i].Price;
            }
            else if (ProductDetails[i].Name.Equals("zucchini"))
            {
                totalAmount += ProductDetails[i].Price*2;
            }
        }

        Console.WriteLine($"You have purchased 1kg lettuce, 2 kg zucchini, 1 kg broccoli. Amount to pay: {totalAmount}");
    }
}