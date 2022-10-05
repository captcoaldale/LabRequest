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
            InitializeCombos();
        }
        private void InitializeCombos()
        {
            foreach(Control ctl in this.Controls)
            {
                string prompt = "Select Client";
                if(ctl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctl;
                    switch(cmb.Name)
                    {
                        case"cmbClient":
                            break;
                        case "cmbAgent":
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
                    cmb.Text = prompt;
                    cmb.ForeColor = Color.LightGray;
                }

            }
        }
    }
}
