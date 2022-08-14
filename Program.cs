namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(70);
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();

        }
    }
}