namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Card c = new Card(1, 1);
            //Card c1 = new Card(2, 2);
            //Card c3= new Card(3, 3);    
            //Card c4= new Card(4, 4);
            //Console.WriteLine(c);
            //Console.WriteLine(c1);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Deck deck = new Deck();
            //Console.WriteLine(deck);
            Player player = new Player("noam");
            Deck deck = new Deck();
            deck.Shuffle();
            player.Take(deck.Deal());
            player.Take(deck.Deal());
            int total = 0;
            for (int i = 0; i < 5; i++)
            {

            }
        }
    }
}