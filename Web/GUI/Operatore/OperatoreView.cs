using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Operatore
{
	public partial class OperatoreView : TemplateView
	{
        public OperatoreView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new OperatoreViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "OPERATORI";
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
                var space = new OperatoreModel();
                space.Title = "NUOVO OPERATORE";
                space.Model = new WcfService.Dto.OperatoreDto();
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
