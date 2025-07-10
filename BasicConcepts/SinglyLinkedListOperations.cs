// using System;

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

//     public void InsertAtHead(int value)
//     {
//         Node newNode = new Node(value);
//         newNode.next = head;
//         head = newNode;
//     }

//     public void InsertAtTail(int value)
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

//     public void InsertAtPosition(int position, int value)
//     {
//         Node newNode = new Node(value);

//         if (position == 0)
//         {
//             newNode.next = head;
//             head = newNode;
//             return;
//         }

//         Node current = head;
//         for (int i = 0; i < position - 1 && current != null; i++)
//         {
//             current = current.next;
//         }

//         if (current == null)
//         {
//             Console.WriteLine("Position out of range.");
//             return;
//         }

//         newNode.next = current.next;
//         current.next = newNode;
//     }

//     public void DeleteHead()
//     {
//         if (head != null)
//         {
//             head = head.next;
//         }
//         else
//         {
//             Console.WriteLine("List is empty.");
//         }
//     }

//     public void DeleteByValue(int value)
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
//         else
//         {
//             Console.WriteLine("Value not found.");
//         }
//     }

//     public void DeleteAtPosition(int position)
//     {
//         if (head == null)
//         {
//             Console.WriteLine("List is empty.");
//             return;
//         }

//         if (position == 0)
//         {
//             head = head.next;
//             return;
//         }

//         Node current = head;
//         for (int i = 0; i < position - 1 && current.next != null; i++)
//         {
//             current = current.next;
//         }

//         if (current.next != null)
//         {
//             current.next = current.next.next;
//         }
//         else
//         {
//             Console.WriteLine("Position out of range.");
//         }
//     }

//     public void PrintList()
//     {
//         if (head == null)
//         {
//             Console.WriteLine("List is empty.");
//             return;
//         }

//         Node current = head;
//         while (current != null)
//         {
//             Console.Write(current.data + " -> ");
//             current = current.next;
//         }
//         Console.WriteLine("null");
//     }
// }

// public class SinglyLinkedListOperations
// {
//     public static void Main()
//     {
//         SinglyLinkedList list = new SinglyLinkedList();
//         int choice, value, position;

//         do
//         {
//             Console.WriteLine("\nMenu:");
//             Console.WriteLine("1. Insert at Head");
//             Console.WriteLine("2. Insert at Tail");
//             Console.WriteLine("3. Insert at Position");
//             Console.WriteLine("4. Delete Head");
//             Console.WriteLine("5. Delete at Position");
//             Console.WriteLine("6. Delete by Value");
//             Console.WriteLine("7. Print List");
//             Console.WriteLine("8. Exit");
//             Console.Write("Enter your choice: ");
//             choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Enter value to insert at head: ");
//                     value = Convert.ToInt32(Console.ReadLine());
//                     list.InsertAtHead(value);
//                     break;

//                 case 2:
//                     Console.Write("Enter value to insert at tail: ");
//                     value = Convert.ToInt32(Console.ReadLine());
//                     list.InsertAtTail(value);
//                     break;

//                 case 3:
//                     Console.Write("Enter position to insert at: ");
//                     position = Convert.ToInt32(Console.ReadLine());
//                     Console.Write("Enter value: ");
//                     value = Convert.ToInt32(Console.ReadLine());
//                     list.InsertAtPosition(position, value);
//                     break;

//                 case 4:
//                     list.DeleteHead();
//                     break;

//                 case 5:
//                     Console.Write("Enter position to delete: ");
//                     position = Convert.ToInt32(Console.ReadLine());
//                     list.DeleteAtPosition(position);
//                     break;

//                 case 6:
//                     Console.Write("Enter value to delete: ");
//                     value = Convert.ToInt32(Console.ReadLine());
//                     list.DeleteByValue(value);
//                     break;

//                 case 7:
//                     list.PrintList();
//                     break;

//                 case 8:
//                     Console.WriteLine("Exiting...");
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     break;
//             }

//         } while (choice != 8);
//     }
// }
