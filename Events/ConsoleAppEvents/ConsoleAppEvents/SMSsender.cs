using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvents
{
    public class SMSsender
    {
        public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS sender: sms was send!!! Data: " + e.Agenda.AgendaDate + "Tytul: " + e.Agenda.AgendaName);
        }

        public void OnAddedAgendaShorter(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS sender: sms was send (shorter method)!!! Data: " + e.Agenda.AgendaDate + " Tytul: " + e.Agenda.AgendaName);
        }

    }
}
