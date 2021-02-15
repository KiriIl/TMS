using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class ConsoleDescriptionDrawer : Drawer
    {
        protected override string LanguageInDescription { get => "Figure is"; }
        public override void Draw(Shape shape)
        {
            Console.WriteLine($"{LanguageInDescription}");
            Console.WriteLine(shape);
        }
    }
}
