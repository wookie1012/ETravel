
using System;
using System.Collections;

namespace ETravel.Buisness
{
    interface IMap : IComparable, IEnumerable, IDisposable
    {
        int MapID { get; set; }

        void ClearMap();
        void AddNode();
        int DeleteNode(int id);
        int DeleteNode(Node node);

        Node GetStartNodeNode();
        void SetStartNode();

    }
}
