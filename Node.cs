using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WazLista
{
    public class Node
    {
        int id;
        string name;

        public static int _id = 1;


        public Node(string name)
        {
            this.name = name;
            id = Node._id;
            Node._id++;

        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

    }
}
