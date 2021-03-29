using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimWithLimits
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            Position[] centrePos = new Position[5];
            Matrix matrix = new Matrix();
            Matrix tempMatrix = new Matrix(5);
            Matrix connections = new Matrix(5);
            Node[] nodes = new Node[5];
            nodes = nodes.Select(i => new Node()).ToArray();
            int currentNode = 4;
            int maxConnections = 3;

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            Position centre = new Position
            {
                X = pictureBox1.Width / 2,
                Y = pictureBox1.Height / 2
            };

            int elementsCount = matrix.GetMatrix().GetLength(0);
            float addAngle = (float)(2*Math.PI / elementsCount);
            float curAngle = 0f;
            for (int i = 0; i < elementsCount; i++)
            {
                float x =(float) Math.Round(60 * Math.Cos(curAngle)) + centre.X;
                float y =(float) Math.Round(60 * Math.Sin(curAngle)) + centre.Y;
                centrePos[i] = new Position
                {
                    X = (int)x,
                    Y = (int)y
                };

               
                curAngle -= addAngle;
            }

            /*for (int i = 0; i < centrePos.Length; i++)
            {
                for (int j = 0; j < centrePos.Length; j++)
                {
                    if (i != j)
                    {
                        g.DrawLine(new Pen(Color.Black), centrePos[i].X + 10, centrePos[i].Y + 10, centrePos[j].X + 10, centrePos[j].Y + 10);
                    }
                }
            }*/

            MatrixManager.AddRow(tempMatrix, MatrixManager.GetRow(matrix, currentNode), currentNode);
            MatrixManager.RemoveColumn(tempMatrix, currentNode);
            MatrixManager.RemoveColumn(matrix, currentNode);
            for (int i = 0; i < matrix.GetMatrix().GetLength(0) - 1; i++)
            {
                Position pos = tempMatrix.FindMinPos();
                
                MatrixManager.AddRow(tempMatrix, MatrixManager.GetRow(matrix, pos.X), pos.X);
                MatrixManager.RemoveColumn(tempMatrix, pos.X);
                MatrixManager.RemoveColumn(matrix, pos.X);
                nodes[pos.X].AddConnection();
                if (nodes[pos.X].GetConnectionCount() == maxConnections)
                {
                    MatrixManager.RemoveRow(tempMatrix, pos.X);
                }
                nodes[pos.Y].AddConnection();
                if (nodes[pos.Y].GetConnectionCount() == maxConnections)
                {
                    MatrixManager.RemoveRow(tempMatrix, pos.Y);
                }
                //MessageBox.Show(pos.X + " " + pos.Y);
                g.DrawLine(new Pen(Color.Black), centrePos[pos.X].X + 10, centrePos[pos.X].Y + 10, centrePos[pos.Y].X + 10, centrePos[pos.Y].Y + 10);

                //show(tempMatrix);
            }
            for (int i = 0; i < centrePos.Length; i++)
            {
                g.FillEllipse(new SolidBrush(Color.Red), centrePos[i].X, centrePos[i].Y, 20, 20);
                g.DrawString(i.ToString(), new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), centrePos[i].X, centrePos[i].Y);
            }
        }
    }
}
