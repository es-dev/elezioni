using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Operatore
{
	public partial class OperatoreModel : TemplateModel
	{
        public OperatoreModel()
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
                    var obj = (WcfService.Dto.OperatoreDto)model;
                    editAmministratore.Value = obj.Amministratore;
                    editCognome.Value = obj.Cognome;
                    editConfermaPassword.Value = obj.ConfermaPassword;
                    editEmail.Value = obj.Email;
                    editNome.Value = obj.Nome;
                    editNomeUtente.Value = obj.Username;
                    editPassword.Value = obj.Password;
                    editSupervisor.Value = obj.Supervisor;
                    editTelefono.Value = obj.Telefono;
                    editUtente.Value = obj.Utente;
                    var consultazione = obj.Consultazione;
                    if (consultazione!=null)
                    {
                        editConsultazione.Model = consultazione;
                        editConsultazione.Value = consultazione.Descrizione;
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
                var obj = (WcfService.Dto.OperatoreDto)model;
                obj.Amministratore = (bool)editAmministratore.Value;
                obj.Cognome = editCognome.Value;
                obj.ConfermaPassword = editConfermaPassword.Value;
                obj.Email = editEmail.Value;
                obj.Nome = editNome.Value;
                obj.Password = editPassword.Value;
                obj.Supervisor = (bool)editSupervisor.Value;
                obj.Telefono = editTelefono.Value;
                obj.Username = editNomeUtente.Value;
                obj.Utente = (bool)editUtente.Value;
                obj.ConsultazioneId = (int)editConsultazione.Id;
                obj.Consultazione = (WcfService.Dto.ConsultazioneDto)editConsultazione.Model;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editConsultazione_ComboClick()
        {
            var view = new Consultazione.ConsultazioneView();
            editConsultazione.Show(view);

        }

        private void editConsultazione_ComboConfirm(object model)
        {
            try
            {
                var consultazione = (WcfService.Dto.ConsultazioneDto)model;
                if (consultazione != null)
                    editConsultazione.Value = consultazione.Descrizione;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
