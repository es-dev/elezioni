using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.ScrutinioLista
{
	public partial class ScrutinioListaView : TemplateView
	{
        public ScrutinioListaView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ScrutinioListaViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SCRUTINI LISTE";
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
                var space = new ScrutinioListaModel();
                space.Title = "NUOVO SCRUTINIO LISTA";
                space.Model = new WcfService.Dto.ScrutinioListaDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
