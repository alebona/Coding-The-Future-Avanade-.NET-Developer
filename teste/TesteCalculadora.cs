using calculadora;
using System;
using Xunit;

namespace teste
{
    public class CalculadoraTests
    {
        private Calculadora CriarCalculadora()
        {
            string data = DateTime.Now.ToString(); // Obtém a data atual
            return new Calculadora(data);
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(8, 5, 13)]
        public void SomarDoisNumeros_DeveRetornarSomaCorreta(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = CriarCalculadora();

            // Act
            int resultado = calc.Somar(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(8, 5, 3)]
        public void SubtrairDoisNumeros_DeveRetornarSubtracaoCorreta(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = CriarCalculadora();

            // Act
            int resultado = calc.Subtrair(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(8, 5, 40)]
        public void MultiplicarDoisNumeros_DeveRetornarMultiplicacaoCorreta(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = CriarCalculadora();

            // Act
            int resultado = calc.Multiplicar(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(9, 3, 3)]
        public void DividirDoisNumeros_DeveRetornarDivisaoCorreta(int valor1, int valor2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = CriarCalculadora();

            // Act
            int resultado = calc.Dividir(valor1, valor2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DividirNumeroPorZero_DeveLancarExcecao()
        {
            // Arrange
            Calculadora calc = CriarCalculadora();

            // Act e Assert
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(6, 0));
        }

        [Fact]
        public void TesteHistorico_DeveRetornarHistoricoCorreto()
        {
            // Arrange
            Calculadora calc = CriarCalculadora();

            // Act
            calc.Somar(1, 2);
            calc.Somar(3, 4);
            calc.Somar(4, 5);
            calc.Somar(5, 6);

            var historico = calc.Historico();

            // Assert
            Assert.NotEmpty(historico);
            Assert.Equal(3, historico.Count);
        }
    }
}
