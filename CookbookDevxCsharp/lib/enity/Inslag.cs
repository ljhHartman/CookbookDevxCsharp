using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookDevxCsharp.lib.enity
{
    class Inslag
    {
        public int INSLAGNUMMER { get; set; }
        public bool AGENDA { get; set; }
        public string STATUS { get; set; }
        public string LEVERANCIER { get; set; }
        public int SCHEEPDOSSIERNUMMER { get; set; }
        public int COLLIESGECONFIRMEERD { get; set; }
        public int AGENDANUMMER { get; set; }
        public DateTime INSLAGDATUM { get; set; }
        public string KLANTORDERNUMMERS { get; set; }
        public string BOOTNAAM { get; set; }
        public string KLANTNAAM { get; set; }
        public string VERVOERSSOORT { get; set; }
        public string VERVOERDER { get; set; }
        public string VRACHTBRIEFNUMMER { get; set; }
        public string BIJZONDERHEDEN { get; set; }
        public int TOTAAL_AANTAL_COLLIES { get; set; }
        public float TOTAAL_BRUTO_GEWICHT_COLLIES { get; set; }
        public float TOTAAL_NETTO_GEWICHT_COLLIES { get; set; }
        public float TOTAAL_WAARDE_COLLIES { get; set; }
        public string VALUTA_COLLIES { get; set; }
        public string DOUANEDOCUMENT_SOORT { get; set; }
        public string DOUANEDOCUMENT_NUMMER { get; set; }
        public string GOEDERENSOORT_DOUANE { get; set; }
        public DateTime INSLAGTIJD { get; set; }
        public string SCHEEPSNAAM { get; set; }
        public string GOEDERENOMSCHRIJVING { get; set; }
        public int UITSLAGNUMMER { get; set; }
        public int UITGESLAGEN { get; set; }
        public Boolean CONFIRMED { get; set; }
        public string OPDRACHTGEVER { get; set; }
        public string AANLEVERINGTYPE { get; set; }
        public string AFHANDELAAR { get; set; }
        public string AIS { get; set; }
        public string MANIFEST { get; set; }
        public string MRN { get; set; }
        public string ECS { get; set; }
        public string DEPOT { get; set; }
        public string LOCATIE { get; set; }
        public string TIR { get; set; }
        public string AGD { get; set; }
        public string ATA { get; set; }
    }
}
