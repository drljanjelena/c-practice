namespace BattleGame
{
       class Program
       {
              static void Main(string[] args)
              {

                     Unit player = new Unit(100, 20, 12, "Player");
                     Unit enemy = new Unit(75, 10, 7, "Enemy");
                     Random random = new Random();

                     while (!player.IsDead && !enemy.IsDead)
                     {
                            Console.WriteLine(player.UnitName + "HP = " + player.Hp + ", " + enemy.UnitName + " HP = " +
                                              enemy.Hp);
                            Console.WriteLine("Player turn! What will you do?");
                            Console.WriteLine("a - attack, h - heal");
                            string choice = Console.ReadLine();

                            if (choice == "a")
                            {
                                   player.Attack(enemy);
                            }
                            else
                            {
                                   player.Heal();
                            }
                            
                            if(player.IsDead || enemy.IsDead) break;

                            Console.WriteLine(player.UnitName + "HP = " + player.Hp + ", " + enemy.UnitName +
                                              " HP = " + enemy.Hp);
                            Console.WriteLine("Enemy turn!");

                            int rand = random.Next(0, 2);
                            if (rand == 0)
                            {
                                   enemy.Attack(player);
                            }
                            else
                            {
                                   enemy.Heal();
                            }
                     }
              }
       }
}