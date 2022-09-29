using Shape.Enums;
using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Factories
{
    public abstract class AbstractFactory
    {
        public abstract IShape getShape(shapeType shapeType);
    }
}
