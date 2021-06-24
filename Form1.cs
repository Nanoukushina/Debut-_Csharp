using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mon_Horloge
{
    public partial class Form1 : Form1Base, Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public sealed partial class ClockPage : Page {
            DispatcherTimer Timer = new DispatcherTimer();
        public ClockPage() { InitializeComponent(); 
                DataContext = this; Timer.Tick += Timer_Tick; Timer.Interval = new TimeSpan(0, 0, 1); 
                Timer.Start();
            }
            private void Timer_Tick(object sender, object e)
            { Time.Text = DateTime.Now.ToSsortingng("h:mm:ss tt");
            } 
        }


