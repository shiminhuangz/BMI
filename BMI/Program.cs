using System;

class Program
{
    static void Main()
    {
        Console.Write("請輸入身高(CM):：");
        double height = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("請輸入體重(KG)：");
        double weight = Convert.ToDouble(Console.ReadLine());
        height = height / 100;
        double bmi = weight / (height * height);

        Console.WriteLine($"您的BMI為：{bmi:F2}");

       /*
        if (bmi < 18.5)
        {
            Console.WriteLine("過輕。");
        }
        else if (bmi < 24.9)
        {
            Console.WriteLine("適中。");
        }
        else if (bmi < 29.9)
        {
            Console.WriteLine("過重。");
        }
        else
        {
            Console.WriteLine("肥胖。");
        }*/

       
        Console.ReadKey();
    }
}
