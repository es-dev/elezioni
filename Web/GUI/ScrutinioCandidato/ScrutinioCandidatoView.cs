using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.ScrutinioCandidato
{
	public partial class ScrutinioCandidatoView : TemplateView
	{
        public ScrutinioCandidatoView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ScrutinioCandidatoViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SCRUTINI CANDIDATI";
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
                var space = new ScrutinioCandidatoModel();
                space.Title = "NUOVO SCRUTINIO CANDIDATO";
                space.Model = new WcfService.Dto.ScrutinioCandidatoDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
