using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ConnectionControl : UserControl
    {
        private Button connectButton;
        private TextBox ipTextBox;
        public ConnectionControl()
        {
            connectButton=new Button();
            ipTextBox=new TextBox();    

            connectButton.Location=new Point(10,10);
            connectButton.Size=new Size(100,30); 
            ipTextBox.Location=new Point(120,10);
            ipTextBox.Size=new Size(150,30);
            this.Controls.Add(connectButton);
            this.Controls.Add(ipTextBox);

            connectButton.Click += ConnectButton_Click;

            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
           string ipAddress=ipTextBox.Text.Trim();
        }
    }
}
