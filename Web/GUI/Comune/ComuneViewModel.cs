using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Comune
{
    public class ComuneViewModel : Library.Template.MVVM.TemplateViewModel<ComuneDto, ComuneItem>
    {

        public ComuneViewModel(ISpace space)
            : base(space) 
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void Load(int skip, int take)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objDtos = wcf.LoadComuni(skip, take);
                Load(objDtos);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int GetCount()
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountComuni();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public override bool Save(object model, bool creating)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var objDto = (ComuneDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        object key = wcf.CreateComune(objDto);
                        performed = (key != null);
                        if (performed)
                            objDto.Id = (int)key;
                    }
                    else //updating
                        performed = wcf.UpdateComune(objDto);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override bool Delete(object model)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var objDto = (ComuneDto)model;
                    bool performed = wcf.DeleteComune(objDto);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override object Read(object model)
        {
            try
            {
                if (model != null)
                {
                    //var wcf = new WcfService.Service();
                    //var objDto = (ComuneDto)model;
                    //var objFkDto = wcf.ReadComune(objDto);
                    //return objFkDto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}