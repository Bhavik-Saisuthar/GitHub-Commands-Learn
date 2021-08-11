using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IMediator
    {
        void AddParticipant(Participant participate);
        void BroadcastMessage(string message, Participant participate);
    }
}
