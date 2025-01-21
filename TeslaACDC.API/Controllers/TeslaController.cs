namespace TeslaACDC.Controllers;

using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

[ApiController]
[Route("api/[controller]")]
public class TeslaController : ControllerBase
{

  private readonly IMathOp _mathOpService;

  public TeslaController(IMathOp mathOpService)
  {
    _mathOpService = mathOpService;
  }
  
  [HttpPost]
  [Route("Sum")]
  public async Task<IActionResult> Sum(Sum sum)
  {
    var resultSum = await _mathOpService.Sum(sum);
    return Ok("The sum is equal: " + resultSum);
  }

  [HttpPost]
  [Route("AreaSquare")]
  public async Task<IActionResult> AreaSquare(AreaSquare areaSquare)
  {
    var result_areaSquare = await _mathOpService.SquareArea(areaSquare);
    return Ok("The area of ​​a quare whose side measures is equal to: " + result_areaSquare);
  }

  [HttpPost]
  [Route("AreaSquareSide")]
  public async Task<IActionResult> AreaSquareSide(AreaSquareSide areaSquareSide)
  {
    var result_areaSquareSide = await _mathOpService.SquareAreaSide(areaSquareSide);
    return Ok("The area of ​​a quare whose side measures is equal to: " + result_areaSquareSide);
  }

  [HttpPost]
  [Route("AreaTriangle")]
  public async Task<IActionResult> TriangleArea(TriangleArea triangleArea)
  {
    var result_areaTriangle = await _mathOpService.TriangleArea(triangleArea);
    return Ok("The area of ​​a quare whose side measures is equal to: " + result_areaTriangle);
  }

    /*
        1ro: debe devolver una array de albums
        2do: debe recibir dos valores y sumarlos, devolver el resultado
        3ro: debe calcular el area de un cuadrado.
        4to: Calcular area de un triangulo
        5to: Calcular area de un cuadrado recibiendo todos sus lados

    */
    
}

