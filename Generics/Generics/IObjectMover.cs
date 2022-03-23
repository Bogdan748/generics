using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGenerics
{
    public interface IObjectMover<in T>
        where T: ITranslatableObject
    {

        void MoveObjects(int dx,int dy,params T[] objects);
    }
}
