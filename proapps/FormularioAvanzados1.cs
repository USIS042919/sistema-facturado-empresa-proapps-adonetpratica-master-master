using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proapps
{
    public partial class FormularioAvanzados1 : Form
    {
        public FormularioAvanzados1()
        {
            InitializeComponent();
        }

        private void FormularioAvanzados1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.Dato1' Puede moverla o quitarla según sea necesario.
            this.dato1TableAdapter.FillEventosClientes(this.sistema_dbDataSet.Dato1);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.Dato2' Puede moverla o quitarla según sea necesario.
            this.dato2TableAdapter.FillEventosClientes(this.sistema_dbDataSet.Dato2);




        }


        private void btnPrimero_Click_1(object sender, EventArgs e)
        {
            dato2BindingSource.MoveFirst();
            dato1BindingSource.MoveFirst();
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            dato2BindingSource.MovePrevious();
            dato1BindingSource.MovePrevious();
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            dato2BindingSource.MoveNext();
            dato1BindingSource.MoveNext();
        }

        private void btnUltimo_Click_1(object sender, EventArgs e)
        {
            dato2BindingSource.MoveLast();
            dato1BindingSource.MoveLast();
        }

        private void unionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
