using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecimalaBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool esNumCorrecto = int.TryParse(this.txtNumero.Text, out int numero);
            if (!esNumCorrecto)
            {
                MessageBox.Show("Debe Ingresar un valor numerico...");
                return;
            }

            if(!(numero >=0 && numero<=255))
            {
                MessageBox.Show("Numero fuera de rango...");
                return;
            }

            int[] res = binario(numero);
            Console.WriteLine("Inicio");
            for(int i=res.Length-1; i>=0; i--) 
            {
                Console.WriteLine("{0}", res[i]);
            }
            Console.WriteLine("fin");

            /*
            if (res[0] == 1)
                this.chk8.Checked = true;

            else
                this.chk8.Checked = false;
            */
            this.chk8.Checked = res[7] == 1 ? true : false;
            this.chk7.Checked = res[6] == 1 ? true : false;
            this.chk6.Checked = res[5] == 1 ? true : false;
            this.chk5.Checked = res[4] == 1 ? true : false;
            this.chk4.Checked = res[3] == 1 ? true : false;
            this.chk3.Checked = res[2] == 1 ? true : false;
            this.chk2.Checked = res[1] == 1 ? true : false;
            this.chk1.Checked = res[0] == 1 ? true : false;

        }

        private int[] binario(int num)
        {
            int[] bin = { 0, 0, 0, 0, 0, 0, 0, 0 };
            //int[] bin = new int[8];
            int i = 0;
            int resto = 0;
            while (num > 0)
            {
                resto = num % 2;
                bin[i++] = resto;
                num = num / 2;
                Console.WriteLine("{0}", resto);
            }

            return bin;
        }

        private void btnBinaDec_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (chk1.Checked) num += 1;
            if (chk2.Checked) num += 2;
            if (chk3.Checked) num += 4;
            if (chk4.Checked) num += 8;
            if (chk5.Checked) num += 16;
            if (chk6.Checked) num += 32;
            if (chk7.Checked) num += 64;
            if (chk1.Checked) num += 128;
            this.txtNumero.Text = num.ToString(); 

        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            sumaBinarioaDecimal();
        }

        void sumaBinarioaDecimal()
        {
            int num = 0;
            if (chk1.Checked) num += 1;
            if (chk2.Checked) num += 2;
            if (chk3.Checked) num += 4;
            if (chk4.Checked) num += 8;
            if (chk5.Checked) num += 16;
            if (chk6.Checked) num += 32;
            if (chk7.Checked) num += 64;
            if (chk8.Checked) num += 128;
            this.txtNumero.Text = num.ToString();
        }
    }
}
