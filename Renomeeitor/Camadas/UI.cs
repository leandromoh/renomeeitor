using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Renomeeitor.Camadas;
using Renomeeitor.Classes_Auxiliares;

namespace Renomeeitor
{
    public partial class View : Form
    {
        BLL BLLObject = new BLL();
        string[,] ObjsParaValidacao = new string[5, 2];
        string[,] DePara = new string[2, 3];
        string erros, title1, title2, title3, title4, title5, erroPasta, mensagem1, mensagem2;

        // form filho e alguns de seus elementos 
        frmAviso formAviso = new frmAviso();
        ProgressBar Progbar = new ProgressBar();
        Label laProcessando = new Label();
        Label laConcluido = new Label();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIdioma.SelectedIndex = 0;

            formAviso.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            title1 = " Processando";
            title2 = " Operação Concluida";
            title3 = "  Atenção";
            title4 = "Caminho..?";
            title5 = "Qual lista deseja salvar?";
            erroPasta = "Por favor selecione uma pasta que não seja um diretório raiz.";
            mensagem1 = "Deseja salvar a lista \"Antes\"? \n" +
                        "Caso você clique em \"Não\" a lista \"Depois\" será a lista salva.";
            mensagem2 = "Deseja que o caminho do arquivo também seja salvo?";

            foreach (Control c in formAviso.panelConcluido.Controls)
                if (c is Label)
                    if (c.Name == "lblConcluido") laConcluido = c as Label;

            foreach (Control c in formAviso.panelProcessando.Controls)
            {
                if (c is ProgressBar)
                {
                    Progbar = c as ProgressBar;
                    Progbar.Value = 0;
                }
                if (c is Label)
                {
                    if (c.Name == "lblProcessando") laProcessando = c as Label;
                }
            }

            BLLObject.SetFormAvisoDALL(formAviso, Progbar);
        }

