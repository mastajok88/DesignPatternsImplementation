namespace DoBridgeExercise
{
    public class Square : Shape
    {
        public Square(IRenderer renderer, string name) 
            : base(renderer, name)
        {
        }

        public override void Draw()
        {
            Renderer.RenderShape(this);
        }
    }
}