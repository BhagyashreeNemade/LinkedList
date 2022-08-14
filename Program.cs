namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            linked.InsertAtLast(56);
            linked.InsertAtLast(30);
            linked.InsertAtLast(40);
            linked.InsertAtLast(70);
            linked.DisplayList();
            linked.DeleteAtSpecifiedPosition(40);
            Console.WriteLine("The length of Linkedlist is " + linked.LinkedlistCount());
            linked.DisplayList();

        }
    }
}