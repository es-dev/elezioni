using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.SezioneCollegio
{
	public partial class SezioneCollegioView : TemplateView
	{
        public SezioneCollegioView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new SezioneCollegioViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SEZIONI COLLEGI";
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
                var space = new SezioneCollegioModel();
                space.Title = "NUOVA SEZIONE COLLEGIO";
                space.Model = new WcfService.Dto.ComuneDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
