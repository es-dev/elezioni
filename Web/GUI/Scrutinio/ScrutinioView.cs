using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Scrutinio
{
	public partial class ScrutinioView : TemplateView
	{
        public ScrutinioView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ScrutinioViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SCRUTINI";
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
                var space = new ScrutinioModel();
                space.Title = "NUOVO SCRUTINIO";
                space.Model = new WcfService.Dto.ScrutinioDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
