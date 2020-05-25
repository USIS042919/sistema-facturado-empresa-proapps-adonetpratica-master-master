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
    public partial class FormularioAvanzados2 : Form
    {
        public FormularioAvanzados2()
        {
            InitializeComponent();
        }

        private void FormularioAvanzado2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.tabla2' Puede moverla o quitarla según sea necesario.
            this.tabla2TableAdapter.FillEmpleadosGastos(this.sistema_dbDataSet.tabla2);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.tabla1' Puede moverla o quitarla según sea necesario.
            this.tabla1TableAdapter.FillEmpleadoInforme(this.sistema_dbDataSet.tabla1);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.tabla1' Puede moverla o quitarla según sea necesario.
            this.tabla1TableAdapter.FillEmpleadoInforme(this.sistema_dbDataSet.tabla1);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet.tabla2' Puede moverla o quitarla según sea necesario.
            this.tabla2TableAdapter.FillEmpleadosGastos(this.sistema_dbDataSet.tabla2);

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            tabla2BindingSource.MoveFirst();
            tabla1BindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tabla2BindingSource.MovePrevious();
            tabla1BindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            tabla2BindingSource.MoveNext();
            tabla1BindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            tabla2BindingSource.MoveLast();
            tabla1BindingSource.MoveLast();
        }
    }
}
