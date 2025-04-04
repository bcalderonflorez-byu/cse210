/* Author: Brian Calderon
   Aditional Code:
   1) Adding a Dictionary collection with a list of scriptures and make a random select
*/

using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        bool _continue = true;
         
        Dictionary<Reference, string>  Dictionary_Book; 
        Dictionary_Book = get_scriptures();        

        Random rand = new Random();        
        Reference Ref1 = Dictionary_Book.ElementAt(rand.Next(0, Dictionary_Book.Count)).Key;
        string _text = Dictionary_Book[Ref1];
        Scripture scripture = new Scripture(Ref1,Dictionary_Book[Ref1]);

        do{

            Console.Clear();
            string print_text = scripture.GetDisplayText();
            Console.WriteLine(print_text);

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string Choice_answer =  Console.ReadLine();

            if (Choice_answer == "quit"){
                _continue = false;
            } else{
                _continue = !scripture.IsCompletelyHidden();
                var random = new Random();
                int index = random.Next(_text.Split(' ').Count()); 
                scripture.HideRandomWords(index);
            }

        }while (_continue);
    }

    public static Dictionary<Reference, string> get_scriptures(){
        Dictionary<Reference, string> Dic_scriptures = new Dictionary<Reference, string>();

        Reference ref1 = new Reference("Moses",1,39);
        string text1 = "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.";        
        Dic_scriptures.Add(ref1, text1);

        Reference ref2 = new Reference("Proverbs",3,5,6);
        string text2 = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Dic_scriptures.Add(ref2, text2);

        Reference ref3 = new Reference("Abraham",3,22,23);
        string text3 = "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.";
        Dic_scriptures.Add(ref3, text3);

        Reference ref4 = new Reference("Isaiah",1,18);
        string text4 = "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.";
        Dic_scriptures.Add(ref4, text4);

        return Dic_scriptures;
    }
}