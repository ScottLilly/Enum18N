using EnumI18N.Resources;

namespace EnumI18N
{
    internal static class ExtensionMethods
    {
        internal static string InCurrentLanguage(this string text)
        {
            return Literals.ResourceManager.GetString(text) ?? text;
        }
    }
}
