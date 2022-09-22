using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICredyManager credyManager, ICredyManager credyManager2,ILoggerService loggerService)
        {
            //Basvuran Bilgilerini Degerlendirme

            credyManager.Hesapla();
            credyManager2.BiseyYap();
            loggerService.Log();
        }
        public void CredyOnBılgılendirme(List<ICredyManager> credies)
        {
            foreach (var credie in credies)
            {
                credie.Hesapla();
                Console.WriteLine("seni her nefeste ozledim bugun");
                Console.WriteLine("******************************");
            }
        }

    }
}
