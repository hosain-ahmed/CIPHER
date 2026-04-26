using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Forms.CustomItems
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class LogoButton : Button
    {
        public LogoButton()
        {
            // 1. Turn off the "standard" button painting
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.Transparent;

            // 2. Prevent the grey highlight on hover/click
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
        }

        // 3. This removes the "Focus Rectangle" (the dotted line)
        protected override bool ShowFocusCues => false;

        // 4. Force the button to only exist where the logo is
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.BackgroundImage != null)
            {
                UpdateRegion();
            }
        }

        private void UpdateRegion()
        {
            using (var bmp = new Bitmap(this.BackgroundImage, this.Size))
            {
                // This tells the button: "Your shape is only the non-see-through pixels"
                this.Region = RegionFromBitmap(bmp);
            }
        }

        private Region RegionFromBitmap(Bitmap bmp)
        {
            GraphicsPath path = new GraphicsPath();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (bmp.GetPixel(x, y).A > 10) // Only count pixels that aren't transparent
                        path.AddRectangle(new Rectangle(x, y, 1, 1));
                }
            }
            return new Region(path);
        }
    }
}