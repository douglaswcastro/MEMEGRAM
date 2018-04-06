using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criador_de_memes
{
    public partial class Form1 : Form
    {
        static int tamanholetra = 36;
        static int tamletinf = 36;
        static string fonte;
        static string corsup, corinf;
        string imagemDeSaida;
        int altura;
        int largura;

        static void ExibirImagem(Bitmap image)
        {
            Task mytask = Task.Run(() =>
            {
                var f = new Form();
                PictureBox p = new PictureBox
                {
                    Name = "MEME",
                    Size = new Size(image.Width, image.Height),
                    Location = new Point(0, 0),
                    Image = image,

                };
                f.Controls.Add(p);
                f.SetBounds(10, 10, image.Width + 20, image.Height + 40);
                f.ShowDialog();
                Application.DoEvents();

            });
        }

        public Form1()
        {
            InitializeComponent();
            txtfontsup.Text = tamanholetra.ToString();
            txtfontinf.Text = tamletinf.ToString();
            cbfonte.SelectedIndex = 0;
            cbcorsup.SelectedIndex = 0;
            cbcorinf.SelectedIndex = 0;
            txtcaminho.Enabled = false;
            txtcaminho.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.FileName = "openFileDialog1";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.ShowDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.InitialDirectory = @"C:\Users\Public\Pictures\Sample Pictures";
                openFileDialog1.Title = "Localizar Imagem";
                openFileDialog1.CheckFileExists = true;
                string imagemDeEntrada = openFileDialog1.FileName;
            }
        }

        private void btnbuscar_Click(object sender, System.EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";

            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtcaminho.Text = openFileDialog1.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Não existe o arquivo: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvisualizar_Click(object sender, EventArgs e)
        {
            string imagemdeentrada = txtcaminho.Text;
            string textoSuperior = txttextosup.Text;
            string textoInferior = txttextoinf.Text;


            fonte = cbfonte.SelectedItem.ToString();
            corsup = cbcorsup.SelectedItem.ToString();
            corinf = cbcorinf.SelectedItem.ToString();

            SizeF stringSize = new SizeF();

            if (txtcaminho.Text == "")
            {
                MessageBox.Show("Selecione imagem");
            }
            else
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(imagemdeentrada);//load the image file


                altura = bitmap.Height;
                largura = bitmap.Width;

                tamanholetra = int.Parse(txtfontsup.Text);
                tamletinf = int.Parse(txtfontinf.Text);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    if (tamanholetra <= 0)
                    {
                        MessageBox.Show("tamanho da letra superior precisa ser maior que 0");
                    }
                    else if (tamletinf <= 0)
                    {
                        MessageBox.Show("tamanho da letra inferior precisa ser maior que 0");
                    }
                    else
                    {

                        using (Font stringFont = new Font(fonte, tamanholetra))
                        {
                            // Calcula o tamanho do texto superior baseado na fonte escolhida
                            stringSize = graphics.MeasureString(textoSuperior, stringFont);

                            // Define a posição do texto superior centralizado
                            PointF posSuperior = new PointF((largura + stringSize.Width) / 2, 10f);
                            PointF sombraSuperior = new PointF(posSuperior.X + 3, posSuperior.Y + 3);

                            //Sombra primeiro, para desenhar "por baixo"
                            switch (corsup)
                            {
                                case "Branco":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.White, posSuperior);
                                    break;
                                case "Preto":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, posSuperior);
                                    break;
                                case "Azul":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Blue, posSuperior);
                                    break;
                                case "Verde":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Green, posSuperior);
                                    break;
                                case "Rosa":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Pink, posSuperior);
                                    break;
                                case "Amarelo":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Yellow, posSuperior);
                                    break;
                                case "Vermelho":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Red, posSuperior);
                                    break;
                                default:
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.White, posSuperior);
                                    break;
                            }


                        }
                        using (Font stringFont = new Font(fonte, tamletinf))
                        {
                            // Calcula o tamanho do texto inferior baseado na fonte escolhida
                            stringSize = graphics.MeasureString(textoInferior, stringFont);

                            // Define a posição do texto inferior centralizado
                            PointF posInferior = new PointF((largura - stringSize.Width) / 2, altura - stringSize.Height - 10f);
                            PointF sombraInferior = new PointF(posInferior.X + 3, posInferior.Y + 3);
                            // Desenha os textos na imagem.

                            switch (corinf)
                            {
                                case "Branco":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.White, posInferior);
                                    break;
                                case "Preto":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, posInferior);
                                    break;
                                case "Azul":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Blue, posInferior);
                                    break;
                                case "Verde":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Green, posInferior);
                                    break;
                                case "Rosa":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Pink, posInferior);
                                    break;
                                case "Amarelo":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Yellow, posInferior);
                                    break;
                                case "Vermelho":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Red, posInferior);
                                    break;
                                default:
                                    graphics.DrawString(textoInferior, stringFont, Brushes.White, posInferior);
                                    break;
                            }

                        }

                        ExibirImagem(bitmap);

                    }

                }


            }

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            fonte = cbfonte.SelectedItem.ToString();
            corsup = cbcorsup.SelectedItem.ToString();
            corinf = cbcorinf.SelectedItem.ToString();

            if (txtcaminho.Text == "")
            {
                MessageBox.Show("Selecione imagem e salve para ser feliz");
            }
            else
            {
                //define o titulo
                saveFileDialog1.Title = "Salvar Arquivo Texto";

                saveFileDialog1.Filter = "imagem| *.jpg"; ;

                saveFileDialog1.FilterIndex = 1;

                saveFileDialog1.FileName = "";

                saveFileDialog1.DefaultExt = ".jpg";

                saveFileDialog1.InitialDirectory = openFileDialog1.FileName;
                //restauro o diretorio atual antes de fechar a janela
                saveFileDialog1.RestoreDirectory = true;
                //exibe um aviso se o usuário informar um arquivo que não existe
                //saveFileDialog1.CheckFileExists = true;
                //exibe um aviso se o usuário informar um caminho que não existe
                saveFileDialog1.CheckPathExists = true;

                //Open the dialog and determine which button was pressed
                DialogResult resultado = saveFileDialog1.ShowDialog();

                //Se o ousuário pressionar o botão Salvar
                if (resultado == DialogResult.OK)
                {
                    imagemDeSaida = saveFileDialog1.FileName;
                }
                else
                {
                    //exibe mensagem informando que a operação foi cancelada
                    MessageBox.Show("Operação cancelada");
                }


                string imagemdeentrada = txtcaminho.Text;
                string textoSuperior = txttextosup.Text;
                string textoInferior = txttextoinf.Text;

                SizeF stringSize = new SizeF();

                if (txtcaminho.Text == "" && txttextoinf.Text == "" && txttextosup.Text == "")
                {
                    MessageBox.Show("Selecione imagem e crie seu meme e seja feliz");
                }

                else
                {
                    Bitmap bitmap = (Bitmap)Image.FromFile(imagemdeentrada);//load the image file

                    if (bitmap.Height > 800 && bitmap.Width > 800)
                    {
                        altura = 800;
                    }
                    else
                    {
                        altura = bitmap.Height;
                        largura = bitmap.Width;
                    }

                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Font stringFont = new Font(fonte, tamanholetra))
                        {
                            // Calcula o tamanho do texto superior baseado na fonte escolhida
                            stringSize = graphics.MeasureString(textoSuperior, stringFont);

                            // Define a posição do texto superior centralizado
                            PointF posSuperior = new PointF((largura - stringSize.Width) / 2, 10f);
                            PointF sombraSuperior = new PointF(posSuperior.X + 3, posSuperior.Y + 3);

                            //Sombra primeiro, para desenhar "por baixo"
                            switch (corsup)
                            {
                                case "Branco":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.White, posSuperior);
                                    break;
                                case "Preto":

                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, posSuperior);
                                    break;
                                case "Azul":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Blue, posSuperior);
                                    break;
                                case "Verde":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Green, posSuperior);
                                    break;
                                case "Rosa":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Pink, posSuperior);
                                    break;
                                case "Amarelo":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Yellow, posSuperior);
                                    break;
                                case "Vermelho":
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Black, sombraSuperior);
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.Red, posSuperior);
                                    break;
                                default:
                                    graphics.DrawString(textoSuperior, stringFont, Brushes.White, posSuperior);
                                    break;
                            }

                        }
                        using (Font stringFont = new Font(fonte, tamletinf))
                        {
                            // Calcula o tamanho do texto inferior baseado na fonte escolhida
                            stringSize = graphics.MeasureString(textoInferior, stringFont);

                            // Define a posição do texto inferior centralizado
                            PointF posInferior = new PointF((largura - stringSize.Width) / 2, altura - stringSize.Height - 10f);
                            PointF sombraInferior = new PointF(posInferior.X + 3, posInferior.Y + 3);

                            // Desenha os textos na imagem.
                            switch (corinf)
                            {
                                case "Branco":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.White, posInferior);
                                    break;
                                case "Preto":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, posInferior);
                                    break;
                                case "Azul":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Blue, posInferior);
                                    break;
                                case "Verde":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Green, posInferior);
                                    break;
                                case "Rosa":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Pink, posInferior);
                                    break;
                                case "Amarelo":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Yellow, posInferior);
                                    break;
                                case "Vermelho":
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Black, sombraInferior);
                                    graphics.DrawString(textoInferior, stringFont, Brushes.Red, posInferior);
                                    break;
                                default:
                                    graphics.DrawString(textoInferior, stringFont, Brushes.White, posInferior);
                                    break;
                            }
                        }
                    }
                    if (imagemDeSaida != "")
                    {
                        bitmap.Save(imagemDeSaida);
                    }

                }
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtcaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmais_Click(object sender, EventArgs e)
        {

            tamanholetra++;
            txtfontsup.Text = tamanholetra.ToString();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            tamanholetra--;
            txtfontsup.Text = tamanholetra.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnmaiinf_Click(object sender, EventArgs e)
        {
            tamletinf++;
            txtfontinf.Text = tamletinf.ToString();
        }

        private void btnmeninf_Click(object sender, EventArgs e)
        {
            tamletinf--;
            txtfontinf.Text = tamletinf.ToString();
        }

        private void cbfonte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbcorfonte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

