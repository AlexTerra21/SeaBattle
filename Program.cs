using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    class Program
    {
        static bool[,] BattleField = new bool[10,10];
        static Random rnd = new Random();

        static void Main(string[] args)
        {
           // FillBattleField();
            PrintBattleFild();

            

            Console.ReadLine();
        }

        static void FillBattleField()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    BattleField[i, j] = rnd.Next(2)==0?false:true;
                }
        }

        static void PrintBattleFild()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(BattleField[i, j]?"*":"_");
                }
                Console.WriteLine();
            }
        }
    }
}
