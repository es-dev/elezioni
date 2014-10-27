using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Comune
{
	public partial class ComuneView : TemplateView
	{
        public ComuneView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ComuneViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "DISTRETTI";
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
                var space = new ComuneModel();
                space.Title = "NUOVO COMUNE";
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
