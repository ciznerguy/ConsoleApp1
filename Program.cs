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


        static void Main(string[] args)
        {
            {
                int[] arr1 = { 0, 8, 2, -999, 10, 5, -999, 15 }; // מערך חביב (דוגמה חיובית)
                int[] arr2 = { 0, 8, 3, -999, 11, 5, -999, 16 }; // מערך שאינו חביב (סכום לא תואם)
                int[] arr3 = { 1, 2, 3, -999, 6 }; // מערך לא תקין (התחלה לא ב-0)
                int[] arr4 = { 0, 10, 5, -999, 15 }; // מערך לא תקין (אין מספיק איברים)

                // קריאת הפונקציה על כל מערך
                Console.WriteLine("Is arr1 nice? " + IsNice(arr1)); // אמור להחזיר true
                Console.WriteLine("Is arr2 nice? " + IsNice(arr2)); // אמור להחזיר false
                Console.WriteLine("Is arr3 nice? " + IsNice(arr3)); // אמור להחזיר false
                Console.WriteLine("Is arr4 nice? " + IsNice(arr4)); // אמור להחזיר false
            }

        }

    }
}
