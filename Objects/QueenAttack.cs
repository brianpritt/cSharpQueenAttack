using System;

namespace QueenAttack.Objects
{
  public class Queen
  {
    private int _queenX;
    private int _queenY;
    private int _pawnX;
    private int _pawnY;

    public Queen(int queenX, int queenY, int pawnX, int pawnY)
    {
      _queenX = queenX;
      _queenY = queenY;
      _pawnX = pawnX;
      _pawnY = pawnY;
    }

    public bool AxisCheck()
    {
      if (_queenX == _pawnX)
      {
        return true;
      }
      else if (_queenY == _pawnY)
      {
        return true;
      }
      else if (Math.Abs(_queenX - _pawnX) == Math.Abs(_queenY - _pawnY))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
