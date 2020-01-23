using System;

namespace DoBridgeExercise
{
    public abstract class Shape
    {
        protected readonly IRenderer Renderer;
        public string Name { get; set; }
        protected Shape(IRenderer renderer, string name)
        {
            Renderer = renderer ?? throw new ArgumentNullException(paramName: nameof(renderer));
            this.Name = name;
        }
        public abstract void Draw();
    }
}