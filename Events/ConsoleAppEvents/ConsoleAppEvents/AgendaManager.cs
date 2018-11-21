using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppEvents
{
    class AgendaManager
    {
        public delegate void AddedAgendaEventHandler(object o, AgendaEventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;

        //EventHandler 
        //EventHandler<TEventArgs>
        public event EventHandler<AgendaEventArgs> AddedAgendaShorter;


        

        //event publisher powinien byc :
        //    1. protected
        //    2. virtual
        //    3. void
        //    4. nazwa powinna sie zaczynac sie od ok

        protected virtual void OnAddedAgenda(Agenda newAgenda) // publisher - metoda ktora jest uruchamiana wtedy gdy event nastapi
        {
            if (AddedAgenda != null) AddedAgenda(this, new AgendaEventArgs() { Agenda = newAgenda });
        }

        protected virtual void OnAddedAgendaShorter(Agenda newAgenda) // publisher - metoda ktora jest uruchamiana wtedy gdy event nastapi
        {
            if (AddedAgendaShorter != null) AddedAgendaShorter(this, new AgendaEventArgs() { Agenda = newAgenda });
        }

        public void AddAgenda(Agenda newAgenda)
        {
            Console.WriteLine("AddAgenda: zaczynam cos dodawac....");
            Thread.Sleep(3000);
            // tutaj poinformowac smssender o zakonczeniu
            OnAddedAgenda(newAgenda);
            OnAddedAgendaShorter(newAgenda);
            Console.WriteLine("AddAgenda: skonczylem dodawac....");

        }
    }
}

#region Instruction
// 1 tworzymy  public event EventHandler<AgendaEventArgs> AddedAgendaShorter;
// 2 tworzymy publishera: 
//protected virtual void OnAddedAgendaShorter(Agenda newAgenda) // publisher - metoda ktora jest uruchamiana wtedy gdy event nastapi
//{
//    if (AddedAgendaShorter != null) AddedAgendaShorter(this, new AgendaEventArgs() { Agenda = newAgenda });
//}
//3 dodajemydo public void AddAgenda: OnAddedAgendaShorter(newAgenda);
// 4 piszemy metode w smssenderze:
//public void OnAddedAgendaShorter(object o, AgendaEventArgs e)
//{
//    Console.WriteLine("SMS sender: sms was send (shorter method)!!! Data: " + e.Agenda.AgendaDate + " Tytul: " + e.Agenda.AgendaName);
//}
//5 rejestrujemy metode w program.cs: agendamgr.AddedAgendaShorter += sms.OnAddedAgendaShorter;



#endregion


