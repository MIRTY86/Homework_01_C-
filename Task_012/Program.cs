using System;
using System.Globalization;



class Program
{
    static void Main(string[] args)
    {
        string num = "2.566";
        //**********************************************************
        //Далее пример измения разделителя в числе - запятую меняем на точку.
        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        double n = Convert.ToDouble(num, numberFormatInfo );
    }
}