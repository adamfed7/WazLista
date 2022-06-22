using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WazLista
{
    public class List
    {
        List<Node> listNode = new List<Node>();

        public void addNext(Node node)
        {
            listNode.Add(node);
        }

        public void remove(Node node)
        {
            listNode.Remove(node);
        }

        public int count(Node node)
        {
            return listNode.Count() - node.getId();
        }

        public Node getNext(Node node)
        {
            return listNode[node.getId() + 1];
        }

        public Node getPrevious(Node node)
        {
            return listNode[node.getId() - 1];
        }

        public Node toEnd()
        {
            return listNode.Last();
        }

        public Node toBegining()
        {
            return listNode.First();
        }


    }
}
