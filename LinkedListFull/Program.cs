using System;
using System.Collections.Generic;

namespace LinkedListFull
{
    class Node_S
    {
        public Node_S Next; // Đây là một con trỏ next.
        public int Info;
    }

    class Node_D
    {
        public Node_D Lptr;
        public Node_D Rptr;
        public int Info;
    }

    class Program
    {
        public static Node_S SL = null; // Initial, SL (Single Link) quản lý danh sách liên kết đơn
        public static Node_D LL = null; // Initial, LL (Left List) quản lý danh sách liên kết kép
        public static Node_D RL = null; // Initial, RL (Right List) quản lý danh sách liên kết kép

        /// Danh sách liên kết đơn
        public static int Length_S()
        {
            Node_S Sp = SL;
            int i = 0;
            while (Sp != null)
            {
                i++;
                Sp = Sp.Next;
            }
            return i;
        }

        // Bổ sung 1 nút vào đầu dslk đơn được trỏ bởi SL
        public static void AddFirst_S(int x)
        {
            Node_S Sp = new Node_S(); // Tạo một nút (không có tên) có cấu trúc Node_S được trỏ bởi Sp
            // (Nghĩa là: Địa chỉ của node vừa tạo nằm trong con trỏ Sp)
            // Địa chỉ của node là một số nguyên.
            // Sp là con trỏ, con trỏ là một biến đặc biệt, chứa địa chỉ của biến.
            // Một biến bất kỳ đều cần phải có địa chỉ.
            // Máy tính truy cập theo địa chỉ.
            // Để truy cập một biến hoặc dùng tên biến hoặc dùng địa chỉ của biến
            // Địa chỉ của biến chỉ có thể nằm trong con trỏ.

            Sp.Info = x; // Truy cập (gán = x) vào trường Info của nút vừa tạo bằng con trỏ Sp
            Sp.Next = SL;
            SL = Sp;
        }

        public static void AddLast_S(int x)
        {
            Node_S Sp = new Node_S();
            Sp.Next = null;
            Sp.Info = x;
            if (SL == null)
            {
                SL = Sp;
            }
            else // Tìm phần tử cuối
            {
                Node_S Sq = SL; // Tạo một con trỏ trung gian để duyệt danh sách SL.
                while (Sq.Next != null)
                {
                    Sq = Sq.Next;
                }
                // Sq sẽ trỏ vào phần tử cuối danh sách.
                Sq.Next = Sp;
            }
        }

        public static void Add_k_S(int x, int k)
        {
            Node_S Sp = new Node_S();
            Sp.Info = x;
            int i = 1;
            int l = Length_S();
            if (k < 1 || k > l + 1)
            {
                Console.WriteLine("Vi tri chen khong hop le");
            }
            else
            {
                if (k == 1)
                {
                    AddFirst_S(x);
                }
                else
                {
                    Node_S Sq = SL;
                    while (Sq.Next != null && i != k - 1)
                    {
                        i++;
                        Sq = Sq.Next;
                    }
                    Sp.Next = Sq.Next;
                    Sq.Next = Sp;
                }
            }
        }

        public static void DeleteFirst_S()
        {
            if (SL != null)
            {
                SL = SL.Next;
            }
        }

        public static void DeleteLast_S()
        {
            if (SL == null)
            {
                SL = SL.Next;
            }
            else if (SL.Next == null)
            {
                SL = null;
            }
            else
            {
                Node_S Sq = SL;
                while (Sq.Next.Next != null)
                {
                    Sq = Sq.Next;
                } // Sq trỏ vào áp chót
                Sq.Next = null;
            }
        }

        public static void Traverse_S()
        {
            Node_S Sq = SL;
            while (Sq != null)
            {
                Console.WriteLine("Info: {0}", Sq.Info);
                Sq = Sq.Next;
            }
        }

        public static int Search_S(int x)
        {
            Node_S Sq = SL;
            int pos = 1;
            while (Sq != null && Sq.Info != x)
            {
                Sq = Sq.Next;
                pos++;
            }
            if (Sq != null)
                return pos;
            else
                return 0;
        }

        public static Node_S Search(int x)
        {
            Node_S Sq = SL;
            while (Sq != null && Sq.Info != x)
            {
                Sq = Sq.Next;
            }
            if (Sq != null) return Sq;
            else return null;
        }

