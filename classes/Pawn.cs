using System;

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

    public void move(int newX, int newY) {
        x = newX;
        y = newY;
    }

}
