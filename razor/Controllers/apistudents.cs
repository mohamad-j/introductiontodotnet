using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;

using Classes;

namespace Controllers;


public class ApiStudents : BasicController {

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

        var dict =  getBody< Params >();  
        
        return  "";
    }

}