using System;

namespace MediatorDesignPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new ConcreteMediator();

            Participant participant1 = new ConcreteParticipant(mediator, "Bhavik");
            Participant participant2 = new ConcreteParticipant(mediator, "Robot");
            Participant participant3 = new ConcreteParticipant(mediator, "Chitti");
            Participant participant4 = new ConcreteParticipant(mediator, "Keyboard");
            Participant participant5 = new ConcreteParticipant(mediator, "Mouse");

            mediator.AddParticipant(participant1);
            mediator.AddParticipant(participant2);
            mediator.AddParticipant(participant3);
            mediator.AddParticipant(participant4);
            mediator.AddParticipant(participant5);

            participant1.SendMessage("dotnettutorials.net - this website is very good to learn Design Pattern");

            participant2.SendMessage("What is Design Patterns? Please explain ");

            Console.ReadLine();
        }
    }
}
