using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System.Text.Json;
using Classes;

namespace Controllers;

[ApiController]
public class ApiStudents : ControllerBase {

    private class Params {
        public string? name{ set; get; }

        public int? age { set; get; }
    }
    [Route("api/student/create")]
    public async Task<string> createStudent()
    {
        // var body = HttpContext.Items;
        // return body["request_body"];
        HttpContext.Response.Headers.Add("Content-Type", "application/json");

        string? body="";
      using (StreamReader stream = new StreamReader(Request.Body))
        {
            body = await stream.ReadToEndAsync();
        }

        var dict = JsonSerializer.Deserialize< Params >( body );
        
        return  JsonSerializer.Serialize( dict );
    }

}