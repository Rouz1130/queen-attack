using Xunit;
using System.Collections.Generic;

namespace QueenAttack
{
  public class QueenTest
  {
    // [Fact]
    // public void Attack_GetsCoordinatesForQueenAndPawn_true()
    // {
    //   Queen testCoordinates = new Queen() {};
    //   List<int> actualCoordinates = new List<int>() {1, 1, 2, 3};
    //   Assert.Equal(actualCoordinates, testCoordinates.Attack(1,1,2,3));
    // }

    [Fact]
    public void Attack_QueenAttacksHorizontally_true()
    {
      Queen testCoordinates = new Queen() {};
      Assert.Equal(true, testCoordinates.IsAttack(5, 1, 4, 1));
    }

    [Fact]
    public void Attack_QueenAttacksVertically_true()
    {
      Queen testCoordinates = new Queen() {};
      Assert.Equal(true, testCoordinates.IsAttack(1,5,1,4));
    }

    [Fact]
    public void Attack_QueenAttacksDiagonally_true()
    {
      Queen testCoordinates = new Queen() {};
      Assert.Equal(true, testCoordinates.IsAttack(4, 1 , 4, 2));
    }
  }
}
