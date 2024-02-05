using System;

public class Pion {
    private static int dernierIdPion = 0;
    private int idPion;
    private int[] coordonnees;

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

}
