using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Structure.Stack
{
    class Node
    {
        public int data; // Dato que almacena el nodo
        public Node next; // Direccion de memoria del siguiente nodo
        
        // Constructores de los nodos
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
        
        public Node(int data)
        {
            this.data = data;
            next = null; // El nodo no apuntara a ninguna direccion de memoria
        }
    }
}
