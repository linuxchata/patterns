using System;

namespace Facade
{
    public sealed class Facade
    {
        private SubSystemOne _systemOne;

        private SubSystemTwo _systemTwo;

        private SubSystemThree _systemThree;

        private SubSystemFour _systemFour;

        public Facade()
        {
            _systemOne = new SubSystemOne();
            _systemTwo = new SubSystemTwo();
            _systemThree = new SubSystemThree();
            _systemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("Method A on Facade");
            _systemOne.MethodOne();
            _systemTwo.MethodTwo();
            Console.WriteLine();
        }

        public void MethodB()
        {
            Console.WriteLine("Method B on Facade");
            _systemThree.MethodThree();
            _systemFour.MethodFour();
            Console.WriteLine();
        }
    }
}
