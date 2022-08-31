using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PowerShell ps = PowerShell.Create();
            ps.AddScript(@"C:\Scripts\REM.ps1",true)
                .AddParameter(@"C:\pos\test")
                .AddParameter("-NewName").AddParameter(@"C:\pos\test1").Invoke();
            */

            //using (Runspace runspace = RunspaceFactory.CreateRunspace())
            //{
            //    runspace.Open();
            //    PowerShell ps = PowerShell.Create();
            //    ps.Runspace = runspace;
            //    ps.AddScript(@"C:\Scripts\REM.ps1");
            //    ps.Invoke();
               

            //    foreach (PSObject result in ps.Invoke())
            //    {
            //        Console.WriteLine(result);
            //    }
            //}

           

            try
            {
                //Console.WriteLine("Enter Old : ");
                //String oldDr = args[0];// Console.ReadLine();
                //Console.WriteLine("Enter New : ");
                //String newDr = args[1];//Console.ReadLine();
                //FileSystem.Rename(oldDr, newDr);


                Console.WriteLine("\n SUCCESS!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