        public static void Delete_k_S(int k)
        {
            Node_S Sq = SL;
            int i = 1;
            if (k < 1 || k > Length_S())
            {
                Console.WriteLine("Vi tri xoa khong hop le");
            }
            else
            {
                if (k == 1)
                {
                    DeleteFirst_S();
                }
                else
                {
                    while (Sq != null && i != k - 1)
                    {
                        Sq = Sq.Next;
                        i++;
                    }
                    Sq.Next = Sq.Next.Next;
                }
            }
        }

        public static void Delete_x_S(int x)
        {
            while (Search_S(x) > 0)
            {
                Delete_k_S(Search_S(x));
            }
        }

        /// Danh sách liên kết kép
        public static int Length_D()
        {
            Node_D DL = LL; // Tạo con trỏ DL duyệt danh sách từ phía tay trái
            Node_D DR = RL; // Tạo con trỏ DR duyệt danh sách từ phía tay phải
            int i = 0;
            if (DL != null) i = 1;
            while (DL != null)
            {
                if (DL == DR) break;
                DL = DL.Rptr;
                i++;
                if (DR == DL) break;
                DR = DR.Lptr;
                i++;
            }
            return i;
        }

        public static void AddFirst_D(int x)
        {
            Node_D Dp = new Node_D();
            Dp.Info = x;
            if (LL == null)
            {
                LL = Dp;
                RL = Dp;
            }
            else
            {
                Dp.Rptr = LL;
                //LL.Lptr = Dp;
                LL = Dp;
                Dp.Lptr = null;
            }
        }

        public static void AddLast_D(int x)
        {
            Node_D Dp = new Node_D();
            Dp.Info = x;
            if (RL == null)
            {
                LL = Dp;
                RL = Dp;
            }
            else
            {
                RL.Rptr = Dp;
                Dp.Lptr = RL;
                RL = Dp;
            }
        }

        public static void Add_k_D(int x, int k)
        {
            Node_D DL = LL;
            Node_D DR;
            Node_D Dp = new Node_D();
            Dp.Info = x;
            int i = 1, l = Length_D();
            if (k < 1 || k > l + 1)
            {
                Console.WriteLine("Vi tri chen khong hop le");
            }
            else
            {
                if (k == 1)
                {
                    AddFirst_D(x);
                }
                else if (k == l)
                {
                    AddLast_D(x);
                }
                else
                {
                    while (DL != null && i != k - 1)
                    {
                        i++;
                        DL = DL.Rptr;
                    }
                    DR = DL.Rptr;
                    Dp.Rptr = DR;
                    Dp.Lptr = DL;
                    DL.Rptr = Dp;
                    DR.Lptr = Dp;
                }
            }

        }

        public static void DeleteFirst_D()
        {
            if (LL != null)
            {
                LL = LL.Rptr;
            }
        }

        public static void DeleteLast_D()
        {
            if (RL != null)
            {
                RL = RL.Lptr;
                RL.Rptr = null;
            }
        }

        public static void Traverse_D()
        {
            Node_D Dq = LL;
            while (Dq != RL.Rptr)
            {
                Console.WriteLine("Info: {0}", Dq.Info);
                Dq = Dq.Rptr;
            }
        }

        public static int Search_D(int x)
        {
            Node_D Dq = LL;
            int pos = 1;
            while (Dq != null && Dq.Info != x)
            {
                Dq = Dq.Rptr;
                pos++;
            }
            if (Dq != null)
                return pos;
            else
                return 0;
        }

        public static void Delete_k_D(int k)
        {
            Node_D DL = LL;
            Node_D DR;
            int i = 1, l = Length_D();
            if (k < 1 || k > l)
            {
                Console.WriteLine("Vi tri xoa khong hop le");
            }
            else
            {
                if (k == 1)
                {
                    DeleteFirst_D();
                }
                else
                {
                    if (k == l)
                    {
                        DeleteLast_D();
                    }
                    else
                    {
                        while (DL != null && i != k - 1)
                        {
                            i++;
                            DL = DL.Rptr;
                        }
                        DR = DL.Rptr.Rptr;
                        DL.Rptr = DR;
                        DR.Lptr = DL;
                    }
                }
            }
        }

        public static void Delete_x_D(int x)
        {
            while (Search_D(x) > 0)
            {
                Delete_k_D(Search_D(x));
            }
        }

        public static void Main()
        {
            //Mới Test với DSLK kép
            for (int i = 1; i < 5; i++)
            {
                AddFirst_D(i);
            }
            for (int i = 4; i < 8; i++)
            {
                AddLast_D(i);
            }
            Traverse_D();
        }
    }
}
