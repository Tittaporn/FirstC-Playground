using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstPlayground
{
    class Program
    {
        // 6) Enum and Class
        enum PlayerState { 
        Idle,
        Attacking
        }
        static PlayerState playerState;
        static void Main(string[] args)
        {
            // 1) Variables and log in console
            int age = 32;
            int saving = 100;
            string name = "Lee McCormick.";
            Console.WriteLine("Hello World!");how 
            Console.Write("Hello, " + name + " Welcome to " + age + " years old.");

            // 2) Functions
            TestVoidFunction();
            bool testBool = TestBoolFunctionWithParameter(99);
            Console.WriteLine("Test Bool Function : " + testBool);

            // 3.1) If Conditions
            if ((saving > 1000 && saving == 1001) || (saving > 2000 && saving == 2002))
            {
                Console.WriteLine("Hey! you are about to be billinair.");
            }
            else
            {
                Console.WriteLine("You are dirt poor.");
            }

            if (age < 20)
            {
                Console.WriteLine("Hey! " + name + " You are just a babe!");
            }
            else
            {
                Console.WriteLine("Hey! " + name + " You are not a kid anymore!");
            }

            // 3.2) switch Conditions
            switch (name)
            {
                // default: // Not sure how this switch work!
                case "test switch first case":
                    Console.WriteLine("test switch first case".ToUpper());
                    break;
                case "test switch second case":
                    Console.WriteLine("test switch second case".ToLower());
                    break;
            }

            playerState = PlayerState.Idle;
            switch (playerState) {
                case PlayerState.Attacking:
                    Console.WriteLine("PlayerState.Attacking");
                    break;
                case PlayerState.Idle:
                    Console.WriteLine("PlayerState.Idle");
                    break;
            }

            // 4) Collections
            string[] strNullArray = null;
            int[] intArray = new int[1];
            int[] intArrayAgain = new int[] {1, 2, 3, 4, 5};
            Console.WriteLine("strNullArray : " + strNullArray);
            Console.WriteLine("intArray : " + intArray);
            Console.WriteLine("intArrayAgain : " + intArrayAgain);

            List<int> intList = new List<int>();
            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            intList.Add(9);
            //   List<int> intList = new List<int>() { 6, 7, 8, 9 };

            // 5) Foreach, For, While and Do While
            foreach (int i in intList) {
                Console.WriteLine("i in intList : " + i);
            }

            for (int i = 0; i < intList.Count; i++) {
                Console.WriteLine("index : " + i + " And intList[i] : " + intList[i]);
            }

            int ii = 0;
            while (ii < 5) {
                Console.WriteLine("while Loop : " + ii);
                ii++;
            }
            int doWhileTest = 7;
            do
            {
            Console.WriteLine("doWhileTest : " + doWhileTest);
            doWhileTest--;
            } while (doWhileTest >= 0);

            // 7) Class
            MyClass myClass = new MyClass();
            myClass.TestFunction();
            myClass.myInt = 5;
            Console.WriteLine("myClass.myInt : " + myClass.myInt);

            Console.ReadKey();
            //  Console.ReadLine();
        }

        // 7) Class 
        class MyClass {
            private float myFloat;
            public int myInt;

            public MyClass() { 
            // Custom constructor
            }

           public void TestFunction() { 
            // Do something in public...
           }

           private void TestPrivateFunction() {
                // Do something private in this class...
                // Defalut is private ==> void == private
            }
        }

        // 2) Functions
        static void TestVoidFunction()
        {
            Console.WriteLine("Testing Void Function...");
            playerState = PlayerState.Attacking;
            Console.WriteLine("Test Void Function Print : " + playerState);
        }

        static bool TestBoolFunctionWithParameter(int i)
        {
            return i < 100;
        }
    }
}