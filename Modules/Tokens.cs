using R2API;
using System;

namespace ImpostorMod.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region impostor
            string prefix = ImpostorPlugin.DEVELOPER_PREFIX + "_IMPOSTOR_BODY_";

            string desc = "Impostor is a Man / Machine / Alien who can kill, quite well.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Knife is an excellent for inconspicously neutralising your foes." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > The 7-shooter can tactically expire the life contracts of the Impostor's foes from a distance." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Vent can help you escape from any situation that puts your credibility at risk." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > [KILL] does as advertised, might want put a couple more stab wounds in (just in case)" + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, moving on to the next target.";
            string outroFailure = "..and so he vanished, absolutely PISSED.";

            LanguageAPI.Add(prefix + "NAME", "Impostor");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "Extremely Suspicious");
            LanguageAPI.Add(prefix + "LORE", "Impostor is a Man / Machine / Alien who can kill, quite well. A man of class, a tactical killer, A killing machine, a thing with sussy intentions: you decide");
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Regenerative");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "He heals quite quickly, you know");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_NAME", "Knife");
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Helpers.agilePrefix + $"Shank for <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_GUN_NAME", "6+1 Shooter");
            LanguageAPI.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Helpers.agilePrefix + $"Fire a 8-1 shooter for <style=cIsDamage>{100f * StaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_ROLL_NAME", "Vent");
            LanguageAPI.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Vent a moderate distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_NAME", "[KILL]");
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Stab for <style=cIsDamage>{100f * StaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Impostor: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As the impostor, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "IMPOSTOR: Mastery");
            #endregion
            #endregion
        }
    }
}