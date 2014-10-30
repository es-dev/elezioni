using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Lista
{
	public partial class ListaView : TemplateView
	{
        public ListaView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ListaViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "LISTE";
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
                var space = new ListaModel();
                space.Title = "NUOVA LISTA";
                space.Model = new WcfService.Dto.ListaDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
