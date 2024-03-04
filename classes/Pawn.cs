using System;

public class Pawn {
    private static int LastPawnId = 0;
    private int pawnId;
    private int x;
    private int y;
    public Pion(int[] _coordinates)
    {
        coordinates = _coordinates;
        idPion = ++dernierIdPion;
    }

    public int IdPion
    {
        get { return idPion; }
    }

    public int[] coordinates
    {
        get { return coordinates; }
        set { coordinates = value; }
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

    public void moove(int newX, int newY) {
        x = newX;
        y = newY;
    }


}
