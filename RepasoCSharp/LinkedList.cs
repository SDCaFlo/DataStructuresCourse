using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoCSharp
{
    internal class LinkedList
    {

        private class Node
        {
            // Propiededades nodo
            public int Valor { get; set; }
            public Node? NextNode { get; set; }  //"Nullable Reference Types" 

            //constructor de Nodo
            public Node(int valor)
            {
                Valor = valor;
                NextNode = null;
            }

            //metodo
            public void SetNextNode(int valor)
            {
                NextNode = new Node(valor);
            }
        }

        // Propiedades de la LinkedList
        Node? HeadNode { get; set; }
        Node? LastNode { get; set; }
        // Constructor LinkedList
        public LinkedList() { 
            HeadNode = null;
            LastNode = null;
        }


        public void AppendNode(int valor)
        {
            // Método para agregar un nuevo nodo al final de la lista.
            Node newNode = new Node(valor);

            if (HeadNode == null)
            {
                HeadNode = newNode;
                LastNode = newNode;
            }

            else
            {
                LastNode!.NextNode = newNode;   //null forgiving
                LastNode = newNode;
            }
        }

        public void PrintValues()
        {
            // Método para imprimir valores
            if (HeadNode == null)
            {
                Console.WriteLine("No hay valores");
            }
            else
            {
                Node? currentNode = HeadNode;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Valor);
                    currentNode = currentNode.NextNode;
                }
            }
        }
    }
}
