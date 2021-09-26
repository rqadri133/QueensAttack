using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueensAttack
{
    public class Node
    {

        public Guid NodeID
        {
            get;
            set;
        }

        public Node ParentNode
        {
            get;
            set;
        }

        public bool StopAtThisNode
        {
            get;
            set;
        }



        public bool OnyLeftTraversingAllowed
        {
            get;
            set;
        }


        public bool OnlyRightTraversingAllowed
        {
            get;
            set;
        }

        public Node LeftChildNode
        {
            get;
            set;
        }


        public Node RightChildNode
        {
            get;
            set;
        }

        public List<Node> ChildNodes
        {
            get;
            set;


        }



    }
}
