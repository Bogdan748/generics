using System;
using CsharpGenerics;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace cSharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> listOfRectagles = new List<Rectangle>(
                new[]
                {
                    new Rectangle(10, 20),
                    new Rectangle(30, 40)

                });



            //bool areEqual = EqualityChecker.AreEqual(r1, r2);
            //Console.WriteLine(areEqual);

            IEnumerable<Shape> listOfShapes = listOfRectagles;

            //Covarianta (in)
            // Generic<Derived> => Generic<Base>
            double sumAreas = ShapeCalculator.SumAreas(listOfShapes);
            Console.WriteLine(sumAreas);

            //
            //LIST de rectagle nu deriva din list of Shape
            //List<Shape> listOFShape = listOfRectagles;


            //Contravarianta (in)
            // Generic<Base> => Generic<Derived>
            IObjectMover < Shape > shapeMover= new ObjectMover<Shape>();
            IObjectMover<Rectangle> rectangleMover = shapeMover;

            rectangleMover.MoveObjects(10, 20, new Rectangle(10, 20));

            Person p1 = new Person("1234")
            {
                FirstName="John",
                LastName="Doe"
            };

            Person p2 = new Person("1234")
            {
                FirstName = "John",
                LastName = "Doe"
            };

            bool areEqual2 = EqualityChecker.AreEqual(p1, p2);
            Console.WriteLine(areEqual2);


             /*bool areEqual = p1 == p2;
             Console.WriteLine(areEqual);*/

             Person p3 = Factory.Create<Person>();

            p1.Print();
            p2.Print();
            p3.Print();
            VariableHelper.Swap(ref p1, ref p2);
            p1.Print();
            p2.Print();


            MyCollection<int> collenctionOfInt = new MyCollection<int>(1,2,3,4);
            Console.WriteLine(collenctionOfInt[0]);

            foreach  (int element in collenctionOfInt)
            {
                Console.WriteLine(element);
            }
            
        }

        private static void Example_With_Generic_clasess()
        {
            

            Tuple<int, int> tupleFrequencies = new Tuple<int, int>()
            {
                FirstElement = 2,
                SecondElement = 2
            };


            Tuple<string, string> tupleTranslation = new Tuple<string, string>
            {
                FirstElement = "Da",
                SecondElement = "dsadsa"
            };

            Tuple<int, string, decimal> tupleProduct = new Tuple<int, string, decimal>
            {
                FirstElement = 1,
                SecondElement = "dsadsa",
                ThirdElement = 23M,

            };


            List<int> listIntegers = new List<int>();
            listIntegers.Add(2);
            listIntegers.AddRange(new[] { 1, 2, 3 });

            foreach (int elem in listIntegers)
            {
                //Console.WriteLine(elem);
            }


            List<string> listString = new List<string>();
            listString.Add("test");
            listString.AddRange(new[] { "one", "two" });
            foreach (string elem in listString)
            {
                // Console.WriteLine(elem);
            }


            //List<string> converted = (List<int>)listIntegers;


        }

        private static void Example_With_GenericMethods()
        {
            int a = 10;
            int b = 20;
            VariableHelper.Swap<int>(ref a, ref b);
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);


            string c = "first";
            string d = "second";
            //VariableHelper.Swap<string>(ref c, ref d);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
        }
    }

    
}
