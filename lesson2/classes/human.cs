using MyApp.Interfaces;

namespace MyApp.Humans;

class MainHuman : IHuman {
    protected string? _name;
    protected int _age;

    protected string? _gender;

    public virtual string? p_name {
        set{
             
            _name =  value;

            if( value.StartsWith("X-") ) {
                _gender = "GIRL";
            } else if ( value.StartsWith("Y-") ) {
                _gender = "BOY";
            } else {
                _gender = null;
            }

        }


        get{
            return _name;
        }
        
    }

    public MainHuman( string name, int age )
    {
        p_name = name;
        _age = age;
    }


    public virtual string? getName()
    {
        return _name;
    }
}