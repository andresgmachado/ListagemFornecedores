using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores.Models
{
    public class EmpresaModel
    {
        public int IdEmpresa { get; set; }
        public string Uf { get; set; }
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }

    }
}
