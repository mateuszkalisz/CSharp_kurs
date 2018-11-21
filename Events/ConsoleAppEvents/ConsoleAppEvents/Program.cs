using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaManager agendamgr = new AgendaManager();
            SMSsender sms = new SMSsender();
            
            agendamgr.AddedAgenda += sms.OnAddedAgenda;
            agendamgr.AddedAgendaShorter += sms.OnAddedAgendaShorter;
            
            agendamgr.AddAgenda(new Agenda()
            {
            AgendaDate = DateTime.Now.AddDays(2),
            AgendaName = "blablabla"
            });


            
            Console.ReadKey();

        }

    }
}
