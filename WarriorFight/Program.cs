using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Menu();
            

                int choice = GiveNumber("         == Wybierz opcje ==", 1 ,3);

                switch (choice)  
                {

                    case 1:
                        NewGame();
                        break;
                    case 2:
                        WarriorInfo();
                        break;
                    case 3:
                        exit = true;
                        break;
                       
                }
            } while (exit == false);

            }

        private static void Menu()
        {
            Console.WriteLine($"      W A R R I O R  F I G H T ");
            Console.WriteLine();
            Console.WriteLine($"1:        ==  NOWA GRA  ==");
            Console.WriteLine($"2:        == Informacje ==");
            Console.WriteLine($"3:        ==  Wyjscie   == ");
            Console.WriteLine();
            Console.WriteLine( );
        }

        private static void GameMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1:          == GLADIATOR  ==");
            Console.WriteLine("2:          == NEKROMANTA ==");
            Console.WriteLine("3:          ==  PALLADYN  ==" );
            Console.WriteLine("4:          ==  LUCZNIK   ==");
            Console.WriteLine("5:          == CZARODZIEJ ==");
           
        }
       
        private static void WarriorInfo()
        {
            Console.Clear();
            bool exit = false;
            do
            {
                Console.Clear();
                Logo();
                GameMenu();
                Console.WriteLine("6:            == COFNIJ ==");
                int number = GiveNumber("  == WYBIERZ INFORMACJE O POSTACI ==", 1, 6);

                

                switch (number)
                {
                    case 1:
                        ShowWarrior(number);
                        break;
                    case 2:
                        ShowWarrior(number);
                        break;
                    case 3:
                        ShowWarrior(number);
                        break;
                    case 4:
                        ShowWarrior(number);
                        break;
                    case 5:
                        ShowWarrior(number);
                        break;
                    case 6:
                        exit = true;
                        break;
                }


            } while (exit == false);

        }

      

        private static void ShowWarrior(int choice)
        {
            Warrior player = new Warrior(0, 0, 0, 0, 0);
            Console.Clear();
            string message = "";
            if (choice == 1)
            {
                player = new Gladiator();
                Gladiator.Weapon();
                message = "ATAK SPECJALNY OBRONA = 45"; 
            }
            else if (choice == 2)
            {
                player = new Neckromancer();
                Neckromancer.Weapon();
                message = "ATAK SPECJALNY ZABIERA 50% ZYCIA I DODAJE DO SIEBIE";
            }
            else if (choice == 3)
            {
                player = new Palladin();
                Palladin.Weapon();
                message = "ATAK SPECJALNY ATAK MIN = 40 I ATAK MAX = 150";
            }
            else if (choice == 4)
            {
                player = new BowMan();
                BowMan.Weapon();
                message = "ATAK SPECJALNY OBRAZENIA = 200";
            }
            else if (choice == 5)
            {
                player = new Wizzard();
                Wizzard.Weapon();
                message = " ATAK SPECJALNY PODWAJA ILOSC ZYCIA";
            }
    
            
            Console.WriteLine($" ATAK MIN = {player.attackMin}");
            Console.WriteLine($" ATAK MAX = {player.attackMax}");
            Console.WriteLine($" OBRONA   = {player.deffense}");
            Console.WriteLine($" ZYCIE    = {player.life}");
            Console.WriteLine($" UNIK     = {player.evasion}");
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine(" Nacisnij dowolny klawisz");
            Console.ReadKey();

        }

       

        private static void NewGame()
        {
            Console.Clear();
            Logo();
            Console.WriteLine();
                Console.WriteLine("          == GRACZ PIERWSZY ==");
                Console.WriteLine();
                GameMenu();
                Console.WriteLine();
                int choiceA = GiveNumber("         == WYBIERZ WOJOWNIKA == " ,1, 5);
            Warrior player1 = new Warrior(0, 0, 0, 0, 0);
            

            if( choiceA == 1 )
            {
                 player1 = new Gladiator();
            }else if ( choiceA == 2 )
            {
               player1 = new Neckromancer();
            }else if ( choiceA == 3 )
            {
                 player1 = new Palladin();
            }else if ( choiceA == 4 )
            {
                 player1 = new BowMan();
            }else if ( choiceA == 5 )
            {
                 player1 = new Wizzard();
            }
            
                  
               Console.Clear();
            Logo();
            Console.WriteLine();
            Console.WriteLine("           == GRACZ DRUGI ==");
            Console.WriteLine();
            GameMenu();
            Console.WriteLine();
            int choiceB = GiveNumber("         == WYBIERZ WOJOWNIKA == ", 1, 5);
            Warrior player2 = new Warrior(0,0,0,0,0);
            
            if (choiceB == 1)
            {
                 player2 = new Gladiator();
            }
            else if (choiceB == 2)
            {
                 player2 = new Neckromancer();
            }
            else if (choiceB == 3)
            {
                player2 = new Palladin();
            }
            else if (choiceB == 4)
            {
                 player2 = new BowMan();
            }
            else if (choiceB == 5)
            {
                 player2 = new Wizzard();
            }
            
            

            Game(player1 , player2, choiceA , choiceB);


        }

        private static void Game(Warrior playerl, Warrior player2, int choiceA , int choiceB)
        {
           
            bool win = false;
            
            int count1 = 0;
            int count2 = 0;
            int menuRange1 = 3;
            int menuRange2 = 3;
            do
            {
                float dmg1 = 0;
                float dmg2 = 0;              
                bool evasion1;
                bool evasion2;
                int attackMinTmp1 = playerl.attackMin;
                int attackMaxTmp1 = playerl.attackMax;
                int attackMinTmp2 = player2.attackMin;
                int attackMaxTmp2 = player2.attackMax;
                float defTmp1 = playerl.deffense;
                float defTmp2 = player2.deffense;
                
                GameView(count1);
                Console.WriteLine();
                int choice1 = GiveNumber("       == Co chcesz zrobic GRACZ 1 ==",1,menuRange1);
                if(choice1 == 3)
                {
                    count1 = count1 + 1;
                }
                if(choice1 == 1)
                {
                 float attack1 = playerl.Attack(playerl.attackMin,playerl.attackMax);
                    dmg1 = playerl.Dmg(attack1, player2.deffense);
                }else if(choice1 == 2)
                {
                    playerl.deffense = playerl.Deffense(playerl.deffense);
                }
                else
                {
                   
                    if(choiceA == 1)
                    {
                       playerl.deffense =  Gladiator.SpecialAttack(playerl.deffense);

                    }else if (choiceA == 2)
                    {
                       player2.life = Neckromancer.SpecialAttack(player2.life);
                        playerl.life = playerl.life + player2.life;

                    }else if (choiceA == 5)
                    {
                      playerl.life =  Wizzard.SpecialAttack(playerl.life);

                    }else if (choiceA == 3)
                    {
                       playerl.attackMax =  Palladin.SpecialAttack(playerl.attackMax);
                        playerl.attackMin = Palladin.SpecialAttack2(playerl.attackMin);
                        float attack1 = playerl.Attack(playerl.attackMin, playerl.attackMax);
                        dmg1 = playerl.Dmg(attack1, player2.deffense);
                    }
                    else if(choiceA == 4)
                    {
                         dmg1 =  BowMan.SpecialAttack(playerl.attackMax);
                        count1++;
                    }
                    
                }

                Console.Clear();
                GameView(count2);
                Console.WriteLine();

                int choice2 = GiveNumber("       == Co chcesz zrobic GRACZ 2 ==", 1, menuRange2);
                if (choice2 == 1)
                {
                    float attack2 = player2.Attack(player2.attackMin, player2.attackMax);
                    dmg2 = player2.Dmg(attack2, playerl.deffense);
                }
                else if (choice2 == 2)
                {
                    player2.deffense = player2.Deffense(player2.deffense);
                }
                else
                {
                    count2++;
                    if (choiceB == 1)
                    {
                        player2.deffense = Gladiator.SpecialAttack(player2.deffense);

                    }
                    else if (choiceB == 2)
                    {
                        playerl.life = Neckromancer.SpecialAttack(playerl.life);
                        player2.life = player2.life + playerl.life;

                    }
                    else if (choiceB == 5)
                    {
                        player2.life = Wizzard.SpecialAttack(player2.life);

                    }
                    else if (choiceB == 3)
                    {
                        player2.attackMax = Palladin.SpecialAttack(player2.attackMax);
                        player2.attackMin = Palladin.SpecialAttack2(player2.attackMin);
                        float attack2 = player2.Attack(player2.attackMin, player2.attackMax);
                        dmg2 = player2.Dmg(attack2, playerl.deffense);
                           
                    }
                    else if (choiceB == 4)
                    {
                        dmg2 = BowMan.SpecialAttack( player2.attackMax);
                        count2++;
                    }
                    
                }

                evasion1 = playerl.Evasion(playerl.evasion);
                evasion2 = player2.Evasion(player2.evasion);
                if(evasion1 == false)
                {
                    playerl.life = playerl.life - dmg2 ;
                }
                if (evasion2 == false)
                {
                    player2.life = player2.life - dmg1;
                }

                if(playerl.life < 0 || player2.life < 0)
                {
                    win = true;
                }

                

                Show(playerl.life, player2.life , dmg1 , dmg2, evasion1, evasion2 );
                

                playerl.attackMin = attackMinTmp1;
                playerl.attackMax = attackMaxTmp1;
                playerl.deffense = defTmp1;
                player2.attackMin = attackMinTmp2;
                player2.attackMax = attackMaxTmp2;
                player2.deffense = defTmp2;
                
                if(count1 == 2)
                {
                    menuRange1 = 2;
                }
                if(count2 == 2)
                {
                    menuRange2 = 2;
                }

                
            } while (win == false);
            if (win == true)
            {
                Console.Clear();
                Logo();
                Console.WriteLine("         == KONIEC GRY ==");
                Console.WriteLine();
                WhoWIn(playerl.life, player2.life);
                Console.WriteLine();
                Console.WriteLine("   == Nacisnij dowolny klawisz ==");
                Console.ReadKey();
            }
        }

        private static void WhoWIn(float life1, float life2)
        {
            

            if(life1 > 0 && life2 <= 0)
            {
                Console.WriteLine( "      !!! GRACZ 1 WYGRWA !!!");
            }else if(life2 > 0 && life1 <= 0)
            {
                Console.WriteLine( "      !!! GRACZ 2 WYGRYWA !!!");
            }
            else
            {
                Console.WriteLine( "     !!! REMIS !!!");
            }
            
            
        }

        private static void Show(float life1, float life2, float dmg1, float dmg2, bool evasion1, bool evasion2)
        {
            string message1 ;
            string message2;
            if(evasion1 == true)
            {
                message1 = "Uniknal ataku";
            }
            else
            {
                message1 = "Nie uniknl ataku ";
            }
            if(evasion2 == true)
            {
                message2 = "Uniknal ataku";
            }
            else
            {
                message2 = "Nie uniknal ataku";
            }


            Console.WriteLine($" Gracz 1    zadaje: obrazenia = {dmg1}" );
            Console.WriteLine($"            {message1}");
            Console.WriteLine($"            Pozostale zycie to: {life1}  ");
            Console.WriteLine();
            Console.WriteLine($" Gracz 2    zadaje: obrazenia = {dmg2}");
            Console.WriteLine($"            {message2}");
            Console.WriteLine($"            Pozostale zycie to: {life2}  ");
            Console.WriteLine();
            Console.WriteLine("Nacisnij dowolny klawisz by kontynuowac rozgrywke");
            Console.ReadKey();
        }

        private static void GameView(int count)
        {
            string message;
            if(count == 2)
            {
                message = "3.   == NIE MOZNA UZYC ATAKU SPECJALNEGO ==";
            }
            else
            {
                message = "3.      == ATAK SPECJALNY ==";
            }

            Console.Clear();
            Logo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.           == ATAK ==");
            Console.WriteLine("2.          == OBRONA ==");
            Console.WriteLine(message);
        }

        private static  int GiveNumber(string message, int numberMin, int numberMax)
        {
            int choice = 0;

            do
            {
                Console.WriteLine(message);

            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < numberMin || choice > numberMax);

            return choice;
        }

        private static void Logo()
        {
            Console.WriteLine("      == W A R R I O R  F I G H T ==");
            Console.WriteLine();
        }

    }
}
