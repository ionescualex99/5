namespace _5

{
    class Program
    {
        //faire array
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;//joueur 1 par default
        static int choice; //choix
        static int flag = 0; //verifie qui a gagne, si valeur est 1 quelqun a gagne
                             //si 0 match continue
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//clear screen
                Console.WriteLine("Joueur1:X");
                Console.WriteLine("Joueur2:O");
                //Console.WriteLine("\n");
                Console.WriteLine();
                if (player % 2 == 0)//verifie tour joueur
                {
                    Console.WriteLine("Joueur2");
                    Console.WriteLine("Choisir Case:");
                }
                else
                {
                    Console.WriteLine("Joueur1");
                    Console.WriteLine("Choisir Case:");
                }
                //Console.WriteLine("\n");
                Console.WriteLine();
                Board();//appelle fonction board
                choice = int.Parse(Console.ReadLine());//prend tour joueur

                if (arr[choice] != 'X' && arr[choice] != 'O')
                //verifie si la position est marquee avec X ou 0
                {
                    if (player % 2 == 0) //si tour du joueur, alors mettre O, sinon X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }

                flag = CheckWin();//verifie si quelqun a gagne
            }
            while (flag != 1 && flag != -1);
            //ce loop roule jusque ce que toutes cases sont occupees
            //avec X ou O ou joueur n'a pas gagne

            Console.Clear();//clear console
            Board();//va chercher le board rempli
            if (flag == 1)
            // si valeur flag est 1 alors quelqun a gagne
            {
                Console.WriteLine("joueur {0} gagne", (player % 2) + 1);

            }

            static void Board()
                //methode qui cree le board
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     |     |      ");
            }
            //verifie si quelqun a gagne
            static int CheckWin()
            {
                //condition gagnante horizontale
                //condition gagnante premiere rangee
                if (arr[1] == arr[2] && arr[2] == arr[3])
                {
                    return 1;
                }
                //condition gagnante deuxieme rangee
                else if (arr[4] == arr[5] && arr[5] == arr[6])
                {
                    return 1;
                }
                //condition gagnante troisieme rangee
                else if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    return 1;
                }
                //Condition gagnante verticale
                //premiere colonne
                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return 1;
                }
                //condition gagnante deuxieme colonne
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return 1;
                }
                //condition gagnante troisieme colonne
                else if (arr[3] == arr[6] && arr[6] == arr[9])
                {
                    return 1;
                }
                //Condition gagnante diagonale
                else if (arr[1] == arr[5] && arr[5] == arr[9])
                {
                    return 1;
                }
                else if (arr[3] == arr[5] && arr[5] == arr[7])
                {
                    return 1;
                }
              
                else
                {
                    return 0;
                }
            }
        }
    }
}
    