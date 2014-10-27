using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Consultazione
{
	public partial class ConsultazioneView : TemplateView
	{
        public ConsultazioneView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ConsultazioneViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "CONSULTAZIONI";
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
                var space = new ConsultazioneModel();
                space.Title = "NUOVA CONSULTAZIONE";
                space.Model = new WcfService.Dto.ConsultazioneDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
