namespace Program.Tests;
using assignment0;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void DivisibleByFourWithTrueInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("0");


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(1604);

        //Assert
        output.Should().Be(true);
    }

    [Fact]
    public void DivisibleByFourWithFalseInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("0");


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(1603);

        //Assert  
        output.Should().Be(false);  
    }

    [Fact]
    public void DivisibleBy400WithTrueInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("0");


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(1600);

        //Assert
        output.Should().Be(true);
    }

    [Fact]
    public void DivisibleBy400WithTrueInput2()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("0");


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(2000);

        //Assert
        output.Should().Be(true);
    }

    [Fact]
    public void DivisibleBy400WithFalseInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("0");


        //Act
        var output = is_This_A_Leap_Year.isLeapYear(1700);

        //Assert
        output.Should().Be(false);
    }
    [Fact]
    public void throwFormatExceptionOnIncorrectInput()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("Test");
        
        //Act
        Action output = () => is_This_A_Leap_Year.isLeapYear("Test");

        //Assert
        output.Should().Throw<FormatException>();
    }

    [Fact]
    public void inputSmallerThan1582()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("1200");
        //Act
        var output =is_This_A_Leap_Year.isLeapYear("1200");
        //Assert
        output.Should().Be(false);
    }
    [Fact]
    public void inputBiggerThan1582()
    {
        //Arrange
        var is_This_A_Leap_Year = new Exercise3("1604");
        //Act
        var output =is_This_A_Leap_Year.isLeapYear("1604");
        //Assert
        output.Should().Be(true);
    }
}