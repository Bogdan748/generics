using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGenerics
{
    public class EqualityChecker
    {
        public static bool AreEqual<T>(T first, T second)
            where T: IEquatable<T>
        {
            if (first is null && second is null)
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }



            return first.Equals(second);
        }
    }
}
