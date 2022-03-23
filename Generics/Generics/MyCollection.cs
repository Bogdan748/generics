using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGenerics
{
    public class MyCollection<T> : IEnumerable<T>
    {
        private readonly T[] array;

        public MyCollection(params T[] elements)
        {
            array = elements ?? new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }


                return default;
                //throw new IndexOutOfRangeException($"Index {index} was outside of the bounds of the array[0, {array.Length - 1}]");
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
