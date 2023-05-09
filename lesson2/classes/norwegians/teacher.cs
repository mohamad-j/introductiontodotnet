using MyApp.Humans;

namespace MyApp.Norwegians;

class Teacher : NorwegianHuman {

    public Teacher( string name, int age ) : base( name, age )  
    {
    }


    public override string? getName()
    {
        return " teacher : " + _name;
    }
    
}