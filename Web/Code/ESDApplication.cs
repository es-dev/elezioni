using Library.Code;
using Library.Template.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Code
{
    public class ESDApplication
    {
        internal static void Init(TemplateBase view)
        {
            try
            {
                view.Title = "ENTERPRISE MANAGER - ESD";
                view.Version = "Versione software beta 1";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}