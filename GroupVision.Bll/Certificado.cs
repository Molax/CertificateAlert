using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupVision.Dal;
using GroupVision.ViewModel;

namespace GroupVision.Bll
{
    public class Certificado
    {
        //public void CadastraCertificado(string celular, DateTime data_emissao, DateTime data_vencimento, int fkEmpresa, string tipo)
        //{
        //    new Dal.Certificado().CadastraCertificado(celular,data_emissao,data_vencimento,fkEmpresa,tipo);
        //}

        //public List<SelecionaTodosCertificados> SelecionaTodosCertificados()
        //{
        //    List<SelecionaTodosCertificados> rCertificado = new List<ViewModel.SelecionaTodosCertificados>();
        //    var x = new Dal.Certificado().SelecionaTodosCertificados();

        //    foreach (var item in x)
        //    {
        //        rCertificado.Add(new SelecionaTodosCertificados {
        //            celular = item.CELULAR,
        //            data_emissao = item.DATA_EMISSAO,
        //            data_vencimento = item.DATA_VENCIMENTO,
        //            empresa = new Bll.Empresa().SelecionaTodasEmpresas().First().nome,
        //            id = item.PK_ID_CERTIFICADO,
        //            tipo = item.TIPO,
        //            fkEmpresa = item.FK_EMPRESA,
        //            fkUsuario = item.ID_USUARIO_ULT_ATT
        //        });
        //    }

        //    return rCertificado;
        //}
    }
}
