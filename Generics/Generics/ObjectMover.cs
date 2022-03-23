

namespace CsharpGenerics
{
    public class ObjectMover<T> : IObjectMover<T>
        where T: ITranslatableObject
    {
        public void  MoveObjects(int dx, int dy, params T[] objects)
        {
            foreach (T obj in objects)
            {
                obj.Move(dx, dy);
            }
        }

    }
}
