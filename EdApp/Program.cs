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

    public class RedTriangle : Red { }
    public class RedCircle : Red { }
    public class BlueSquare : Blue  { }
    

    public class Red : Colour {}
    public class Blue : Colour { }

    public abstract class Colour : IShape { }

    public interface IShape { }


}
