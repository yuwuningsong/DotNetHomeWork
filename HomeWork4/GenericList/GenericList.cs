using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }


        // 尾插法添加结点
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        // 新的遍历方法
        public void MyForEach(Action<T> action)
        {
            Node<T> p = head;
            while(p != null)
            {
                action(p.Data);
                p = p.Next;
            }
        }
    }
}
