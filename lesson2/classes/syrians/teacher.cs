using MyApp.Humans;

namespace MyApp.Syrians;

class Teacher : SyrianHuman {

    public Teacher( string name, int age ) : base( name, age )  
    {
    }


    public override string? getName()
    {
        return " teacher : " + _name;
    }
    
}