namespace lab03_FTP_client_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NIC card = NIC.Instance;

            Console.WriteLine(card.macAddress);
            Console.WriteLine(card.manficature);
            Console.WriteLine(card.type);
           NIC card2 = NIC.Instance;

            Console.WriteLine(card2.GetHashCode());
            Console.WriteLine(card.GetHashCode());
        }
    }
}
