using MyApp.Humans;

namespace MyApp.Syrians;

class Student : SyrianHuman {


    public override string? p_name { get => " student " + _name;  }
    
    public Student( string name, int age ) : base( name, age )
    {

    }

    

}