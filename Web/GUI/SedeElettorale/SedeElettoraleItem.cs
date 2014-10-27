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

namespace Web.GUI.SedeElettorale
{
	public partial class SedeElettoraleItem : TemplateItem
	{
        public SedeElettoraleItem()
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

        private void SedeElettoraleItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new SedeElettoraleModel();
                    space.Title = "DETTAGLI SEDE ELETTORALE";
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
