using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;
using EnumsNET;

namespace Cosmos.I18N.Core.Historical
{
    public class HistoricalCountryModel : CountryModel
    {
        public int Since { get; set; }

        public int? EndedIn { get; set; }

        public HistoricalCountryNavModel Previous { get; set; }

        public List<HistoricalCountryNavModel> Next { get; set; } = new List<HistoricalCountryNavModel>();

        internal int Flag { get; set; } = 0;

        public class HistoricalCountryNavModel
        {
            public long? Cep1CrCode { get; set; }

            public string CountryEnum { get; set; }

            public string CountryCode { get; set; }

            public string Alpha2Code { get; set; }

            public string Alpha3Code { get; set; }

            public string M49Code { get; set; }

            public string I18NIdentityCode { get; set; }

            public int Since { get; set; }

            public int? EndedIn { get; set; }

            internal bool Kill { get; set; } = false;
        }

        public override bool IsValid()
        {
            if (!base.IsValid())
                return false;

            if (Previous is null && (Next is null || !Next.Any()))
                return false;

            if (Since <= 0)
                return false;

            if (Flag == -1)
                return false;

            return true;
        }

        public RuntimeCountryInfo ToRuntimeCountryInfo()
        {
            var runtimeData = new Dictionary<string, string>
            {
                {"M49", M49Code},
                {"ALPHA2", Alpha2Code},
                {"ALPHA3", Alpha3Code},
                {"NAME", Name},
                {"SHORTER_FORM", ShorterForm},
                {"ALIAS", Alias},
                {"ENUM", CountryEnum},
                {"CODE", CountryCode},
                {"TYPE", CountryType},
                {"CN_NAME", ChineseName},
                {"CN_SHORTER_FORM", ChineseShorterForm},
                {"CN_ALIAS1", ChineseAlias},
                {"CN_ALIAS2", ChineseAlias2},
                {"CONTINENT", Continent},
                {"I18N", I18NIdentityCode}
            };

            return new RuntimeCountryInfo(
                Enums.Parse<Continent>(Continent, true),
                Enums.Parse<CountryType>(CountryType, true),
                Cep1CrCode,
                CountryCode,
                CountryEnum,
                runtimeData
            );
        }

        internal HistoricalCountryNav ToRuntimeNav()
        {
            var ret = new HistoricalCountryNav
            {
                Key = (Cep1CrCode, Since, EndedIn),
                Code = Cep1CrCode,
                Name = Name
            };

            if (Previous != null)
            {
                ret.Previous = (Previous.Cep1CrCode!.Value, Previous.Since, Previous.EndedIn);
            }

            if (Next != null && Next.Any())
            {
                foreach (var current in Next)
                {
                    ret.Next.Add((current.Cep1CrCode!.Value, current.Since, current.EndedIn));
                }
            }

            return ret;
        }
    }
}