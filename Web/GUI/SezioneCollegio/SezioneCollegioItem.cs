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

namespace Web.GUI.SezioneCollegio
{
	public partial class SezioneCollegioItem : TemplateItem
	{
        public SezioneCollegioItem()
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

        private void SezioneCollegioItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new SezioneCollegioModel();
                    space.Title = "DETTAGLI SEZIONE COLLEGIO";
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
