
using IceCream;

IceCream.IceCream dessert = new VanillaIceCream();

dessert = new Nuts(dessert);
dessert = new WhippedCream(dessert);


Console.WriteLine("Ice Cream: {0}", dessert.cost());
Console.WriteLine("{0}", dessert.getLevelName(1));