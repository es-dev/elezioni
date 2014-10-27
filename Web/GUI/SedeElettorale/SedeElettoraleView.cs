using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.SedeElettorale
{
	public partial class SedeElettoraleView : TemplateView
	{
        public SedeElettoraleView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new SedeElettoraleViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SEDI ELETTORALI";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var space = new SedeElettoraleModel();
                space.Title = "NUOVA SEDE ELETTORALE";
                space.Model = new WcfService.Dto.SedeElettoraleDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
