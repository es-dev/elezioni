using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Comune
{
	public partial class ComuneModel : TemplateModel
	{
        public ComuneModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var objDto = (DataLayer.Comune)model;
                    editNome.Value = objDto.Nome;
                    editDescrizione.Value = objDto.Descrizione;
                    editCodiceISTAT.Value = objDto.CodiceISTAT;
                    editNumeroSezioni.Value = objDto.NumeroSezioni;
                    editProvincia.Value = objDto.Provincia;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                var objDto = (DataLayer.Comune)model;
                objDto.Nome = (string)editNome.Value;
                objDto.Descrizione= (string)editDescrizione.Value;
                objDto.CodiceISTAT=(string)editCodiceISTAT.Value;
                objDto.NumeroSezioni=(int)editNumeroSezioni.Value;
                objDto.Provincia= (string)editProvincia.Value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
