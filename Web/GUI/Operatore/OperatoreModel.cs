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
                var obj = (WcfService.Dto.ComuneDto)model;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
