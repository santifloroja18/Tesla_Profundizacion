namespace TeslaACDC.Controllers;

using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Model;
[ApiController]
[Route("api/[controller]")]
public class TeslaController : ControllerBase
{
  [HttpPost]
  [Route("Addition")]
  public async Task<IActionResult> Addition(Addition addition)
  {
    var result =  addition.number_one + addition.number_two;
    return Ok("The sum of: " + addition.number_one + " + " + + addition.number_two + " = " + result);
  }

  [HttpPost]
  [Route("AreaSquare")]
  public async Task<IActionResult> AreaSquare(Square square)
  {
    var area = square.side * square.side;
    return Ok("The area of ​​a square whose side measures " + square.side + " is equal to " + area);
  }

    // Tres métodos: 
    /*
        1ro: debe devolver una array de albums
        2do: debe recibir dos valores y sumarlos, devolver el resultado
        3ro: debe calcular el area de un cuadrado.

        EXTRA CURRICULAR
        Crear una clase extra, y poner la lógica afuera del controlador.
        4to: Calcular area de un triangulo
        5to: capturar con errores.
    */
    
}

