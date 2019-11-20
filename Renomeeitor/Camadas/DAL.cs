using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Renomeeitor.Classes_Auxiliares;

namespace Renomeeitor
{
    public class DAL
    {
        public string diretorioRaiz;
        public string caminhoArquivoTxt;
        public string extensaoPermitida;
        public string nomeFuncFormata;
        public int counter, qtdArquivosEncontrados;

        public List<string> de = new List<string>();
        public List<string> para = new List<string>();
        public List<string> nomeAntigo = new List<string>();
        public List<string> nomeNovo = new List<string>();
        public List<string> CaminhoArq = new List<string>();

        public List<Container> ListContainer = new List<Container>();
        public List<FormataStringAvancado> ListFuncFormtStringAvancado = new List<FormataStringAvancado>();

        public delegate void Renomeia(string f, string d);  // DELEGATE PARA A FUNÇÃO ESCOLHIDA ENTRE AS FUNÇÕES: RENOMEIABASICO E RENOMEIAAVANCADO
        public delegate string FormataString(string s);     // DELEGATE PARA A FUNÇÃO ESCOLHIDA ENTRE AS FUNÇÕES: TOUPPER, TOLOWER, UCFIRST E UCWORDS
        public delegate string FormataStringAvancado(string s, Container c); // DELEGATE PARA AS FUNÇÕES: CUTBETWEEN, ADDAFTER, ADDBEFORE, ADDATEND

        public FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        public frmAviso Aviso = new frmAviso();
        public ProgressBar bar = new ProgressBar();
        public FormataString funcFormata;
        public Renomeia FuncRenomeia;
        public LeArquivoTxt ArqTxt;


        //                    METODOS PARA SELECIONAR PASTA / ARQUIVO TXT

        public void selecionaPasta()
        {
            folderBrowser.ShowNewFolderButton = true;
            folderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop;

            DialogResult resp = folderBrowser.ShowDialog();

            if (resp == DialogResult.OK)
            {
                diretorioRaiz = folderBrowser.SelectedPath;
            }
            else if (resp == DialogResult.Cancel && folderBrowser.SelectedPath.Length == 3)
            {
                diretorioRaiz = "";
            }
        }

