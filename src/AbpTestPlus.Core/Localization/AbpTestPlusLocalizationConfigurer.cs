using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpTestPlus.Localization
{
    public static class AbpTestPlusLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpTestPlusConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpTestPlusLocalizationConfigurer).GetAssembly(),
                        "AbpTestPlus.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
