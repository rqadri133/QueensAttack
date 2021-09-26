using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueensAttack
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            //   int[,] ls = new int[,] { { 5, 5 }, { 4, 2 }, { 2, 3 } };
            
            List<List<int>> lstParent = new List<List<int>>();
            
            List<int> Item1 = new List<int>() { 5, 5 };
            List<int> Item2 = new List<int>() { 4, 2 };
            List<int> Item3 = new List<int>() { 2, 3 };

            lstParent.Add(Item1);
            lstParent.Add(Item2);
            lstParent.Add(Item3);



            int r = queensAttack(5, 3, 4, 3 ,  lstParent);
            Console.WriteLine($"The Queen could placed on total {r} number of Positions");
            int counter = DrawCheshBoard(5 , lstParent , 4,3 );
            Console.WriteLine($"The Queen could be placed to total {counter}");

            Console.ReadLine();

        }
       
        private static bool IsObstacle(int r_q, int c_q, List<List<int>> ls)
        {
            bool _isObstacle = false;
            int i = 0;
            try
            {
                foreach (List<int> lsRow in ls)
                {
                    foreach(int lstCol in lsRow)
                    {
                        if (lsRow[0] == r_q && lsRow[1] == c_q)
                        {
                             Console.WriteLine($"The Queen stopped at this Obstacle {r_q} , {c_q}");
                            _isObstacle = true;
                            break;
                        }
                  
                    }
                }
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("hm");
            }
            catch (Exception e)
            {
                Console.WriteLine("hm");
            }


            return _isObstacle;

        }

        public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            List<Position> positions = new List<Position>();
            
            
            bool _queenFoundFirstWhere = false;
            int rowIndexMove = r_q;
            int colIndexMove = c_q;

            Console.WriteLine(r_q.ToString() + "," + c_q.ToString());
            // lets move the queen up left  
            // row minus to left and col up                           
            while ((r_q <= n && c_q <= n) && (r_q >= 0 && c_q >= 0))
            {
                // queen move left row    
                r_q = r_q - 1;
                // queen move left up one col up
                c_q = c_q + 1;
                // if no obstacles found 
                if(r_q < 1 || c_q < 1)
                {
                    break;

                }


                if (r_q > n || c_q > n)
                {
                    break;
                }

               
                if (k > 0)
                {
                    if (r_q < n && c_q < n)
                    if (!IsObstacle(r_q,c_q,obstacles))
                    {
                            Console.WriteLine($"The Queen moved from position left diagonal up");
                            positions.Add(new Position() { X = r_q, Y = c_q });
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"The Queen moved from position left diagonal up");

                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }
            r_q = rowIndexMove;
            c_q = colIndexMove;
            Console.WriteLine(r_q.ToString() + "," + c_q.ToString());


            // lets move the queen up left  
            // row minus to left and col up                           
            while ((r_q <= n && c_q <= n) && (r_q > 0 && c_q > 0))

            {
                // queen move right row    
                r_q = r_q + 1;
                // queen move right up one col up
                c_q = c_q + 1;
                // if no obstacles found 
                if (r_q < 1 || c_q < 1)
                {
                    break;

                }

                if (r_q > n || c_q > n)
                {
                    break;
                }


                if (k > 0)
                {
                    if(r_q < n && c_q < n)
                     if (!IsObstacle(r_q, c_q, obstacles))
                     {
                            Console.WriteLine($"The Queen moved from position right up diagonal");

                            positions.Add(new Position() { X = r_q, Y = c_q });
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }
            r_q = rowIndexMove;
            c_q = colIndexMove;


            // lets move the queen  left downowrd  
            // row minus to left and col down                           
            while ((r_q <= n && c_q <= n) && (r_q > 0 && c_q > 0))
            {
                // queen move right row    
                r_q = r_q - 1;
                // queen move right up one col up
                c_q = c_q - 1;
                if (r_q < 1 || c_q < 1)
                {
                    break;

                }

                // if no obstacles found 
                if (r_q > n || c_q > n)
                {
                    break;
                }

                if (k > 0)
                {
                    if (r_q < n && c_q < n)
                        if (!IsObstacle(r_q, c_q, obstacles))
                        {
                            positions.Add(new Position() { X = r_q, Y = c_q });
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }
            r_q = rowIndexMove;
            c_q = colIndexMove;


            // lets move the queen  left downowrd  
            // row minus to left and col down                           
            while ((r_q <= n && c_q <= n) && (r_q > 0 && c_q > 0))
            {
                // queen move right row    
                r_q = r_q + 1;
                // queen move right down col
                c_q = c_q - 1;
                // if no obstacles found 
                if (r_q < 1 || c_q < 1)
                {
                    break;

                }

                if (r_q > n || c_q > n) 
                {
                    break;
                }
               
                if (k > 0)
                {
                    if (r_q < n && c_q < n)
                        if (!IsObstacle(r_q, c_q, obstacles))
                        {
                            positions.Add(new Position() { X = r_q, Y = c_q });
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }
            r_q = rowIndexMove;
            c_q = colIndexMove;


            // lets move the queen  left downowrd  
            // row minus to left and col down                           
            while ((r_q <= n && c_q <= n) && (r_q > 0 && c_q > 0))
            {
                // queen move right row on the same column    
                r_q = r_q - 1;
                // queen move right down col
                if (r_q < 1 || c_q < 1)
                {
                    break;

                }

                if (r_q > n || c_q > n )
                {
                    break;
                }

                if (k > 0)
                {
                    if (r_q < n && c_q < n)
                    if (!IsObstacle(r_q, c_q, obstacles))
                    {
                            positions.Add(new Position() { X = r_q, Y = c_q });
                    }
                 }
                else
                {
                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }
            r_q = rowIndexMove;
            c_q = colIndexMove;

            // lets move the queen  left downowrd  
            // row minus to left and col down                           
            while ((r_q <= n && c_q <= n) && (r_q > 0 && c_q > 0))
            {
                // queen move right row on the same column    
                r_q = r_q + 1;
                // queen move right down col
                if (r_q < 1 || c_q < 1)
                {
                    break;

                }


                if (r_q > n || c_q > n) 
                {
                    break;
                }

                if (k > 0)
                {
                    if (r_q < n && c_q < n)
                    if (!IsObstacle(r_q, c_q, obstacles))
                    {
                            positions.Add(new Position() { X = r_q, Y = c_q });
                    }
                }
                else
                {
                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }
            r_q = rowIndexMove;
            c_q = colIndexMove;

            // lets move the queen  left downowrd  
            // row minus to left and col down                           
            while ((r_q <= n && c_q <= n) && (r_q > 0 && c_q > 0))
            {
                // queen move right row on the same column    
                // queen move right down col
                c_q = c_q + 1;

                if (r_q < 1 || c_q < 1)
                {
                    break;

                }

                if (r_q > n || c_q > n) 
                {
                    break;
                }

                if (k > 0)
                {
                    if (r_q < n && c_q < n)
                     if (!IsObstacle(r_q, c_q, obstacles))
                     {
                            positions.Add(new Position() { X = r_q, Y = c_q });
                     }
                 }
                else
                {
                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }
            r_q = rowIndexMove;
            c_q = colIndexMove;

            // lets move the queen  left downowrd  
            // row minus to left and col down                           
            while ((r_q <= n && c_q <= n) && (r_q > 0 && c_q > 0))
            {
                // queen move right row on the same column    

                // queen move right down col
                c_q = c_q - 1;
                if (r_q < 1 || c_q < 1)
                {
                    break;

                }


                if (r_q > n || c_q > n) 
                {
                    break;
                }

                if (k > 0)
                {
                    if (r_q < n && c_q < n)
                     if (!IsObstacle(r_q, c_q, obstacles))
                     {
                            positions.Add(new Position() { X = r_q, Y = c_q });
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    positions.Add(new Position() { X = r_q, Y = c_q });

                }
            }

            Console.WriteLine($"Its a {n} X {n} Chess Board");
            Console.WriteLine($"The Queen was at Position {rowIndexMove} , {colIndexMove}");

            foreach(Position pos in positions)
            {
                Console.WriteLine($"The Queen moved to position {pos.X} , {pos.Y} "); 

            }

            
            
            return positions.Count;


        }

        private static int DrawCheshBoard(int n , List<List<int>> lstParent , int r , int c )
        {
            string rowCol = String.Empty;
            List<Position> positions = new List<Position>();
            for(int row=1; row < n; row++)
            {
                for (int col=1; col< n; col++)
                {

                    if (r == row && col == c)
                    {
                        rowCol = rowCol + "|Q|";

                    }
                    else if(IsObstacle(row,col,lstParent))
                    {
                        rowCol = rowCol + "|X|";
                       
                    }
                    else
                    {
                        positions.Add(new Position() { X = row, Y = col });
                        rowCol = rowCol + "|E|"; 

                    }
                }

                rowCol = rowCol + Environment.NewLine;

            }

            Console.WriteLine(rowCol);

            return positions.Count;

        }

    }

}