        public void selecionaArquivo()
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoTxt = openFileDialog.FileName;
            }
        }

        //                    METODO PARA PESQUISAR ARQUIVOS EM DIRETORIO E SUB-DIRETORIOS

        public void DirSearchSub(string sDir)
        {
            try
            {
                string nomeDir = sDir + "\\";
                foreach (string f in Directory.GetFiles(sDir, "*." + extensaoPermitida))
                {
                    try
                    {
                        FuncRenomeia(f.Substring(nomeDir.Length), nomeDir);
                        bar.PerformStep();
                        CaminhoArq.Add(nomeDir);
                    }
                    catch (System.Exception excpt)
                    {
                        MessageBox.Show("Operação invalida...\n\nErro: " + excpt.Message);
                        break;//comando adicionado de ultima hora
                    }
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearchSub(d);
                }
            }
            catch (System.Exception excpt)
            {
                if (!(excpt is UnauthorizedAccessException))
                    MessageBox.Show("Operação invalida...\n\nErro: " + excpt.Message);
            }
        }

        public void DirSearchNotSub(string sDir)
        {
            try
            {
                string nomeDir = sDir + "\\";
                foreach (string f in Directory.GetFiles(sDir, "*." + extensaoPermitida))
                {
                    try
                    {
                        FuncRenomeia(f.Substring(nomeDir.Length), nomeDir);
                        bar.PerformStep();
                        CaminhoArq.Add(nomeDir);
                    }
                    catch (System.Exception excpt)
                    {
                        MessageBox.Show("Operação invalida...\n\nErro: " + excpt.Message);
                        break;//comando adicionado de ultima hora
                    }
                }
            }
            catch (System.Exception excpt)
            {
                if (!(excpt is UnauthorizedAccessException))
                    MessageBox.Show("Operação invalida...\n\nErro: " + excpt.Message);
            }
        }

        public void DirSearch(bool pegaSubdirs)
        {
            qtdArquivosEncontrados = ArquivosEncontrados(pegaSubdirs).Length;
            bar.Maximum = qtdArquivosEncontrados;
            bar.Step = 1;

            if (pegaSubdirs)
                DirSearchSub(diretorioRaiz);
            else
                DirSearchNotSub(diretorioRaiz);
        }

        //                    METODO PARA RETORNAR O NUMERO DE ARQUIVOS NO DIRETORIO SELECIONADO (INCLUINDO SUBDIRETORIOS OU NÃO)

        public string[] ArquivosEncontrados(bool subPastas)
        {
            try
            {
                string[] filePaths;

                if (subPastas)
                    filePaths = Directory.GetFiles(@diretorioRaiz, "*." + extensaoPermitida, SearchOption.AllDirectories);
                else
                    filePaths = Directory.GetFiles(@diretorioRaiz, "*." + extensaoPermitida);

                return filePaths;
            }
            catch (System.Exception excpt)
            {
                if (!(excpt is UnauthorizedAccessException))
                    MessageBox.Show("Operação invalida...\n\nErro: " + excpt.Message);

                return null;
            }
        }

        //                    METODOS PARA RENOMEAÇÃO (BASICA, AVANÇADA E POR .TXT) DE ARQUIVOS

        public void RenomeiaBasico(string nomeArq, string caminhoDiretorio)
        {
            string novoNome = nomeArq;

            for (int i = 0; i < de.Count; i++)
            {
                if (nomeArq.Contains(de[i])) // TIRAR ESSE IF DEPOIS DOS 100% PARA VER SE AUMENTA VELOCIDADE
                    novoNome = novoNome.Replace(de[i], para[i]);
            }

            if (nomeFuncFormata != "Nenhuma")
            {
                novoNome = funcFormata(novoNome);
            }

            File.Move(@caminhoDiretorio + nomeArq, @caminhoDiretorio + novoNome);
        }

        public void RenomeiaAvancado(string nomeArq, string caminhoDiretorio)
        {
            string novoNome = nomeArq;

            for (int i = 0; i < ListFuncFormtStringAvancado.Count; i++)
                novoNome = ListFuncFormtStringAvancado[i](novoNome, ListContainer[i]);

            File.Move(@caminhoDiretorio + nomeArq, @caminhoDiretorio + novoNome);

        }

        public void RenomeiaPorTxt(string nomeArq, string caminhoDiretorio)
        {
            string novoNome = nomeArq;

            //novoNome = StringExtensions.AddAtEnd(nomeArq, new Container(ArqTxt.arrText[counter]));

            novoNome = ArqTxt.arrText[counter] + "." + extensaoPermitida;

            counter++;

            File.Move(@caminhoDiretorio + nomeArq, @caminhoDiretorio + novoNome);
        }

        public void PreVisualizarRenomeiaBasico(string nomeArq, string caminhoDiretorio)
        {
            string novoNome = nomeArq;

            for (int i = 0; i < de.Count; i++)
            {
                if (nomeArq.Contains(de[i])) // TIRAR ESSE IF DEPOIS DOS 100% PARA VER SE AUMENTA VELOCIDADE
                    novoNome = novoNome.Replace(de[i], para[i]);
            }

            if (nomeFuncFormata != "Nenhuma")
            {
                novoNome = funcFormata(novoNome);
            }

            nomeAntigo.Add(nomeArq);
            nomeNovo.Add(novoNome);
        }

        public void PreVisualizarRenomeiaAvancado(string nomeArq, string caminhoDiretorio)
        {
            string novoNome = nomeArq;

            for (int i = 0; i < ListFuncFormtStringAvancado.Count; i++)
                novoNome = ListFuncFormtStringAvancado[i](novoNome, ListContainer[i]);

            nomeAntigo.Add(nomeArq);
            nomeNovo.Add(novoNome);
        }

        public void PreVisualizarRenomeiaPorTxt(string nomeArq, string caminhoDiretorio)
        {
            string novoNome = nomeArq;

            //novoNome = StringExtensions.AddAtEnd(nomeArq, new Container(ArqTxt.arrText[counter]));

            novoNome = ArqTxt.arrText[counter] + "." + extensaoPermitida;

            counter++;

            nomeAntigo.Add(nomeArq);
            nomeNovo.Add(novoNome);
        }

        //                    METODOS PARA SETAR OS DELEGATES EM TEMPO DE EXECUÇÃO

        public void setDelegateRenomeia(int i)
        {
            switch (i)
            {
                case 0:
                    FuncRenomeia = new Renomeia(RenomeiaBasico);
                    break;
                case 1:
                    FuncRenomeia = new Renomeia(RenomeiaAvancado);
                    break;
                case 2:
                    FuncRenomeia = new Renomeia(PreVisualizarRenomeiaBasico);
                    break;
                case 3:
                    FuncRenomeia = new Renomeia(PreVisualizarRenomeiaAvancado);
                    break;
                case 4:
                    FuncRenomeia = new Renomeia(RenomeiaPorTxt);
                    break;
                case 5:
                    FuncRenomeia = new Renomeia(PreVisualizarRenomeiaPorTxt);
                    break;
            }
        }

        public void setDelegateTipoFormatacao(string rbtText)
        {
            switch (rbtText)
            {
                case "rbtFalse":
                    nomeFuncFormata = "Nenhuma";
                    break;
                case "rbtToUpper":
                    funcFormata = new FormataString(StringExtensions.ToUpper);
                    break;
                case "rbtToLower":
                    funcFormata = new FormataString(StringExtensions.ToLower);
                    break;
                case "rbtUcWords":
                    funcFormata = new FormataString(StringExtensions.UcWords);
                    break;
                case "rbtUcFirst":
                    funcFormata = new FormataString(StringExtensions.UcFirst);
                    break;
            }
        }
    }
}
