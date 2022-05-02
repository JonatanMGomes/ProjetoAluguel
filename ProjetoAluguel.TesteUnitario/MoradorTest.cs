using Xunit;
using ProjetoAluguel;
using System;

namespace ProjetoAluguel.TesteUnitario;

public class MoradorTest
{
    [Fact]
    public void TestandoSeGetNomeRetornaCorretamente()
    {
        //Arrange - Preparando
        var nomeEsperado = "Jonatan";
        var moradorTest = new Morador(nomeEsperado, "11122233344", "02/05/2022");
        //Act - Agindo
        var nomeATestar = moradorTest.GetNome();
        //Assert - 
        Assert.Equal(nomeEsperado, nomeATestar);
    }
    [Fact]
    public void TetandoSeSetNomeSetaCorretamente()
    {
        //Arrange
        var nomeASetarEsperado = "Jonatan";
        var moradorTest = new Morador("nome tosco", "11122233344", "02/05/2022");
        //Act
        moradorTest.SetNome(nomeASetarEsperado);
        var nomeATestar = moradorTest.GetNome();
        //Assert
        Assert.Equal(nomeASetarEsperado, nomeATestar);
    }
    [Fact]
    public void TesttandoSeGetCPFRetornaCorretamente(){
        //Arrange
        var cpfEsperado = "11122233344";
        var moradorTest = new Morador("Jonatan", cpfEsperado, "02/05/2022");
        //Act
        var cpfATestar = moradorTest.GetCPF();
        //Assert
        Assert.Equal(cpfEsperado, cpfATestar);
    }
    [Fact]
    public void TestandoSeSetCPFSetaCorretamente(){
        //arrange
        var cpfASetarEsperado = "11122233344";
        var moradorTest = new Morador("Jonatan", "22233344455", "02/05/2022");
        //act
        moradorTest.SetCPF(cpfASetarEsperado);
        var cpfATestar = moradorTest.GetCPF();
        //assert
        Assert.Equal(cpfASetarEsperado, cpfATestar);
    }
}