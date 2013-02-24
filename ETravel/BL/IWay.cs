
using System;
using System.Collections;

namespace ETravel.Buisness
{
    interface IWay : IEnumerable, IComparable 
    {
        ILink FirstNode { get; set; }
        ILink LastNode { get; set; }

        ILink Current { get; set; }

        ILink MoveNext();
        ILink MoveForward();
        int SetCurrentNode(INode node);

    }
}
