using PointOfSale.DataObjects;
using System;
using System.Drawing;
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

        private void InitializeCombos(GroupBox gbx)
        {
           foreach(Control ctl in gbx.Controls)
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
                            query = "SELECT project_type_pk, project_type_desc " +
                                   "FROM tbl_project_type;";                              
                            value = "project_type_pk";
                            display = "project_type_desc";
                            prompt = "Select Project Type";
                            break;
                        case "cmbProject":
                            break;
                        case "cmbProjectObjective":
                            query = "SELECT objective_pk, objective_desc " +
                                  "FROM tbl_project_objective;";
                            value = "objective_pk";
                            display = "objective_desc";
                            prompt = "Select Project Objective";
                            break;
                        case "cmbPriorityRequested":
                            query = "SELECT priority_pk, priority_desc " +
                                  "FROM tbl_priority;";
                            value = "priority_pk";
                            display = "priority_desc";
                            prompt = "Select Project Priority";
                            break;
                        case "cmbPrice":
                            query = "SELECT price_pk, amount " +
                                  "FROM tbl_price;";
                            value = "price_pk";
                            display = "amount";
                            prompt = "Select Project Price";
                            break;
                        case "cmbTest":
                            query = "SELECT test_method_pk, " +
                                "concat(acronym,' -- ', method_desc) as display " +
                                 "FROM tbl_test_method;";
                            value = "test_method_pk";
                            display = "display";
                            prompt = "Select Project Test";
                            break;
                        case "cmbField":
                            break;
                        case "cmbZone":
                            break;
                        case "cmbDLS":
                            break;
                        case "cmbSite":
                            break;
                        default:
                            break;

                    }
                    if (!string.IsNullOrEmpty(query))
                    {
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
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clientID = GetSelectedValue((ComboBox)sender);
            GetLocationForClient();
            //MessageBox.Show(this.clientID.ToString());
        }

        private int GetSelectedValue(ComboBox cmb)
        {
            object sv = cmb.SelectedValue.ToString();
            return Convert.ToInt32(sv);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             btnSave.Visible = false;
             InitializeCombos(this.gbxClient);
            InitializeCombos(this.gbxProject);
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

        private void cmbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.agentID = GetSelectedValue((ComboBox)sender);
            MessageBox.Show(this.agentID.ToString());
        }

        private void GetLocationForClient()
        {
            MySQL_Connection conn = new MySQL_Connection();
            string query = "SELECT l.location_pk, c.company_name, f.field_desc, " +
                "z.zone_desc, s.site_desc, l.land_desc, l.location_notes " +
                "FROM tbl_location l " +
                "INNER JOIN  tbl_company  c ON  l.client_fk = c.company_pk " +
                "INNER JOIN tbl_field f ON l.field_fk = f.field_pk " +
                "INNER JOIN tbl_zone z ON l.zone_fk = z.zone_pk " +
                "INNER JOIN tbl_site s ON l.site_fk = s.site_pk " +
                "where c.company_pk = " + this.clientID;
            conn.OpenConnection();
            BindingSource bindingSource = new BindingSource(conn.DataTableGet(query), null);
            conn.CloseConnection();
            // set properties
            dgvDisplay.DataSource = bindingSource;

        }
    }
}
