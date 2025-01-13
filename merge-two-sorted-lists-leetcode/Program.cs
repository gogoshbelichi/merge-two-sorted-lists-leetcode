//Definition for singly-linked list.
public class ListNode { 
    public int val; 
    public ListNode next; 
    public ListNode(int val=0, ListNode next=null) { 
        this.val = val; 
        this.next = next;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        ListNode linkedlistone = new ListNode((0),
            new ListNode((1),
                new ListNode((2),
                    new ListNode((3),
                        new ListNode((6), 
                            new ListNode((7)))))));
        
        ListNode linkedlisttwo = new ListNode((0),
            new ListNode((2),
                new ListNode((4),
                    new ListNode((5),
                        new ListNode((6), 
                            new ListNode((8)))))));
        
        /*Console.WriteLine("LinkedList №1");
        while (linkedlistone != null)
        {
            Console.Write(linkedlistone.val + " ");
            linkedlistone = linkedlistone.next;
        }
        Console.WriteLine(" ");
        Console.WriteLine("LinkedList №2");
        while (linkedlisttwo != null)
        {
            Console.Write(linkedlisttwo.val + " ");
            linkedlisttwo = linkedlisttwo.next;
        }
        Console.WriteLine(" ");*/
        Console.WriteLine("LinkedList merged");
        ListNode merged = MergeTwoLists(linkedlistone, linkedlisttwo);
        while (merged != null)
        {
            Console.Write(merged.val + " ");
            merged = merged.next;
        }
    }
    
    static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if(list1 == null) return list2;
        if(list2 == null) return list1;

        if(list1.val < list2.val) {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }
}

