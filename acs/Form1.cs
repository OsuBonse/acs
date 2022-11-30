using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Collections.Specialized;
using System.Xml.Linq;
namespace acs
{
    public partial class Form1 : Form
    {
        public static bool flag = false;
        public Form1()
        {
            InitializeComponent();
           
        }
        public void button1_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            openFileDialog1.InitialDirectory = "C:\\Users\\3d\\Documents\\Assetto Corsa\\setups";
            string fileText = System.IO.File.ReadAllText(textBox1.Text);
            textBox2.Text = fileText;
            INIManager manager = new INIManager(textBox1.Text);

            string ArbFront = manager.GetPrivateString("ARB_FRONT", "VALUE");
            string ArbRear = manager.GetPrivateString("ARB_REAR", "VALUE");

            string BrakePowerMult = manager.GetPrivateString("BRAKE_POWER_MULT", "VALUE");

            string CamberLf = manager.GetPrivateString("CAMBER_LF", "VALUE");
            string CamberLr = manager.GetPrivateString("CAMBER_LR", "VALUE");
            string CamberRf = manager.GetPrivateString("CAMBER_RF", "VALUE");
            string CamberRr = manager.GetPrivateString("CAMBER_RR", "VALUE");

            string DampBumpLf = manager.GetPrivateString("DAMP_BUMP_LF", "VALUE");
            string DampBumpLr = manager.GetPrivateString("DAMP_BUMP_LR", "VALUE");
            string DampBumpRf = manager.GetPrivateString("DAMP_BUMP_RF", "VALUE");
            string DampBumpRr = manager.GetPrivateString("DAMP_BUMP_RR", "VALUE");

            string DampFastBumpLf = manager.GetPrivateString("DAMP_FAST_BUMP_LF", "VALUE");
            string DampFastBumpLr = manager.GetPrivateString("DAMP_FAST_BUMP_LR", "VALUE");
            string DampFastBumpRf = manager.GetPrivateString("DAMP_FAST_BUMP_RF", "VALUE");
            string DampFastBumpRr = manager.GetPrivateString("DAMP_FAST_BUMP_RR", "VALUE");

            string DampFastReboundLf = manager.GetPrivateString("DAMP_FAST_REBOUND_LF", "VALUE");
            string DampFastReboundLr = manager.GetPrivateString("DAMP_FAST_REBOUND_LR", "VALUE");
            string DampFastReboundRf = manager.GetPrivateString("DAMP_FAST_REBOUND_RF", "VALUE");
            string DampFastReboundRr = manager.GetPrivateString("DAMP_FAST_REBOUND_RR", "VALUE");

            string DampReboundLf = manager.GetPrivateString("ARB_FRONT", "VALUE");
            string DampReboundLr = manager.GetPrivateString("ARB_FRONT", "VALUE");
            string DampReboundRf = manager.GetPrivateString("ARB_FRONT", "VALUE");
            string DampReboundRr = manager.GetPrivateString("ARB_FRONT", "VALUE");

            string DiffCoast = manager.GetPrivateString("DIFF_COAST", "VALUE");
            string DiffPower = manager.GetPrivateString("DIFF_POWER", "VALUE");
            string DiffPreload = manager.GetPrivateString("DIFF_PRELOAD", "VALUE");

            string EngineLimiter = manager.GetPrivateString("ENGINE_LIMITER", "VALUE");
            string FinalRatio = manager.GetPrivateString("FINAL_RATIO", "VALUE");
            string FrontBias = manager.GetPrivateString("FRONT_BIAS", "VALUE");

            string Fuel = manager.GetPrivateString("FUEL", "VALUE");

            string Gearset = manager.GetPrivateString("GEARSET", "VALUE");

            string PressureLf = manager.GetPrivateString("PRESSURE_LF", "VALUE");
            string PressureLr = manager.GetPrivateString("PRESSURE_LR", "VALUE");
            string PressureRf = manager.GetPrivateString("PRESSURE_RF", "VALUE");
            string PressureRr = manager.GetPrivateString("PRESSURE_RR", "VALUE");

            string RodLengthLf = manager.GetPrivateString("ROD_LENGTH_LF", "VALUE");
            string RodLengthLr = manager.GetPrivateString("ROD_LENGTH_LR", "VALUE");
            string RodLengthRf = manager.GetPrivateString("ROD_LENGTH_RF", "VALUE");
            string RodLengthRr = manager.GetPrivateString("ROD_LENGTH_RR", "VALUE");

