
using System;

namespace ETravel.Buisness
{
    interface ILink : IComparable,IDisposable
    {
        INode NodeA { get; set; }
        INode NodeB { get; set; }

        ITransportType TransportType { get; set; }

        int Cost { get; set; }
        int Duration { get; set; }

    }
}
