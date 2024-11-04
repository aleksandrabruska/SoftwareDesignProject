namespace IceCream;

public abstract class IceCream
{
    public abstract float cost();

    public abstract string getLevelName(int level);

    protected string getLevelIndicator(int level)
    {
        string lv = "";
        for (int i = 0; i < level; i++)
            lv += "= ";
        return lv;
    }
}