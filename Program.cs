namespace _5

{
    class Program
    {
        //faire array
        static char[] table = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int joueur = 1;//joueur 1 par default
        static int choix; //choix
        static int drapeau = 0; //verifie qui a gagne, si valeur est 1 quelqun a gagne
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
                if (joueur % 2 == 0)//verifie tour joueur
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

                if (table[choix] != 'X' && table[choix] != 'O')
                //verifie si la position est marquee avec X ou 0
                {
                    if (joueur % 2 == 0) //si tour du joueur, alors mettre O, sinon X
                    {
                        table[choix] = 'O';
                        joueur++;
                    }
                    else
                    {
                        table[choix] = 'X';
                        joueur++;
                    }
                }

                drapeau = Verifier();//verifie si quelqun a gagne
            }
            while (drapeau != 1 && drapeau != -1);
            //ce loop roule jusque ce que toutes cases sont occupees
            //avec X ou O ou joueur n'a pas gagne

            Console.Clear();//clear console
            Board();//va chercher le board rempli
            if (drapeau == 1)
            // si valeur drapeau est 1 alors quelqun a gagne
            {
                Console.WriteLine("joueur {0} gagne", (joueur % 2) + 1);

            }

            static void Board()
                //methode qui cree le board
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", table[1], table[2], table[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", table[4], table[5], table[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", table[7], table[8], table[9]);
                Console.WriteLine("     |     |      ");
            }
            //verifie si quelqun a gagne
            static int Verifier()
            {
                //condition gagnante horizontale
                //premiere rangee
                if (table[1] == table[2] && table[2] == table[3])
                {
                    return 1;
                }
                //condition gagnante deuxieme rangee
                else if (table[4] == table[5] && table[5] == table[6])
                {
                    return 1;
                }
                //condition gagnante troisieme rangee
                else if (table[6] == table[7] && table[7] == table[8])
                {
                    return 1;
                }
                //Condition gagnante verticale
                //premiere colonne
                else if (table[1] == table[4] && table[4] == table[7])
                {
                    return 1;
                }
                //condition gagnante deuxieme colonne
                else if (table[2] == table[5] && table[5] == table[8])
                {
                    return 1;
                }
                //condition gagnante troisieme colonne
                else if (table[3] == table[6] && table[6] == table[9])
                {
                    return 1;
                }
                //Condition gagnante diagonale

                else if (table[1] == table[5] && table[5] == table[9])
                {
                    return 1;
                }
                else if (table[3] == table[5] && table[5] == table[7])
                {
                    return 1;
                }
                //verifie egalite
                //si toutes les cellules ont X ou O alors egal
                else if (table[1] != '1' && table[2] != '2' && table[3] != '3' && table[4] != '4' && table[5] != '5' && table[6] != '6' && table[7] != '7' && table[8] != '8' && table[9] != '9')
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
                }
            }
        }
    }