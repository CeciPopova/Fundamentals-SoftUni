using System;
using System.Collections.Generic;
using System.Linq;

namespace E1._03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string , Piece> piecesList = new Dictionary<string , Piece>();   

            for (int i = 0; i < numOfPieces; i++)
            {
                string[] piecesInfo =Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();    
                string piece = piecesInfo[0];
                string composer = piecesInfo[1];    
                string key =piecesInfo[2];
                piecesList.Add(piece, new Piece(piece, composer, key));

            }
            string command = Console.ReadLine();
            while (command!="Stop")
            {
                string[] commandArgs = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                if (action=="Add")
                {
                    string piece = commandArgs[1];
                    string composer = commandArgs[2];
                    string key = commandArgs[3];

                    if (piecesList.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        piecesList.Add(piece,new Piece(piece, composer, key));
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (action=="Remove")
                {
                    string piece = commandArgs[1];
                    if (piecesList.ContainsKey(piece))
                    {
                        piecesList.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");

                    }
                }
                else if (action=="ChangeKey")
                {
                    string piece = commandArgs[1];
                    string newKey = commandArgs[2];
                    if (piecesList.ContainsKey(piece))
                    {
                        piecesList[piece].Key = newKey; 

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in piecesList)
            {
                string composer = item.Value.Composer;
                string key = item.Value.Key;    

                Console.WriteLine($"{item.Key} -> Composer: {composer}, Key: {key}");
            }
        }
    }
    public class Piece
    {
        public Piece(string pieceName, string composer, string key)
        {
            this.PieceName = pieceName;
            this.Composer = composer;   
            this.Key = key; 

        }
        public string PieceName { get; set; }    
        public string Composer { get; set; } 
        public string Key { get; set; }
       

    }
}
