using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        #region Comune
        #region CRUD
        [OperationContract]
        Dto.ComuneDto CreateComune(Dto.ComuneDto comune);
        
        [OperationContract]
        IEnumerable<Dto.ComuneDto> ReadComuni();

        [OperationContract]
        bool UpdateComune(Dto.ComuneDto comune);

        [OperationContract]
        bool DeleteComune(Dto.ComuneDto comune);

        [OperationContract]
        int CountComuni();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.ComuneDto> LoadComuni(int skip, int take, string search=null);
        
        [OperationContract]
        int CountComuni(string search=null);
        #endregion
        #endregion

        #region Consultazione
        #region CRUD
        [OperationContract]
        Dto.ConsultazioneDto CreateConsultazione(Dto.ConsultazioneDto consultazione);

        [OperationContract]
        IEnumerable<Dto.ConsultazioneDto> ReadConsultazioni();

        [OperationContract]
        bool UpdateConsultazione(Dto.ConsultazioneDto consultazione);

        [OperationContract]
        bool DeleteConsultazione(Dto.ConsultazioneDto consultazione);

        [OperationContract]
        int CountConsultazioni();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.ConsultazioneDto> LoadConsultazioni(int skip, int take, string search = null);

        [OperationContract]
        int CountConsultazioni(string search = null);
        #endregion
        #endregion

        #region Operatore
        #region CRUD
        [OperationContract]
        Dto.OperatoreDto CreateOperatore(Dto.OperatoreDto operatore);

        [OperationContract]
        IEnumerable<Dto.OperatoreDto> ReadOperatori();

        [OperationContract]
        bool UpdateOperatore(Dto.OperatoreDto operatore);

        [OperationContract]
        bool DeleteOperatore(Dto.OperatoreDto operatore);

        [OperationContract]
        int CountOperatori();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.OperatoreDto> LoadOperatori(int skip, int take, string search = null);

        [OperationContract]
        int CountOperatori(string search = null);
        #endregion
        #endregion

        #region SedeElettorale
        #region CRUD
        [OperationContract]
        Dto.SedeElettoraleDto CreateSedeElettorale(Dto.SedeElettoraleDto sedeElettorale);

        [OperationContract]
        IEnumerable<Dto.SedeElettoraleDto> ReadSediElettorali();

        [OperationContract]
        bool UpdateSedeElettorale(Dto.SedeElettoraleDto sedeElettorale);

        [OperationContract]
        bool DeleteSedeElettorale(Dto.SedeElettoraleDto sedeElettorale);

        [OperationContract]
        int CountSediElettorali();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.SedeElettoraleDto> LoadSediElettorali(int skip, int take, string search = null);

        [OperationContract]
        int CountSediElettorali(string search = null);
        #endregion
        #endregion

        #region Sezione
        #region CRUD
        [OperationContract]
        Dto.SezioneDto CreateSezione(Dto.SezioneDto sezione);

        [OperationContract]
        IEnumerable<Dto.SezioneDto> ReadSezioni();

        [OperationContract]
        bool UpdateSezione(Dto.SezioneDto sezione);

        [OperationContract]
        bool DeleteSezione(Dto.SezioneDto sezione);

        [OperationContract]
        int CountSezioni();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.SezioneDto> LoadSezioni(int skip, int take, string search = null);

        [OperationContract]
        int CountSezioni(string search = null);
        #endregion
        #endregion

        #region Collegio
        #region CRUD
        [OperationContract]
        Dto.CollegioDto CreateCollegio(Dto.CollegioDto collegio);

        [OperationContract]
        IEnumerable<Dto.CollegioDto> ReadCollegi();

        [OperationContract]
        bool UpdateCollegio(Dto.CollegioDto collegio);

        [OperationContract]
        bool DeleteCollegio(Dto.CollegioDto collegio);

        [OperationContract]
        int CountCollegi();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.CollegioDto> LoadCollegi(int skip, int take, string search = null);

        [OperationContract]
        int CountCollegi(string search = null);
        #endregion
        #endregion

        #region SezioneCollegio
        #region CRUD
        [OperationContract]
        Dto.SezioneCollegioDto CreateSezioneCollegio(Dto.SezioneCollegioDto sezioneCollegio);

        [OperationContract]
        IEnumerable<Dto.SezioneCollegioDto> ReadSezioniCollegio();

        [OperationContract]
        bool UpdateSezioneCollegio(Dto.SezioneCollegioDto sezioneCollegio);

        [OperationContract]
        bool DeleteSezioneCollegio(Dto.SezioneCollegioDto sezioneCollegio);

        [OperationContract]
        int CountSezioniCollegio();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.SezioneCollegioDto> LoadSezioniCollegi(int skip, int take, string search = null);

        [OperationContract]
        int CountSezioniCollegi(string search = null);
        #endregion
        #endregion

        #region Affluenza
        #region CRUD
        [OperationContract]
        Dto.AffluenzaDto CreateAffluenza(Dto.AffluenzaDto affluenza);

        [OperationContract]
        IEnumerable<Dto.AffluenzaDto> ReadAffluenze();

        [OperationContract]
        bool UpdateAffluenza(Dto.AffluenzaDto affluenza);

        [OperationContract]
        bool DeleteAffluenza(Dto.AffluenzaDto affluenza);

        [OperationContract]
        int CountAffluenze();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.AffluenzaDto> LoadAffluenze(int skip, int take, string search = null);

        [OperationContract]
        int CountAffluenze(string search = null);
        #endregion
        #endregion

        #region Rilevamento
        #region CRUD
        [OperationContract]
        Dto.RilevamentoDto CreateRilevamento(Dto.RilevamentoDto rilevamento);

        [OperationContract]
        IEnumerable<Dto.RilevamentoDto> ReadRilevamenti();

        [OperationContract]
        bool UpdateRilevamento(Dto.RilevamentoDto rilevamento);

        [OperationContract]
        bool DeleteRilevamento(Dto.RilevamentoDto rilevamento);

        [OperationContract]
        int CountRilevamenti();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.RilevamentoDto> LoadRilevamenti(int skip, int take, string search = null);

        [OperationContract]
        int CountRilevamenti(string search = null);
        #endregion
        #endregion

        #region Scrutinio
        #region CRUD
        [OperationContract]
        Dto.ScrutinioDto CreateScrutinio(Dto.ScrutinioDto scrutinio);

        [OperationContract]
        IEnumerable<Dto.ScrutinioDto> ReadScrutini();

        [OperationContract]
        bool UpdateScrutinio(Dto.ScrutinioDto scrutinio);

        [OperationContract]
        bool DeleteScrutinio(Dto.ScrutinioDto scrutinio);

        [OperationContract]
        int CountScrutini();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ScrutinioDto> LoadScrutini(int skip, int take, string search = null);

        [OperationContract]
        int CountScrutini(string search = null);
        #endregion
        #endregion

        #region CapoCoalizione
        #region CRUD
        [OperationContract]
        Dto.CapoCoalizioneDto CreateCapoCoalizione(Dto.CapoCoalizioneDto capoCoalizione);

        [OperationContract]
        IEnumerable<Dto.CapoCoalizioneDto> ReadCapiCoalizioni();

        [OperationContract]
        bool UpdateCapoCoalizione(Dto.CapoCoalizioneDto capoCoalizione);

        [OperationContract]
        bool DeleteCapoCoalizione(Dto.CapoCoalizioneDto capoCoalizione);

        [OperationContract]
        int CountCapiCoalizioni();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.CapoCoalizioneDto> LoadCapiCoalizioni(int skip, int take, string search = null);

        [OperationContract]
        int CountCapiCoalizioni(string search = null);
        #endregion
        #endregion

        #region ScrutinioCapoCoalizione
        #region CRUD
        [OperationContract]
        Dto.ScrutinioCapoCoalizioneDto CreateScrutinioCapoCoalizione(Dto.ScrutinioCapoCoalizioneDto scrutinioCapoCoalizione);

        [OperationContract]
        IEnumerable<Dto.ScrutinioCapoCoalizioneDto> ReadScrutiniCapoCoalizione();

        [OperationContract]
        bool UpdateScrutinioCapoCoalizione(Dto.ScrutinioCapoCoalizioneDto scrutinioCapoCoalizione);

        [OperationContract]
        bool DeleteScrutinioCapoCoalizione(Dto.ScrutinioCapoCoalizioneDto scrutinioCapoCoalizione);

        [OperationContract]
        int CountScrutiniCapoCoalizione();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ScrutinioCapoCoalizioneDto> LoadScrutiniCapoCoalizione(int skip, int take, string search = null);

        [OperationContract]
        int CountScrutiniCapoCoalizione(string search = null);
        #endregion
        #endregion

        #region Lista
        #region CRUD
        [OperationContract]
        Dto.ListaDto CreateLista(Dto.ListaDto lista);

        [OperationContract]
        IEnumerable<Dto.ListaDto> ReadListe();

        [OperationContract]
        bool UpdateLista(Dto.ListaDto lista);

        [OperationContract]
        bool DeleteLista(Dto.ListaDto lista);

        [OperationContract]
        int CountListe();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ListaDto> LoadListe(int skip, int take, string search = null);

        [OperationContract]
        int CountListe(string search = null);
        #endregion
        #endregion

        #region ScrutinioLista
        #region CRUD
        [OperationContract]
        Dto.ScrutinioListaDto CreateScrutinioLista(Dto.ScrutinioListaDto scrutinioLista);

        [OperationContract]
        IEnumerable<Dto.ScrutinioListaDto> ReadScrutiniLista();

        [OperationContract]
        bool UpdateScrutinioLista(Dto.ScrutinioListaDto scrutinioLista);

        [OperationContract]
        bool DeleteScrutinioLista(Dto.ScrutinioListaDto scrutinioLista);

        [OperationContract]
        int CountScrutiniLista();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ScrutinioListaDto> LoadScrutiniLista(int skip, int take, string search = null);

        [OperationContract]
        int CountScrutiniLista(string search = null);
        #endregion
        #endregion


        #region Candidato
        #region CRUD
        [OperationContract]
        Dto.CandidatoDto CreateCandidato(Dto.CandidatoDto candidato);

        [OperationContract]
        IEnumerable<Dto.CandidatoDto> ReadCandidati();

        [OperationContract]
        bool UpdateCandidato(Dto.CandidatoDto candidato);

        [OperationContract]
        bool DeleteCandidato(Dto.CandidatoDto candidato);

        [OperationContract]
        int CountCandidati();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.CandidatoDto> LoadCandidati(int skip, int take, string search = null);

        [OperationContract]
        int CountCandidati(string search = null);
        #endregion
        #endregion

        #region ScrutinioCandidato
        #region CRUD
        [OperationContract]
        Dto.ScrutinioCandidatoDto CreateScrutinioCandidato(Dto.ScrutinioCandidatoDto scrutinioCandidato);

        [OperationContract]
        IEnumerable<Dto.ScrutinioCandidatoDto> ReadScrutiniCandidato();

        [OperationContract]
        bool UpdateScrutinioCandidato(Dto.ScrutinioCandidatoDto scrutinioCandidato);

        [OperationContract]
        bool DeleteScrutinioCandidato(Dto.ScrutinioCandidatoDto scrutinioCandidato);

        [OperationContract]
        int CountScrutiniCandidato();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ScrutinioCandidatoDto> LoadScrutiniCandidato(int skip, int take, string search = null);

        [OperationContract]
        int CountScrutiniCandidato(string search = null);
        #endregion
        #endregion

    }


}
