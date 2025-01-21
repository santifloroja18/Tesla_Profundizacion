using System;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Interfaces;

public interface IMathOp
{
    Task<float> Sum(Sum sum);
    Task<float> SquareArea(AreaSquare areaSquare);
    Task<float> SquareAreaSide(AreaSquareSide areaSquareSide);
    Task<float> TriangleArea(TriangleArea triangleArea);
}
