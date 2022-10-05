using PointOfSale.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PointOfSale
{
    public partial class Form1 : Form
    {
        private int clientID;
        private int agentID;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void InitializeCombos()
        {
           foreach(Control ctl in gbxClient.Controls)
            {
               if(ctl is ComboBox)
                {
                    string prompt = "";
                    string query = "";
                    string value = "";
                    string display = "";
                    ComboBox cmb = (ComboBox)ctl;
                    switch (cmb.Name)
                    {
                        case "cmbClient":
                            query = "SELECT company_pk, company_name FROM tbl_company WHERE is_client = true";
                            value = "company_pk";
                            display = "company_name";
                            prompt = "Select Client";
                            break;
                        case "cmbAgent":
                            query = "SELECT p.personnel_pk, concat(p.first_name,' ',p.last_name,' -- ',o.office_desc) " +
                                "AS display " +
                                "FROM tbl_personnel p " +
                                "INNER JOIN tbl_office o " +
                                "ON p.office_fk = o.office_pk " +
                                "WHERE p.function_fk = 5";
                            value = "personnel_pk";
                            display = "display";
                            prompt = "Select Agent";
                            break;
                        case "cmbProjectType":
                            break;
                        case "cmbProject":
                            break;
                        case "cmbField":
                            break;
                        case "cmbZone":
                            break;
                        case "cmbSite":
                            break;
                        case "cmbDLS":
                            break;


                    }
                    MySQL_Connection conn = new MySQL_Connection();
                    //Create a binding source
                    conn.OpenConnection();
                    BindingSource bindingSource = new BindingSource(conn.DataTableGet(query), null);
                    conn.CloseConnection();
                    // set properties
                    cmb.DisplayMember = display;
                    cmb.ValueMember = value;
                    cmb.Text = prompt;
                    cmb.ForeColor = Color.Gray;
                    // must set last or breaks ...
                    cmb.DataSource = bindingSource;
                }

            }
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("I am selected.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.dvgField = new DataGridView();
            this.dvgParameter = new DataGridView();
            this.dvgSoluables = new DataGridView();
            this.dvgTotals = new DataGridView();
            this.dvgSaturationIndex = new DataGridView();
            this.dvgCorrosion = new DataGridView();
            btnSave.Visible = false;
            */
            InitializeCombos();
            this.FormClosing += new FormClosingEventHandler(Form1_Closing);
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
            /*
            if (textBox1.Text != strMyOriginalText)
            {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
            }
            */
            // cleanup, first release memory...
            System.Windows.Forms.Application.Exit();
        }
    }
}
