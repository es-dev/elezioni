using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.CapoCoalizione
{
	public partial class CapoCoalizioneView : TemplateView
	{
        public CapoCoalizioneView()
		{ 
			InitializeComponent();
		}

        public override void Init()
        {
            try
            {
                Take = 10;
                ViewModel = new CapoCoalizioneViewModel(this);
                TitleSpace = "ENTERPRISE MANAGER - ESD";
                Title = "CAPI COALIZIONI";
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
                var space = new CapoCoalizioneModel();
                space.Title = "NUOVO CAPO COALIZIONE";
                space.Model = new WcfService.Dto.CapoCoalizioneDto() ;
                AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

	}
}
