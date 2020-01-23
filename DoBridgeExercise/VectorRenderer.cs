using System;

namespace DoBridgeExercise
{
    public class VectorRenderer : IRenderer
    {
        public void RenderShape(Shape shape)
        {
            Console.WriteLine($"Drawing {shape.Name} as lines");
        }
    }
}