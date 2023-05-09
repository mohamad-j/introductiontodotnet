// using Newtonsoft.Json;
using System.Text.Json;

namespace Classes;

class Student {

    private Dictionary< int , Student > studentslist = new Dictionary<int, Student>();

    public static int idcounter = 1;
    public int id;
    public string name { set; get; }

    public int age { set; get; }

    public Student( string p_name, int p_age )
    {
        name = p_name;
        age = p_age;

        id = idcounter;

        studentslist.Add( id, this );

        idcounter = idcounter + 5;

    }

    public override string ToString()
    {
        string json = $" Name: {name}, Age: {age}, id: {id} ";
        return " {  " + json + " }";
    }


    public string allStudents()
    {
        return JsonSerializer.Serialize( studentslist );  //JsonConvert.SerializeObject( studentslist );
    }
}