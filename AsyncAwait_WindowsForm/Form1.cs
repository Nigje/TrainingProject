using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Text = await DoSomting();
        }

        private Task<string> DoSomting()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                return "Done";
            });
        }

    }

}
