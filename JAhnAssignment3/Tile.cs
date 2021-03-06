﻿/* Tile.cs
* Assignment 3
* Revision History
*   Jaden Ahn, 2017.10.08: Created
*   Jaden Ahn, 2017.10.15: Improved class structure
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAhnAssignment3
{
    public class Tile : Button
    {
        private int row;
        private int col;

        public Tile(int row, int col)
        {
            this.Row = row;
            this.col = col;
        }

        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
    }
}
