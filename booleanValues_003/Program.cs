using System;

namespace booleanValues_003
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean values are true or false
            bool myFirstBoolean = 3 + 2 == 5;
            Console.WriteLine(myFirstBoolean.ToString());

            bool mySecondBoolean = 3 + 2 > 5;
            Console.WriteLine(mySecondBoolean.ToString());

            // && requires both sides to be true in order to be true
            bool bothAreTrue = myFirstBoolean && mySecondBoolean;
            Console.WriteLine("bothAreTrue evaluates " + bothAreTrue);

            // || or requires either side to be true in order to be true
            bool oneIsTrue = myFirstBoolean || mySecondBoolean;
            Console.WriteLine("oneIsTrue evaluates {0} because one " +
                              "expression is true", oneIsTrue);
            // ! not reverses truth
            bool reverseMyFirstBoolean = !myFirstBoolean;
            Console.WriteLine("myFirstBoolean is {0} but " +
                              "reverseMyFirstBoolean is {1}",
                              myFirstBoolean, reverseMyFirstBoolean);
        }
    }
}
 