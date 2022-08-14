namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(56);
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

        }
    }
}