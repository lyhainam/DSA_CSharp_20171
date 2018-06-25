using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BST
    {
        public int Info;
        public BST Lptr;
        public BST Rptr;

        public BST(int x)
        {
            this.Info = x;
            this.Lptr = this.Rptr = null;
        }
    }

    class Program
    {
        static BST T;

        static BST Find(int x)
        {
            if (T.Info == x) return null;
            else
            {
                BST c = T;
                BST i = T;
                while (i != null)
                {
                    if (i.Info > x)
                    {
                        c = i;
                        i = i.Lptr;
                    }
                    else if (i.Info < x)
                    {
                        c = i;
                        i = i.Rptr;
                    }
                    else return c;
                }
            }
            return null;
        }

        static void Insert(int x)
        {
            BST p = new BST(x);
            if (T == null)
            {
                T = p;
            }
            else
            {
                BST c = T;
                BST i = T;
                while (i != null)
                {
                    if (i.Info > x)
                    {
                        c = i;
                        i = i.Lptr;
                    }
                    else if (i.Info < x)
                    {
                        c = i;
                        i = i.Rptr;
                    }
                    else return;
                }

                if (c.Info > p.Info)
                    c.Lptr = p;
                else
                    c.Rptr = p;
            }
        }

        static void Traverse(BST node)
        {
            if (node != null)
            {
                Console.Write(node.Info + " ");
                Traverse(node.Rptr);
                Traverse(node.Lptr);
            }
        }

        static BST Search(int x)
        {
            if (T != null)
            {
                BST i = T;
                while (i != null)
                {
                    if (i.Info > x)
                    {
                        i = i.Lptr;
                    }
                    else if (i.Info < x)
                    {
                        i = i.Rptr;
                    }
                    else return i;
                }
            }
            return null;
        }

        static void Delete(BST Node)
        {
            int _node = Node.Info;
            if ((Node.Lptr == null) && (Node.Rptr == null))
            {
                BST Parent = Find(_node);
                if (Parent.Info > Node.Info)
                    Parent.Lptr = null;
                else
                    Parent.Rptr = null;
            }
            else if (Node.Lptr == null)
            {
                BST Parent = Find(_node);
                if (Parent.Info > Node.Info)
                    Parent.Lptr = Node.Rptr;
                else
                    Parent.Rptr = Node.Rptr;
            }
            else if (Node.Rptr == null)
            {
                BST Parent = Find(_node);
                if (Parent.Info > Node.Info)
                    Parent.Lptr = Node.Lptr;
                else
                    Parent.Rptr = Node.Lptr;
            }
            else
            {
                BST f = Node.Lptr;
                while (f.Rptr != null)
                {
                    f = f.Rptr;
                }
                BST Parent = Find(f.Info);
                Node.Info = f.Info;
                Parent.Rptr = f.Lptr;
            }
        }

        static void Main(string[] args)
        {
            Insert(40);
            Insert(5);
            Insert(35);
            Insert(45);
            Insert(15);
            Insert(56);
            Insert(48);
            Insert(13);
            Insert(16);
            Insert(49);
            Insert(47);
            Traverse(T);
            Console.WriteLine();

            //Tìm và xóa một node
            BST a = Search(40);
            Delete(a);
            Traverse(T);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
