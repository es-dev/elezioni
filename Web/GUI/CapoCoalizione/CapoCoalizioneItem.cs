using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.CapoCoalizione
{
	public partial class CapoCoalizioneItem : TemplateItem
	{
        public CapoCoalizioneItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CapoCoalizioneItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new CapoCoalizioneModel();
                    space.Title = "DETTAGLI CAPO COALIZIONE";
                    AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
	}
}
