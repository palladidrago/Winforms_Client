using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindownsFormsApp_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
    public class Human
    {
        string fName { get; set; } string lName { get; set; } // Name of the guy
        int amountOfBtc { get; set; } //Amount of bitcoinz
        int age{ get; set; } //Age
        string phoneNumber { get; set; } //Phone number
        string bitcoinAddress { get; set; } //His bitcoin address

        public Human(string fName, string lName, int amountOfBtc, int age, string phoneNumber, string bitcoinAddress)
        {
            this.fName = fName;
            this.lName = lName;
            this.amountOfBtc = amountOfBtc;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.bitcoinAddress = bitcoinAddress;
        }
    }
}
