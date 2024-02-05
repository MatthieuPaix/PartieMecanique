public enum TypeMur
{
    vertical,
    horizontal
}

public class Mur
{
    private TypeMur type;

    public Mur(TypeMur type)
    {
        this.Type = type;
    }

    public TypeMur Type
    {
        get { return type; }
        set { type = value; }
    }
}