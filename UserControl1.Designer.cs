using System.Drawing;
using System.Windows.Forms;

namespace BarChart
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private int _quantityBar { get; set; }
        private int _range { get; set; }
        private Rectangle rectangle1;
        private RectangleF rectangle;

        private Brush color1 { get; set; }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
        }

        #endregion


        public void Bar(PaintEventArgs pea)
        {
            int distance = -60;
            for (int i = 1; i <= _quantityBar; i++)
            {
                int height = 200;
                int x = 1;
                distance += 60;
                for (int j = 0; j <= _range; j++)
                {

                    pea.Graphics.FillRectangle(color1, distance, height -= 1, 20, x);
                    x++;
                }

                string value = _range.ToString();
                TextRenderer.DrawText(pea.Graphics, value, this.Font, new Point(distance, height - 20),
                    SystemColors.ControlText);


                //private Color colorLabel=Color.Red;
                //public Color KolorSlupka
                //{
                //    get
                //    {
                //        return colorLabel;
                //    }
                //    set
                //    {
                //        rectangle1 = value;
                //        label2.ForeColor = value;
                //        label3.ForeColor = value;
                //        label4.ForeColor = value;

                //        Invalidate();
                //    }
                //}


            }
        }
    }
}
