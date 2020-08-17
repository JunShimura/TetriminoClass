using System;


namespace TetriminoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] mino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };
            Tetrimino tetrimino = new Tetrimino(mino);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(tetrimino.NextMino());
            }
        }
    }
}
