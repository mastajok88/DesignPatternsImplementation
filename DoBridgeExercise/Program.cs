namespace DoBridgeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var rasterRenderer = new RasterRenderer();
            var vectorRenderer = new VectorRenderer();
            
            var triangleOne = new Triangle(rasterRenderer, nameof(Triangle));
            var triangleTwo = new Triangle(vectorRenderer, nameof(Triangle));

            triangleOne.Draw();
            triangleTwo.Draw();
            
            
        }
    }
}