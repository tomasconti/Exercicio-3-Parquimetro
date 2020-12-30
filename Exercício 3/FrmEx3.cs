using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_3
{
    public partial class Form1 : Form
    {
        private Parquimetro parquimetro = new Parquimetro();
        float saldo = 0;
        public Form1()
        {
            InitializeComponent();
            lblRS2.Visible = false;
            lblSaldo.Visible = false;
            lblTitulosaldo.Visible = false;
            lblConfirma.Visible = false; 

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lblRS2.Visible = false;
            lblSaldo.Visible = false;
            lblTitulosaldo.Visible = false;
            lblConfirma.Visible = false;

            float moeda;
            if(radValor1.Checked)
            {
                moeda = 0.05f;
                parquimetro.adicionaMoeda(moeda);
            }
            if (radValor2.Checked)
            {
                moeda = 0.10f;
                parquimetro.adicionaMoeda(moeda);
            }
            if (radValor3.Checked)
            {
                moeda = 0.50f;
                parquimetro.adicionaMoeda(moeda);
            }
            if (radValor4.Checked)
            {
                moeda = 1.00f;
                parquimetro.adicionaMoeda(moeda);
            }
        
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblRS2.Visible = true;
            lblSaldo.Visible = true;
            lblTitulosaldo.Visible = true;
            lblConfirma.Visible = false;

            saldo = parquimetro.consultaSaldo();
            lblSaldo.Text = saldo.ToString();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            parquimetro.cancelar();
            lblRS2.Visible = false;
            lblSaldo.Visible = false;
            lblTitulosaldo.Visible = false;
            lblConfirma.Visible = false;

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            float hora = 0;
            lblRS2.Visible = false;
            lblSaldo.Visible = false;
            lblTitulosaldo.Visible = false;
            lblConfirma.Visible = true;

            if (radHora1.Checked)
            {
                hora = 1;
               float valor = parquimetro.confirmar(hora);
              
                if ( valor > parquimetro.Saldo)
                {
                    lblConfirma.Text = "Saldo insuficiente!!";
                  
                }
                if(valor < parquimetro.Saldo || valor == parquimetro.Saldo)
                {
                    float troco = parquimetro.Saldo - valor;
                    lblConfirma.Text = "Compra finalizada, seu troco é R$ " + troco;
                    parquimetro.Saldo = 0;
                }
            }
            if (radHora2.Checked)
            {
                hora = 2;
                float valor = parquimetro.confirmar(hora);

                if (valor > parquimetro.Saldo)
                {
                    lblConfirma.Text = "Saldo insuficiente!!";

                }
                if (valor < parquimetro.Saldo || valor == parquimetro.Saldo)
                {
                    float troco = parquimetro.Saldo - valor;
                    lblConfirma.Text = "Compra finalizada, seu troco é R$ " + troco;
                    parquimetro.Saldo = 0;
                }
            }
            if (radHora3.Checked)
            {
                hora = 3;
                float valor = parquimetro.confirmar(hora);

                if (valor > parquimetro.Saldo)
                {
                    lblConfirma.Text = "Saldo insuficiente!!";

                }
                if (valor < parquimetro.Saldo || valor == parquimetro.Saldo)
                {
                    float troco = parquimetro.Saldo - valor;
                    lblConfirma.Text = "Compra finalizada, seu troco é R$ " + troco;
                    parquimetro.Saldo = 0;
                }
            }
            if (radHora4.Checked)
            {
                hora = 4;
               float valor= parquimetro.confirmar(hora);
             
                if (valor > parquimetro.Saldo)
                {
                    lblConfirma.Text = "Saldo insuficiente!!";

                }
                if (valor < parquimetro.Saldo || valor == parquimetro.Saldo)
                {
                    float troco = parquimetro.Saldo - valor;
                    lblConfirma.Text = "Compra finalizada, seu troco é R$ " + troco;
                    parquimetro.Saldo = 0;
                }
            }
        }

        private void radHora1_CheckedChanged(object sender, EventArgs e)
        {
            lblValor.Text = "1.50";
        }

        private void radHora2_CheckedChanged(object sender, EventArgs e)
        {
            lblValor.Text = "3.00";
        }

        private void radHora3_CheckedChanged(object sender, EventArgs e)
        {
            lblValor.Text = "4.50";
        }

        private void radHora4_CheckedChanged(object sender, EventArgs e)
        {
            lblValor.Text = "6.00";
        }
    }
}
