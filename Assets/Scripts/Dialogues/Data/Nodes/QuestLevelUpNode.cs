using NodeEditor;
using NodeEditor.Data;
using UnityEngine;

namespace Dialogues.Data.Nodes
{
    [NodeGroup(group: "Dialogues")]
    internal class QuestLevelUpNode : Node, IExecutionNode
    {
        [Port("succes")]
        private Node _succesNode;
        [Port("fail")]
        private Node _failNode;
        //[SerializeField]
        //private QuestData _quest;
        private Node _next = null;


        public Node SuccesNode => _succesNode;
        public Node FailNode => _failNode;
        public int QuestId => 0;// _quest.ID;
    }
}
