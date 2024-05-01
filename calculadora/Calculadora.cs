using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    
    /// <summary>
    /// Classe responsável por fornecer funcionalidades de uma calculadora avançada.
    /// </summary>
    public class Calculadora
    {
        private readonly List<string> _historicoOperacoes;
        private readonly string _dataAtual;

        /// <summary>
        /// Construtor da Calculadora.
        /// </summary>
        /// <param name="data">Data atual formatada.</param>
        public Calculadora(string data)
        {
            _historicoOperacoes = new List<string>();
            _dataAtual = data;
        }

        /// <summary>
        /// Realiza a operação de soma e registra no histórico.
        /// </summary>
        /// <param name="valor1">Primeiro valor a ser somado.</param>
        /// <param name="valor2">Segundo valor a ser somado.</param>
        /// <returns>O resultado da soma.</returns>
        public int Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            RegistrarOperacao("soma", resultado);
            return resultado;
        }

        /// <summary>
        /// Realiza a operação de subtração e registra no histórico.
        /// </summary>
        /// <param name="valor1">Valor a ser subtraído.</param>
        /// <param name="valor2">Valor a ser subtraído.</param>
        /// <returns>O resultado da subtração.</returns>
        public int Subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            RegistrarOperacao("subtração", resultado);
            return resultado;
        }

        /// <summary>
        /// Realiza a operação de multiplicação e registra no histórico.
        /// </summary>
        /// <param name="valor1">Primeiro valor a ser multiplicado.</param>
        /// <param name="valor2">Segundo valor a ser multiplicado.</param>
        /// <returns>O resultado da multiplicação.</returns>
        public int Multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            RegistrarOperacao("multiplicação", resultado);
            return resultado;
        }

        /// <summary>
        /// Realiza a operação de divisão e registra no histórico.
        /// </summary>
        /// <param name="valor1">Valor a ser dividido.</param>
        /// <param name="valor2">Valor pelo qual dividir.</param>
        /// <returns>O resultado da divisão.</returns>
        public int Dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            RegistrarOperacao("divisão", resultado);
            return resultado;
        }

        /// <summary>
        /// Retorna o histórico das últimas operações.
        /// </summary>
        /// <returns>Lista contendo as operações registradas.</returns>
        public List<string> Historico()
        {
            // Limitando o histórico a 3 operações mais recentes
            int limiteHistorico = 3;
            if (_historicoOperacoes.Count > limiteHistorico)
            {
                _historicoOperacoes.RemoveRange(limiteHistorico, _historicoOperacoes.Count - limiteHistorico);
            }
            return _historicoOperacoes;
        }

        /// <summary>
        /// Registra a operação realizada no histórico.
        /// </summary>
        /// <param name="operacao">Tipo de operação realizada.</param>
        /// <param name="resultado">Resultado da operação.</param>
        private void RegistrarOperacao(string operacao, int resultado)
        {
            _historicoOperacoes.Insert(0, $"Operação: {operacao}, Resultado: {resultado}, Data: {_dataAtual}");
        }
    }

}
