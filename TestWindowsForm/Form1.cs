using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Windsor;
using Component = Castle.MicroKernel.Registration.Component;


namespace TestWindowsForm
{
    public partial class Form1 : Form
    {
        private readonly ITemp _temp;
        public Form1()
        {
            IWindsorContainer container = new WindsorContainer();

            // Register the CompositionRoot type with the container
            container.Register(Component.For<ITemp>().ImplementedBy<Temp>());
            var root = container.Resolve<ITemp>();
            int fgh = root.add(2, 3);
            InitializeComponent();
        }

        public Form1(ITemp tamp)
        {

            this._temp = tamp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager=new Manager();
            var ty=manager.add(2, 2);
            int test = _temp.add(2, 4);
            _temp.a = 4;
        }
    }
}
