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
        public IEnumerable<Dto.ComuneDto> LoadComuni(int skip, int take, string search=null)
        {
            try
            {
                var comuni = QueryComuni(search);
                comuni = (from q in comuni select q).Skip(skip).Take(take);
                var engine = new Assemblers.ComuneAssembler();
                var _comuni= engine.Assemble(comuni);
                return _comuni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountComuni(string search=null)
        {
            try
            {
                var comuni = QueryComuni(search);
                var count = comuni.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ComuneDto ReadComune(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var comune = wcf.ReadComune("Id=" + Id);
                return comune;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Comune> QueryComuni(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var comuni = (from q in ef.Comunes select q);
                if (search != null)
                    comuni = (from q in comuni where q.Nome.StartsWith(search) select q);
                comuni = (from q in comuni orderby q.Nome select q);
                return comuni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.ConsultazioneDto> LoadConsultazioni(int skip, int take, string search = null)
        {
            try
            {
                var consultazioni = QueryConsultazioni(search);
                consultazioni = (from q in consultazioni select q).Skip(skip).Take(take);
                var engine = new Assemblers.ConsultazioneAssembler();
                var consultazioniDto = new List<Dto.ConsultazioneDto>();
                foreach(var consultazione in consultazioni)
                {
                    var consultazioneDto = engine.Assemble(consultazione);
                    engine.AssembleNavigational(consultazione, consultazioneDto);
                    consultazioniDto.Add(consultazioneDto);
                }
                return consultazioniDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountConsultazioni(string search = null)
        {
            try
            {
                var consultazioni = QueryConsultazioni(search);
                var count = consultazioni.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ConsultazioneDto ReadConsultazione(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var consultazione = wcf.ReadConsultazione("Id=" + Id);
                return consultazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        
        private IQueryable<DataLayer.Consultazione> QueryConsultazioni(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var consultazioni = (from q in ef.Consultaziones select q);
                if (search != null)
                    consultazioni = (from q in consultazioni where q.Descrizione.StartsWith(search) select q);
                consultazioni = (from q in consultazioni orderby q.Descrizione select q);
                return consultazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

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
        public IEnumerable<Dto.OperatoreDto> LoadOperatori(int skip, int take, string search = null)
        {
            try
            {
                var operatori = QueryOperatori(search);
                operatori = (from q in operatori select q).Skip(skip).Take(take);
                var engine = new Assemblers.OperatoreAssembler();
                var operatoriDto = new List<Dto.OperatoreDto>();
                foreach (var operatore in operatori)
                {
                    var operatoreDto = engine.Assemble(operatore);
                    engine.AssembleNavigational(operatore, operatoreDto);
                    operatoriDto.Add(operatoreDto);
                }
                return operatoriDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountOperatori(string search = null)
        {
            try
            {
                var operatori = QueryOperatori(search);
                var count = operatori.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.OperatoreDto ReadOperatore(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var operatore = wcf.ReadOperatore("Id=" + Id);
                return operatore;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Operatore> QueryOperatori(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var operatori = (from q in ef.Operatores select q);
                if (search != null)
                    operatori = (from q in operatori where (q.Cognome.StartsWith(search) || q.Nome.StartsWith(search)) select q);
                operatori = (from q in operatori orderby q.Cognome select q);
                return operatori;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        
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
        public IEnumerable<Dto.SedeElettoraleDto> LoadSediElettorali(int skip, int take, string search = null)
        {
            try
            {
                var sediElettorali = QuerySediElettorali(search);
                sediElettorali = (from q in sediElettorali select q).Skip(skip).Take(take);
                var engine = new Assemblers.SedeElettoraleAssembler();
                var sediElettoraliDto = new List<Dto.SedeElettoraleDto>();
                foreach (var sedeElettorale in sediElettorali)
                {
                    var sedeElettoraleDto = engine.Assemble(sedeElettorale);
                    engine.AssembleNavigational(sedeElettorale, sedeElettoraleDto);
                    sediElettoraliDto.Add(sedeElettoraleDto);
                }
                return sediElettoraliDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountSediElettorali(string search = null)
        {
            try
            {
                var sediElettorali = QuerySediElettorali(search);
                var count = sediElettorali.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.SedeElettoraleDto ReadSedeElettorale(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var sedeElettorale = wcf.ReadSedeElettorale("Id=" + Id);
                return sedeElettorale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.SedeElettorale> QuerySediElettorali(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var sediElettorali = (from q in ef.SedeElettorales select q);
                if (search != null)
                    sediElettorali = (from q in sediElettorali where (q.Indirizzo.StartsWith(search)) select q);
                sediElettorali = (from q in sediElettorali orderby q.Indirizzo select q);
                return sediElettorali;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

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
        public IEnumerable<Dto.SezioneDto> LoadSezioni(int skip, int take, string search = null)
        {
            try
            {
                var sezioni = QuerySezioni(search);
                sezioni = (from q in sezioni select q).Skip(skip).Take(take);
                var engine = new Assemblers.SezioneAssembler();
                var sezioniDto = new List<Dto.SezioneDto>();
                foreach (var sezione in sezioni)
                {
                    var sezioneDto = engine.Assemble(sezione);
                    engine.AssembleNavigational(sezione, sezioneDto);
                    sezioniDto.Add(sezioneDto);
                }
                return sezioniDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountSezioni(string search = null)
        {
            try
            {
                var sezioni = QuerySezioni(search);
                var count = sezioni.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.SezioneDto ReadSezione(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var sezione = wcf.ReadSezione("Id=" + Id);
                return sezione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Sezione> QuerySezioni(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var sezioni = (from q in ef.Seziones select q);
                if (search != null)
                    sezioni = (from q in sezioni where (q.Numero.StartsWith(search)) select q);
                sezioni = (from q in sezioni orderby q.Numero select q);
                return sezioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

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
        public IEnumerable<Dto.CollegioDto> LoadCollegi(int skip, int take, string search = null)
        {
            try
            {
                var collegi = QueryCollegi(search);
                collegi = (from q in collegi select q).Skip(skip).Take(take);
                var engine = new Assemblers.CollegioAssembler();
                var collegiDto = new List<Dto.CollegioDto>();
                foreach (var collegio in collegi)
                {
                    var collegioDto = engine.Assemble(collegio);
                    engine.AssembleNavigational(collegio, collegioDto);
                    collegiDto.Add(collegioDto);
                }
                return collegiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountCollegi(string search = null)
        {
            try
            {
                var collegi = QueryCollegi(search);
                var count = collegi.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CollegioDto ReadCollegio(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var collegio = wcf.ReadCollegio("Id=" + Id);
                return collegio;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Collegio> QueryCollegi(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var collegi = (from q in ef.Collegios select q);
                if (search != null)
                    collegi = (from q in collegi where (q.Descrizione.StartsWith(search)) select q);
                collegi = (from q in collegi orderby q.Descrizione select q);
                return collegi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.SezioneCollegioDto> LoadSezioniCollegi(int skip, int take, string search = null)
        {
            try
            {
                var sezioniCollegi = QuerySezioniCollegi(search);
                sezioniCollegi = (from q in sezioniCollegi select q).Skip(skip).Take(take);
                var engine = new Assemblers.SezioneCollegioAssembler();
                var sezioniCollegiDto = new List<Dto.SezioneCollegioDto>();
                foreach (var sezioneCollegio in sezioniCollegi)
                {
                    var sezioneCollegioDto = engine.Assemble(sezioneCollegio);
                    engine.AssembleNavigational(sezioneCollegio, sezioneCollegioDto);
                    sezioniCollegiDto.Add(sezioneCollegioDto);
                }
                return sezioniCollegiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountSezioniCollegi(string search = null)
        {
            try
            {
                var sezioniCollegi = QuerySezioniCollegi(search);
                var count = sezioniCollegi.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.SezioneCollegioDto ReadSezioneCollegio(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var sezioneCollegio = wcf.ReadSezioneCollegio("Id=" + Id);
                return sezioneCollegio;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.SezioneCollegio> QuerySezioniCollegi(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var sezioniCollegi = (from q in ef.SezioneCollegios select q);
                //if (search != null)
                //    sezioniCollegi = (from q in sezioniCollegi where (q.Descrizione.StartsWith(search)) select q);
                sezioniCollegi = (from q in sezioniCollegi orderby q.Id select q);
                return sezioniCollegi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.AffluenzaDto> LoadAffluenze(int skip, int take, string search = null)
        {
            try
            {
                var affluenze = QueryAffluenze(search);
                affluenze = (from q in affluenze select q).Skip(skip).Take(take);
                var engine = new Assemblers.AffluenzaAssembler();
                var affluenzeDto = new List<Dto.AffluenzaDto>();
                foreach (var affluenza in affluenze)
                {
                    var affluenzaDto = engine.Assemble(affluenza);
                    engine.AssembleNavigational(affluenza, affluenzaDto);
                    affluenzeDto.Add(affluenzaDto);
                }
                return affluenzeDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAffluenze(string search = null)
        {
            try
            {
                var affluenze = QueryAffluenze(search);
                var count = affluenze.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AffluenzaDto ReadAffluenza(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var affluenza = wcf.ReadAffluenza("Id=" + Id);
                return affluenza;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Affluenza> QueryAffluenze(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var affluenze = (from q in ef.Affluenzas select q);
                //if (search != null)
                //    affluenze = (from q in affluenze where (q.Orario.StartsWith(search)) select q);
                affluenze = (from q in affluenze orderby q.Orario select q);
                return affluenze;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.RilevamentoDto> LoadRilevamenti(int skip, int take, string search = null)
        {
            try
            {
                var rilevamenti = QueryRilevamenti(search);
                rilevamenti = (from q in rilevamenti select q).Skip(skip).Take(take);
                var engine = new Assemblers.RilevamentoAssembler();
                var rilevamentiDto = new List<Dto.RilevamentoDto>();
                foreach (var rilevamento in rilevamenti)
                {
                    var rilevamentoDto = engine.Assemble(rilevamento);
                    engine.AssembleNavigational(rilevamento, rilevamentoDto);
                    rilevamentiDto.Add(rilevamentoDto);
                }
                return rilevamentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountRilevamenti(string search = null)
        {
            try
            {
                var rilevamenti = QueryRilevamenti(search);
                var count = rilevamenti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.RilevamentoDto ReadRilevamento(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var rilevamento = wcf.ReadRilevamento("Id=" + Id);
                return rilevamento;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Rilevamento> QueryRilevamenti(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var rilevamenti = (from q in ef.Rilevamentos select q);
                //if (search != null)
                //    affluenze = (from q in affluenze where (q.Orario.StartsWith(search)) select q);
                rilevamenti = (from q in rilevamenti orderby q.Id select q);
                return rilevamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.ScrutinioDto> LoadScrutini(int skip, int take, string search = null)
        {
            try
            {
                var scrutini = QueryScrutini(search);
                scrutini = (from q in scrutini select q).Skip(skip).Take(take);
                var engine = new Assemblers.ScrutinioAssembler();
                var scrutiniDto = new List<Dto.ScrutinioDto>();
                foreach (var scrutinio in scrutini)
                {
                    var scrutinioDto = engine.Assemble(scrutinio);
                    engine.AssembleNavigational(scrutinio, scrutinioDto);
                    scrutiniDto.Add(scrutinioDto);
                }
                return scrutiniDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountScrutini(string search = null)
        {
            try
            {
                var scrutini = QueryScrutini(search);
                var count = scrutini.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ScrutinioDto ReadScrutinio(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var scrutinio = wcf.ReadScrutinio("Id=" + Id);
                return scrutinio;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Scrutinio> QueryScrutini(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var scrutini = (from q in ef.Scrutinios  select q);
                //if (search != null)
                //    affluenze = (from q in affluenze where (q.Orario.StartsWith(search)) select q);
                scrutini = (from q in scrutini orderby q.Id select q);
                return scrutini;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.CapoCoalizioneDto> LoadCapiCoalizioni(int skip, int take, string search = null)
        {
            try
            {
                var capiCoalizioni = QueryCapiCoalizioni(search);
                capiCoalizioni = (from q in capiCoalizioni select q).Skip(skip).Take(take);
                var engine = new Assemblers.CapoCoalizioneAssembler();
                var capiCoalizioniDto = new List<Dto.CapoCoalizioneDto>();
                foreach (var capoCoalizione in capiCoalizioni)
                {
                    var capoCoalizioneDto = engine.Assemble(capoCoalizione);
                    engine.AssembleNavigational(capoCoalizione, capoCoalizioneDto);
                    capiCoalizioniDto.Add(capoCoalizioneDto);
                } 
                return capiCoalizioniDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountCapiCoalizioni(string search = null)
        {
            try
            {
                var capiCoalizioni = QueryCapiCoalizioni(search);
                var count = capiCoalizioni.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CapoCoalizioneDto ReadCapoCoalizione(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var capoCoalizione = wcf.ReadCapoCoalizione("Id=" + Id);
                return capoCoalizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.CapoCoalizione> QueryCapiCoalizioni(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var capiCoalizioni = (from q in ef.CapoCoaliziones select q);
                if (search != null)
                    capiCoalizioni = (from q in capiCoalizioni where (q.Descrizione.StartsWith(search)) select q);
                capiCoalizioni = (from q in capiCoalizioni orderby q.Descrizione select q);
                return capiCoalizioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.ScrutinioCapoCoalizioneDto> LoadScrutiniCapoCoalizione(int skip, int take, string search = null)
        {
            try
            {
                var scrutiniCapoCoalizione = QueryScrutiniCapoCoalizione(search);
                scrutiniCapoCoalizione = (from q in scrutiniCapoCoalizione select q).Skip(skip).Take(take);
                var engine = new Assemblers.ScrutinioCapoCoalizioneAssembler();
                var scrutiniCapoCoalizioneDto = new List<Dto.ScrutinioCapoCoalizioneDto>();
                foreach (var scrutinioCapoCoalizione in scrutiniCapoCoalizione)
                {
                    var scrutinioCapoCoalizioneDto = engine.Assemble(scrutinioCapoCoalizione);
                    engine.AssembleNavigational(scrutinioCapoCoalizione, scrutinioCapoCoalizioneDto);
                    scrutiniCapoCoalizioneDto.Add(scrutinioCapoCoalizioneDto);
                }
                return scrutiniCapoCoalizioneDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountScrutiniCapoCoalizione(string search = null)
        {
            try
            {
                var scrutiniCapoCoalizione = QueryScrutiniCapoCoalizione(search);
                var count = scrutiniCapoCoalizione.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ScrutinioCapoCoalizioneDto ReadScrutinioCapoCoalizione(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var capoCoalizione = wcf.ReadScrutinioCapoCoalizione("Id=" + Id);
                return capoCoalizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.ScrutinioCapoCoalizione> QueryScrutiniCapoCoalizione(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var scrutiniCapoCoalizione = (from q in ef.ScrutinioCapoCoaliziones select q);
                //if (search != null)
                //    scrutiniCapoCoalizione = (from q in scrutiniCapoCoalizione where (q.Descrizione.StartsWith(search)) select q);
                scrutiniCapoCoalizione = (from q in scrutiniCapoCoalizione orderby q.Id select q);
                return scrutiniCapoCoalizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.ListaDto> LoadListe(int skip, int take, string search = null)
        {
            try
            {
                var liste = QueryListe(search);
                liste = (from q in liste select q).Skip(skip).Take(take);
                var engine = new Assemblers.ListaAssembler();
                var listeDto = new List<Dto.ListaDto>();
                foreach (var lista in liste)
                {
                    var listaDto = engine.Assemble(lista);
                    engine.AssembleNavigational(lista, listaDto);
                    listeDto.Add(listaDto);
                }
                return listeDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountListe(string search = null)
        {
            try
            {
                var liste = QueryListe(search);
                var count = liste.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ListaDto ReadLista(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var lista = wcf.ReadLista("Id=" + Id);
                return lista;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Lista> QueryListe(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var liste = (from q in ef.Listas select q);
                if (search != null)
                    liste = (from q in liste where (q.Descrizione.StartsWith(search)) select q);
                liste = (from q in liste orderby q.Descrizione select q);
                return liste;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.ScrutinioListaDto> LoadScrutiniLista(int skip, int take, string search = null)
        {
            try
            {
                var scrutiniLista = QueryScrutiniLista(search);
                scrutiniLista = (from q in scrutiniLista select q).Skip(skip).Take(take);
                var engine = new Assemblers.ScrutinioListaAssembler();
                var scrutiniListaDto = new List<Dto.ScrutinioListaDto>();
                foreach (var scrutinioLista in scrutiniLista)
                {
                    var scrutinioListaDto = engine.Assemble(scrutinioLista);
                    engine.AssembleNavigational(scrutinioLista, scrutinioListaDto);
                    scrutiniListaDto.Add(scrutinioListaDto);
                }
                return scrutiniListaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountScrutiniLista(string search = null)
        {
            try
            {
                var scrutiniLista = QueryScrutiniLista(search);
                var count = scrutiniLista.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ScrutinioListaDto ReadScrutinioLista(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var scrutinioLista = wcf.ReadScrutinioLista("Id=" + Id);
                return scrutinioLista;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.ScrutinioLista> QueryScrutiniLista(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var scrutiniLista = (from q in ef.ScrutinioListas select q);
                //if (search != null)
                //    scrutiniLista = (from q in scrutiniLista where (q.Descrizione.StartsWith(search)) select q);
                scrutiniLista = (from q in scrutiniLista orderby q.Id select q);
                return scrutiniLista;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.CandidatoDto> LoadCandidati(int skip, int take, string search = null)
        {
            try
            {
                var candidati = QueryCandidati(search);
                candidati = (from q in candidati select q).Skip(skip).Take(take);
                var engine = new Assemblers.CandidatoAssembler();
                var candidatiDto = new List<Dto.CandidatoDto>();
                foreach (var candidato in candidati)
                {
                    var candidatoDto = engine.Assemble(candidato);
                    engine.AssembleNavigational(candidato, candidatoDto);
                    candidatiDto.Add(candidatoDto);
                }
                return candidatiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountCandidati(string search = null)
        {
            try
            {
                var candidati = QueryCandidati(search);
                var count = candidati.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CandidatoDto ReadCandidato(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var candidato = wcf.ReadCandidato("Id=" + Id);
                return candidato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Candidato> QueryCandidati(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var candidati = (from q in ef.Candidatos select q);
                if (search != null)
                    candidati = (from q in candidati where (q.Cognome.StartsWith(search) || q.Nome.StartsWith(search)) select q);
                candidati = (from q in candidati orderby q.Cognome select q);
                return candidati;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
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
        public IEnumerable<Dto.ScrutinioCandidatoDto> LoadScrutiniCandidato(int skip, int take, string search = null)
        {
            try
            {
                var scrutiniCandidato = QueryScrutiniCandidato(search);
                scrutiniCandidato = (from q in scrutiniCandidato select q).Skip(skip).Take(take);
                var engine = new Assemblers.ScrutinioCandidatoAssembler();
                var scrutiniCandidatoDto = new List<Dto.ScrutinioCandidatoDto>();
                foreach (var scrutinioCandidato in scrutiniCandidato)
                {
                    var scrutinioCandidatoDto = engine.Assemble(scrutinioCandidato);
                    engine.AssembleNavigational(scrutinioCandidato, scrutinioCandidatoDto);
                    scrutiniCandidatoDto.Add(scrutinioCandidatoDto);
                }
                return scrutiniCandidatoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountScrutiniCandidato(string search = null)
        {
            try
            {
                var scrutiniCandidato = QueryScrutiniCandidato(search);
                var count = scrutiniCandidato.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ScrutinioCandidatoDto ReadScrutinioCandidato(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var comune = wcf.ReadScrutinioCandidato("Id=" + Id);
                return comune;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.ScrutinioCandidato> QueryScrutiniCandidato(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var scrutiniCandidato = (from q in ef.ScrutinioCandidatos select q);
                //if (search != null)
                //    scrutiniLista = (from q in scrutiniLista where (q.Descrizione.StartsWith(search)) select q);
                scrutiniCandidato = (from q in scrutiniCandidato orderby q.Id select q);
                return scrutiniCandidato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion
     
    }
}
