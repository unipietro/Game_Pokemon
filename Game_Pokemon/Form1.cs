using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;

namespace Game_Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int turno = 0;
        int cont1 = 0, cont2 = 0, piscaFundo = 0, linha = 0, coluna = 0;
        string enderecoImagem;
        SoundPlayer somPikachu = new SoundPlayer(@"pokemon/pikachu.wav");
        SoundPlayer somSquirtle = new SoundPlayer(@"pokemon/squirtle.wav");
        int[,] jogo = { {0,0,0}, {0,0,0}, {0,0,0} };

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "";
            turno = 1;
            FundoJogador(turno);

        }

        private void FundoJogador(int verTurno)
        {

            if(verTurno == 1)
            {
                pictureBox11.BackColor = Color.Yellow;
                pictureBox12.BackColor = Color.Transparent;
            }
            else 
            {
                pictureBox11.BackColor = Color.Transparent;
                pictureBox12.BackColor = Color.Yellow;
            }
        }

        private void ParaJogo()
        {
            pictureBox9.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox10.Enabled = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            linha = 0;
            coluna = 0;
            CampoJogado(linha, coluna);
            pictureBox9.Load(enderecoImagem);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            linha = 0;
            coluna = 1;
            CampoJogado(linha, coluna);
            pictureBox4.Load(enderecoImagem);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            linha = 0;
            coluna = 2;
            CampoJogado(linha, coluna);
            pictureBox7.Load(enderecoImagem);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            linha = 1;
            coluna = 0;
            CampoJogado(linha, coluna);
            pictureBox2.Load(enderecoImagem);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            linha = 1;
            coluna = 1;
            CampoJogado(linha, coluna);
            pictureBox5.Load(enderecoImagem);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            linha = 1;
            coluna = 2;
            CampoJogado(linha, coluna);
            pictureBox8.Load(enderecoImagem);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            linha = 2;
            coluna = 0;
            CampoJogado(linha, coluna);
            pictureBox3.Load(enderecoImagem);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            linha = 2;
            coluna = 1;
            CampoJogado(linha, coluna);
            pictureBox6.Load(enderecoImagem);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            linha = 2;
            coluna = 2;
            CampoJogado(linha, coluna);
            pictureBox10.Load(enderecoImagem);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox9.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox10.Enabled = true;

            label3.Text = "";
            label3.BackColor = Color.Transparent;

            pictureBox9.Load("pokemon/pokebola1.png");
            pictureBox4.Load("pokemon/pokebola1.png");
            pictureBox7.Load("pokemon/pokebola1.png");
            pictureBox2.Load("pokemon/pokebola1.png");
            pictureBox5.Load("pokemon/pokebola1.png");
            pictureBox8.Load("pokemon/pokebola1.png");
            pictureBox3.Load("pokemon/pokebola1.png");
            pictureBox6.Load("pokemon/pokebola1.png");
            pictureBox10.Load("pokemon/pokebola1.png");

            for (int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 3; c++)
                {
                    jogo[l, c] = 0;
                }
            }
            turno = 1;
            FundoJogador(turno);
            timer1.Enabled = false;
            label1.Text = Convert.ToString(cont1);
            label2.Text = Convert.ToString(cont2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(piscaFundo==1)
            {
                label3.BackColor = label3.BackColor == Color.Gold ? Color.Transparent : Color.Gold;
                pictureBox11.BackColor = pictureBox11.BackColor == Color.Gold ? Color.Transparent : Color.Gold;
            }
            else
            {
                label3.BackColor = label3.BackColor == Color.Gold ? Color.Transparent : Color.Gold;
                pictureBox12.BackColor = pictureBox12.BackColor == Color.Gold ? Color.Transparent : Color.Gold;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox9.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox10.Enabled = true;

            label3.Text = "";
            label3.BackColor = Color.Transparent;

            pictureBox9.Load("pokemon/pokebola1.png");
            pictureBox4.Load("pokemon/pokebola1.png");
            pictureBox7.Load("pokemon/pokebola1.png");
            pictureBox2.Load("pokemon/pokebola1.png");
            pictureBox5.Load("pokemon/pokebola1.png");
            pictureBox8.Load("pokemon/pokebola1.png");
            pictureBox3.Load("pokemon/pokebola1.png");
            pictureBox6.Load("pokemon/pokebola1.png");
            pictureBox10.Load("pokemon/pokebola1.png");

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    jogo[l, c] = 0;
                }
            }
            turno = 1;
            FundoJogador(turno);
            timer1.Enabled = false;
            cont1 = 0;
            cont2 = 0;
            label1.Text = Convert.ToString(cont1);
            label2.Text = Convert.ToString(cont2);
        }

        private void VencePikachu()
        {
            somPikachu.Play();
            label3.Text = "Pikachu";
            label3.BackColor = Color.Transparent;
            cont1++;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            ParaJogo();
            piscaFundo = 1;
            timer1.Enabled = true;
        }

        private void VenceSquirtle()
        {
            somSquirtle.Play();
            label3.Text = "Squirtle";
            label3.BackColor = Color.Transparent;
            cont2++;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            ParaJogo();
            piscaFundo = 2;
            timer1.Enabled = true;
        }

        private void VerificaGanhador()
        {
            // Pikachu
            // Verificando linhas
            if(jogo[0,0] == 1 && jogo[0,1] == 1 && jogo[0,2] == 1)
            {
                VencePikachu();
            }

            if (jogo[1, 0] == 1 && jogo[1, 1] == 1 && jogo[1, 2] == 1)
            {
                VencePikachu();
            }

            if (jogo[2, 0] == 1 && jogo[2, 1] == 1 && jogo[2, 2] == 1)
            {
                VencePikachu();
            }
            // Verificando Colunas
            if (jogo[0, 0] == 1 && jogo[1, 0] == 1 && jogo[2, 0] == 1)
            {
                VencePikachu();
            }

            if (jogo[0, 1] == 1 && jogo[1, 1] == 1 && jogo[2, 1] == 1)
            {
                VencePikachu();
            }

            if (jogo[0, 2] == 1 && jogo[1, 2] == 1 && jogo[2, 2] == 1)
            {
                VencePikachu();
            }

            // Diagonais
            if (jogo[0, 0] == 1 && jogo[1, 1] == 1 && jogo[2, 2] == 1)
            {
                VencePikachu();
            }

            if (jogo[2, 0] == 1 && jogo[1, 1] == 1 && jogo[0, 2] == 1)
            {
                VencePikachu();
            }

            // Squirtle
            // Verificando linhas
            if (jogo[0, 0] == 2 && jogo[0, 1] == 2 && jogo[0, 2] == 2)
            {
                VenceSquirtle();
            }

            if (jogo[1, 0] == 2 && jogo[1, 1] == 2 && jogo[1, 2] == 2)
            {
                VenceSquirtle();
            }

            if (jogo[2, 0] == 2 && jogo[2, 1] == 2 && jogo[2, 2] == 2)
            {
                VenceSquirtle();
            }
            // Verificando Colunas
            if (jogo[0, 0] == 2 && jogo[1, 0] == 2 && jogo[2, 0] == 2)
            {
                VenceSquirtle();
            }

            if (jogo[0, 1] == 2 && jogo[1, 1] == 2 && jogo[2, 1] == 2)
            {
                VenceSquirtle();
            }

            if (jogo[0, 2] == 2 && jogo[1, 2] == 2 && jogo[2, 2] == 2)
            {
                VenceSquirtle();
            }

            // Diagonais
            if (jogo[0, 0] == 2 && jogo[1, 1] == 2 && jogo[2, 2] == 2)
            {
                VenceSquirtle();
            }

            if (jogo[2, 0] == 2 && jogo[1, 1] == 2 && jogo[0, 2] == 2)
            {
                VenceSquirtle();
            }

            label1.Text = Convert.ToString(cont1);
            label2.Text = Convert.ToString(cont2);
        }

        private void CampoJogado(int linhaJogada, int colunaJogada)
        {
            if (jogo[linhaJogada, colunaJogada] == 0)
            {
                if (turno == 1)
                {
                    enderecoImagem = "pokemon/pikachu.png";
                    jogo[linhaJogada, colunaJogada] = turno;
                    turno = 2;
                    FundoJogador(turno);
                }
                else
                {
                    enderecoImagem = "pokemon/squirtle.png";
                    jogo[linhaJogada, colunaJogada] = turno;
                    turno = 1;
                    FundoJogador(turno);
                }
            }
            else
            {
                MessageBox.Show("Já foi jogado neste campo! \nEscolha outro campo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FundoJogador(turno);
            VerificaGanhador();
        }

       
    }
}
