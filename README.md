# RAQL.NET
## Installation

You can install the library from Nuget

```bash
dotnet add package RAQL.NET --version 1.0.0
```

## Usage
### Linq
Use it to filter data in of a queryable collection
```csharp
using RAQL.NET.Linq;
using RAQL.NET.Models;

...
try{
  /**
   * implicit conversion from string
   * throws exception if the string 
   * is not valid
   */
  RaqlQuery q = "(x > 1 and x < 4) or (y >= 1 and y <=3)"; 

  IEnumerable<Vector> vectors = new List<Vector>()
        {
            new Vector(1,2),
            new Vector(2,1),
            new Vector(3,1),
            new Vector(3,2),
            new Vector(2,4),
            new Vector(6,3)
        };

  var filterdVectors = vectors.AsQueryable().Raql(q).ToList();
}catch(InvalidDataException ide){
  Console.WriteLine(ide.Message);
}
```
In an ASP.NET Controller you can make advantage of the RaqlQuary Model Binder to return a Bad Request on input validation
```csharp
using Microsoft.AspNetCore.Mvc;
using RAQL.NET.Linq;
using RAQL.NET.Models;

namespace RAQL.NET.Examples.WebApiQueryParamValidation.Controllers
{
  [ApiController]
  [Route("api/vectors")]
  public class VectorController : ControllerBase
  {
    /**
     * Query is validated durin Model Validation executed by the Action in the Controller
     */
    [HttpGet]
    public ActionResult<IEnumerable<Vector>> QueryVectors([FromQuery] RaqlQuery q)
    {
      IEnumerable<Vector> vectors = new List<Vector>()
            {
                new Vector(1,2),
                new Vector(2,1),
                new Vector(3,1),
                new Vector(3,2),
                new Vector(2,4),
                new Vector(6,3)
            };

      return Ok(vectors.AsQueryable().Raql(q).ToList());
    }
  }
}
```
For completness the Vector class used in the above examples


```csharp
public class Vector
{
  public int x { get; set; }
  public int y { get; set; }

  public Vector(int x, int y)
  {
    this.x = x;
    this.y = y;
  }
}
```
