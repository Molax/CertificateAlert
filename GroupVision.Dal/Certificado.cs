using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupVision.Dal
{
    public class Certificado
    {
        //public void CadastraCertificado(string celular, DateTime data_emissao, DateTime data_vencimento, int fkEmpresa, string tipo)
        //{
        //    using (var db = new GroupVisionDataContext())
        //    {
        //        var verifica = db.Certificados.Where(c => c.TIPO == tipo && c.FK_EMPRESA == fkEmpresa && c.DATA_EMISSAO == data_emissao).ToList();

        //        if (verifica.Count > 0)
        //        {
        //            verifica.First().ATIVO = true;

        //            db.SubmitChanges();
        //        }

        //        else
        //        {
        //            var certificado = new Data.Certificado
        //            {
        //                ATIVO = true,
        //                CELULAR = celular,
        //                DATA_EMISSAO = data_emissao,
        //                DATA_ULT_ATT = DateTime.Now,
        //                DATA_VENCIMENTO = data_vencimento,
        //                FK_EMPRESA = fkEmpresa,
        //                ID_USUARIO_ULT_ATT = 1,
        //                TIPO = tipo

        //            };

        //            db.Certificados.InsertOnSubmit(certificado);

        //            db.SubmitChanges();
        //        }
        //    }
        //}

        //public List<Data.Certificado> SelecionaTodosCertificados()
        //{
        //    using (var db = new GroupVisionDataContext())
        //    {
        //        var certificados = db.Certificados.ToList();

        //        return certificados;
        //    }
        //}
    }
}
