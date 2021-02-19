using System;
using Unity;
using UnityEngine;

public partial class CsharpNote
{
    /// <summary>
    /// C#7之前，switch 語句　支持的唯一模式是常量，數字類型和字串類型
    /// </summary>
    /// <param name="parts"></param>
    /// <returns></returns>
    public static string GenerateMessage(params string[] parts) {
        switch (parts.Length) {
            case 0:
                return "No elements to the input";
            case 1:
                return $"One element: {parts[0]}";
            case 2:
                return $"Two elements: {parts[0]},{parts[1]}";
            default:
                return $"Many elements. Too many to write";
        }
    }

    /// <summary>
    /// C#7以後可以使用類型模式
    /// </summary>
    /// <param name="shape"></param>
    /// <returns></returns>
    public static double ComputeAreaModernSwitch(object shape) {
        switch (shape) {
            case Square s:
                return s.Side * s.Side;
            case Circle c:
                return c.Radius * c.Radius;
            case Rectangle r:
                return r.Height * r.Length;
            default:
                throw new ArgumentException(
                    message:"shape is a recognized shape",
                    paramName: nameof(shape));
        }
    }

    // case 表達式中的 when 語句

    public static double CompteArea_Version3(object shape) {
        switch (shape) {
            case Square s when s.Side == 0:
            case Circle c when c.Radius == 0:
                return 0;

            case Square s:
                return s.Side * s.Side;
            case Circle c:
                return c.Radius * c.Radius * Math.PI;
            default:
                throw new ArgumentException(
                    message:"shape is not a recognized shape",
                    paramName: nameof(shape));
        }
    }

    // case 表達式中的 var 聲明
    static object CreateShape(string shapeDescription)
    {
        switch (shapeDescription) {
            case "circle":
                return new Circle(radius:2);
            case "square":
                return new Square(side:4);
            case "large-circle":
                return new Circle(radius: 12);

            //case var o: string when(o?.Trim().Length ?? 0) == 0:
                //return null;
            //錯誤 不明
            default:
                return "invalid shape description";
        }
    }
}