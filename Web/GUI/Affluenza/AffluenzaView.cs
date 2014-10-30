using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Affluenza
{
	public partial class AffluenzaView : TemplateView
	{
        public AffluenzaView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new AffluenzaViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "AFFLUENZE";
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
                var space = new AffluenzaModel();
                space.Title = "NUOVA AFFLUENZA";
                space.Model = new WcfService.Dto.AffluenzaDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
