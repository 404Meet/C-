// public class Node
// {
//     public int data;
//     public Node next;

//     public Node(int value)
//     {
//         data = value;
//         next = null;
//     }
// }

// public class SinglyLinkedList
// {
//     private Node head;

//     // Insert at the end
//     public void Insert(int value)
//     {
//         Node newNode = new Node(value);
//         if (head == null)
//         {
//             head = newNode;
//             return;
//         }

//         Node current = head;
//         while (current.next != null)
//         {
//             current = current.next;
//         }
//         current.next = newNode;
//     }

//     // Delete first occurrence
//     public void Delete(int value)
//     {
//         if (head == null) return;

//         if (head.data == value)
//         {
//             head = head.next;
//             return;
//         }

//         Node current = head;
//         while (current.next != null && current.next.data != value)
//         {
//             current = current.next;
//         }

//         if (current.next != null)
//         {
//             current.next = current.next.next;
//         }
//     }

//     // Print all elements
//     public void PrintList()
//     {
//         Node current = head;
//         while (current != null)
//         {
//             Console.Write(current.data + " -> ");
//             current = current.next;
//         }
//         Console.WriteLine("null");
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         SinglyLinkedList list = new SinglyLinkedList();

//         list.Insert(10);
//         list.Insert(20);
//         list.Insert(30);
//         list.PrintList(); // Output: 10 -> 20 -> 30 -> null
//         list.Delete(20);
//         list.PrintList(); // Output: 10 -> 30 -> null
//     }
// }