using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores.Models
{
    public class Empresa
    {
        public List<EmpresaModel> ListaEmpresa  = new List<EmpresaModel>();

    public Empresa()
        {
            ListaEmpresa.Add(new EmpresaModel
            {
                IdEmpresa = 1,
                NomeFantasia = "Padaria 10",
                Uf = "SC",
                Cnpj = "1234567891012"
            });
        }

    public void CriaEmpresas(EmpresaModel empresamodel)
        {
            ListaEmpresa.Add(empresamodel);
        }

    public void AtualizarEmpresa(EmpresaModel empresamodel)
        {
            foreach (EmpresaModel empresa in ListaEmpresa)
            {
                if (empresa.IdEmpresa == empresamodel.IdEmpresa)
                {
                    ListaEmpresa.Remove(empresa);
                    ListaEmpresa.Add(empresamodel);
                    break;
                }
            }
        }

    public EmpresaModel GetEmpresa(int idEmpresa)
        {
            EmpresaModel _empresa = null;

            foreach (EmpresaModel empresa in ListaEmpresa)
            {
                if (empresa.IdEmpresa == idEmpresa)
                {
                    _empresa = empresa;
                }
            }

            return _empresa;
        }

    public void DeletarEmpresa(int idempresa)
        {
            foreach (EmpresaModel empresa in ListaEmpresa)
            {
                if (empresa.IdEmpresa == idempresa)
                {
                    ListaEmpresa.Remove(empresa);
                    break;
                }
            }
        }
    }
}
