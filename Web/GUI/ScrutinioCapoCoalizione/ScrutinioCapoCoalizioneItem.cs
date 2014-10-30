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

namespace Web.GUI.ScrutinioCapoCoalizione
{
	public partial class ScrutinioCapoCoalizioneItem : TemplateItem
	{
        public ScrutinioCapoCoalizioneItem()
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

        private void ScrutinioCapoCoalizioneItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new ScrutinioCapoCoalizioneModel();
                    space.Title = "DETTAGLI SCRUTINIO CAPO COALIZIONE";
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
