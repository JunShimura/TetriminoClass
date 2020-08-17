using System;
using System.Collections.Generic;
using System.Text;

namespace TetriminoClass
{
    public class Tetrimino
    {
        private List<char> minos;
        public Tetrimino(char[] minos)
        {
            this.minos = new List<char>(minos);
        }
        public char NextMino()
        {
            //ここの処理を考える
            char next = minos[0];

            return next;
        }
    }
}
