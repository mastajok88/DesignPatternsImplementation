using System;

namespace DoBridgeExercise
{
    public class RasterRenderer : IRenderer
    {
        public void RenderShape(Shape shape)
        {
            Console.WriteLine($"Drawing {shape.Name} as pixels");
        }
    }
}