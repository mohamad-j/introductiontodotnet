using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Classes;

[ApiController]
public class BasicController : ControllerBase {

    public async Task< T > getBody< T >()
    {
        string? body="";
      using (StreamReader stream = new StreamReader(Request.Body))
        {
            body = await stream.ReadToEndAsync();
        }

       T result =  JsonSerializer.Deserialize< T >( body );

        return result;
    }


}