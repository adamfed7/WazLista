using System;

namespace WazLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node dziadek = new Node("Dziadek"); //id 0
            Node ojciec = new Node("Ojciec"); //id 1
            Node syn = new Node("Syn"); // id 2
            Node wnuk = new Node("Wnuk"); // id 3

            List list = new List();

            list.addNext(dziadek);
            list.addNext(ojciec);
            list.addNext(syn);
            list.addNext(wnuk);

            Console.WriteLine(list.count(dziadek));
        }
    }
}
