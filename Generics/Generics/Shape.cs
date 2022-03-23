using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGenerics
{
    public abstract class Shape : ITranslatableObject
    {
        public abstract double Area { get; }

        public abstract void Move(int dx, int dy);
    }
}
