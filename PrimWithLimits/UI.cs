using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PrimWithLimits
{
    class UI
    {
        private const int distance = 80;
        private const int nodeDiameter = 30;
        private const int fontWidth = 15;
        private const int fontOffsetX = 7;
        private const int fontOffsetY = 3;
        private readonly Graphics graphics;
        private readonly PictureBox box;
        private Position[] nodePos;

        public UI(PictureBox box) 
        {
            this.box = box;
            graphics = Graphics.FromHwnd(this.box.Handle);
        }

        public void DrawSeveralCircles(int count) 
        {
            if (nodePos is null) 
            {
                FillNodePos(count);
            }

            for (int i = 0; i < nodePos.Length; i++)
            {
                graphics.FillEllipse(new SolidBrush(Color.Red), nodePos[i].X, nodePos[i].Y,
                    nodeDiameter, nodeDiameter);
                graphics.DrawString((i+1).ToString(), new Font(FontFamily.GenericSansSerif, fontWidth),
                    new SolidBrush(Color.Black), nodePos[i].X + fontOffsetX, nodePos[i].Y + fontOffsetY);
            }
        }

        public void DrawFromMatrix(Matrix matrix) 
        {
            graphics.Clear(Color.Black);
            int[,] m = matrix.GetMatrix();
            FillNodePos(m.GetLength(0));
            
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetMatrix().GetLength(1); j++)
                {
                    if(m[i, j] != 0) 
                    {
                        DrawLine(i, j);
                        DrawWeight(m[i, j], i, j);
                    }
                }
            }
            DrawSeveralCircles(m.GetLength(0));
            
        }


        public void ConnectNodes(List<Position> nodes, Matrix matrix) 
        {
            graphics.Clear(Color.Black);
            FillNodePos(nodes.Count + 1);
            nodes.ForEach(c => DrawLine(c.X, c.Y));
            DrawSeveralCircles(nodes.Count + 1);
            DrawWeight(matrix, nodes);
        }

        private void DrawWeight(Matrix matrix, List<Position> nodes) 
        {
            int sum = 0;
            foreach (var connect in nodes)
            {
                sum += matrix.GetMatrix()[connect.X, connect.Y];
                DrawWeight(matrix.GetMatrix()[connect.X, connect.Y], connect.X, connect.Y);
            }
            graphics.DrawString("Суммарная длина: " + sum,
                new Font(FontFamily.GenericSansSerif, fontWidth-3),
                new SolidBrush(Color.DeepSkyBlue), 0, 0);
        }

        private void DrawWeight(int weight, int node1, int node2) 
        {
            int centerX = (nodePos[node1].X + nodePos[node2].X) / 2;
            int centerY = (nodePos[node1].Y + nodePos[node2].Y) / 2;
            graphics.DrawString(weight.ToString(),
                    new Font(FontFamily.GenericSansSerif, fontWidth),
                    new SolidBrush(Color.Blue), centerX + 8, centerY - 10);
        }

        private void DrawLine(int node1, int node2) 
        {
            graphics.DrawLine(new Pen(Color.Coral), 
                nodePos[node1].X + nodeDiameter / 2, nodePos[node1].Y + nodeDiameter / 2,
                nodePos[node2].X + nodeDiameter / 2, nodePos[node2].Y + nodeDiameter / 2);
        }

        private void FillNodePos(int count) 
        {
            nodePos = new Position[count];
            float addAngle = (float)(2 * Math.PI / count);
            float curAngle = 0f;
            for (int i = 0; i < count; i++)
            {
                float x = (float)Math.Round(distance * Math.Cos(curAngle)) + GetCentre().X;
                float y = (float)Math.Round(distance * Math.Sin(curAngle)) + GetCentre().Y;
                nodePos[i] = new Position((int)x, (int)y);
                curAngle -= addAngle;
            }
        }

        private Position GetCentre() 
        {
            return new Position(box.Width / 2 - nodeDiameter / 2, box.Height / 2 - nodeDiameter / 2);
        }
    }
}
