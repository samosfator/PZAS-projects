using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {

        private double a, b, c, x1, x2, h, y;
        private Pen pen;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            getValues();
            drawGraph();
        }

        private void getValues() {
            try {
                a = Convert.ToDouble(aTextBox.Text);
                b = Convert.ToDouble(bTextBox.Text);
                c = Convert.ToDouble(cTextBox.Text);
                x1 = Convert.ToDouble(x1TextBox.Text);
                x2 = Convert.ToDouble(x2TextBox.Text);
                h = Convert.ToDouble(hTextBox.Text);
            } catch (Exception) { }
        }

        private void drawGraph() {
            Graphics g = this.CreateGraphics();
            pen = new Pen(Color.Red, 2);
            int startPointX, startPointY, endPointX, endPointY;
            int xMargin = 700;
            int yMargin = 200;

            drawAxis(g, xMargin, yMargin);

            for (double x = x1; x <= x2; x += h) {
                y = calcY(x);

                startPointX = (int)(x + xMargin);
                startPointY = (int)(y + yMargin);
                endPointX = (int)(startPointX + h);
                endPointY = (int)(calcY(x + h) + yMargin);

                try {
                    g.DrawLine(pen,
                        new Point(startPointX, startPointY),
                        new Point(endPointX, endPointY));
                } catch (Exception) { }
            }
        }

        private void drawAxis(Graphics g, int xMargin, int yMargin) {
            g.DrawLine(new Pen(Color.Black), //X axis
                new Point(xMargin, 0),
                new Point(xMargin, 2000));
            g.DrawLine(new Pen(Color.Black), //Y axis
                new Point(0, yMargin),
                new Point(2000, yMargin));
            g.FillEllipse(new SolidBrush(Color.Red), new Rectangle());
        }

        private double calcY(double x) {
            if (x < -5 && c == 0) {
                y = (1 / (a * x)) - b;
                pen = new Pen(Color.Magenta, 2);
            } else if (x > -5 && c != 0) {
                y = (x - a) / x;
                pen = new Pen(Color.Cyan, 2);
            } else {
                y = (10 * x) / (c - 4);
                pen = new Pen(Color.Blue, 2);
            }
            if (!((a != 0 && b != 0) || (b != 0 && c != 0))) {
                y = Convert.ToInt32(y);
            }
            return y;
        }
    }
}
