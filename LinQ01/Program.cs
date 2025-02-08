namespace LinQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variables (var - Dynamic)

            // Implicitly Typed Local Variables (var - Dynamic)

            // var
            //   var  Data01 = " Ahmed";
            // Copmiler  can Detect the Datatype of the Variable
            // Must Be Initialized
            // Can't Be Null
            // Can't  Change THE DataType  
            // Can't Be Used as A prameter or Return Type


            //  Data01 = 12; // Invalid 
            // =======================================

            // Dynamic 
            //// Like var in JS

            //dynamic Data02 = "Ahmed";
            //// CLR Detect the Datatype of the Variable Based On The Last Value at RunTime
            //// don't need to be Initialized
            //// Can Be Null
            //// Can Change The DataType After Initialization
            //// Can Be Used as A prameter or Return Type




            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);
            //Data02 = 12.5;
            //Console.WriteLine(Data02.GetType().Name);
            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name); 
            #endregion

            #region Anonymous Types
            // Anonymous Types

            // Employee emp = new Employee { id = 1, Name = "Ahmed", Salary = 1000 };
            //var emp = new  { id = 1, Name = "Ahmed", Salary = 1000 };
            //var emp1 = new  { id = 1, Name = "Ahmed", Salary = 1000 };


            //Console.WriteLine(emp.id);
            //Console.WriteLine(emp.Salary);
            //Console.WriteLine(emp.Name);

            //emp.id = 2; // Error

            //Console.WriteLine(emp.GetType().Name);
            //  Console.WriteLine(emp.GetType().Name);
            //// The Same Anonymous Type Will Have The Same Name
            //// 1. The Same Property Name (Case Sensitive)
            ////2. The Same Property order


            //if (emp.Equals(emp1))
            //    Console.WriteLine(" Emp == Ep1");
            //else
            //    Console.WriteLine(" Emp != Ep1");

            #endregion
            #region Extention Methods

            // Extention Methods

            //   int num = 12345;

            //   num.Reverse();
            //var result=  IntExtention.Reverse(num);
            //   Console.WriteLine(result);

            #endregion


            #region LINQ : Language Integrated Query
            // LINQ : Language Integrated Query
            //      : 40+ Extention  MEthod (Linq OPerators) With Any data (Data In Sequence)
            //      : 13 Category 
            //      : LINQ Operators Exists in Built In Class "IEnumerable"


            // Sequence  : OPJECT from Class Implement InterFace "IEnumerable"
            // Local Sequence  : L20  , L2XMl
            // Remote Sequence : L2EF

            // input Sequence-> LINQ Operator -> Output Sequence
            // input Sequence-> LINQ Operator -> One Value
            //               -> LINQ Operator -> Output Sequence


            //   List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////  var result =  Enumerable.Where(numbers, n => n % 2 == 0);
            //     var result =  Enumerable.Any(numbers, n => n % 2 == 0);
            //   Console.WriteLine(result);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion


            #region Linq Syntax
            // Linq Syntax 

            // 1. Method Syntax
            // 1.1  Linq Operators  As => class member method Throw Class "Enumerable"

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = Enumerable.Where(n => n % 2 == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            // 1.1  Linq Operators  As => Extention  method THrow Seqeuence 

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.Where(n => n % 2 == 0);




            // 2. Query Syntax Like SQL Style
            // 2.1  From
            // 2.2  Where
            // 2.3  Select




            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = from n in numbers
            //             where n % 2 == 0
            //             select n;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion
        }
    }
}
