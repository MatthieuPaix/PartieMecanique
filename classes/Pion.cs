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

    public static void Main(string[] args)
    {
        Pion pion1 = new Pion(new int[] { 3, 2 });
        Pion pion2 = new Pion(new int[] { 1, 0 });

        Console.WriteLine($"Pion 1 - ID: {pion1.IdPion}, Coordonnees: [{string.Join(", ", pion1.Coordonnees)}]");
        Console.WriteLine($"Pion 2 - ID: {pion2.IdPion}, Coordonnees: [{string.Join(", ", pion2.Coordonnees)}]");
    }
}
