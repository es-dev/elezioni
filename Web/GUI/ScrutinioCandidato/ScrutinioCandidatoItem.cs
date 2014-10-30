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

namespace Web.GUI.ScrutinioCandidato
{
	public partial class ScrutinioCandidatoItem : TemplateItem
	{
        public ScrutinioCandidatoItem()
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

        private void ScrutinioCandidatoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new ScrutinioCandidatoModel();
                    space.Title = "DETTAGLI SCRUTINIO CANDIDATO";
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
