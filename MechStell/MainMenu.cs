using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechStell
{
    public partial class formMainMenu : Form
    {
        private String selectedStellwerk;
        public formMainMenu()
        {
            InitializeComponent();
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            boxStellwerk.Enabled = false;
            buttonConnect.Enabled = false;
            try
            {
                //MechStell.clientSocket.Connect(inputAdress.Text, Convert.ToInt32(numericPort.Value));
                labelStatus.Text = "Verbunden";
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Hupps...",MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonConnect.Enabled = true;
                labelStatus.Text = "Fehler";
                return;
            }

            new StellwerkGame().Run();
        }

        private void radioStellwerk_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (!radio.Checked)
            {
                return;
            }
            buttonConnect.Enabled = true;
            this.selectedStellwerk = radio.Name;
        }

        public void reActivate()
        {
            buttonConnect.Enabled = true;
            boxStellwerk.Enabled = true;
            labelStatus.Text = "Getrennt";
            MechStell.clientSocket = new System.Net.Sockets.TcpClient();
        }
    }
}
