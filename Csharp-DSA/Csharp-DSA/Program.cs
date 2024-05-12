using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Dynamic_Array
{



    internal class Program
    {
        class Recursion
        {
            public static int Fact(int num)
            {
                if (num == 0) return 1;
                else return num * Fact(num - 1);

            }
        }

        //Struct class 
        /*public struct Book
        {
            public decimal price;
            public string title ;
            public string author ;
        }*/


        //to make array size more big 
        /* public static void ES(ref int[] array ,int x)
         {
             int[] new_array = new int[array.Length + x] ;
             Array.Copy(array,new_array,array.Length) ;
             array = new_array ;

         }*/
        //Linkedlist 

        static void Main(string[] args)
        {
            Console.WriteLine(Recursion.Fact(5));
            //Arrays 
            /*Linear_Search

            Console.WriteLine("Welcome at the array");
            Console.Write("enter the size of array = ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the element which you want search : ");
            int se = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i < size; i++)
            {
                if (se == arr[i])
                {
                    flag = -1;
                    Console.WriteLine($"found at index = {i}");
                }
                if (flag == 0)
                {
                    Console.WriteLine();
                }
            }*/

            /* //Dynamic Array 

            //Dynamic Array 
            //We had 2 types od array : Static , Dynamic 


            //Frist test 
            Console.Write("Enter the size of array = ");

            int x = int.Parse(Console.ReadLine());
            int[] arr1 = new int[x];

            Console.WriteLine("-----------------");
            Console.WriteLine("Enter the elemnts ");

            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter the elemnt {i+1} = ");

                arr1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("Did you want more spcae? ");
            Console.WriteLine("Yes = 1");
            Console.WriteLine("NO = 2");
            int press = int.Parse(Console.ReadLine());
        
            switch (press)
            {
                case 1:
                    {
                        Console.Write("Enter the space = ");
                        int size = int.Parse(Console.ReadLine());
                        ES(ref arr1, size); // call the method 

                        for (int i = x; i < arr1.Length; i++)
                        {
                            Console.Write($"Enter the elemnt {i + 1} = ");

                            arr1[i] = int.Parse(Console.ReadLine());

                        }

                        for (int i = 0 ; i < arr1.Length; i++)
                        {
                            Console.WriteLine($"Array is = {arr1[i]}");
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            Console.WriteLine($"Array{i+1}"+" is = {arr1[i]}");
                        }
                        break;
                    }   
                default:
                    break;
            }*/

            /* Reveseed array
            int[] array = { 1, 2, 3, 4, 5 };
            int length = array.Length;
            int[] reversed = new int[length];
            for (int index = 0; index < length; index++)
            { reversed[length - index - 1] = array[index]; }
            for (int index = 0; index < length; index++)
            { Console.Write(reversed[index] + ""); }
            */

            /* symmetric array
            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length –i - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine("Is symmetric? {0}", symmetric);*/




        }

        public class Linkedlist
        {
            class Node
            {
                public int data;
                public Node next;
            }
            Node Head;

            public void InsertEnd(int data)
            {
                Node p = Head;
                Node X = new Node();
                X.data = data;
                while (p != null)
                {
                    p = p.next;
                }
                p.next = X;
            }
            public void InsertFront(int data)
            {
                Node p = Head;
                Node X = new Node();
                X.data = data;
                X.next = p;
                Head = p;
            }
            public void Insertempty(int data)
            {
                Node Temp = new Node();
                Temp.data = data;
                Temp.next = Head;
                Head = Temp;
            }

            public void InsertAfter(int data, int key)
            {
                Node Temp = new Node();
                Temp.data = data;
                Node p = Head;
                while (p != null)
                {
                    if (p.data == key)
                    {
                        break;
                    }
                    p = p.next;
                }
                Temp.next = p.next;
                p.next = Temp;

            }
            public void Insertbefore(int data, int key)
            {
                Node Temp = new Node();
                Temp.data = data;
                Node p = Head;
                while (p != null)
                {
                    if (p.next.data == key)
                    {
                        break;
                    }
                    p = p.next;
                }
                Temp.next = p.next;
                p.next = Temp;

            }

            public void Pos(int data, int pos)
            {
                Node Temp = new Node();
                Temp.data = data;
                Node p = Head;
                for (int i = 1; i < pos - 1 && p != null; i++)
                {
                    p = p.next;
                }
                Temp.next = p.next;
                p.next = Temp;
            }

        }

        public class StackArray
        {

            int top;
            int[] data;
            public StackArray(int size)
            {
                top = -1;
                data = new int[size];

            }
            public int size()
            {
                return top + 1;
            }
            public bool isEmpty()
            {
                if (top == -1)
                    return true;
                else
                    return false;
            }

            public bool isFull()
            {
                if (top == data.Length - 1)
                    return true;
                else
                    return false;
            }
            public void push(int x)
            {
                if (isFull())
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }
                ///else
                top = top + 1;
                data[top] = x;
            }
            public int pop()
            {
                int x;
                if (isEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return int.MinValue;
                }
                ///else
                x = data[top];
                top = top - 1;
                return x;
            }
            public void display()
            {
                int i;
                Console.WriteLine("top = {0}", top);
                if (isEmpty())
                {
                    Console.WriteLine("Stack is Empty");
                    return;
                }
                ///else
                Console.WriteLine("Stack is : ");
                for (i = top; i >= 0; i--)
                    Console.WriteLine(" {0}", data[i]);
            }

        }

        class StackList
        {
            Node top;

            class Node
            {
                public int data;
                public Node next;
            }
            public void StackLinkedList()
            {
                top = null;

            }
            public int size()
            {
                int s = 0;
                Node p = top;
                while (p != null)
                {
                    p = p.next;
                    s++;
                }
                return s;
            }

            public bool isEmpty()
            {
                if (top == null)
                    return true;
                else
                    return false;
            }
            public void push(int data)
            {
                Node temp;
                temp = new Node();
                temp.data = data;
                temp.next = top;
                top = temp;
            }

            public int pop()
            {
                int x;
                if (isEmpty())
                {
                    Console.WriteLine("No elemnts in stack");
                }


                x = top.data;
                top = top.next;

                return x;

            }
            public int peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return int.MinValue;
                }
                return top.data;
            }
            public void display()
            {
                Node p = top;
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                //else
                Console.WriteLine("Stack is:");
                while (p != null)
                {
                    Console.WriteLine("{0}", p.data);
                    p = p.next;
                }
            }



        }
        public static bool isBalancedParenthesis(string expn)
        {
            StackList stk = new StackList();
            foreach (char ch in expn.ToCharArray())
            {
                switch (ch)
                {
                    case '{':
                    case '[':
                    case '(':
                        stk.push(ch);
                        break;
                    case '}':
                        if (stk.pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (stk.pop() != '[')
                            return false;
                        break;
                    case ')':
                        if (stk.pop() != '(')
                            return false;
                        break;
                }
            }
            return stk.size() == 0;
        }
        /* static void reverseAWord(string word)
         {
             StackArray stack = new StackArray();
             foreach (char c in word)
             {
                 stack.push(c);
             }
             while (!stack.isEmpty())
             {
                 Console.Write(stack.pop());
             }
             Console.WriteLine();
         }*/

        //Queue
        class queue
        {
            int front;
            int rear;
            int[] data;

            public void QueueArray(int size)
            {
                data = new int[size];
                front = rear = -1;
            }
            public bool isFull()
            {
                if (rear == data.Length - 1)
                    return true;
                else
                    return false;
            }
            public void enqueue(int item)
            {
                if (isFull())
                {
                    Console.WriteLine("Queue Overflow");
                    return;
                }
                if (front == -1)
                    front = 0;
                rear = rear + 1;
                data[rear] = item;
            }
            public bool isEmpty()
            {
                if (front == -1 || front == rear + 1)
                    return true;
                else
                    return false;
            }
            public int dequeue()
            {
                int item;
                if (isEmpty())
                {
                    Console.WriteLine("Queue Underflow");
                    return int.MinValue;
                }
                item = data[front];
                front = front + 1;
                return item;
            }
            public int peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue Underflow");
                    return int.MinValue;
                }
                return data[front];
            }
            public void display()
            {
                int i;
                if (isEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                Console.WriteLine("Queue is :");
                for (i = front; i <= rear; i++)
                    Console.Write(data[i] + " ");
                Console.WriteLine();
            }

            class QueueLinkedList
            {
                class Node
                {
                    public int data;
                    public Node next;
                }
                Node front;
                Node rear;
                public QueueLinkedList()
                {
                    front = rear = null;
                }

                public bool isEmpty()
                {
                    if (front == null)
                        return true;
                    else
                        return false;
                }
                public void enqueue(int item)
                {
                    Node temp;
                    temp = new Node();
                    temp.data = item;
                    temp.next = null;
                    if (front == null) // If Queue is empty
                        front = temp;
                    else
                        rear.next = temp;
                    rear = temp;
                }
                public int dequeue()
                {
                    int item;
                    if (isEmpty())
                    {
                        Console.WriteLine("Queue Underflow");
                        return int.MinValue;
                    }
                    item = front.data;
                    front = front.next;
                    return item;
                }
                public int peek()
                {
                    if (isEmpty())
                    {
                        Console.WriteLine("Queue Underflow");
                        return int.MinValue;
                    }
                    return front.data;

                }

                public void display()
                {
                    Node ptr;
                    ptr = front;
                    if (isEmpty())
                    {
                        Console.WriteLine("Queue is empty");
                        return;
                    }
                    Console.WriteLine("Queue elements :");
                    while (ptr != null)
                    {
                        Console.Write(ptr.data + " ");
                        ptr = ptr.next;
                    }
                    Console.WriteLine();
                }

            }


        }
    }
}


