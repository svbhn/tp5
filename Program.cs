using System;

namespace tpmodul5_103022300081;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("John");

        DataGeneric<string> nim = new DataGeneric<string>("103022300081");
        nim.PrintData();

        Console.ReadLine(); 
    }
}
