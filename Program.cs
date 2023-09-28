using System;

namespace Arrays
{
  public class Project
  {
    public static string[] cards;
    static void Main()
    {
      First();
      Second();
      Third();
    }

    static void WriteCards()
    {
      foreach (string card in cards)
      {
        Console.WriteLine(card);
      }
    }

    static void First()
    {
      string[] colors = {"Kör", "Káró", "Treff", "Pik"};
      string[] number = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jumbó", "Dáma", "Király", "Ász"};
      cards = new string[52];
      int genId = 0;

      for (int i = 0; i < colors.Length; i++)
      {
        for (int j = 0; j < number.Length; j++)
        {
          cards[genId] = colors[i] + " " + number[j];
          genId++;
        }
      }
      
      WriteCards();
    }

    static void Second()
    {
      Random rnd = new Random();
      for (int i = 0; i < cards.Length; i++)
      {
        int j = rnd.Next(i, cards.Length);
        string tmp = cards[i];
        cards[i] = cards[j];
        cards[j] = tmp;
      }
      WriteCards();
    }

    static void Third()
    {
      int pcs = int.Parse(Console.ReadLine());
      string[] words = new string[pcs];
      for (int i = 0; i < pcs; i++)
      {
        words[i] = Console.ReadLine();
      }
      string find = Console.ReadLine();
      
      int j = 0;
      bool contains = false;

      while (j < words.Length && !contains)
      {
        if (find == words[j])
        {
          contains = true;
        }
        j++;
      }
      if (contains)
      {
        Console.WriteLine("Contains it at index " + j);
      }
      else
      {
        Console.WriteLine("Doesn't contains it");
      }

    }
  }
}
