
using System;

namespace ETravel.Buisness
{
    interface ILink 
    {
        ILink NextLink { get; set; }
        ILink PreviousLink { get; set; }

        INode CurrentNode { get; set; }
        int Cost { get; set; }
        int Duration { get; set; }

    }
}
