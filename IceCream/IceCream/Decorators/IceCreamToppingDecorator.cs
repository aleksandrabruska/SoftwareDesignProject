namespace IceCream;

public abstract class IceCreamToppingDecorator : IceCream
{
    protected IceCream _iceCream;
    
    public override float cost()
    {
        throw new NotImplementedException();
    }
}