using System;
using System.Collections;
using System.Collections.Generic;

namespace ETravel.Buisness
{
    interface INode : IComparable, IEnumerable
    {
        int NodeId { get; set; }
        string NodeName { get; set; }

        List<INode> Links { get; set; }


    }
}
