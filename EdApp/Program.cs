namespace EdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new ShapeBucket<Red>();

            sb.AddShape(new RedTriangle()); //yes
            sb.AddShape(new RedCircle());  //yes
            sb.AddShape(new BlueSquare());  //no

        }
    }

    public class ShapeBucket<T> where T : Colour
    {
        public void AddShape<T2>(T2 colouredShape) where T2 : T
        {
            //do something
        }
    }

    public sealed class RedTriangle : Red { }
    public sealed class RedCircle : Red { }
    public sealed class BlueSquare : Blue  { }
    

    public abstract class Red : Colour {}
    public abstract class Blue : Colour { }

    public abstract class Colour : IShape { }

    public interface IShape { }


}
