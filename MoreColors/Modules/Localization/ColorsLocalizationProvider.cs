using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Reactor.Localization;
using Reactor.Localization.Providers;
using Reactor.Utilities;

namespace MoreColors.Modules.Localization;

public class ColorsLocalizationProvider : LocalizationProvider
{
    internal static List<IMiraTranslation> ActiveTexts = [];
    private static bool _loadedStrings;
    public override int Priority => ReactorPriority.Normal;
    private static LocalizationProvider? _reactorProvider;

    public override bool TryGetText(StringNames stringName, out string? result)
    {
        if ((int)stringName < 0 && _reactorProvider!.TryGetText(stringName, out var reactorText))
        {
            if (reactorText.IsNullOrWhiteSpace())
            {
                result = "STRMISS";
                return true;
            }
            var localeText = ColorsLocale.GetParsed(reactorText!);
            if (!localeText.Contains("STRMISS"))
            {
                result = localeText;
                return true;
            }
        }
        result = null;
        return false;
    }

    public override bool TryGetTextFormatted(StringNames stringName, Il2CppReferenceArray<Il2CppSystem.Object> parts, out string? result)
    {
        if (!TryGetText(stringName, out result)) return false;

        result = Il2CppSystem.String.Format(result, parts);
        return true;
    }

    public override void OnLanguageChanged(SupportedLangs newLanguage)
    {
        if (_reactorProvider == null)
        {
            _reactorProvider = LocalizationManager.Providers.First(x => x is HardCodedLocalizationProvider);
        }
        if (!_loadedStrings)
        {
            ColorsLocale.LoadExternalLocale();
            _loadedStrings = true;
        }

        for (int i = 0; i < ActiveTexts.Count; i++)
        {
            ActiveTexts[i].ResetText();
        }

        if (ColorsLocale.LangCultureList.TryGetValue((ExtendedLangs)newLanguage, out var culture))
        {
        }
        /*Warning($"<?xml version='1.0' encoding='UTF-8'?>");
        Warning($"<resources>");
        foreach (var stringName in TranslationController.Instance.currentLanguage.AllStrings)
        {
            var value = stringName.Value.Replace("\n", "\\%nl\\%");
            value = value.Replace("{", "\\%");
            value = value.Replace("}", "\\%");
            Warning($"<string name=\"{stringName.Key}\">{value}</string>");
        }
        Warning($"</resources>");*/
    }
}