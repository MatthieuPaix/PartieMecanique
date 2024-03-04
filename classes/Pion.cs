using System;

public class Pion {
    private static int dernierIdPion = 0;
    private int idPion;
    private int x;
    private int y;
    public Pion(int[] _coordonnees)
    {
        coordonnees = _coordonnees;
        idPion = ++dernierIdPion;
    }

    public int IdPion
    {
        get { return idPion; }
    }

    public int[] Coordonnees
    {
        get { return coordonnees; }
        set { coordonnees = value; }
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

    public void bouger(int newX, int newY) {
        x = newX;
        y = newY;
    }


}
