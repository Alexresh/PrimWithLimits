using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrimWithLimits
{
    public partial class MainForm : Form
    {
        readonly List<Position> connectedNodes = new List<Position>();
        private Matrix initialMatrix;
        private bool autoCalc = false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (initialMatrix is null) 
            {
                status.Text = "Матрица не задана";
                return;
            }
            Matrix matrix = new Matrix(initialMatrix.GetMatrix());
            Matrix tempMatrix = new Matrix(matrix.GetMatrix().GetLength(0));
            Node[] nodes = new Node[matrix.GetMatrix().GetLength(0)];
            nodes = nodes.Select(i => new Node()).ToArray();
            int currentNode = 0;
            int maxConnections = (int)numLimit.Value;
            connectedNodes.Clear();

            MatrixManager.AddRow(tempMatrix, MatrixManager.GetRow(matrix, currentNode), currentNode);
            MatrixManager.RemoveColumn(tempMatrix, currentNode);
            MatrixManager.RemoveColumn(matrix, currentNode);
            for (int i = 0; i < matrix.GetMatrix().GetLength(0) - 1; i++)
            {
                Position pos = tempMatrix.FindMinPos();
                if (pos.X == -1 || pos.Y == -1) 
                {
                    status.Text = "Не удалось построить остов";
                    return;
                }
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
                connectedNodes.Add(pos);
            }

            UI ui = new UI(picOutGraph);
            ui.ConnectNodes(connectedNodes, initialMatrix);
            status.Text = "Успешно";
        }

        private void NumericNodesCount_ValueChanged(object sender, EventArgs e)
        {
            DataGridMatrix.Rows.Clear();
            DataGridMatrix.Columns.Clear();
            for (int i = 0; i < NumericNodesCount.Value; i++)
            {
                DataGridMatrix.Columns.Add((i+1).ToString(), (i+1).ToString());
                DataGridMatrix.Rows.Add();
                DataGridMatrix[DataGridMatrix.Columns.Count - 1, DataGridMatrix.Rows.Count - 1].Value = 0;
                DataGridMatrix[DataGridMatrix.Columns.Count - 1, DataGridMatrix.Rows.Count - 1].ReadOnly = true;
            }
            initialMatrix = new Matrix((int)NumericNodesCount.Value);
            ReDraw();
            
        }

        private void DataGridMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!int.TryParse(DataGridMatrix[e.ColumnIndex, e.RowIndex].Value.ToString(), out int res)) 
            {
                DataGridMatrix[e.ColumnIndex, e.RowIndex].Value = 0;
                status.Text = "Только числа";
            }
            
            if (e.ColumnIndex != e.RowIndex) 
            { 
                DataGridMatrix[e.RowIndex, e.ColumnIndex].Value = res;
                initialMatrix.GetMatrix()[e.ColumnIndex, e.RowIndex] = res;
                initialMatrix.GetMatrix()[e.RowIndex, e.ColumnIndex] = res;
                ReDraw();
                if (autoCalc) CalculateBtn_Click(sender, e);
            }
            
        }

        private void ReDraw() 
        {
            UI ui = new UI(picInitGraph);
            ui.DrawFromMatrix(initialMatrix);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            NumericNodesCount_ValueChanged(sender, e);
        }

        private void AutoCalc_CheckedChanged(object sender, EventArgs e)
        {


            if (AutoCalc.Checked == true) 
            {
                calculateBtn.Enabled = false;
                autoCalc = true;
            }
            else 
            {
                calculateBtn.Enabled = true;
                autoCalc = false;
            }
        }

        private void NumLimit_ValueChanged(object sender, EventArgs e)
        {
            if (autoCalc) CalculateBtn_Click(sender, e);
        }

        private void НовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumericNodesCount.Value = 3;
            numLimit.Value = 2;
            NumericNodesCount_ValueChanged(sender, e);
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();
            if(result == DialogResult.OK) 
            {
                initialMatrix = FileManager.LoadMatrixFromFile(openFile.FileName);
                status.Text = "Выбран файл: " + openFile.FileName;
                int[,] mat = initialMatrix.GetMatrix();
                int size = mat.GetLength(0);
                NumericNodesCount.Value = size;
                NumericNodesCount_ValueChanged(sender, e);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i == j)
                        {
                            DataGridMatrix[i, j].Value = 0;
                        }
                        else 
                        {
                            DataGridMatrix[i, j].Value = mat[i, j];
                        }
                    }
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileManager.SaveToFile(initialMatrix, saveFile.FileName);
            }
        }

        private void ВыходAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
