using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ConcreteParticipant : Participant
    {
        public ConcreteParticipant(IMediator mediator, string name) : base(mediator, name) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine(message);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("\n" + name + ": Sending Message: " + message + "\n");

            _mediator.BroadcastMessage(message, this);
        }
    }
}
