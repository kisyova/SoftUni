using System;

class Deck52Cards
{
    static void Main()
    {


        char[] colors = { '♠', '♣', '♦', '♥' };
        char? currentChar = null;

        for (int card = 2; card <= 15; card++)
        {
            for (int sign = 0; sign < 4; sign++)
            {
                currentChar = colors[sign];
                switch (card)
                {
                    case 11:
                        break;
                    case 12:
                        Console.Write("J{0} ", currentChar);
                        break;
                    case 13:
                        Console.Write("D{0} ", currentChar);
                        break;
                    case 14:
                        Console.Write("K{0} ", currentChar);
                        break;
                    case 15:
                        Console.Write("A{0} ", currentChar);
                        break;
                    default:
                        Console.Write("{0}{1} ", card, currentChar);
                        break;
                }

            }
            if (card != 11)
            {
                Console.WriteLine();
            }
        }
    }
}
    

