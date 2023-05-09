using MyApp.Humans;

namespace MyApp.Norwegians;

class Student : NorwegianHuman {


    public override string? p_name { get => " student " + _name;  }
    
    public Student( string name, int age ) : base( name, age )
    {

    }

    

}