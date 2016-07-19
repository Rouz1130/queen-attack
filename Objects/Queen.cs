using System.Collections.Generic;

namespace QueenAttack
{
  public class Queen
  {
    public bool IsAttack(int xQueen, int yQueen, int xPawn, int yPawn)
    {
      if (yQueen == yPawn)
      {
        return true;
      }
      else if (xQueen == xPawn)
      {
        return true;
      }
      else if ((yQueen-yPawn)/(xQueen-xPawn) == 1 || (yQueen-yPawn)/(xQueen-xPawn) == -1 )
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
