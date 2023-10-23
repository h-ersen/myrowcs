using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("MY ROW");


            Console.SetCursorPosition(12, 17);
            Console.WriteLine("PLEASE PUSH SPACEBAR BUTTON TO START MENU...");


            System.Threading.Thread.Sleep(750);



            ConsoleKey button;

            do
            {

                button = Console.ReadKey(true).Key;

                if (button != ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(12, 19);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PLEASE PUSH A VALİD BUTTON TO START MENU");
                }

            } while (button != ConsoleKey.Spacebar);

            Console.SetCursorPosition(12, 21);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please wait...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            int option;

            do
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                     @@@@@@@@@@  @@@@@@@@ @@@  @@@ @@@  @@@");
                Console.WriteLine("                     @@! @@! @@! @@!      @@!@!@@@ @@!  @@@");
                Console.WriteLine("                     @!! !!@ @!@ @!!!:!   @!@@!!@! @!@  !@!");
                Console.WriteLine("                     !!:     !!: !!:      !!:  !!! !!:  !!!");
                Console.WriteLine("                       :      :   : :: ::: ::    :   :.:: : ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                ╔╔═══════════════════════════════════════════╗╗");
                Console.WriteLine("                ║║           1 - NEW GAME                    ║║");
                Console.WriteLine("                ║║                                           ║║");
                Console.WriteLine("                ║║           2 - EXIT                        ║║");
                Console.WriteLine("                ║║                                           ║║");
                Console.WriteLine("                ╚╚═══════════════════════════════════════════╝╝");
                Console.WriteLine("                 ");
                Console.WriteLine("                 ");
                Console.Write("                    Your option:");
                option = Convert.ToInt16(Console.ReadLine());


                switch (option)
                {
                    case 1:

                        int level;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("                    @@@@@@@@@@  @@@@@@@@ @@@  @@@ @@@  @@@");
                            Console.WriteLine("                    @@! @@! @@! @@!      @@!@!@@@ @@!  @@@");
                            Console.WriteLine("                    @!! !!@ @!@ @!!!:!   @!@@!!@! @!@  !@!");
                            Console.WriteLine("                    !!:     !!: !!:      !!:  !!! !!:  !!!");
                            Console.WriteLine("                      :      :   : :: ::: ::    :   :.:: : ");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("                ╔╔═══════════════════════════════════════════╗╗");
                            Console.WriteLine("                ║║               1- EASY                     ║║");
                            Console.WriteLine("                ║║               2- NORMAL                   ║║");
                            Console.WriteLine("                ║║               3- LEGENDARY                ║║");
                            Console.WriteLine("                ║║               4- EXİT                     ║║");
                            Console.WriteLine("                ╚╚═══════════════════════════════════════════╝╝");
                            Console.WriteLine("                 ");
                            Console.WriteLine("                 ");
                            Console.Write("                    Your option:");
                            level = Convert.ToInt16(Console.ReadLine());
                            if (level == 4)
                            {

                                Console.ForegroundColor = ConsoleColor.Gray;
                                
                                Console.Clear();
                                Console.WriteLine("Quit");                                
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                                Environment.Exit(0);
                            }

                            int index = 0;
                            int c = -11;
                            int player = 0;
                            int computer = 0;

                            bool flag = true;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("      1    2    3    4    5    6    7    8  ");
                            Console.WriteLine("   ╔════╦════╦════╦════╦════╦════╦════╦════╗");
                            Console.WriteLine("1  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╠════╬════╬════╬════╬════╬════╬════╬════╣");
                            Console.WriteLine("2  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╠════╬════╬════╬════╬════╬════╬════╬════╣");
                            Console.WriteLine("3  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╠════╬════╬════╬════╬════╬════╬════╬════╣");
                            Console.WriteLine("4  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╠════╬════╬════╬════╬════╬════╬════╬════╣");
                            Console.WriteLine("5  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╠════╬════╬════╬════╬════╬════╬════╬════╣");
                            Console.WriteLine("6  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╠════╬════╬════╬════╬════╬════╬════╬════╣");
                            Console.WriteLine("7  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╠════╬════╬════╬════╬════╬════╬════╬════╣");
                            Console.WriteLine("8  ║    ║    ║    ║    ║    ║    ║    ║    ║");
                            Console.WriteLine("   ╚════╩════╩════╩════╩════╩════╩════╩════╝ ");



                            Random rnd = new Random();
                            int number;

                            int[,] matris = new int[8, 8];
                            for (int i = 0; i < 8; i++)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    number = rnd.Next(-9, 10);
                                    matris[i, j] = number;
                                    while (number == 0)
                                    {
                                        number = rnd.Next(-9, 10);
                                        matris[i, j] = number;

                                    }
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.SetCursorPosition(5 + (j * 5), 2 + (i * 2));
                                    Console.Write("{0,2}", matris[i, j]);


                                }
                                Console.WriteLine();
                            }




                            int x, y;
                            x = rnd.Next(0, 8);
                            y = rnd.Next(0, 8);

                            Console.ForegroundColor = ConsoleColor.DarkGray;

                            matris[x, y] = -11;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                            Console.Write("{0,2}", "▒");



                            string userinput;


                            while (flag)
                            {

                                do
                                {
                                    Console.SetCursorPosition(47, 2);//player
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("ENTER COLUMN:");
                                    userinput = Console.ReadLine();
                                    if (userinput.Length == 1)
                                    {

                                        try
                                        {
                                            c = Convert.ToInt16(userinput);
                                        }
                                        catch (Exception)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.SetCursorPosition(47, 8);
                                            Console.Write("PLEASE ENTER NUMBER FROM 1 TO 8!");
                                        }




                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(47, 8);
                                        Console.Write("PLEASE ENTER NUMBER FROM 1 TO 8!");

                                    }


                                    Console.SetCursorPosition(60, 2);//refreshing the input on screen
                                    Console.Write("                ");
                                    Console.SetCursorPosition(60, 2);

                                    if (c == 9 || c == 0)
                                    {
                                        Console.SetCursorPosition(47, 8);
                                        Console.Write("PLEASE ENTER NUMBER FROM 1 TO 8!");
                                    }
                                    Console.ForegroundColor = ConsoleColor.Red;

                                } while (c < 1 || c > 8 || matris[x, c - 1] == -11);



                                Console.SetCursorPosition(47, 8);
                                Console.Write("                                ");


                                Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                Console.Write("{0,2}", " ");

                                y = c - 1;
                                player = matris[x, y] + player;
                                matris[x, y] = -11;
                                Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                Console.Write("{0,2}", "▒");
                                System.Threading.Thread.Sleep(500);


                                Console.SetCursorPosition(47, 3);
                                Console.Write("               ");
                                Console.SetCursorPosition(47, 3);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("Player: " + player);



                                Console.SetCursorPosition(47, 6);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Wait for computer move...");
                                System.Threading.Thread.Sleep(900);
                                Console.SetCursorPosition(47, 6);
                                Console.Write("                         ");

                                int count1 = 0;
                                
                                for (int b = 0; b < 8; b++)
                                {

                                    if (matris[b, y] == -11)
                                    {
                                        count1++;
                                    }
                                }
                                if (count1 == 8 && player < computer)
                                {
                                    System.Threading.Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();                                    
                                    Console.SetCursorPosition(12, 21);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please wait...");
                                    System.Threading.Thread.Sleep(700);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("You lose!");                     
                                    System.Threading.Thread.Sleep(1500);
                                    Console.Clear();
                                    flag = false;

                                    
                                    break;
                                }

                                if (count1 == 8 && player > computer)
                                {
                                    System.Threading.Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.SetCursorPosition(12, 21);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please wait...");
                                    System.Threading.Thread.Sleep(700);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("You win!");                     
                                    System.Threading.Thread.Sleep(1500);
                                    Console.Clear();
                                    flag = false;
                                    
                                    break;
                                }
                                if (level == 1)
                                {
                                    Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                    Console.Write("{0,2}", " ");

                                    int max;//PC
                                    max = rnd.Next(0, 8);
                                    x = max;

                                    while (matris[x,y]==-11)
                                    {
                                         max = rnd.Next(0, 8);
                                         x = max;
                                    }

                                   

                                    computer = matris[x, y] + computer;

                                    matris[x, y] = -11;
                                    Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                    Console.Write("{0,2}", "▒");

                                    Console.SetCursorPosition(47, 4);
                                    Console.Write("               ");
                                    Console.SetCursorPosition(47, 4);
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("Computer: " + computer);
                                    int count2 = 0;

                                    for (int n = 0; n < 8; n++)
                                    {
                                        if (matris[x, n] == -11)
                                        {
                                            count2++;
                                        }
                                    }


                                    if (count2 == 8 && player < computer)
                                    {

                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.SetCursorPosition(12, 21);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please wait...");
                                        System.Threading.Thread.Sleep(700);                                        
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(20, 10);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(20, 10);
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("You lose!");                     
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;
                                        
                                        break;
                                    }

                                    if (count2 == 8 && player > computer)
                                    {
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.SetCursorPosition(12, 21);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please wait...");
                                        System.Threading.Thread.Sleep(700);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");                                        
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("You win!");                     
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;
                                        
                                        break;
                                    }

                                    if (count2 == 8 && player == computer)
                                    {
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.SetCursorPosition(12, 21);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please wait...");
                                        System.Threading.Thread.Sleep(700);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("Tie up!");                     
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;
                                        
                                        break;

                                    }
                                }

                                if (level == 2)
                                {

                                    int max;
                                    max = -10;

                                    for (int k = 0; k < 8; k++)
                                    {


                                        if (matris[k, y] > max)
                                        {
                                            index = k;
                                            max = matris[k, y];
                                        }

                                    }



                                    Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                    Console.Write("{0,2}", " ");

                                    x = index;
                                    computer = matris[x, y] + computer;

                                    matris[x, y] = -11;
                                    Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                    Console.Write("{0,2}", "▒");

                                    Console.SetCursorPosition(47, 4);
                                    Console.Write("               ");
                                    Console.SetCursorPosition(47, 4);
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("Computer: " + computer);

                                    int count2 = 0;

                                    for (int n = 0; n < 8; n++)
                                    {
                                        if (matris[x, n] == -11)
                                        {
                                            count2++;
                                        }
                                    }


                                    if (count2 == 8 && player < computer)
                                    {
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.SetCursorPosition(12, 21);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please wait...");
                                        System.Threading.Thread.Sleep(700);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("You lose!");                     
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;
                                        
                                        break;
                                    }

                                    if (count2 == 8 && player > computer)
                                    {
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.SetCursorPosition(12, 21);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please wait...");
                                        System.Threading.Thread.Sleep(700);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine("");                                        
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("You win!");                     
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;

                                        flag = false;
                                        
                                        break;
                                    }

                                    if (count2 == 8 && player == computer)
                                    {
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("Tie up!");                     
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;


                                        flag = false;
                                        
                                        break;
                                        
                                    }
                                }

                                if (level == 3)
                                {
                                    int max;
                                    int fark = -20;
                                    int temp1 = 0;

                                    for (int k = 0; k < 8; k++)
                                    {
                                        int temp2 = matris[k, y];
                                        max = -10;

                                        for (int a = 0; a < 8; a++)
                                        {
                                            if (a != y && max < matris[k, a] && matris[k, y] != -11 && matris[k, a] != -11)
                                            {
                                                max = matris[k, a];

                                            }
                                        }

                                        if (fark < matris[k, y] - max && matris[k, y] != -11)
                                        {

                                            fark = matris[k, y] - max;

                                            temp1 = k;
                                        }
                                    }




                                    Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                    Console.Write("{0,2}", " ");

                                    x = temp1;
                                    computer = matris[x, y] + computer;

                                    matris[x, y] = -11;
                                    Console.SetCursorPosition(5 + (y * 5), 2 + (x * 2));
                                    Console.Write("{0,2}", "▒");
                                    Console.SetCursorPosition(60, 4);
                                    Console.Write("   ");
                                    Console.SetCursorPosition(47, 4);
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.Write("Computer: " + computer);
                                    Console.SetCursorPosition(50, 6);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR TURN...");

                                    int count2 = 0;

                                    for (int n = 0; n < 8; n++)
                                    {
                                        if (matris[x, n] == -11)
                                        {
                                            count2++;
                                        }
                                    }


                                    if (count2 == 8 && player < computer)
                                    {
                                        System.Threading.Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.SetCursorPosition(12, 21);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please wait...");
                                        System.Threading.Thread.Sleep(700);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(20, 10);
                                        Console.Clear();
                                        Console.WriteLine("You lose!");                     
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;
                                        
                                        break;

                                    }

                                    if (count2 == 8 && player > computer)
                                    {
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        Console.WriteLine("You win!");                                        
                                        Console.ForegroundColor = ConsoleColor.Red;                                        
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        flag = false;
                                        
                                        break;
                                    }

                                    if (count2 == 8 && player == computer)
                                    {
                                        
                                        Console.Clear();
                                        Console.WriteLine("Tie up!");  
                                        flag = false;
                                        
                                        break;

                                       }


                                  }
                            }








                        } while (level != 4);



                        break;




                }

            } while (option != 2);







            Console.ForegroundColor = ConsoleColor.Gray;
            
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Good bye!");
            
            Console.Clear();
        }
    }
}
