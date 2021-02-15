namespace Net07.DynamicProgrammingAndClasses
{
    abstract class Drawer
    {
        protected abstract string LanguageInDescription { get;}
        public abstract void Draw(Shape shape);
    }
}