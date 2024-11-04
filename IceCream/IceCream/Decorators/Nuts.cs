namespace IceCream;

public class Nuts : IceCreamToppingDecorator
{
    public Nuts(IceCream iceCream)
    {
        this._iceCream = iceCream;
    }
    public override float cost()
    {
        return 0.5f + this._iceCream.cost();
    }
    
    public override string getLevelName(int level)
    {
        string lv = "";
        for (int i = 0; i < level; i++)
            lv += " = ";
        return (lv + "Nuts\n") + this._iceCream.getLevelName(level + 1);
    }
    
}