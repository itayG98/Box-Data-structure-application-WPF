﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    /// <summary>
    /// Represent a Queue where the element sorted by last to first 
    /// </summary>
    /// <typeparam name="V"></typeparam>
    public class MyQueue<V> where V : IComparable
    {
        private QueueNode<V> _root;
        private QueueNode<V> _tail;

        /// <summary>
        /// Root represent the oldest box
        /// </summary>
        public QueueNode<V> Root { get => _root; private set => _root = value; }
        /// <summary>
        /// Tail represent the most new Box
        /// </summary>
        public QueueNode<V> Tail { get => _tail; private set => _tail = value; }

        public MyQueue() => Root = Tail = null;
        public QueueNode<V> Add(V val)
        {
            if (IsEmpty())
            {
                Root = new QueueNode<V>(val);
                Tail = null;
                Root.Prev = null;
                Root.Next = null;
                return Root;
            }
            else if (Root != null && Root.Next == null)
            {
                Tail = new QueueNode<V>(val);
                Root.Next = Tail;
                Tail.Prev = Root;
                return Tail;
            }
            QueueNode<V> newRoot = new QueueNode<V>(val);
            Tail.Next = newRoot;
            newRoot.Prev = Tail;
            Tail = newRoot;
            return newRoot;
        }
        public void Empty()
        {
            Root = null;
            Tail = null;
        }
        public bool Remove(V val)
        {
            if (IsEmpty() || val == null)
                return false;
            foreach (QueueNode<V> node in GetQueueRootFirst())
            {
                if (node.Value.Equals(val))
                {
                    if (node.Prev == null) //Root
                    {
                        if (Root.Next != null)
                        {
                            Root = Root.Next;
                            Root.Prev = null;
                        }
                        else
                        {
                            Root = null;
                            Tail = null;
                        }
                    }
                    else if (node.Next == null) //Tail
                    {
                        Tail = node.Prev;
                        Tail.Next = null;
                    }
                    else
                    {
                        node.Next.Prev = node.Prev;
                        node.Prev.Next = node.Next;
                    }
                    return true;
                }
            }
            return false;
        }
        public bool Remove(QueueNode<V> toRemove) //O(1)
        {
            if (IsEmpty() || toRemove == null)
                return false;
            if (toRemove == Root)
            {
                if (toRemove.Next == null)
                {
                    Empty();
                    return true;
                }
                Root = toRemove.Next;
                Root.Prev = null;
                return true;
            }
            else if (toRemove == Tail)
            {
                if (toRemove.Prev == null)
                {
                    Empty();
                    return true;
                }
                toRemove.Prev.Next = null;
                Tail = toRemove.Prev;
                return true;
            }
            else if (toRemove.Prev != null && toRemove.Next != null)
            {
                toRemove.Prev.Next = toRemove.Next;
                toRemove.Next.Prev = toRemove.Prev;
                return true;
            }
            return false;
        }
        public V Pop()
        {
            if (IsEmpty())
                return default;
            else
            {
                V val = Root.Value;
                Root = Root.Next;
                return val;
            }
        }
        public bool Contains(V val)
        {
            if (IsEmpty())
                return default;
            QueueNode<V> node = Root;
            while (node.Next != null)
            {
                if (node.CompareTo(val) == 0)
                    return true;
                node = node.Next;
            }
            return node.CompareTo(val) == 0;
        }

        public bool IsEmpty() => Root == null && Tail == null;
        /// <summary>
        /// Return Root first value
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetQueueRootFirstByValue()
        {
            if (!IsEmpty())
            {
                QueueNode<V> node = Root;
                yield return node.Value;
                while (node.Next != null)
                {
                    yield return node.Next.Value;
                    node = node.Next;
                }
            }
        }
        /// <summary>
        /// Tails first value
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetQueueTalisFirstValue()
        {
            if (!IsEmpty())
            {
                QueueNode<V> node = Tail;
                yield return node.Value;
                while (node.Prev != null)
                {
                    yield return node.Prev.Value;
                    node = node.Prev;
                }
            }
        }
        /// <summary>
        /// Return Root first queue
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetQueueRootFirst()
        {
            if (!IsEmpty())
            {
                QueueNode<V> node = Root;
                yield return node;
                while (node.Next != null)
                {
                    yield return node.Next;
                    node = node.Next;
                }
            }
        }
        /// <summary>
        /// Return Tail first queue
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetQueueTalisFirst()
        {
            if (!IsEmpty())
            {
                QueueNode<V> node = Tail;
                yield return node;
                while (node.Prev != null)
                {
                    yield return node.Prev;
                    node = node.Prev;
                }
            }
        }

        /*        private QueueNode<V> Partition(QueueNode<V> last, QueueNode<V> first)
                {
                    V pivot = first.Value;
                    QueueNode<V> i = last.Prev;
                    V temp;

                    for (QueueNode<V> j = last; j != first; j = j.Next)
                    {
                        if (j.Value.CompareTo(pivot) <= 0)
                        {
                            i = (i == null) ? last : i.Next;
                            temp = i.Value;
                            i.Value = j.Value;
                            j.Value = temp;
                        }
                    }
                    i = (i == null) ? last : i.Next;
                    temp = i.Value;
                    i.Value = first.Value;
                    first.Value = temp;
                    return i;
                }

                public void QuickSort(QueueNode<V> tail, QueueNode<V> root)
                {
                    if (root != null && tail != root && tail != root.Next)
                    {
                        QueueNode<V> temp = Partition(tail, root);
                        QuickSort(tail, temp.Prev);
                        QuickSort(temp.Next, root);
                    }
                }
                public void QuickSort()
                {
                    if (!IsEmpty())
                        QuickSort(Root, Tail);
                }*/

    }

    public class QueueNode<V> where V : IComparable
    {
        private QueueNode<V> _next;
        private QueueNode<V> _prev;
        private V _value;
        public QueueNode(V val) => Value = val;

        public V Value { get => _value; internal set => _value = value; }
        public QueueNode<V> Next { get => _next; internal set => _next = value; }
        public QueueNode<V> Prev { get => _prev; internal set => _prev = value; }

        public int CompareTo(V val) => Value.CompareTo(val);
        public override bool Equals(object obj)
        {
            if (obj is QueueNode<V> other)
                return Value.Equals(other.Value);
            return false;
        }
    }
}
