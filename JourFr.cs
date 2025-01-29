using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thrive
{
    public partial class JourFr : Form
    {
        public JourFr()
        {
            InitializeComponent();
        }

        private void JourDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassJournal cj = new ClassJournal();
            JourDataGrid.DataSource = cj.ViewEntries();
            JourDataGrid.AutoGenerateColumns = true;
        }
    }
}
