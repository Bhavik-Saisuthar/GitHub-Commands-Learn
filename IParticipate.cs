using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public abstract class Participant
    {
        public readonly IMediator _mediator;
        public readonly string name;

        protected Participant(IMediator mediator, string name)
        {
            _mediator = mediator;
            this.name = name;
        }
        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }
}
