// Import mur

public class Case {
    private Mur haut;
    private Mur gauche;
    private Mur droit;
    private Mur bas;
    private bool depart;

    public Case(bool EstDepart){
        this.depart = EstDepart;
    }
}