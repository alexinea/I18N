using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;
using EnumsNET;

namespace Cosmos.I18N.Core.Historical
{
    public static class HistoricalCountryStarter
    {
        public static void AppendBuildInCountries()
        {
            AppendBuildInCountries(CountryManager.WholeWorld.Data);
        }

        public static void AppendBuildInCountries(IEnumerable<CountryInfo> buildInCountries)
        {
            HistoricalCountryEngine.FirstTimeUpdate(buildInCountries);
        }

        public static void AppendConfiguredCountries(IEnumerable<HistoricalCountryModel> configuredModels)
        {
            if (configuredModels is null) return;
            var models = configuredModels.ToList();
            if (!models.Any()) return;

            //Step.1 修正
            foreach (var model in models)
            {
                if (!model.IsValid())
                {
                    model.Flag = -1;
                    continue;
                }

                var code = (RegionCodeValue) model.Cep1CrCode;

                if (!code.IsHistoricalValue())
                {
                    model.Flag = -1;
                    continue;
                }

                if (model.Since > DateTime.Today.Year || model.Since <= 0)
                {
                    //不支持公元前
                    model.Flag = -1;
                    continue;
                }

                if (model.EndedIn.HasValue && model.Since > model.EndedIn.Value)
                {
                    //不支持公元前
                    model.Flag = -1;
                    continue;
                }

                if (model.Previous != null)
                {
                    if (!model.Previous.EndedIn.HasValue)
                    {
                        model.Flag = -1;
                        continue;
                    }

                    if (model.Previous.EndedIn.Value > model.Since)
                    {
                        model.Flag = -1;
                        continue;
                    }

                    if (!TryFixedNavModel(models, model.Previous) || model.Previous.Kill)
                    {
                        model.Previous = null;
                    }
                }

                if (model.Next != null)
                {
                    if (model.Next.Any())
                    {
                        foreach (var nav in model.Next)
                        {
                            if (nav is null)
                                continue;

                            if (!TryFixedNavModel(models, nav))
                                nav.Kill = true;
                        }

                        if (model.Next.All(x => x.Kill))
                        {
                            model.Next.Clear();
                            model.Next = null;
                        }
                    }
                    else
                    {
                        model.Next = null;
                    }
                }

                if (!model.IsValid())
                {
                    model.Flag = -1;
                }
            }

            //Step.2 过滤
            var validModels = models.Where(x => x.IsValid()).ToList();

            //Step.3 添加
            foreach (var model in validModels)
            {
                var runtimeModel = model.ToRuntimeCountryInfo();
                var runtimeNav = model.ToRuntimeNav();

                RuntimeCountryInfoCache.RuntimeUpdate(runtimeModel);
                HistoricalCountryEngine.AddNav(runtimeNav);
            }
        }

        private static bool TryFixedNavModel(List<HistoricalCountryModel> wholeModels, HistoricalCountryModel.HistoricalCountryNavModel targetNav)
        {
            if (targetNav is null)
                return false;

            if (targetNav.Cep1CrCode.HasValue)
                return true;

            if (!string.IsNullOrWhiteSpace(targetNav.CountryEnum))
            {
                var model = wholeModels.FirstOrDefault(x => x.CountryEnum == targetNav.CountryEnum);

                if (model != null)
                {
                    targetNav.Cep1CrCode = model.Cep1CrCode;
                    return true;
                }

                var enumValue = Enums.GetMember<Country>(targetNav.CountryEnum, true)?.Value ?? Country.Unknown;
                var info = CountryManager.GetCountryInfo(enumValue);

                if (info != null)
                {
                    targetNav.Cep1CrCode = info.Cep1CrCode;
                    return true;
                }
            }

            if (!string.IsNullOrWhiteSpace(targetNav.CountryCode))
            {
                var model = wholeModels.FirstOrDefault(x => x.CountryCode == targetNav.CountryCode);

                if (model != null)
                {
                    targetNav.Cep1CrCode = model.Cep1CrCode;
                    return true;
                }

                var enumValue = Enums.GetMember<CountryCode>(targetNav.CountryCode, true)?.Value ?? CountryCode.Unknown;
                var info = CountryManager.GetCountryInfo(enumValue);

                if (info != null)
                {
                    targetNav.Cep1CrCode = info.Cep1CrCode;
                    return true;
                }
            }

            if (string.IsNullOrWhiteSpace(targetNav.Alpha2Code))
            {
                var model = wholeModels.FirstOrDefault(x => x.Alpha2Code == targetNav.Alpha2Code);

                if (model != null)
                {
                    targetNav.Cep1CrCode = model.Cep1CrCode;
                    return true;
                }

                var info = CountryManager.GetCountryInfo(targetNav.Alpha2Code);

                if (info != null)
                {
                    targetNav.Cep1CrCode = info.Cep1CrCode;
                    return true;
                }
            }

            if (string.IsNullOrWhiteSpace(targetNav.Alpha3Code))
            {
                var model = wholeModels.FirstOrDefault(x => x.Alpha3Code == targetNav.Alpha3Code);

                if (model != null)
                {
                    targetNav.Cep1CrCode = model.Cep1CrCode;
                    return true;
                }

                var info = CountryManager.GetCountryInfo(targetNav.Alpha3Code);

                if (info != null)
                {
                    targetNav.Cep1CrCode = info.Cep1CrCode;
                    return true;
                }
            }

            if (string.IsNullOrWhiteSpace(targetNav.M49Code))
            {
                var model = wholeModels.FirstOrDefault(x => x.M49Code == targetNav.M49Code);

                if (model != null)
                {
                    targetNav.Cep1CrCode = model.Cep1CrCode;
                    return true;
                }

                var info = CountryManager.WholeWorld.Data.FirstOrDefault(x => x.M49Code == targetNav.M49Code);

                if (info != null)
                {
                    targetNav.Cep1CrCode = info.Cep1CrCode;
                    return true;
                }
            }

            if (string.IsNullOrWhiteSpace(targetNav.I18NIdentityCode))
            {
                var model = wholeModels.FirstOrDefault(x => x.I18NIdentityCode == targetNav.I18NIdentityCode);

                if (model != null)
                {
                    targetNav.Cep1CrCode = model.Cep1CrCode;
                    return true;
                }

                var info = CountryManager.WholeWorld.Data.FirstOrDefault(x => x.I18NIdentityCode == targetNav.I18NIdentityCode);

                if (info != null)
                {
                    targetNav.Cep1CrCode = info.Cep1CrCode;
                    return true;
                }
            }

            targetNav.Kill = true;

            return false;
        }
    }
}