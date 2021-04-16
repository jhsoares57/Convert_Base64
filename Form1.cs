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

namespace Base64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            SelecionarPasta();
        }

        public void SelecionarPasta()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var dir = folderBrowserDialog1.SelectedPath;

                label1.Text = dir + "\\decode.pdf";

                
            }
        }

        private bool verificarExistencia()
        {
            if (File.Exists(label1.Text))
            {
                DialogResult result;
                result = MessageBox.Show("Já existe um arquivo na pasta! \n Deseja deletar o arquivo existente?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(label1.Text);

                    
                }
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtstring64.Text != "")
                {
                    if(verificarExistencia())
                    {

                        byte[] bytes = Convert.FromBase64String(txtstring64.Text);
                        var dir = label1.Text;
                        System.IO.FileStream stream = new FileStream(dir, FileMode.CreateNew);
                        System.IO.BinaryWriter writer = new BinaryWriter(stream);
                        writer.Write(bytes, 0, bytes.Length);
                        writer.Close();
                        MessageBox.Show("Sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Informe uma string em base64", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtstring64.Focus();
                }
            }
            catch (Exception ex)
            {
                if(ex.Message == "The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.")
                {
                    MessageBox.Show("Erro: Informe uma string base64 correta! ", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Erro: " + ex, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void btnSelArq_Click(object sender, EventArgs e)
        {
            SelecionarDir();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if(lblDirArq.Text != "")
            {
                converter();
            }
            else
            {
                MessageBox.Show("Selecione um arquivo! ", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SelecionarDir()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "arquivos | *.*;";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "por favor, selecione um arquivo";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                var dir = dialog.FileName;

                lblDirArq.Text = dir;
            }
        }

        private void converter()
        {
            try
            {
                var dir = lblDirArq.Text;
                if (System.IO.File.Exists(dir))

                {

                    byte[] objByte = File.ReadAllBytes(dir);

                    string arquivo = Convert.ToBase64String(objByte);

                    
                    txtEncoder.Text = arquivo;

                    //File.WriteAllText("c:\\arquivo.txt", arquivo);

                }
                else
                {
                    MessageBox.Show("Arquivo selecionado inválido!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEncoder.Text);
            MessageBox.Show("Copiado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
