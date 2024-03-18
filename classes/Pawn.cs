public enum MoveType
{
    top,
    topRight,
    right,
    rightBottom,
    bottom,
    bottomLeft,
    left,
    leftTop
}

public class Pawn {

    private int x;
    private int y;

    public Pion(int _x, int _y)
    {
        x = _x;
        y = _y;
    }

    public int x 
    {
        get { return x; }
        set { x = value; }
    }

    public int y
    {
        get { return y; }
        set { y = value; }
    }

    public void move(MoveType type) 
    {
        switch (type)
        {
            case top:
                y += 2;
                break;

            case topRight:
                x += 1;
                y += 1;
                break;

            case right:
                x += 2;
                break;

            case rightBottom:
                x += 1;
                y -= 1;
                break;

            case bottom:
                y -= 2;
                break;

            case bottomLeft:
                x -= 1;
                y -= 1;
                break;

            case left:
                x -= 2;
                break;

            case leftTop:
                x -= 1;
                y += 1;
                break;
        }
    }
}
