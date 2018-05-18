using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HomeMvc.Localization
{
    public static class HomeMvcLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HomeMvcConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HomeMvcLocalizationConfigurer).GetAssembly(),
                        "HomeMvc.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
