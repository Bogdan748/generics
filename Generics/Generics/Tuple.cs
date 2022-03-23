
namespace cSharpGenerics
{
    public class Tuple<T1,T2>

    {
        public T1 FirstElement { get; set; }

        public T2 SecondElement { get; set; }
    }

    public class Tuple<T1,T2,T3> : Tuple<T1, T2>

    {
        public T3 ThirdElement { get; set; }
    }
}
