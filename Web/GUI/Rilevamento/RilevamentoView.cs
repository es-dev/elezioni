using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Rilevamento
{
	public partial class RilevamentoView : TemplateView
	{
        public RilevamentoView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new RilevamentoViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "RILEVAMENTI";
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
                var space = new RilevamentoModel();
                space.Title = "NUOVO RILEVAMENTO";
                space.Model = new WcfService.Dto.RilevamentoDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
