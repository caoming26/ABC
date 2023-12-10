using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_bakery.system;


namespace ABC_bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
