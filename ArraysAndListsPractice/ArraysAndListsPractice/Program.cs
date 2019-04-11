using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        //List<string(orINT)> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jesse");
        //intList.Remove("Jesse");

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //byte[] byteArray = new byte[5000];

        string[] stringArray = { "Hello", "my", "name", "is", "Drew" };

        int[] numArray = { 1, 2, 3, 4, 5 };

        List<string> stringList = new List<string>();
        stringList.Add("Some");
        stringList.Add("code");
        stringList.Add("I");
        stringList.Add("have");
        stringList.Add("wrote");

      

        Console.WriteLine("Please pick a number between 0 and 4.");
        int input1 = Convert.ToInt32(Console.ReadLine());
        

        if (input1 > 5) Console.WriteLine("This index does not exist.");   
        else Console.WriteLine(stringArray[input1]);
            


        Console.WriteLine("Now, pick another number between 0-4 again.");
        int input2 = Convert.ToInt32(Console.ReadLine());
        

        if (input2 > 5) Console.WriteLine("This index does not exist.");
        else Console.WriteLine(numArray[input2]);
            
        
        
        Console.WriteLine("And again, pick another number between 0-4.");
        int input3 = Convert.ToInt32(Console.ReadLine());


        if (input3 > 5) Console.WriteLine("This index does not exist.");
        else Console.WriteLine(stringList[input3]);

        Console.ReadLine();


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;



        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();




    }
    }

