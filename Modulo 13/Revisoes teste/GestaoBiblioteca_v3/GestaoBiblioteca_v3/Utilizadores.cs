using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GestaoBiblioteca
{
    public class Utilizadores
    {
        public Dictionary<int, Utilizador> Dados { get; } = new Dictionary<int, Utilizador>();

        public Utilizadores()
        {


        }

        public void InicializarDadosFake()
        {

            Dados.Add(1, new Utilizador(true, 1, TipoUtilizador.Utilizador, "user", "user", "Utilizador de Testes", "user@example.com", "000000000"));
            Dados.Add(2, new Utilizador(true, 2, TipoUtilizador.Administrador, "admin", "admin", "Admin de Testes", "admin@example.com", "000000000"));
            Dados.Add(3, new Utilizador(false, 3, TipoUtilizador.Utilizador, "vader", "vader", "Darth Vader", "darth.vader@example.com", "000000000"));
        }

        /// <summary>
        /// Inserir um novo utilizador. /// </summary>
        /// <param name="utilizador">Dados do novo utilizador.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação. </returns>
        public ResultadoOperacao Inserir(Utilizador utilizador)
        {
            ResultadoOperacao resultado = ResultadoOperacao.OK;
            // Adicionar o utilizador na coleção de utilizadores
            Dados.Add(utilizador.ID, new Utilizador());
            return resultado;
        }
        /// <summary>
        /// Atualizar os dados de um utilizador.
        /// </summary>
        ///  ‹param name="utilizador">Dados do utilizador.</param>
        /// ‹returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação. </returns>

        public ResultadoOperacao Atualizar(Utilizador utilizador)
        {
            ResultadoOperacao resultado = ResultadoOperacao.OK;
            // Editar o utilizador na coleção de utilizadores
            Dados[utilizador.ID] = new Utilizador();
            return resultado;

        }
        /// <summary>
        /// Eliminar um utilizador. /// </summary>
        /// <param name="id">Chave primária do utilizador a eliminar.</param>
        /// <returns>Devolve um valor da enumeração ResultadoOperacao que indica o resultado desta operação.</returns>


        public ResultadoOperacao Eliminar(int id)
        {
            ResultadoOperacao resultado = ResultadoOperacao.OK;
            // Eliminar o utilizador da coleção de utilizadores
            // (verificar o valor booleano retornado pelo método Remove(), que indica se o elemento  com o id especificado foi removido com sucesso)
            resultado = (Dados.Remove(id) ? ResultadoOperacao.OK : ResultadoOperacao.Erro);
            return resultado;
        }

    }

}














