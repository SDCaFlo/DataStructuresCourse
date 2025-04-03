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

        public bool SearchValue(int valor)
        {
            // Método para buscar un valor
            if (HeadNode == null)
            {
                Console.WriteLine("No hay valores");
                return false;
            }

            Node? currentNode = HeadNode;
            while (currentNode != null)
            {
                if (currentNode.Valor == valor)
                {
                    return true;
                }
                currentNode = currentNode.NextNode;
            }
            return false; //si no se encuentra
        }


        public void DeleteElement(int valor)
        {
            if (HeadNode == null) // si no se encuentra valores.
            {
                Console.WriteLine("No hay valores");
                return;
            }

            if (HeadNode.Valor == valor) //Si el valor está a la cabeza. debemos modificar el headnode
            {
                HeadNode = HeadNode.NextNode;
                if (HeadNode == null)
                { // Si la lista queda vacía
                    LastNode = null; 
                } 
                Console.WriteLine("Elemento eliminado");
                return;
            }


            Node? currentNode = HeadNode;

            while (currentNode.NextNode != null) // Iteración elemento por elemento.
            {
                if (currentNode.NextNode.Valor == valor)
                {
                    currentNode.NextNode = currentNode.NextNode.NextNode; // Chequeamos el valor del siguiente nodo, para evitar retroceder.
                    
                    if (currentNode.NextNode == null) { 
                        LastNode =  currentNode; 
                    }
                    Console.WriteLine("Elemento Eliminado");
                    return;

                }
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine("No se encontró el valor");

        }
    }
}
