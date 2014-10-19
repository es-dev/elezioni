using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        #region Comune
        #region CRUD
        public Dto.ComuneDto CreateComune(Dto.ComuneDto comune)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey= wcf.CreateComune(comune);
                var newComune = wcf.ReadComune(dtoKey);
                return newComune;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ComuneDto> ReadComuni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var comuni= wcf.ReadComunes();
                return comuni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateComune(Dto.ComuneDto comune)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateComune(comune);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteComune(Dto.ComuneDto comune)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteComune(comune);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountComuni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count= wcf.ComunesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Consultazione
        #region CRUD
        public Dto.ConsultazioneDto CreateConsultazione(Dto.ConsultazioneDto consultazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateConsultazione(consultazione);
                var newConsultazione = wcf.ReadConsultazione(dtoKey);
                return newConsultazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ConsultazioneDto> ReadConsultazioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var consultazioni = wcf.ReadConsultaziones();
                return consultazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateConsultazione(Dto.ConsultazioneDto consultazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateConsultazione(consultazione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteConsultazione(Dto.ConsultazioneDto consultazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteConsultazione(consultazione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountConsultazioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ConsultazionesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Operatore
        #region CRUD
        public Dto.OperatoreDto CreateOperatore(Dto.OperatoreDto operatore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateOperatore(operatore);
                var newOperatore = wcf.ReadOperatore(dtoKey);
                return newOperatore;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.OperatoreDto> ReadOperatori()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var operatori = wcf.ReadOperatores();
                return operatori;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateOperatore(Dto.OperatoreDto operatore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateOperatore(operatore);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteOperatore(Dto.OperatoreDto operatore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteOperatore(operatore);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountOperatori()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.OperatoresCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region SedeElettorale
        #region CRUD
        public Dto.SedeElettoraleDto CreateSedeElettorale(Dto.SedeElettoraleDto sedeElettorale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateSedeElettorale(sedeElettorale);
                var newSedeElettorale = wcf.ReadSedeElettorale(dtoKey);
                return newSedeElettorale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.SedeElettoraleDto> ReadSediElettorali()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var sediElettorali = wcf.ReadSedeElettorales();
                return sediElettorali;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateSedeElettorale(Dto.SedeElettoraleDto sedeElettorale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateSedeElettorale(sedeElettorale);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteSedeElettorale(Dto.SedeElettoraleDto sedeElettorale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteSedeElettorale(sedeElettorale);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountSediElettorali()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.SedeElettoralesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Sezione
        #region CRUD
        public Dto.SezioneDto CreateSezione(Dto.SezioneDto sezione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateSezione(sezione);
                var newSezione = wcf.ReadSezione(dtoKey);
                return newSezione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.SezioneDto> ReadSezioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var sezioni = wcf.ReadSeziones();
                return sezioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateSezione(Dto.SezioneDto sezione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateSezione(sezione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteSezione(Dto.SezioneDto sezione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteSezione(sezione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountSezioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.SezionesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Collegio
        #region CRUD
        public Dto.CollegioDto CreateCollegio(Dto.CollegioDto collegio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCollegio(collegio);
                var newCollegio = wcf.ReadCollegio(dtoKey);
                return newCollegio;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CollegioDto> ReadCollegi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var collegi = wcf.ReadCollegios();
                return collegi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCollegio(Dto.CollegioDto collegio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCollegio(collegio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCollegio(Dto.CollegioDto collegio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCollegio(collegio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountCollegi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.CollegiosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region SezioneCollegio
        #region CRUD
        public Dto.SezioneCollegioDto CreateSezioneCollegio(Dto.SezioneCollegioDto sezioneCollegio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateSezioneCollegio(sezioneCollegio);
                var newSezioneCollegio = wcf.ReadSezioneCollegio(dtoKey);
                return newSezioneCollegio;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.SezioneCollegioDto> ReadSezioniCollegio()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var sezioneCollegi = wcf.ReadSezioneCollegios();
                return sezioneCollegi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateSezioneCollegio(Dto.SezioneCollegioDto sezioneCollegio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateSezioneCollegio(sezioneCollegio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteSezioneCollegio(Dto.SezioneCollegioDto sezioneCollegio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteSezioneCollegio(sezioneCollegio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountSezioniCollegio()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.SezioneCollegiosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion
                
        #region Affluenza
        #region CRUD

        public Dto.AffluenzaDto CreateAffluenza(Dto.AffluenzaDto affluenza)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAffluenza(affluenza);
                var newAffluenza = wcf.ReadAffluenza(dtoKey);
                return newAffluenza;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AffluenzaDto> ReadAffluenze()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var affluenze = wcf.ReadAffluenzas();
                return affluenze;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAffluenza(Dto.AffluenzaDto affluenza)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAffluenza(affluenza);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAffluenza(Dto.AffluenzaDto affluenza)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAffluenza(affluenza);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAffluenze()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AffluenzasCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Rilevamento
        #region CRUD

        public Dto.RilevamentoDto CreateRilevamento(Dto.RilevamentoDto rilevamento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateRilevamento(rilevamento);
                var newRilevamento = wcf.ReadRilevamento(dtoKey);
                return newRilevamento;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.RilevamentoDto> ReadRilevamenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var rilevamenti = wcf.ReadRilevamentos();
                return rilevamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateRilevamento(Dto.RilevamentoDto rilevamento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateRilevamento(rilevamento);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteRilevamento(Dto.RilevamentoDto rilevamento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteRilevamento(rilevamento);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountRilevamenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.RilevamentosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Scrutinio
        #region CRUD

        public Dto.ScrutinioDto CreateScrutinio(Dto.ScrutinioDto scrutinio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateScrutinio(scrutinio);
                var newScrutinio = wcf.ReadScrutinio(dtoKey);
                return newScrutinio;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ScrutinioDto> ReadScrutini()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var scrutini = wcf.ReadScrutinios();
                return scrutini;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateScrutinio(Dto.ScrutinioDto scrutinio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateScrutinio(scrutinio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteScrutinio(Dto.ScrutinioDto scrutinio)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteScrutinio(scrutinio);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountScrutini()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ScrutiniosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region CapoCoalizione
        #region CRUD
        public Dto.CapoCoalizioneDto CreateCapoCoalizione(Dto.CapoCoalizioneDto capoCoalizione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCapoCoalizione(capoCoalizione);
                var newCapoCoalizione = wcf.ReadCapoCoalizione(dtoKey);
                return newCapoCoalizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CapoCoalizioneDto> ReadCapiCoalizioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var capiCoalizioni = wcf.ReadCapoCoaliziones();
                return capiCoalizioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCapoCoalizione(Dto.CapoCoalizioneDto capoCoalizione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCapoCoalizione(capoCoalizione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCapoCoalizione(Dto.CapoCoalizioneDto capoCoalizione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCapoCoalizione(capoCoalizione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountCapiCoalizioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.CapoCoalizionesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region ScrutinioCapoCoalizione
        #region CRUD

        public Dto.ScrutinioCapoCoalizioneDto CreateScrutinioCapoCoalizione(Dto.ScrutinioCapoCoalizioneDto scrutinioCapoCoalizione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateScrutinioCapoCoalizione(scrutinioCapoCoalizione);
                var newScrutinioCapoCoalizione = wcf.ReadScrutinioCapoCoalizione(dtoKey);
                return newScrutinioCapoCoalizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ScrutinioCapoCoalizioneDto> ReadScrutiniCapoCoalizione()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var scrutiniCapoCoalizione = wcf.ReadScrutinioCapoCoaliziones();
                return scrutiniCapoCoalizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateScrutinioCapoCoalizione(Dto.ScrutinioCapoCoalizioneDto scrutinioCapoCoalizione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateScrutinioCapoCoalizione(scrutinioCapoCoalizione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteScrutinioCapoCoalizione(Dto.ScrutinioCapoCoalizioneDto scrutinioCapoCoalizione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteScrutinioCapoCoalizione(scrutinioCapoCoalizione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountScrutiniCapoCoalizione()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ScrutinioCapoCoalizionesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Lista
        #region CRUD
        public Dto.ListaDto CreateLista(Dto.ListaDto lista)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateLista(lista);
                var newLista = wcf.ReadLista(dtoKey);
                return newLista;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ListaDto> ReadListe()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var liste = wcf.ReadListas();
                return liste;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateLista(Dto.ListaDto lista)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateLista(lista);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteLista(Dto.ListaDto lista)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteLista(lista);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountListe()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ListasCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region ScrutinioLista
        #region CRUD

        public Dto.ScrutinioListaDto CreateScrutinioLista(Dto.ScrutinioListaDto scrutinioLista)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateScrutinioLista(scrutinioLista);
                var newScrutinioLista = wcf.ReadScrutinioLista(dtoKey);
                return newScrutinioLista;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ScrutinioListaDto> ReadScrutiniLista()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var scrutiniLista = wcf.ReadScrutinioListas();
                return scrutiniLista;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateScrutinioLista(Dto.ScrutinioListaDto scrutinioLista)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateScrutinioLista(scrutinioLista);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteScrutinioLista(Dto.ScrutinioListaDto scrutinioLista)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteScrutinioLista(scrutinioLista);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountScrutiniLista()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ScrutinioListasCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region Candidato
        #region CRUD
        public Dto.CandidatoDto CreateCandidato(Dto.CandidatoDto candidato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCandidato(candidato);
                var newCandidato = wcf.ReadCandidato(dtoKey);
                return newCandidato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CandidatoDto> ReadCandidati()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var candidati = wcf.ReadCandidatos();
                return candidati;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCandidato(Dto.CandidatoDto candidato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCandidato(candidato);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCandidato(Dto.CandidatoDto candidato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCandidato(candidato);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountCandidati()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.CandidatosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion

        #region ScrutinioCandidato
        #region CRUD

        public Dto.ScrutinioCandidatoDto CreateScrutinioCandidato(Dto.ScrutinioCandidatoDto scrutinioCandidato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateScrutinioCandidato(scrutinioCandidato);
                var newScrutinioCandidato = wcf.ReadScrutinioCandidato(dtoKey);
                return newScrutinioCandidato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ScrutinioCandidatoDto> ReadScrutiniCandidato()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var scrutiniCandidato = wcf.ReadScrutinioCandidatos();
                return scrutiniCandidato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateScrutinioCandidato(Dto.ScrutinioCandidatoDto scrutinioCandidato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateScrutinioCandidato(scrutinioCandidato);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteScrutinioCandidato(Dto.ScrutinioCandidatoDto scrutinioCandidato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteScrutinioCandidato(scrutinioCandidato);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountScrutiniCandidato()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ScrutinioCandidatosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        #endregion
        #endregion


    }
}
