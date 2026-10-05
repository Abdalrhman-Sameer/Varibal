List<int> Totallist = new List<int>();
do
{
    Console.WriteLine("Enter a price ");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter a quantity ");
    int quantity = Convert.ToInt32(Console.ReadLine());
    int total = (int)(price * quantity);
    Console.WriteLine("Total= " + total);
    Totallist.Add(total);
    Console.WriteLine("if you want to continue press 1 or if you want to exit press 0");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice){
        case 1:
            continue;
        case 0:
            Console.WriteLine("Total amount is: " + Totallist.Sum());
            break;
    }
    break;
} while(true);