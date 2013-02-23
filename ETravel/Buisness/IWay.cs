
using System;
using System.Collections;

namespace ETravel.Buisness
{
    interface IWay : IEnumerable, IComparable 
    {
        ILink First { get; set; }
        ILink Last { get; set; }

        ILink Current { get; set; }

        ILink MoveNext();

    }
}
