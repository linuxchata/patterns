using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public sealed class Facade
    {
        private SubSystemOne systemOne;

        private SubSystemTwo systemTwo;

        private SubSystemThree systemThree;

        private SubSystemFour systemFour;

        public Facade()
        {
            this.systemOne = new SubSystemOne();
            this.systemTwo = new SubSystemTwo();
            this.systemThree = new SubSystemThree();
            this.systemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("Method A on Facade");
            this.systemOne.MethodOne();
            this.systemTwo.MethodTwo();
            Console.WriteLine();
        }

        public void MethodB()
        {
            Console.WriteLine("Method B on Facade");
            this.systemThree.MethodThree();
            this.systemFour.MethodFour();
            Console.WriteLine();
        }
    }
}
