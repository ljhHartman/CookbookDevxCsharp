using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CookbookDevxCsharp.lib.ds;
using DevExpress.XtraGrid.Views.Grid;
using CookbookDevxCsharp.lib.enity;
using DevExpress.XtraGrid.Views.Base;

/*
SOURCE:
https://www.youtube.com/watch?v=AdHF6FIYUUc&ab_channel=Ho%C3%A0ngHi%E1%BA%BFu
 */

namespace CookbookDevxCsharp.lib.gridControl
{
    public partial class ucMasterDetail2 : UserControl
    {
        #region Variables
        List<Inslag> lstInslag;
        List<Colli> lstColli;
        int Inslagnummer = 8500;
        #endregion



        #region Constructers
        public ucMasterDetail2()
        {
            InitializeComponent();

            // remove Drag a column header
            grvMain.OptionsDetail.ShowDetailTabs = false;
            // ShowGroupPnel
            grvDetail.OptionsView.ShowGroupPanel = false;
            loadData();
        }
        #endregion



        #region Method
        private void loadData()
        {
            // Get SqlTable "Inslag"
            var dsInslag = new dsInslagColli.InslagDataTable();
            var tbaInslag = new ds.dsInslagColliTableAdapters.InslagTableAdapter();
            tbaInslag.FillBy(dsInslag, Inslagnummer);

            // Get SqlTable "Colli"
            var dsColli = new dsInslagColli.ColliDataTable();
            var tbaColli = new ds.dsInslagColliTableAdapters.ColliTableAdapter();
            tbaColli.FillBy(dsColli, Inslagnummer);

            // Dataset to List "lstInslag"
            lstInslag = new List<Inslag>();
            foreach (DataRow row in dsInslag.Rows)
            {
                lstInslag.Add(new Inslag()
                {
                    INSLAGNUMMER = (int)row["INSLAGNUMMER"],
                    AGENDA = bool.TryParse(row["AGENDA"].ToString(), out bool result),
                    STATUS = (string)row["STATUS"],
                    LEVERANCIER = (string)row["LEVERANCIER"],
                    SCHEEPDOSSIERNUMMER = (int)row["SCHEEPDOSSIERNUMMER"],
                    COLLIESGECONFIRMEERD = (int)row["COLLIESGECONFIRMEERD"],
                    AGENDANUMMER = IntCheckNull(row["AGENDANUMMER"]),
                    INSLAGDATUM = (DateTime)row["INSLAGDATUM"],
                    KLANTORDERNUMMERS = (string)row["KLANTORDERNUMMERS"],
                    BOOTNAAM = (string)row["BOOTNAAM"],
                    KLANTNAAM = (string)row["KLANTNAAM"],
                    VERVOERSSOORT = (string)row["VERVOERSSOORT"],
                    VERVOERDER = (string)row["VERVOERDER"],
                    VRACHTBRIEFNUMMER = (string)row["VRACHTBRIEFNUMMER"],
                    BIJZONDERHEDEN = (string)row["BIJZONDERHEDEN"],
                    TOTAAL_AANTAL_COLLIES = IntCheckNull(row["TOTAAL_AANTAL_COLLIES"]),
                    //TOTAAL_BRUTO_GEWICHT_COLLIES = FloatCheckNull(row["TOTAAL_BRUTO_GEWICHT_COLLIES"]),
                    //TOTAAL_NETTO_GEWICHT_COLLIES = FloatCheckNull(row["TOTAAL_NETTO_GEWICHT_COLLIES"]),
                    //TOTAAL_WAARDE_COLLIES = (float)row["TOTAAL_WAARDE_COLLIES"],
                    //VALUTA_COLLIES = StringCheckDBNull(row["VALUTA_COLLIES"]),
                    DOUANEDOCUMENT_SOORT = StringCheckDBNull(row["DOUANEDOCUMENT_SOORT"]),
                    DOUANEDOCUMENT_NUMMER = StringCheckDBNull(row["DOUANEDOCUMENT_NUMMER"]),
                    GOEDERENSOORT_DOUANE = StringCheckDBNull(row["GOEDERENSOORT_DOUANE"]),
                    INSLAGTIJD = (DateTime)row["INSLAGTIJD"],
                    SCHEEPSNAAM = StringCheckDBNull(row["SCHEEPSNAAM"]),
                    GOEDERENOMSCHRIJVING = StringCheckDBNull(row["GOEDERENOMSCHRIJVING"]),
                    UITSLAGNUMMER = IntCheckNull(row["UITSLAGNUMMER"]),
                    UITGESLAGEN = IntCheckNull(row["UITGESLAGEN"]),
                    CONFIRMED = bool.TryParse(row["CONFIRMED"].ToString(), out bool res2),
                    OPDRACHTGEVER = StringCheckDBNull(row["OPDRACHTGEVER"]),
                    AANLEVERINGTYPE = StringCheckDBNull(row["AANLEVERINGTYPE"]),
                    AFHANDELAAR = StringCheckDBNull(row["AFHANDELAAR"]),
                    AIS = StringCheckDBNull(row["AIS"]),
                    MANIFEST = StringCheckDBNull(row["MANIFEST"]),
                    MRN = StringCheckDBNull(row["MRN"]),
                    ECS = StringCheckDBNull(row["ECS"]),
                    DEPOT = StringCheckDBNull(row["DEPOT"]),
                    LOCATIE = StringCheckDBNull(row["LOCATIE"]),
                    TIR = StringCheckDBNull(row["TIR"]),
                    AGD = StringCheckDBNull(row["AGD"]),
                    ATA = StringCheckDBNull(row["ATA"])
                });
            }

            // Dataset to List "lstColli"
            lstColli = new List<Colli>();
            foreach (DataRow row in dsColli.Rows)
            {
                lstColli.Add(new Colli()
                {
                    ID = (int)row["ID"],
                    INSLAGNUMMER = (int)row["INSLAGNUMMER"],
                    //BRUTOGEWICHT = (float)row["BRUTOGEWICHT"],
                    AGENDANUMMER = IntCheckNull(row["AGENDANUMMER"]),
                    STATUS = StringCheckDBNull(row["STATUS"]),
                    //NETTOGEWICHT = (float)row["NETTOGEWICHT"],
                    //WAARDE = (float)row["WAARDE"],
                    VALUTA = StringCheckDBNull(row["VALUTA"]),
                    DOUANEDOCUMENT_SOORT = StringCheckDBNull(row["DOUANEDOCUMENT_SOORT"]),
                    DOUANEDOCUMENT_NUMMER = StringCheckDBNull(row["DOUANEDOCUMENT_NUMMER"]),
                    GOEDERENSOORT_DOUANE = StringCheckDBNull(row["GOEDERENSOORT_DOUANE"]),
                    KLANTORDERNUMMERS = StringCheckDBNull(row["KLANTORDERNUMMERS"]),
                    //LENGTE = (float)row["LENGTE"],
                    //BREEDTE = (float)row["BREEDTE"],
                    //HOOGTE = (float)row["HOOGTE"],
                    GOEDERENOMSCHRIJVING = StringCheckDBNull(row["GOEDERENOMSCHRIJVING"]),
                    U_DOUANEDOCUMENT_SOORT = StringCheckDBNull(row["U_DOUANEDOCUMENT_SOORT"]),
                    AIS = StringCheckDBNull(row["AIS"]),
                    MANIFEST = StringCheckDBNull(row["MANIFEST"]),
                    //MRN = StringCheckDBNull(row["MRN]"]),
                    ECS = StringCheckDBNull(row["ECS"]),
                    DOSSIERNUMMER = IntCheckNull(row["DOSSIERNUMMER"]),
                    DEPOT = StringCheckDBNull(row["DEPOT"]),
                    LOCATIE = StringCheckDBNull(row["LOCATIE"]),
                    UITGESLAGEN = bool.TryParse(row["UITGESLAGEN"].ToString(), out bool result),
                    UITSLAGNUMMER = IntCheckNull(row["UITSLAGNUMMER"])
                });
            }
            gctMain.DataSource = lstInslag;
        }
        #endregion



        #region Events
        private void frMain_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void grvMain_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            //if Category don't have product a plus is enable
            GridView view = sender as GridView;
            Inslag cat = view.GetRow(e.RowHandle) as Inslag;
            if (cat != null)
                e.IsEmpty = !lstColli.Any(x => x.INSLAGNUMMER == cat.INSLAGNUMMER);
        }

        private void grvMain_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            //Load data to grid detail
            GridView view = sender as GridView;
            Inslag cat = view.GetRow(e.RowHandle) as Inslag;
            if (cat != null)
                e.ChildList = lstColli.Where(x => x.INSLAGNUMMER == cat.INSLAGNUMMER).ToList(); // Cast IEnumberable to ILIst or List
        }

        private void grvMain_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            // Set 1: Detail
            e.RelationCount = 1;
        }

        private void grvMain_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }

        private int IntCheckNull(object value)
        {
            // If if value is not a null, if so the return value is 0
            var res = Int32.TryParse(value.ToString(), out int res2) ? value : 0;
            return (int)res;
        }

        private string StringCheckDBNull(object value)
        {
            return DBNull.Value.Equals(value) ? "" : (string)value;
        }

        #endregion
    }
}