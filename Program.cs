namespace _5

{
    class Program
    {
        //faire array
        static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;//joueur 1 par default
        static int choix; //choix
        static int gagnant = 0; //verifie qui a gagne, si valeur est 1 quelqun a gagne
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
                choix = int.Parse(Console.ReadLine());//prend tour joueur

                if (board[choix] != 'X' && board[choix] != 'O')
                //verifie si la position est marquee avec X ou 0
                {
                    if (player % 2 == 0) //si tour du joueur, alors mettre O, sinon X
                    {
                        board[choix] = 'O';
                        player++;
                    }
                    else
                    {
                        board[choix] = 'X';
                        player++;
                    }
                }

                gagnant = Verifier();//verifie si quelqun a gagne
            }
            while (gagnant != 1);
            //ce loop roule jusque ce que toutes cases sont occupees
            //avec X ou O ou joueur n'a pas gagne

            Console.Clear();//clear console
            Board();//va chercher le board rempli
            if (gagnant == 1)
            // si valeur drapeau est 1 alors quelqun a gagne
            {
                Console.WriteLine();
                Console.WriteLine("joueur {0} a gagné!!", (player % 2) + 1);
                Console.WriteLine("Félicitations!!");
            }
            //Console.ReadLine();

            static void Board()
                //methode qui cree le board
            {
                Console.WriteLine("********************************");
                Console.WriteLine("********************************");
                Console.WriteLine();
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
                Console.WriteLine("     |     |      ");
            }
            //verifie si quelqun a gagne
            static int Verifier()
            {
                //condition gagnante horizontale
                //premiere rangee
                if (board[1] == board[2] && board[2] == board[3])
                {
                    return 1;
                }
                //condition gagnante deuxieme rangee
                else if (board[4] == board[5] && board[5] == board[6])
                {
                    return 1;
                }
                //condition gagnante troisieme rangee
                else if (board[6] == board[7] && board[7] == board[8])
                {
                    return 1;
                }
                //Condition gagnante verticale
                //premiere colonne
                else if (board[1] == board[4] && board[4] == board[7])
                {
                    return 1;
                }
                //condition gagnante deuxieme colonne
                else if (board[2] == board[5] && board[5] == board[8])
                {
                    return 1;
                }
                //condition gagnante troisieme colonne
                else if (board[3] == board[6] && board[6] == board[9])
                {
                    return 1;
                }
                //Condition gagnante diagonale

                else if (board[1] == board[5] && board[5] == board[9])
                {
                    return 1;
                }
                else if (board[3] == board[5] && board[5] == board[7])
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