            string SpringRateLf = manager.GetPrivateString("SPRING_RATE_LF", "VALUE");
            string SpringRateLr = manager.GetPrivateString("SPRING_RATE_LR", "VALUE");
            string SpringRateRf = manager.GetPrivateString("SPRING_RATE_RF", "VALUE");
            string SpringRateRr = manager.GetPrivateString("SPRING_RATE_RR", "VALUE");

            string ToeOutLf = manager.GetPrivateString("TOE_OUT_LF", "VALUE");
            string ToeOutLr = manager.GetPrivateString("TOE_OUT_LR", "VALUE");
            string ToeOutRf = manager.GetPrivateString("TOE_OUT_RF", "VALUE");
            string ToeOutRr = manager.GetPrivateString("TOE_OUT_RR", "VALUE");

            string Turbo = manager.GetPrivateString("TURBO", "VALUE");

            string Tyres = manager.GetPrivateString("TYRES", "VALUE");

            textBox3.Text = ArbFront;
            textBox4.Text = ArbRear;

            textBox5.Text = BrakePowerMult;

            textBox6.Text = CamberLf;
            textBox7.Text = CamberLr;
            textBox52.Text = CamberRf;
            textBox9.Text = CamberRr;

            textBox10.Text = DampBumpLf;
            textBox11.Text = DampBumpLr;
            textBox12.Text = DampBumpRf;
            textBox13.Text = DampBumpRr;

            textBox14.Text = DampFastBumpLf;
            textBox15.Text = DampFastBumpLr;
            textBox16.Text = DampFastBumpRf;
            textBox17.Text = DampFastBumpRr;

            textBox18.Text = DampFastReboundLf;
            textBox19.Text = DampFastReboundLr;
            textBox20.Text = DampFastReboundRf;
            textBox21.Text = DampFastReboundRr;

            textBox22.Text = DampReboundLf;
            textBox23.Text = DampReboundLr;
            textBox24.Text = DampReboundRf;
            textBox25.Text = DampReboundRr;

            textBox26.Text = DiffCoast;
            textBox27.Text = DiffPower;
            textBox28.Text = DiffPreload;

            textBox29.Text = EngineLimiter;
            textBox30.Text = FinalRatio;
            textBox31.Text = FrontBias;

            textBox53.Text = Fuel;

            textBox33.Text = Gearset;

            textBox34.Text = PressureLf;
            textBox35.Text = PressureLr;
            textBox36.Text = PressureRf;
            textBox37.Text = PressureRr;

            textBox38.Text = RodLengthLf;
            textBox39.Text = RodLengthLr;
            textBox40.Text = RodLengthRf;
            textBox41.Text = RodLengthRr;

            textBox42.Text = SpringRateLf;
            textBox43.Text = SpringRateLr;
            textBox44.Text = SpringRateRf;
            textBox54.Text = SpringRateRr;

            textBox46.Text = ToeOutLf;
            textBox47.Text = ToeOutLr;
            textBox48.Text = ToeOutRf;
            textBox49.Text = ToeOutRr;

            textBox50.Text = Turbo;

            textBox55.Text = Tyres;
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            textBox3.Text = trackBar1.Value.ToString();
            trackBar1.Minimum = 100;
            trackBar1.Maximum = 13000;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = trackBar2.Value.ToString();
            trackBar2.Minimum = 100;
            trackBar2.Maximum = 13000;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            flag = true;
            INIManager manager = new INIManager(textBox1.Text);
            manager.WritePrivateString("ARB_FRONT", "VALUE", textBox3.Text);
            manager.WritePrivateString("ARB_REAR", "VALUE", textBox4.Text);

            manager.WritePrivateString("BRAKE_POWER_MULT", "VALUE", textBox5.Text);

            manager.WritePrivateString("CAMBER_LF", "VALUE", textBox6.Text);
            manager.WritePrivateString("CAMBER_LR", "VALUE", textBox7.Text);
            manager.WritePrivateString("CAMBER_RF", "VALUE", textBox52.Text);
            manager.WritePrivateString("CAMBER_RR", "VALUE", textBox9.Text);

