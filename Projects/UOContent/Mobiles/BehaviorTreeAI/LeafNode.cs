using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Mobiles.BehaviorTreeAI
{
    public abstract class LeafNode : BehaviorTreeNode
    {
        public LeafNode(BehaviorTree tree) : base(tree)
        {
        }
    }
}
