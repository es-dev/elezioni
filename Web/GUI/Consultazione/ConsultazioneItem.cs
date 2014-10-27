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

namespace Web.GUI.Consultazione
{
	public partial class ConsultazioneItem : TemplateItem
	{
        public ConsultazioneItem()
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

        private void ConsultazioneItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new ConsultazioneModel();
                    space.Title = "DETTAGLI CONSULTAZIONE";
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
