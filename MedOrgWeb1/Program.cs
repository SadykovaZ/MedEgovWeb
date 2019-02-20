using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Med.Egov.Lib.Model;
namespace MedOrgWeb1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MedOrg m = new MedOrg();
            //m.Address = "";
            //m.Name = "Clinic 3";

            //ServiceMedOrg.AddMedOrg(m);

            foreach (MedOrg item in ServiceMedOrg.GetMedOrg())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
