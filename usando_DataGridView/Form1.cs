using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usando_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datagridView.Rows.Add(txtNome.Text, txtCurso.Text);

            txtNome.Clear();
            txtCurso.Clear();

            MessageBox.Show("Aluno Incluido com Sucesso", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTotal.Text = datagridView.RowCount.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (datagridView.SelectedRows.Count == 0)
            {
                
                MessageBox.Show("Nenhum Item Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                datagridView.Rows.RemoveAt(datagridView.CurrentRow.Index);

                txtTotal.Text = datagridView.RowCount.ToString();
                txtAlterado.Clear();
            }
        }

        private void datagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (datagridView.RowCount > 0)
            {
                txtAlterado.Text = datagridView.CurrentRow.Cells["Nome"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datagridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                datagridView.CurrentRow.Cells["Nome"].Value = txtAlterado.Text;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            datagridView.RowCount = 0;

            
            txtTotal.Text = datagridView.RowCount.ToString();
            txtAlterado.Clear();
        }
    }
}
