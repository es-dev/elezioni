using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Candidato
{
	public partial class CandidatoView : TemplateView
	{
        public CandidatoView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new CandidatoViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "CANDIDATI";
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
                var space = new CandidatoModel();
                space.Title = "NUOVO CANDIDATO";
                space.Model = new WcfService.Dto.CandidatoDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
