namespace Program.Tests;
using assignment0;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void DivisibleByFourWithTrueInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3();


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(8);

        //Assert
        output.Should().Be(true);
    }

    [Fact]
    public void DivisibleByFourWithFalseInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3();


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(9);

        //Assert  
        output.Should().Be(false);  
    }

    [Fact]
    public void DivisibleBy400WithTrueInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3();


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(1600);

        //Assert
        output.Should().Be(true);
    }

    [Fact]
    public void DivisibleBy400WithFalseInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3();


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(1700);

        //Assert
        output.Should().Be(false);
    }
}