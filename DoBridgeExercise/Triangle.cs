namespace DoBridgeExercise
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer, string name)
            : base(renderer, name)
        {
        }

        public override void Draw()
        {
            Renderer.RenderShape(this);
        }
    }
}