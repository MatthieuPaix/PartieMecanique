using Blockade

#include Wall;

public class Case {
    private Wall topWall;
    private Wall leftWall;
    private Wall rightWall;
    private Wall bottomWall;
    private bool StartingCase;

    public Case(bool isBeginning){
        this.beginning = isBeginning;
    }
}