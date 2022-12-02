using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuhanTalk.CustomControl
{
    internal class ShadowControl : Panel
    {
        const int WS_EX_TRANSPARENT = 0x20;



        int opacity = 50;



        public int Opacity

        {

            get

            {

                return opacity;

            }

            set

            {

                if (value < 0 || value > 100)

                    throw new ArgumentException("Value must be between 0 and 100");

                opacity = value;

            }

        }



        protected override CreateParams CreateParams

        {

            get

            {

                var cp = base.CreateParams;

                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;



                return cp;

            }

        }



        protected override void OnPaint(PaintEventArgs e)

        {

            using (var b = new SolidBrush(Color.FromArgb(opacity * 255 / 100, BackColor)))

            {

                e.Graphics.FillRectangle(b, ClientRectangle);

            }



            base.OnPaint(e);

        }
    }
}
