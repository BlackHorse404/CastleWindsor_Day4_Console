using System;
using System.Text;
using CastleWindsor_Day4_Console.Utilities;
using CastleWindsor_Day4_Console.Data;
using CastleWindsor_Day4_Console.BusinessLogic;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using CastleWindsor_Day4_Console.Data.InterFace;

namespace CastleWindsor_Day4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //format encoding 
            Console.OutputEncoding = Encoding.UTF8;
            //Process     

            //Constructor Injection - sử dụng nguyên tắc DI (Dependency Injection)
            //SVBusinessLogic svBL = new SVBusinessLogic(new DataAccessList());

            //sử dụng thư viện Castle Windsor
            try
            {
                WindsorContainer container = new WindsorContainer();
                container.Register(Component.For<ISinhVienDAL>().ImplementedBy<DataAccessList>(),
                                   Component.For<SVBusinessLogic>());
                Execute.RunMain(container);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
