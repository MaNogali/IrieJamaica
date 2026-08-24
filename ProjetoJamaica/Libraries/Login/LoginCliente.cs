using MySqlX.XDevAPI;
using Newtonsoft.Json;
using ProjetoJamaica.Models;

namespace ProjetoJamaica.Libraries.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Cliente cliente)
        {
            string clienteJSONString = JsonConvert.SerializeObject(cliente);

            _sessao.Cadastrar(Key, clienteJSONString);
        }

        public Cliente GetCliente()
        {
            // Deserializar
            if (_sessao.Existe(Key))
            {
                string clienteJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(clienteJSONString);
            }
            else
            {
                return null;
            }
        }
        //Remove a sessão e desloga o CLiente
        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
