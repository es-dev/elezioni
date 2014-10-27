using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Operatore
{
    public class OperatoreViewModel : Library.Template.MVVM.TemplateViewModel<OperatoreDto, OperatoreItem>
    {

        public OperatoreViewModel(ISpace space)
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
                var objDtos = wcf.LoadOperatori(skip, take);
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
                var count = wcf.CountOperatori();
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
                    var objDto = (OperatoreDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        object key = wcf.CreateOperatore(objDto);
                        performed = (key != null);
                        if (performed)
                            objDto.Id = (int)key;
                    }
                    else //updating
                        performed = wcf.UpdateOperatore(objDto);
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
                    var objDto = (OperatoreDto)model;
                    bool performed = wcf.DeleteOperatore(objDto);
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
                    //var objDto = (OperatoreDto)model;
                    //var objFkDto = wcf.ReadOperatore(objDto);
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