        private void btnSelecionaPasta_Click(object sender, EventArgs e)
        {
            string aux;
            bool flag;
            do
            {
                flag = false;
                aux = BLLObject.SelecionaPasta();
                if (aux != null)
                    if (aux.Length == 3)
                    {
                        MessageBox.Show(erroPasta, title3, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = true;
                    }

            } while (flag);

            txtPastaSelecionada.Text = aux;
        }

        private void btnSelecionaTxt_Click(object sender, EventArgs e)
        {
            txtEnderecoBlocDeNot.Text = BLLObject.SelecionaArquivoTxt();
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            CarregaArrayDePara();

            CustomMessageBox(title1, false);

            erros = BLLObject.RenomeiaBasico(DePara, txtExtensao.Text, GetCheckedRadio(grpEstilo).Name, chkSubPastas.Checked, false);

            if (SeTemErrosMostra()) return;

            rbtFalse.Checked = true;

            CustomMessageBox(title2, true);

        }

        private void btnRenomearAvancado_Click(object sender, EventArgs e)
        {           
            CarregaArrayObjsParaValidacao();

            CustomMessageBox(title1, false);

            erros = BLLObject.RenomeiaAvancado(ObjsParaValidacao, txtExtensao.Text, chkSubPastas.Checked, false);

            if (SeTemErrosMostra()) return;

            CustomMessageBox(title2, true);
        }

        private void btnExecutaTxt_Click(object sender, EventArgs e)
        {
            CustomMessageBox(title1, false);

            erros = BLLObject.RenomeiaPorTxt(txtEnderecoBlocDeNot.Text, txtExtensao.Text, chkSubPastas.Checked, false);

            if (SeTemErrosMostra()) return;

            CustomMessageBox(title2, true);

        }

        private void btnPreVisualizarAvancado_Click(object sender, EventArgs e)
        {
            CarregaArrayObjsParaValidacao();

            CustomMessageBox(title1, false);

            erros = BLLObject.RenomeiaAvancado(ObjsParaValidacao, txtExtensao.Text, chkSubPastas.Checked, true);

            if (SeTemErrosMostra()) return;

            CarregaListsNome();

            formAviso.Hide();
        }

        private void btnPreVisualizarBasico_Click(object sender, EventArgs e)
        {
            CarregaArrayDePara();

            CustomMessageBox(title1, false);

            erros = BLLObject.RenomeiaBasico(DePara, txtExtensao.Text, GetCheckedRadio(grpEstilo).Name, chkSubPastas.Checked, true);

            if (SeTemErrosMostra()) return;

            // rbtFalse.Checked = true;

            CarregaListsNome();

            formAviso.Hide();
        }

        private void btnPreVisualizarTxt_Click(object sender, EventArgs e)
        {
            CustomMessageBox(title1, false);

            erros = BLLObject.RenomeiaPorTxt(txtEnderecoBlocDeNot.Text, txtExtensao.Text, chkSubPastas.Checked, true);

            if (SeTemErrosMostra()) return;

            CarregaListsNome();

            formAviso.Hide();
        }

        public void CarregaListsNome()
        {
            LimpaListsNome();

            foreach (string n in BLLObject.getNomeAntigo())
                lstAntes.Items.Add(n);

            foreach (string n in BLLObject.getNomeNovo())
                lstDepois.Items.Add(n);

            BLLObject.LimpaListsNome();

            tabControl1.SelectedTab = tabPagePreVisualizacao;
        }

        public void LimpaListsNome()
        {
            lstAntes.Items.Clear();
            lstDepois.Items.Clear();
        }

        public void CarregaArrayDePara()
        {
            DePara[0, 0] = txtDe1.Text;
            DePara[0, 1] = txtDe2.Text;
            DePara[0, 2] = txtDe3.Text;
            DePara[1, 0] = txtPara1.Text;
            DePara[1, 1] = txtPara2.Text;
            DePara[1, 2] = txtPara3.Text;
        }

        public void CarregaArrayObjsParaValidacao()
        {
            ObjsParaValidacao[0, 0] = mskDo.Text;
            ObjsParaValidacao[0, 1] = mskAo.Text;
            ObjsParaValidacao[1, 0] = txtAcrescentarTrecho.Text;
            ObjsParaValidacao[1, 1] = mskApos.Text;
            ObjsParaValidacao[2, 0] = txtAcrescentarInicio.Text;
            ObjsParaValidacao[3, 0] = txtAcrescentarFim.Text;
            ObjsParaValidacao[4, 0] = txtRemove.Text;
        }

        public bool SeTemErrosMostra()
        {
            if (erros != null)
            {
                formAviso.Hide();
                MessageBox.Show(erros, title3, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        public RadioButton GetCheckedRadio(Control container)
        {
            foreach (var c in container.Controls)
            {
                RadioButton radio = c as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }
            return null;
        }

        private void lstAntes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDepois.SelectedIndex = lstAntes.SelectedIndex;
        }

        private void lstDepois_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAntes.SelectedIndex = lstDepois.SelectedIndex;
        }

        public View()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDe1.Text = "";
            txtDe2.Text = "";
            txtDe3.Text = "";

            txtPara1.Text = "";
            txtPara2.Text = "";
            txtPara3.Text = "";
        }

        private void btnLimparAvancado_Click(object sender, EventArgs e)
        {
            mskAo.Text = "";
            mskDo.Text = "";
            mskApos.Text = "";

            txtAcrescentarTrecho.Text = "";
            txtAcrescentarInicio.Text = "";
            txtAcrescentarFim.Text = "";
            txtRemove.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string data, caminho;
            int i = 0;

            caminho = EscolherPasta();
            if (caminho == null) return;

            data = System.DateTime.Now.ToString().Replace("/", "-").Replace(":", ";");

            // MessageBox.Show("@"+data);

            GravaArquivoTxt g = new GravaArquivoTxt(caminho + "\\Lista_Renomeeitor " + data + ".txt");

            DialogResult dialogResult1 = MessageBox.Show(mensagem1, title5, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult1 == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show(mensagem2, title4, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                CustomMessageBox(title1, false);

                if (dialogResult2 == DialogResult.Yes)
                {
                    foreach (string s in BLLObject.getCaminhoArq())
                    {
                        g.Gravar(s + lstAntes.Items[i++].ToString());
                        Progbar.PerformStep();
                    }
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    foreach (string s in lstAntes.Items)
                    {
                        g.Gravar(s.ToString());
                        Progbar.PerformStep();
                    }
                }
            }
            else if (dialogResult1 == DialogResult.No)
            {
                DialogResult dialogResult3 = MessageBox.Show(mensagem2, title4, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                CustomMessageBox(title1, false);

                if (dialogResult3 == DialogResult.Yes)
                {
                    foreach (string s in BLLObject.getCaminhoArq())
                    {
                        g.Gravar(s + lstDepois.Items[i++].ToString());
                        Progbar.PerformStep();
                    }
                }
                else if (dialogResult3 == DialogResult.No)
                {
                    foreach (string s in lstDepois.Items)
                    {
                        g.Gravar(s.ToString());
                        Progbar.PerformStep();
                    }
                }
            }
            CustomMessageBox(title2, true);
        }

        private string EscolherPasta()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = true;

            folderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
                return folderBrowser.SelectedPath;

            return null;
        }

        private void CustomMessageBox(string title, bool b)
        {
            formAviso.Text = title;
            if (b)
            {
                formAviso.panelConcluido.Visible = true;
                formAviso.btnOk.Visible = true;
                formAviso.panelProcessando.Visible = false;
            }
            else
            {
                Progbar.Value = 0;
                formAviso.panelConcluido.Visible = false;
                formAviso.btnOk.Visible = false;
                formAviso.panelProcessando.Visible = true;

                //formAviso.Owner = this;
                //formAviso.StartPosition = FormStartPosition.CenterParent;
                formAviso.Show();
                formAviso.Location = new Point(this.Left + (this.Width / 2 - formAviso.Width / 2), this.Top + (this.Height / 2 - formAviso.Height / 2));
            }
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedIndex == 0)
            {
                lblIdioma.Text = "Linguagem:";
                lblExtensao.Text = "Tipo de arquivo permitido: (Exemplos: rar, mp3, jpg, etc)";
                btnSelecionaPasta.Text = "Selecionar Pasta";
                lblPastaSelecionada.Text = "Pasta Selecionada:";
                lblDe1.Text = "  De:";
                lblDe2.Text = "  De:";
                lblDe3.Text = "  De:";
                lblPara1.Text = "Para:";
                lblPara2.Text = "Para:";
                lblPara3.Text = "Para:";
                lblTrechos.Text = "Substituir trechos no nome dos arquivos:";
                rbtFalse.Text = "Deixar como está";
                rbtToUpper.Text = "Todo maiusculo";
                rbtToLower.Text = "Todo minusculo";
                rbtUcWords.Text = "Primeira letra de cada palavra em maiusculo";
                rbtUcFirst.Text = "Primeira letra do nome do arquivo em maiusculo";
                grpEstilo.Text = "Deixar nomes dos arquivos:";
                btnRenomear.Text = "Renomear Arquivos";
                tabPageBasico.Text = "  Básico  ";
                btnLimparBasico.Text = "Limpar";
                chkSubPastas.Text = "Incluir SubPastas";
                btnPreVisualizarBasico.Text = "Pré-Visualizar";
                tabPageAvancado.Text = "  Avançado  ";
                grpBlocoDeNotas.Text = "Extrair Nomes A Partir De Um Bloco de Notas";
                btnPreVisualizarTxt.Text = "Pré-Visualizar";
                btnSelecionaTxt.Text = "Selecionar .txt";
                btnExecutaTxt.Text = "Aplicar";
                lblEnderecoBlocDeNot.Text = "Endereço Bloco de Notas:";
                label5.Text = "Remover  ocorrências  do trecho:";
                btnLimparAvancado.Text = "Limpar";
                btnPreVisualizarAvancado.Text = "Pré-Visualizar";
                btnRenomearAvancado.Text = "Aplicar";
                lblApaga.Text = "Apagar  do";
                lblAcrescentarFim.Text = "Trecho a acrescentar  no  fim do  nome:";
                lblAo.Text = " º  ao";
                lblAcrescentarInicio.Text = "Trecho a acrescentar  no  inicio  do nome: ";
                lblCaracter1.Text = "º  caracter";
                lblAcrescentar.Text = "Acrescentar o trecho:";
                lblCaracter2.Text = "º  caracter";
                lblApos.Text = "após o";
                lblManipulacao.Text = "Manipulação avançada de trechos do nome do arquivo";
                tabPagePreVisualizacao.Text = "  Pré-Visualização  ";
                btnSalvar.Text = "Salvar Lista";
                lblDepois.Text = "Depois";
                lblAntes.Text = "Antes";
                tabPageSobre.Text = "  Sobre  ";
                lnlCopyRight.Text = "Todos os direitos reservados © 2014 Leandro Fernandes Vieira";
                label4.Text = "  leandromoh@hotmail.com";
                label3.Text = "E-mail para Contato:";
                label2.Text = "Leandro Fernandes Vieira";
                label1.Text = "Desenvolvido Por:";
                //                           mensagens messagebox
                title1 = " Processando";
                title2 = " Sucesso!";
                title3 = "  Atenção";
                title4 = "Caminho..?";
                title5 = "Qual lista deseja salvar?";
                erroPasta = "Por favor selecione uma pasta que não seja um diretório raiz.";

                mensagem1 = "Deseja salvar a lista \"Antes\"? \n" +
                                "Caso você clique em \"Não\" a lista \"Depois\" será a lista salva.";
                mensagem2 = "Deseja que o caminho do arquivo também seja salvo?";
                //                          form aviso
                laProcessando.Text = "Processando...";
                laConcluido.Text = "Concluído!";
                BLLObject.Port_Ingles(true);
            }
            else
            {
                lblIdioma.Text = "Language:";
                lblExtensao.Text = "Allowed file type: (Example: rar, mp3, jpg, avi, pdf, etc)";
                btnSelecionaPasta.Text = "Select Folder";
                lblPastaSelecionada.Text = "Selected Folder:";
                lblDe1.Text = "From:";
                lblDe2.Text = "From:";
                lblDe3.Text = "From:";
                lblPara1.Text = "  To:";
                lblPara2.Text = "  To:";
                lblPara3.Text = "  To:";
                lblTrechos.Text = "Replace excerpts in file name:";
                rbtFalse.Text = "Leave as it is";
                rbtToUpper.Text = "Uppercase";
                rbtToLower.Text = "Lowercase";
                rbtUcWords.Text = "First letter of each word capitalized";
                rbtUcFirst.Text = "First letter of file name capitalized";
                grpEstilo.Text = "Change file names into:";
                btnRenomear.Text = "Rename Files";
                tabPageBasico.Text = "  Basic  ";
                btnLimparBasico.Text = "Clear";
                chkSubPastas.Text = "Include Subfolders";
                btnPreVisualizarBasico.Text = "Preview";
                tabPageAvancado.Text = "  Advanced  ";
                grpBlocoDeNotas.Text = "Extract names from a notepad";
                btnPreVisualizarTxt.Text = "Preview";
                btnSelecionaTxt.Text = "Select .txt";
                btnExecutaTxt.Text = "Apply";
                lblEnderecoBlocDeNot.Text = "Notepad's  path:";
                label5.Text = "Remove  excerpt  occurrences:";
                btnLimparAvancado.Text = "Clear";
                btnPreVisualizarAvancado.Text = "Preview";
                btnRenomearAvancado.Text = "Apply";
                lblApaga.Text = "Erase from";
                lblAcrescentarFim.Text = "Excerpt to add at the end  of  the  name:";
                lblAo.Text = " º  to";
                lblAcrescentarInicio.Text = "Excerpt to add at the beginning of the name: ";
                lblCaracter1.Text = "º  character";
                lblAcrescentar.Text = "Add the excerpt:";
                lblCaracter2.Text = "º  character";
                lblApos.Text = "  after";
                lblManipulacao.Text = "Advanced manipulation of excerpts in file name";
                tabPagePreVisualizacao.Text = "  Preview  ";
                btnSalvar.Text = "Save List";
                lblDepois.Text = "After";
                lblAntes.Text = "Before";
                tabPageSobre.Text = "  About  ";
                lnlCopyRight.Text = "Copyright © 2014 Leandro Fernandes Vieira, All Rights Reserved.";
                label4.Text = "  leandromoh@hotmail.com";
                label3.Text = "Contact E-mail:";
                label2.Text = "Leandro Fernandes Vieira";
                label1.Text = "Developed By:";
                //                           mensagens messagebox
                title1 = " Processing";
                title2 = " Success!";
                title3 = "Warning";
                title4 = "Path..?";
                title5 = "Which list you want to save?";
                erroPasta = "Please, select a folder that is not a root directory.";

                mensagem1 = "Do you want to save the list \"Before\"? \n" +
                                "Case you click \"No\", the list \"After\" will be the saved list.";
                mensagem2 = "Would like to save the file's path too?";
                //                          form aviso
                laProcessando.Text = "Processing...";
                laConcluido.Text = "Completed!";
                BLLObject.Port_Ingles(false);
            }
        }
    }
}