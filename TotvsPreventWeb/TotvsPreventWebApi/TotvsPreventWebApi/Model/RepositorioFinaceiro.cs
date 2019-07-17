using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotvsPreventWebApi.Model
{
    public class RepositorioFinaceiro : IFinaceiro
    {
        public List<Caixa> ObterTotalCaixaPorDepartamento()
        {
            List<Caixa> listCaixa = new List<Caixa>();
            Caixa Caixa1 = new Caixa { filial = "01", Tipo = "Contas a Pagar", Valor = "R$ 9.850,00", Departamento = "Engenharia/Operações" };
            Caixa Caixa2 = new Caixa { filial = "01", Tipo = "Contas a Pagar", Valor = "R$ 20.745,00", Departamento = "Limpeza" };
            Caixa Caixa3 = new Caixa { filial = "01", Tipo = "Contas a Pagar", Valor = "R$ 40.745,00", Departamento = "Recursos Homanos" };

            listCaixa.Add(Caixa1);
            listCaixa.Add(Caixa2);
            listCaixa.Add(Caixa3);

            return listCaixa;

        }

        public List<Fornecedor> ObterTotalListaFornecedorApagar()
        {
            List<Fornecedor> ListaFornecedor = new List<Fornecedor>();
            Fornecedor fornecedor1 = new Fornecedor { Cnpj = "82.553.434/0001-83", DataVencimento = DateTime.Now, RazaoSocial = "Linha Forte Distribuidora",Valor = "R$ 8.745,00" };
            Fornecedor fornecedor2 = new Fornecedor { Cnpj = "587.783.44/0821-83", DataVencimento = DateTime.Now, RazaoSocial = "Escoville Supermercado", Valor = "R$ 3.745,00" };
            Fornecedor fornecedo3 = new Fornecedor { Cnpj = "587.783.44/0821-83", DataVencimento = DateTime.Now, RazaoSocial = "Atakadinho Bahia Produtos", Valor = "R$ 2.745,00" };


            ListaFornecedor.Add(fornecedor1);
            ListaFornecedor.Add(fornecedor2);
            ListaFornecedor.Add(fornecedo3);

            return ListaFornecedor;
        }

        public List<Funcionario> ObterTotalListaFuncionarioPendentesPorDapatamento(string Departamentos)
        {
            throw new NotImplementedException();
        }
    }
}
