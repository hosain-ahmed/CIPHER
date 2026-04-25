using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Helpers
{
    public static class Theme
    {
        // Backgrounds
        public static Color BgDeep = ColorTranslator.FromHtml("#121212");
        public static Color BgCard = ColorTranslator.FromHtml("#1E1E1E");

        // Accents
        public static Color PrimaryGreen = ColorTranslator.FromHtml("#00FF41");
        public static Color DangerRed = ColorTranslator.FromHtml("#FF3B3B");
        public static Color InfoBlue = ColorTranslator.FromHtml("#00A3FF");

        // Text
        public static Color TextMain = Color.FromArgb(224, 224, 224);
        public static Color TextDim = Color.FromArgb(150, 150, 150);

        // Fonts (Standardize these!)
        public static Font HeaderFont = new Font("Segoe UI Semibold", 14f);
        public static Font BodyFont = new Font("Segoe UI", 10f);
        public static Font TerminalFont = new Font("Consolas", 10f);
    }
}
