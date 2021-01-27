using System;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l = new ListNode();

            ListNode l3 = new ListNode {

                val = { 5, 6, 4 }

            };

            ListNode l4 = new ListNode { 5, 6, 4};

            AddTwoNumbers(l3,l4);


        }

        
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                }
          }



        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {






            return 0 ;
        }



    }
}
