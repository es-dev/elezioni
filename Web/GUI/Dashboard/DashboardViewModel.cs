using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Comune;
using Web.GUI.Consultazione;

namespace Web.GUI.Dashboard
{
    public class DashboardViewModel: TemplateViewModel<Dashboard, DashboardItem>
    {

        public DashboardViewModel(ISpace space) : base(space) 
        {

        }

        public override void Load(int skip, int take)
        {
            try
            {
                var objDtos = LoadDashboards(skip, take);
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
                var query = QueryDashboards();
                int count = query.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        
        private IList<Dashboard> LoadDashboards(int skip, int take)
        {
            try
            {
                var query = QueryDashboards();
                var objDtos = query.Skip(skip).Take(take).ToList();
                return objDtos;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<Dashboard> QueryDashboards()
        {
            try
            {
                var dashboards = new List<Dashboard>();
                var dashboardComune = new Dashboard("Comune", "ELE", "Visualizza le informazioni sul comune...", "Images.comune.png", "", typeof(ComuneView));
                var dashboardConsultazione = new Dashboard("Consultazione", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardCollegio = new Dashboard("Collegio", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardSedeElettorale = new Dashboard("Sede elettorale", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardOperatore = new Dashboard("Operatore", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardAffluenza = new Dashboard("Affluenza", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardSezione = new Dashboard("Sezione", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardSezioneCollegio = new Dashboard("Sezione Collegio", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardRilevamento = new Dashboard("Rilevamento", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardScrutinio = new Dashboard("Scrutinio", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardCapocoalizione = new Dashboard("Capo coalizione", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardScrutinioCapocoalizione = new Dashboard("Scrutinio capo coalizione", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardListe = new Dashboard("Lista", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardScrutinioLista = new Dashboard("Scrutinio lista", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardCandidato = new Dashboard("Candidato", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                var dashboardScrutinioCandidato = new Dashboard("Scrutinio candidato", "ELE", "Visualizza le informazioni sula consultazione...", "Images.consultazione.png", "", typeof(ConsultazioneView));
                dashboards.Add(dashboardComune);
                dashboards.Add(dashboardConsultazione);
                dashboards.Add(dashboardCollegio);
                dashboards.Add(dashboardSedeElettorale);
                dashboards.Add(dashboardOperatore);
                dashboards.Add(dashboardAffluenza);
                dashboards.Add(dashboardSezione);
                dashboards.Add(dashboardSezioneCollegio);
                dashboards.Add(dashboardRilevamento);
                dashboards.Add(dashboardScrutinio);
                dashboards.Add(dashboardCapocoalizione);
                dashboards.Add(dashboardScrutinioCapocoalizione);
                dashboards.Add(dashboardListe);
                dashboards.Add(dashboardScrutinioLista);
                dashboards.Add(dashboardCandidato);
                dashboards.Add(dashboardScrutinioCandidato);

                var query = dashboards.AsQueryable();
                return query;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}