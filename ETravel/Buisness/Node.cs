
namespace ETravel.Buisness
{
    class Node : INode
    {

        private Node _currentNode;



        public Node CurrntNode
        {
            get
            {
                return _currentNode ?? new Node();
            }
        }

          
    }
}
