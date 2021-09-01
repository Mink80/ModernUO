using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Mobiles.BehaviorTreeAI
{
    public abstract class ActionNode : LeafNode
    {
        public ActionNode(BehaviorTree tree) : base(tree)
        {
        }
    }
}
