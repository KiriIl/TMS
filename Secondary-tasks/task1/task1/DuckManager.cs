using System;

namespace task1
{
    static class DuckManager
    {
        static Random Random;
        readonly static Type[] ducks = new Type[]
        {
            typeof(LoverDuck),
            typeof(RubberDuck),
            typeof(GrayDuck),
            typeof(Quacwa)
        };

        static DuckManager()
        {
            Random = new Random();
        }

        public static Duck RandomDuck()
        {
            int i = Random.Next(0, ducks.Length);
            Type type = ducks[i];
            object duck = Activator.CreateInstance(type);
            return (Duck)duck;
        }
    }
}