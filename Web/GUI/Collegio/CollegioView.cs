using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Collegio
{
	public partial class CollegioView : TemplateView
	{
        public CollegioView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new CollegioViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "COLLEGI";
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
                var space = new CollegioModel();
                space.Title = "NUOVO COLLEGIO";
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
