using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Sezione
{
	public partial class SezioneView : TemplateView
	{
        public SezioneView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new SezioneViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SEZIONI";
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
                var space = new SezioneModel();
                space.Title = "NUOVA SEZIONE";
                space.Model = new WcfService.Dto.SezioneDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
