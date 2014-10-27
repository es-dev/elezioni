using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Sezione
{
    public class SezioneViewModel : Library.Template.MVVM.TemplateViewModel<SezioneDto, SezioneItem>
    {

        public SezioneViewModel(ISpace space)
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
                var objDtos = wcf.LoadSezioni(skip, take);
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
                var count = wcf.CountSezioni();
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
                    var objDto = (SezioneDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        object key = wcf.CreateSezione(objDto);
                        performed = (key != null);
                        if (performed)
                            objDto.Id = (int)key;
                    }
                    else //updating
                        performed = wcf.UpdateSezione(objDto);
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
                    var objDto = (SezioneDto)model;
                    bool performed = wcf.DeleteSezione(objDto);
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
                    //var objDto = (SezioneDto)model;
                    //var objFkDto = wcf.ReadSezione(objDto);
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