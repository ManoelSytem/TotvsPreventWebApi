using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotvsPreventWebApi.Model
{
    public interface IFinaceiro
    {
        List<Caixa> ObterTotalCaixaPorDepartamento();
        List<Fornecedor> ObterTotalListaFornecedorApagar();
        List<Funcionario> ObterTotalListaFuncionarioPendentesPorDapatamento(string Departamentos);
    }
}
