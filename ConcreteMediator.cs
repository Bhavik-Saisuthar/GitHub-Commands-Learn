using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ConcreteMediator : IMediator
    {
        readonly List<Participant> participates = new List<Participant>();

        public void AddParticipant(Participant participate)
        {
            participates.Add(participate);
        }

        public void BroadcastMessage(string message, Participant participate)
        {
            foreach (var item in participates)
            {
                if (item != participate)
                {
                    participate.ReceiveMessage(item.name + ": Received Message: " + message);
                }
            }
        }
    }
}
