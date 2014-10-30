using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.ScrutinioCapoCoalizione
{
	public partial class ScrutinioCapoCoalizioneView : TemplateView
	{
        public ScrutinioCapoCoalizioneView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new ScrutinioCapoCoalizioneViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "SCRUTINI CAPI COALIZIONI";
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
                var space = new ScrutinioCapoCoalizioneModel();
                space.Title = "NUOVO SCRUTINIO CAPO COALIZIONE";
                space.Model = new WcfService.Dto.ScrutinioCapoCoalizioneDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
