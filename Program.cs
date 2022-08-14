namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            linked.InsertForSort(56);
            linked.InsertForSort(30);
            linked.InsertForSort(40);
            linked.InsertForSort(70);
            linked.ValueAre();
            linked.DisplayList();
            Console.ReadLine();

        }
    }
}