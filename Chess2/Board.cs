﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2
{
    class Board
    {

        protected ChessBoardSquares[,] ChessBoards = new ChessBoardSquares[8,8];

        

        public void RemovePiece(int SquarePositionX, int SquarePositionY)
        {
            ChessBoards[SquarePositionX, SquarePositionY].Image = null;           
        }

        public void AddPiece(Image PieceCopied , int SquarePositionX, int SquarePositionY)
        {
            ChessBoards[SquarePositionX,SquarePositionY].Image = PieceCopied;
        }
        public void AddChessBoardSquare(ChessBoardSquares NewBoardSquares,int LocationX,int LocationY )
        {
            ChessBoards[LocationX, LocationY] = NewBoardSquares;
        }

        public Image GetPiece(int LocationX, int LocationY)
        {
            return ChessBoards[LocationX, LocationY].Image;
        }
    }
}
