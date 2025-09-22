using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Form1 : Form
    {
        CompanyDBDataContext dc;
        public Form1()
        {           
            InitializeComponent();
            dc = new CompanyDBDataContext();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //direactly call dataGridView1
            //dataGridView1.DataSource = dc.Employees.ToList();
            Table<Employee> tab = dc.Employees;
            dataGridView1.DataSource = tab;

        }

      
    }
}
