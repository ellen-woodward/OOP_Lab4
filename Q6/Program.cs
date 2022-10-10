using Q6;

Lunch lunch1 = new Lunch("beans", "cookie", "coffee");
Lunch lunch2 = new Lunch("pizza", "fries", "milkshake");
Lunch lunch3 = new Lunch("toastie", "salad", "water");
Lunch lunch4 = new Lunch("hotdog", "fruit", "milk");
Lunch lunch5 = new Lunch("soup", "bread", "soda");

Display(lunch1, lunch2, lunch3);
Console.WriteLine();
Display(lunch1, lunch2, lunch3, lunch4);
Console.WriteLine();
Display(lunch1, lunch2, lunch3, lunch4, lunch5);

static void Display(params Lunch[]lunches)
{
    Console.WriteLine("Entree\tSide\tDrink");

    foreach (Lunch lunch in lunches)
    {
        Console.WriteLine($"{lunch.Entree}\t{lunch.Side}\t{lunch.Drink}");
    }
}