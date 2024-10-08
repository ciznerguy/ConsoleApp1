using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        

        public static int SumOfList(Node<int> n)
        {
            int sum = 0;
           
            while (n !=null)
            {
                sum+= n.GetValue();
            }
            return sum;
        }

        public static bool IsNice(int[] arr)
        {
            int sum = 0;

            if (arr[0] != 0 || arr[arr.Length - 2] != -999)
            {
                return false;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                while (arr[i] != -999)
                {
                    sum += arr[i];
                    i++;
                }

                if (sum == arr[i + 1])
                {
                    sum = 0;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static Node<int> InsertAtPosition(Node<int> lst, int position, int value)
        {
            Node<int> head = lst;
            int index = 1;

            if (position == 1)
                return new Node<int>(value, lst);

            while(lst != null)
            {
                if (position - 1 == index)
                {
                    lst.SetNext(new Node<int>(value, lst.GetNext()));
                    return head;
                }
                lst = lst.GetNext();
                index++;
            }
            //אני מניח שאם לא הכנסתי חוליה אני מחזיר
            //נאל בשביל שתהיה אינדיקציה למתכנת שלא הצלחנו להכניס
            return null;
        }

        static void Main(string[] args)
        {
            {
                Node<int> lstOnMain = new Node<int>(3, new Node<int>(7, new Node<int>(17)));
                Node<int> headOnMain = InsertAtPosition(lstOnMain, 1, 5);
                Console.WriteLine(lstOnMain);
                Console.WriteLine(headOnMain);
            }

        }

    }
}
