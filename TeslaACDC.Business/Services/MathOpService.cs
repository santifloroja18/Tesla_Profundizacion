using System;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class MathOpService : IMathOp
{
    public async Task<float> SquareArea(AreaSquare areaSquare)
    {
        var square = areaSquare.side * areaSquare.side;
        return square;
    }

    public async Task<float> Sum(Sum sum)
    {
    var result =  sum.num1 + sum.num2;
    return result;
    }

    public async Task<float> SquareAreaSide(AreaSquareSide areaSquareSide)
    {
        var areaSquare = (areaSquareSide.side_one + areaSquareSide.side_two + areaSquareSide.side_three + areaSquareSide.side_four) / 2;
        return areaSquare;
    }

    public async Task<float> TriangleArea(TriangleArea triangleArea)
    {
        var areaTriangle = (triangleArea.num_base * triangleArea.num_height) / 2;
        return areaTriangle;
    }
}
