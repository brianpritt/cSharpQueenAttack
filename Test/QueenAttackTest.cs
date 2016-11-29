using Xunit;
using System.Collections.Generic;
using System;
using QueenAttack.Objects;

namespace QueenAttack
{
  public class AngleFindTest
  {
    [Fact]
    public void QueenAttack_canAttackonXAxis_true()
    {
      //Arrange
      Queen newQueen = new Queen(2,5,2,0);
      //Act
      newQueen.AxisCheck();
      //Assert
      Assert.Equal(true, newQueen.AxisCheck());
    }
    [Fact]
    public void QueenAttack_canAttackonYAxis_true()
    {
      //Arrange
      Queen newQueen = new Queen(5,2,0,2);
      //Act

      //Assert
      Assert.Equal(true, newQueen.AxisCheck());
    }
    [Fact]
    public void QueenAttack_canAttackonDiagonal_true()
    {
      //Arrange
      Queen newQueen = new Queen(4,1,7,4);
      //Act

      //Assert
      Assert.Equal(true, newQueen.AxisCheck());
    }
  }
}
