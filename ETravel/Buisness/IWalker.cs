
using System;

namespace ETravel.Buisness
{
    interface IWalker: IDisposable
    {
        IMap CurrentMap { get; set; }
        INode CurrentNode { get; set; }

        IResult FindWay(Node startPlace, Node destinationPlace);
        IResult FindWay(Node destinationPlace);
    }
}
