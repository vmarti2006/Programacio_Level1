using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Girad;

public class UnitTest1
{
    [Theory]
    [InlineData("123","123,231,312")]
    [InlineData("1","1")]
    [InlineData("111111","111111")]

    public void ComprovaQueELResultatEsCorrecte(string numero, string esperat)
    {
        // Arrange

        // Act
        string resultat = Program.GirarNumero(numero);

        // Assert
        Assert.Equal(resultat, esperat);
    }
}
