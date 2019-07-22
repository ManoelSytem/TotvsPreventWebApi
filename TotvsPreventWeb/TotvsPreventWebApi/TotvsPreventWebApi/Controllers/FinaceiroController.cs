using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TotvsPreventWebApi.Model;

namespace TotvsPreventWebApi.Controllers
{

    [Route("api/[controller]/[action]")]
    public class FinaceiroController 
    {
      
        private readonly IFinaceiro _finaceiroRepositorio;

        public FinaceiroController(IFinaceiro IFinaceiroRepositorio)
        {
            _finaceiroRepositorio = IFinaceiroRepositorio;
        }

        [HttpGet]
        public IEnumerable<Caixa> GetTotalCaixa()
        {
            return _finaceiroRepositorio.ObterTotalCaixaPorDepartamento();
        }

        [HttpGet]
        public IEnumerable<Fornecedor> GetApagarFornecedor()
        {
            return _finaceiroRepositorio.ObterTotalListaFornecedorApagar();
        }

    }
}