            manager.WritePrivateString("DAMP_BUMP_LF", "VALUE", textBox10.Text);
            manager.WritePrivateString("DAMP_BUMP_LR", "VALUE", textBox11.Text);
            manager.WritePrivateString("DAMP_BUMP_RF", "VALUE", textBox12.Text);
            manager.WritePrivateString("DAMP_BUMP_RR", "VALUE", textBox13.Text);

            manager.WritePrivateString("DAMP_FAST_BUMP_LF", "VALUE", textBox14.Text);
            manager.WritePrivateString("DAMP_FAST_BUMP_LR", "VALUE", textBox15.Text);
            manager.WritePrivateString("DAMP_FAST_BUMP_RF", "VALUE", textBox16.Text);
            manager.WritePrivateString("DAMP_FAST_BUMP_RR", "VALUE", textBox17.Text);

            manager.WritePrivateString("DAMP_FAST_REBOUND_LF", "VALUE", textBox18.Text);
            manager.WritePrivateString("DAMP_FAST_REBOUND_LR", "VALUE", textBox19.Text);
            manager.WritePrivateString("DAMP_FAST_REBOUND_RF", "VALUE", textBox20.Text);
            manager.WritePrivateString("DAMP_FAST_REBOUND_RR", "VALUE", textBox21.Text);

            manager.WritePrivateString("DAMP_REBOUND_LF", "VALUE", textBox22.Text);
            manager.WritePrivateString("DAMP_REBOUND_LR", "VALUE", textBox23.Text);
            manager.WritePrivateString("DAMP_REBOUND_RF", "VALUE", textBox24.Text);
            manager.WritePrivateString("DAMP_REBOUND_RR", "VALUE", textBox25.Text);

            manager.WritePrivateString("DIFF_COAST", "VALUE", textBox26.Text);
            manager.WritePrivateString("DIFF_POWER", "VALUE", textBox27.Text);
            manager.WritePrivateString("DIFF_PRELOAD", "VALUE", textBox28.Text);

            manager.WritePrivateString("ENGINE_LIMITER", "VALUE", textBox29.Text);
            manager.WritePrivateString("FINAL_RATIO", "VALUE", textBox30.Text);
            manager.WritePrivateString("FRONT_BIAS", "VALUE", textBox31.Text);

            manager.WritePrivateString("FUEL", "VALUE", textBox53.Text);

            manager.WritePrivateString("GEARSET", "VALUE", textBox33.Text);

            manager.WritePrivateString("PRESSURE_LF", "VALUE", textBox34.Text);
            manager.WritePrivateString("PRESSURE_LR", "VALUE", textBox35.Text);
            manager.WritePrivateString("PRESSURE_RF", "VALUE", textBox36.Text);
            manager.WritePrivateString("PRESSURE_RR", "VALUE", textBox37.Text);

            manager.WritePrivateString("ROD_LENGTH_LF", "VALUE", textBox38.Text);
            manager.WritePrivateString("ROD_LENGTH_LR", "VALUE", textBox39.Text);
            manager.WritePrivateString("ROD_LENGTH_RF", "VALUE", textBox40.Text);
            manager.WritePrivateString("ROD_LENGTH_RR", "VALUE", textBox54.Text);

            manager.WritePrivateString("SPRING_RATE_LF", "VALUE", textBox42.Text);
            manager.WritePrivateString("SPRING_RATE_LR", "VALUE", textBox43.Text);
            manager.WritePrivateString("SPRING_RATE_RF", "VALUE", textBox44.Text);
            manager.WritePrivateString("SPRING_RATE_RR", "VALUE", textBox45.Text);

            manager.WritePrivateString("TOE_OUT_LF", "VALUE", textBox46.Text);
            manager.WritePrivateString("TOE_OUT_LR", "VALUE", textBox47.Text);
            manager.WritePrivateString("TOE_OUT_RF", "VALUE", textBox48.Text);
            manager.WritePrivateString("TOE_OUT_RR", "VALUE", textBox49.Text);

            manager.WritePrivateString("TURBO", "VALUE", textBox50.Text);

            manager.WritePrivateString("TYRES", "VALUE", textBox55.Text);

            if (flag == true)
            {
                flag = false;
                string fileText = System.IO.File.ReadAllText(textBox1.Text);
                textBox2.Text = fileText;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
