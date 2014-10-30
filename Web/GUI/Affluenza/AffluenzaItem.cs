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

namespace Web.GUI.Affluenza
{
	public partial class AffluenzaItem : TemplateItem
	{
        public AffluenzaItem()
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

        private void AffluenzaItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new AffluenzaModel();
                    space.Title = "DETTAGLI AFFLUENZA";
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
