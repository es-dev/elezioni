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

namespace Web.GUI.Comune
{
	public partial class ComuneItem : TemplateItem
	{
        public ComuneItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var objDto = (WcfService.Dto.ComuneDto)model;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ComuneItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new ComuneModel();
                    space.Title = "DETTAGLI COMUNE";
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
