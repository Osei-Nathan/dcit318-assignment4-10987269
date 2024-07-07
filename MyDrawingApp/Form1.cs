using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyDrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing;
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();
            drawingPanel.MouseDown += DrawingPanel_MouseDown;
            drawingPanel.MouseMove += DrawingPanel_MouseMove;
            drawingPanel.MouseUp += DrawingPanel_MouseUp;
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = drawingPanel.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, startPoint, e.Location);
                }
                startPoint = e.Location;
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
