using Microsoft.AspNetCore.Mvc;

namespace Classes;

public class School : BasicController {

    public School()
    {

    }

    [Route("api/schoolname/{id}")]
    public string getSchoolName( int id)
    {

        return "name";
    }
}