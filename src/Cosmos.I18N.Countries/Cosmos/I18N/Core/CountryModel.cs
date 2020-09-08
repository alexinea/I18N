namespace Cosmos.I18N.Core
{
    public class CountryModel
    {
        public string Name { get; set; }
        public string ShorterForm { get; set; }
        public string Alias { get; set; }
        public string CountryEnum { get; set; }
        public string CountryCode { get; set; }
        public string CountryType { get; set; }
        public string BelongsToCountry { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string M49Code { get; set; }
        public long Cep1CrCode { get; set; }
        public string ChineseName { get; set; }
        public string ChineseShorterForm { get; set; }
        public string ChineseAlias { get; set; }
        public string ChineseAlias2 { get; set; }
        public string Continent { get; set; }
        public string I18NIdentityCode { get; set; }
        public bool CommonwealthOfNations { get; set; }

        public virtual bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;
            
            if (string.IsNullOrWhiteSpace(CountryEnum))
                return false;
            
            if (string.IsNullOrWhiteSpace(CountryCode))
                return false;
            
            if (string.IsNullOrWhiteSpace(CountryType))
                return false;
            
            if (string.IsNullOrWhiteSpace(BelongsToCountry))
                return false;
            
            if (string.IsNullOrWhiteSpace(ChineseName))
                return false;
            
            if (string.IsNullOrWhiteSpace(Continent))
                return false;

            if (Cep1CrCode < 1_00_000)
                return false;
            
            return true;
        }
    }
}