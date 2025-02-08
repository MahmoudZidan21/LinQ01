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


        }
    }
}
