using Shape.Factories;
using System;
using Shape.Enums;
using Shape.Interfaces;

class Program
{
    static void Main(string []args)
    {
        AbstractFactory shapeFactory = FactoryGenerator.getFactory(ShapeStyle.ROUNDED);

        IShape squareShape = shapeFactory.getShape(shapeType.SQUARE);

        squareShape.Draw();
    }
}