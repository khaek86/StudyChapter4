using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLiknedList<string> linkedList = new MyLiknedList<string>();

            linkedList.Add("aaa");
            linkedList.Add("bbb");
            linkedList.Add("ccc");
            linkedList.Add("ddd");
            linkedList.Add("Eee");
            linkedList.Remove(4);
            //linkedList.RemoveT(15);
            //linkedList.Insert1(2, "ttt");

            //linkedList.Find(2);

            linkedList.Foreach();
            

            
            //Console.WriteLine("Count : {0}",linkedList.Count());


            //LinkedList<T>
            List<string> list = new List<string>();

        }
    }
    public class MyLinkedListNode<T>
    {
        public T value { set; get; }
        public MyLinkedListNode<T> nextLink;
    }

    public class MyLiknedList<T>
    {
        private MyLinkedListNode<T> startPoint = new MyLinkedListNode<T>();
        //LinkedList<T>
        public void Add(T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>();
            newnode.value = value;

            MyLinkedListNode<T> startPointForWhile = startPoint;

            while (startPointForWhile.nextLink != null)
            {
                startPointForWhile = startPointForWhile.nextLink;
            }
            startPointForWhile.nextLink = newnode;
        }

        public void Foreach()
        {
            MyLinkedListNode<T> startPointForWhile = startPoint;
            while (startPointForWhile != null)
            {
                startPointForWhile = startPointForWhile.nextLink;

                if (startPointForWhile != null)
                {
                    Console.WriteLine(startPointForWhile.value);
                }
            }
        }

        public int Count()
        {
            int count = 0;
            MyLinkedListNode<T> startPointForWhile = startPoint;
            while (startPointForWhile != null)
            {
                if (startPointForWhile.nextLink != null)
                {
                    startPointForWhile = startPointForWhile.nextLink;
                    count++;
                }
                else
                {
                    return count;
                }
            }
            return count;
        }

        public  void RemoveT(T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>();
            newnode.value = value;

            MyLinkedListNode<T> startPointForWhile = startPoint;

            while (startPointForWhile.nextLink != null)
            {
                startPointForWhile = startPointForWhile.nextLink;
            }
            startPointForWhile.nextLink = newnode;
            if (newnode != null) startPointForWhile.nextLink = null;
        }

        public void Remove(uint index)
        {
            if (startPoint == null)
            {
                return;
            }

            MyLinkedListNode<T> startPointForWhile = startPoint;
            int innerIndex = 0;
            while (startPointForWhile.nextLink != null)
            {
                if (innerIndex == index)
                {
                    Debug.WriteLine(startPointForWhile.nextLink.value);                    
                    startPointForWhile.nextLink = startPointForWhile.nextLink.nextLink;
                }
                if (startPointForWhile.nextLink == null)
                {
                    break;
                }
                startPointForWhile = startPointForWhile.nextLink;
                innerIndex++;
            }
            Debug.WriteLine(innerIndex);
        }
        public T Find(T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>();
            newnode.value = value;

            MyLinkedListNode<T> startPointForWhile = startPoint;

            while (startPointForWhile.nextLink != null)
            {
                startPointForWhile = startPointForWhile.nextLink;
            }
            startPointForWhile.nextLink = newnode;
            if (newnode != null) startPointForWhile.nextLink = null;

            return newnode.value;
        }
        public void Insert1(int index, T value)
        {
            MyLinkedListNode<T> startPointForWhile = startPoint;
            int innerIndex = 0;
           
            if (index > 0 && index <= index + 1)
            {
                while (startPointForWhile != null)
                {
                    startPointForWhile = startPointForWhile.nextLink;
                    innerIndex++;
                }
                if (innerIndex == index)
                {
                    startPointForWhile = startPointForWhile.nextLink;
                }
            }
        }
        public void Insert2(T target, T value)
        {
            MyLinkedListNode<T> newnode = new MyLinkedListNode<T>();
            newnode.value = value;

            MyLinkedListNode<T> startPointForWhile = startPoint;

            while (startPointForWhile.nextLink != null)
            {
                startPointForWhile = startPointForWhile.nextLink;
            }
            startPointForWhile.nextLink = newnode;
            if (newnode != null) startPointForWhile.nextLink = null;
        }
     }
}
