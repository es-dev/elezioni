using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Consultazione
{
	public partial class ConsultazioneModel : TemplateModel
	{
        public ConsultazioneModel()
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
                    var obj = (WcfService.Dto.ConsultazioneDto)model;
                    editDescrizione.Value = obj.Descrizione;
                    editFine.Value = obj.DataFine;
                    editNumero.Value = obj.Numero;
                    editInizio.Value = obj.DataInizio;
                    editTipo.Value = obj.Tipo;
                    var comune = obj.Comune;
                    if (comune != null)
                    {
                        editComune.Model = comune;
                        editComune.Value = comune.Nome;
                    }
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
                var obj = (WcfService.Dto.ConsultazioneDto)model;
                obj.Descrizione = editDescrizione.Value ;
                obj.DataFine = (DateTime)editFine.Value;
                obj.Numero = editNumero.Value;
                obj.DataInizio =(DateTime)editInizio.Value;
                obj.Tipo = editTipo.Value;
                obj.ComuneId = (int)editComune.Id;
                obj.Comune = (WcfService.Dto.ComuneDto)editComune.Model;
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editComune_ComboClick()
        {
            try
            {
                var view = new Comune.ComuneView();
                editComune.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editComune_ComboConfirm(object model)
        {
            try
            {
                var comune = (WcfService.Dto.ComuneDto)model;
                if (comune != null)
                    editComune.Value = comune.Nome;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
