using System;
using System.Collections.Generic;

namespace OOP3
{
      class Program
    {
        static void Main(string[] args)
        {
            NeededCredyManager neededCredyManager=new NeededCredyManager();
            
            CarCredyManager carCredyManager=new CarCredyManager();  

            HouseCredyManager houseCredyManager=new HouseCredyManager();
            
            

            ILoggerService dataBaseloggerService=new DateBaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();


            BasvuruManager basvuruManager=new BasvuruManager();
            basvuruManager.BasvuruYap(carCredyManager,houseCredyManager,dataBaseloggerService);



            List<ICredyManager> credies=new List<ICredyManager>() {neededCredyManager,carCredyManager,houseCredyManager };
            //basvuruManager.CredyOnBılgılendirme(credies);




        }
    }
}
