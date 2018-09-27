using System;
namespace HelloWorld
{
    public class Numbers
    {
        int a;
        int b;

        public Numbers(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public int add() {
            return a + b;
        }
    }
}
