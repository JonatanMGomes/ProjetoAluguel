using Xunit;
using ProjetoAluguel;
using System;

namespace ProjetoAluguel.TesteUnitario
{
    public class MoradiaTest
    {
        [Fact]
        public void TestandoSeMoradiaSalvaCEPCorreto()
        {
            //Arrange - Preparando
            var cepEsperado = "92480000";
            var moradiaTest = new Moradia("endereço teste", cepEsperado, 10, 1, 2);
            //Act - Agindo
            var cepATestar = moradiaTest.GetCEP();
            //Assert - 
            Assert.Equal(cepEsperado, cepATestar);
        }
        [Fact]
        public void TestandoSeMoradiaNaoSalvaCEPIncorreto()
        {
            //Arrange - Preparando
            var cepIncorreto = "924800001";
            var moradiaTest = new Moradia("endereço teste", cepIncorreto, 10, 1, 2);
            //Act - Agindo
            var cepATestar = moradiaTest.GetCEP();
            //Assert - 
            Assert.Equal(null, cepATestar);
        }
        [Fact]
        public void TestandoSeKitnetSalvaQtdCorretaDeBanheiros()
        {
            //Arrange
            var qtdEsperadaBanheiros = 1;
            var moradiaTest = new Kitnet("endereço teste", "92480000", 25, qtdEsperadaBanheiros, 2);
            //Act
            var qtdBanheirosATestar = moradiaTest.GetQuantidadeBanheiros();
            //Assert
            Assert.Equal(qtdEsperadaBanheiros, qtdBanheirosATestar);
        }
        [Fact]
        public void TestandoSeKitnetNaoSalvaQtdIncorretaDeBanheiros()
        {
            //Arrange
            var qtdIncorretaBanheiros = 3;
            var moradiaTest = new Kitnet("endereço teste", "92480000", 25, qtdIncorretaBanheiros, 2);
            //Act
            var qtdBanheirosATestar = moradiaTest.GetQuantidadeBanheiros();
            //Assert
            Assert.Equal(0, qtdBanheirosATestar);
        }
        [Fact]
        public void TestandoSeApartamentoSalvaQtdCorretaDeBanheiros()
        {
            //Arrange
            var qtdEsperadaBanheiros = 2;
            var moradiaTest = new Apartamento("endereço teste", "92480000", 25, qtdEsperadaBanheiros, 2, 5, 100);
            //Act
            var qtdBanheirosATestar = moradiaTest.GetQuantidadeBanheiros();
            //Assert
            Assert.Equal(qtdEsperadaBanheiros, qtdBanheirosATestar);
        }
        [Fact]
        public void TestandoSeApartamentoNaoSalvaQtdIncorretaDeBanheiros()
        {
            //Arrange
            var qtdIncorretaBanheiros = 4;
            var moradiaTest = new Apartamento("endereço teste", "92480000", 25, qtdIncorretaBanheiros, 2, 5, 100);
            //Act
            var qtdBanheirosATestar = moradiaTest.GetQuantidadeBanheiros();
            //Assert
            Assert.Equal(0, qtdBanheirosATestar);
        }
        [Fact]
        public void TestandoSeCasaSalvaQtdCorretaDeBanheiros()
        {
            //Arrange
            var qtdEsperadaBanheiros = 4;
            var moradiaTest = new Casa("endereço teste", "92480000", 25, qtdEsperadaBanheiros, 2, true);
            //Act
            var qtdBanheirosATestar = moradiaTest.GetQuantidadeBanheiros();
            //Assert
            Assert.Equal(qtdEsperadaBanheiros, qtdBanheirosATestar);
        }
        [Fact]
        public void TestandoSeCasaNaoSalvaQtdIncorretaDeBanheiros()
        {
            //Arrange
            var qtdIncorretaBanheiros = 6;
            var moradiaTest = new Casa("endereço teste", "92480000", 25, qtdIncorretaBanheiros, 2, true);
            //Act
            var qtdBanheirosATestar = moradiaTest.GetQuantidadeBanheiros();
            //Assert
            Assert.Equal(0, qtdBanheirosATestar);
        }
        [Fact]
        public void TestandoSeKitnetSalvaQtdCorretaDeMetragem()
        {
            //Arrange
            var qtdEsperadaMetragem = 40;
            var moradiaTest = new Kitnet("endereço teste", "92480000", qtdEsperadaMetragem, 1, 2);
            //Act
            var qtdMetragemATestar = moradiaTest.GetTamanhoMetros();
            //Assert
            Assert.Equal(qtdEsperadaMetragem, qtdMetragemATestar);
        }
        [Fact]
        public void TestandoSeKitnetNaoSalvaQtdIncorretaMetragem()
        {
            //Arrange
            var qtdIncorretaMetragem = 55;
            var moradiaTest = new Kitnet("endereço teste", "92480000", qtdIncorretaMetragem, 1, 2);
            //Act
            var qtdMetragemATestar = moradiaTest.GetTamanhoMetros();
            //Assert
            Assert.Equal(0, qtdMetragemATestar);
        }
        [Fact]
        public void TestandoSeApartamentoSalvaQtdCorretaDeMetragem()
        {
            //Arrange
            var qtdEsperadaMetragem = 50;
            var moradiaTest = new Apartamento("endereço teste", "92480000", qtdEsperadaMetragem, 2, 2, 5, 100);
            //Act
            var qtdMetragemATestar = moradiaTest.GetTamanhoMetros();
            //Assert
            Assert.Equal(qtdEsperadaMetragem, qtdMetragemATestar);
        }
        [Fact]
        public void TestandoSeApartamentoNaoSalvaQtdIncorretaMetragem()
        {
            //Arrange
            var qtdIncorretaMetragem = 65;
            var moradiaTest = new Apartamento("endereço teste", "92480000", qtdIncorretaMetragem, 2, 2, 5, 100);
            //Act
            var qtdMetragemATestar = moradiaTest.GetTamanhoMetros();
            //Assert
            Assert.Equal(0, qtdMetragemATestar);
        }
        [Fact]
        public void TestandoSeCasaSalvaQtdCorretaDeMetragem()
        {
            //Arrange
            var qtdEsperadaMetragem = 80;
            var moradiaTest = new Casa("endereço teste", "92480000", qtdEsperadaMetragem, 1, 2, true);
            //Act
            var qtdMetragemATestar = moradiaTest.GetTamanhoMetros();
            //Assert
            Assert.Equal(qtdEsperadaMetragem, qtdMetragemATestar);
        }
        [Fact]
        public void TestandoSeCasaNaoSalvaQtdIncorretaMetragem()
        {
            //Arrange
            var qtdIncorretaMetragem = 115;
            var moradiaTest = new Casa("endereço teste", "92480000", qtdIncorretaMetragem, 1, 2, true);
            //Act
            var qtdMetragemATestar = moradiaTest.GetTamanhoMetros();
            //Assert
            Assert.Equal(0, qtdMetragemATestar);
        }
        [Fact]
        public void TestandoSeApartamentoSalvaQtdCorretaDeAndares()
        {
            //Arrange
            var qtdEsperadaDeAndares = 7;
            var moradiaTest = new Apartamento("endereço teste", "92480000", 50, 1, 2, qtdEsperadaDeAndares, 100);
            //Act
            var qtdDeAndaresATestar = moradiaTest.GetAndar();
            //Assert
            Assert.Equal(qtdEsperadaDeAndares, qtdDeAndaresATestar);
        }
        [Fact]
        public void TestandoSeApartamentoNaoSalvaQtdIncorretaDeAndares()
        {
            //Arrange
            var qtdIncorretaDeAndares = 12;
            var moradiaTest = new Apartamento("endereço teste", "92480000", 50, 1, 2, qtdIncorretaDeAndares, 100);
            //Act
            var qtdDeAndaresATestar = moradiaTest.GetAndar();
            //Assert
            Assert.Equal(0, qtdDeAndaresATestar);
        }
    }
}