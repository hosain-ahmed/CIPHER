using System.Drawing;

namespace CIPHER.Helpers
{
    public static class Theme
    {
        // Backgrounds
        public static readonly Color BackgroundMain = ColorTranslator.FromHtml("#F4F7F6");
        public static readonly Color BackgroundSidebar = ColorTranslator.FromHtml("#32383E");
        public static readonly Color BackgroundCard = Color.White;

        // Brand Accents
        public static readonly Color PrimaryCyan = ColorTranslator.FromHtml("#00D2FF");
        public static readonly Color MutedTeal = ColorTranslator.FromHtml("#006070");

        // Text Colors
        public static readonly Color TextMain = ColorTranslator.FromHtml("#1A2026");
        public static readonly Color TextSecondary = ColorTranslator.FromHtml("#607D8B");
        public static readonly Color TextGhostly = ColorTranslator.FromHtml("#90A4AE");

        // Status Colors
        public static readonly Color SuccessGreen = ColorTranslator.FromHtml("#4CAF50");
        public static readonly Color WarningRed = ColorTranslator.FromHtml("#E66A6A");
        public static readonly Color EasyGold = ColorTranslator.FromHtml("#C1A056");

        // UI Elements
        public static readonly Color GridLines = ColorTranslator.FromHtml("#DDE4E6");
    }
}