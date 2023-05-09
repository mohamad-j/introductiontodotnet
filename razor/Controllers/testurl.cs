using Microsoft.AspNetCore.Mvc;
using Classes;
namespace Controllers;

[ApiController]
public class TestMe : ControllerBase {

    [Route("api/getstudent")]
    public string getName()
    {
        Student st = new Student("Moha", 2343);


        /// Get the body as a string
        // StreamReader reader = new StreamReader( Request.Body );

        // string body = await reader.ReadToEndAsync();

        // // Convert string 

        // System.Text.Json.JsonSerializer.Serialize
        
        return st.name;



        // HttpContext httpcontext = new HttpContext();
    }
}