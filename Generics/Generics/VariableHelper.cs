
namespace CsharpGenerics
{
    public static class VariableHelper
    {
        public static void Swap<T>(ref T a,ref T b)
            where T: new()
        {
            T aux = a;
            a = b;
            b = aux;
        }
    }
}
