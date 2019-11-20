using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Renomeeitor.Classes_Auxiliares;

namespace Renomeeitor.Camadas
{
    class BLL
    {
        DAL DALObject = new DAL();

        string erros = "";
        string erro1;
        string erro2;
        string erro3;
        string erro4;
        string erro5;
        string erro6;
        string erro7;

        public void Port_Ingles(bool a)
        {
            if (a)
            {
                erro1 = "● Digite a posição inicial para apagar";
                erro2 = "● Digite a posição final para apagar";
                erro3 = "● Digite o trecho a ser acrescentado a partir do ";
                erro4 = "● Digite a partir de qual posição o trecho será acrescentado";
                erro5 = "● Selecione o endereço do Bloco de Notas\n";
                erro6 = "● Selecione a pasta deseja (na aba \"Básico\")\n";
                erro7 = "● Selecione o tipo de arquivo desejado (na aba \"Básico\")\n";
            }
            else 
            {
                erro1 = "● Enter the starting position to erase";
                erro2 = "● Enter the final position to erase";
                erro3 = "● Enter the excerpt to be added from the";
                erro4 = "● Enter from which position the excerpt will be added";
                erro5 = "● Select the Notepad's path\n";
                erro6 = "● Select the folder you want (in the \"Basic\" tab)\n";
                erro7 = "● Select the desired file type (in the \"Basic\" tab)\n";            
            }
        }
        public string SelecionaPasta()
        {
            DALObject.selecionaPasta();
            return DALObject.diretorioRaiz;
        }

        public string SelecionaArquivoTxt()
        {
            DALObject.selecionaArquivo();
            return DALObject.caminhoArquivoTxt;
        }

        public string RenomeiaBasico(string[,] DePara, string extensaoPermitida, string TipoFormatacao, bool subPastas, bool PreVisualizar)
        {
            erros = "";

            Valida_Erros_Pasta_E_Extensao(extensaoPermitida);

            ValidaDePara(DePara[0, 0], DePara[1, 0], "primeiro");
            ValidaDePara(DePara[0, 1], DePara[1, 1], "segundo");
            ValidaDePara(DePara[0, 2], DePara[1, 2], "terceiro");

            if (Tem_Erros()) return erros;

            DALObject.extensaoPermitida = extensaoPermitida;
            DALObject.setDelegateTipoFormatacao(TipoFormatacao);

            if (PreVisualizar)
            {
                DALObject.setDelegateRenomeia(2);
                DALObject.CaminhoArq.Clear();
            }
            else
                DALObject.setDelegateRenomeia(0);

            DALObject.DirSearch(subPastas);

            DALObject.de.Clear();
            DALObject.para.Clear();
            DALObject.nomeFuncFormata = null;

            return null;
        }

        public string RenomeiaAvancado(string[,] camposAvancados, string extensaoPermitida, bool subPastas, bool PreVisualizar)
        {
            erros = "";

            Valida_Erros_Pasta_E_Extensao(extensaoPermitida);

            Valida_Cria_Delegates(camposAvancados);

            if (Tem_Erros()) return erros;

            DALObject.extensaoPermitida = extensaoPermitida;

            if (PreVisualizar)
            {
                DALObject.setDelegateRenomeia(3);
                DALObject.CaminhoArq.Clear();
            }
            else
                DALObject.setDelegateRenomeia(1);

            DALObject.DirSearch(subPastas);

            DALObject.ListContainer.Clear();
            DALObject.ListFuncFormtStringAvancado.Clear();

            return null;
        }

        public string RenomeiaPorTxt(string enderecoTxt, string extensaoPermitida, bool subPastas, bool PreVisualizar)
        {
            erros = "";

            Valida_Erros_Pasta_E_Extensao(extensaoPermitida);

            if (String.IsNullOrEmpty(enderecoTxt))
                erros += erro5;

            if (Tem_Erros()) return erros;

            DALObject.extensaoPermitida = extensaoPermitida;

            if (PreVisualizar)
            {
                DALObject.setDelegateRenomeia(5);
                DALObject.CaminhoArq.Clear();
            }
            else
                DALObject.setDelegateRenomeia(4);

            DALObject.ArqTxt = new LeArquivoTxt(@enderecoTxt);
            DALObject.ArqTxt.LeArquivo();

            string[] aux = DALObject.ArquivosEncontrados(subPastas);

            if (aux == null) return null;

            int qtdArqs = aux.Length;
            int qtdTxt = DALObject.ArqTxt.arrText.Count;

            if( qtdArqs > qtdTxt)
                return
                    "O bloco de notas selecionado não tem nomes suficiente!\n\n"
                    + qtdArqs + " arquivos ." + DALObject.extensaoPermitida.ToUpper() + " foram encontrados "
                    + "mas no bloco de notas há apenas " + qtdTxt + " nomes!!!";

            DALObject.counter = 0;
            DALObject.DirSearch(subPastas);

            return null;
        }

        public List<string> getNomeAntigo()
        {
            return DALObject.nomeAntigo;
        }

        public List<string> getNomeNovo()
        {
            return DALObject.nomeNovo;
        }

        public List<string> getCaminhoArq()
        {
            return DALObject.CaminhoArq;
        }

        public void LimpaListsNome()
        {
            DALObject.nomeAntigo.Clear();
            DALObject.nomeNovo.Clear();
        }

        // METODOS USADOS DURANTE AS VALIDAÇÕES

        public bool Tem_Erros()
        {
            if (!String.IsNullOrEmpty(erros))
            {
                DALObject.de.Clear();
                DALObject.para.Clear();
                DALObject.ListContainer.Clear();
                DALObject.ListFuncFormtStringAvancado.Clear();

                return true;
            }

            return false;
        }

        public void Valida_Erros_Pasta_E_Extensao(string extensaoPermitida)
        {
            if (String.IsNullOrEmpty(DALObject.diretorioRaiz))
                erros += erro6;

            if (String.IsNullOrEmpty(extensaoPermitida))
                erros += erro7;
        }

        public void ValidaDePara(string strDeI, string strParaI, string posicao)
        {
            if ((strDeI == "") ^ (strParaI == ""))
                if (strDeI == "")
                    erros += "● Preencha o " + posicao + " campo \"De\"\n";
                else
                    erros += "● Preencha o " + posicao + " campo \"Para\"\n";
            else
                if ((strDeI != "") && (strParaI != ""))
                {
                    DALObject.de.Add(strDeI);
                    DALObject.para.Add(strParaI);
                }
        }

        public void Valida_Cria_Delegates(string[,] camposAvancados)
        {

            if (ValidaAvancado(camposAvancados[0, 0], camposAvancados[0, 1], erro1, erro2))
            {
                DALObject.ListContainer.Add(new Container(Int32.Parse(camposAvancados[0, 0]), Int32.Parse(camposAvancados[0, 1])));
                DALObject.ListFuncFormtStringAvancado.Add(StringExtensions.CutBetween);
            }

            if (ValidaAvancado(camposAvancados[1, 0], camposAvancados[1, 1], erro3 + camposAvancados[1, 1] + "º caracter", erro4))
            {
                DALObject.ListContainer.Add(new Container(camposAvancados[1, 0], Int32.Parse(camposAvancados[1, 1])));
                DALObject.ListFuncFormtStringAvancado.Add(StringExtensions.AddAfter);
            }

            if (camposAvancados[2, 0] != "")
            {
                DALObject.ListContainer.Add(new Container(camposAvancados[2, 0]));
                DALObject.ListFuncFormtStringAvancado.Add(StringExtensions.AddBefore);
            }

            if (camposAvancados[3, 0] != "")
            {
                DALObject.ListContainer.Add(new Container(camposAvancados[3, 0]));
                DALObject.ListFuncFormtStringAvancado.Add(StringExtensions.AddAtEnd);
            }

            if (camposAvancados[4, 0] != "")
            {
                DALObject.ListContainer.Add(new Container(camposAvancados[4, 0]));
                DALObject.ListFuncFormtStringAvancado.Add(StringExtensions.RemoveSubString);
            }

        }

        public bool ValidaAvancado(string txt1, string txt2, string erroText1, string erroText2)
        {
            if ((txt1 == "") ^ (txt2 == ""))
                if (txt1 == "")
                    erros += erroText1 + "\n";
                else
                    erros += erroText2 + "\n";
            else
                if ((txt1 != "") && (txt2 != ""))
                    return true;

            return false;
        }

        public void SetFormAvisoDALL(frmAviso form, System.Windows.Forms.ProgressBar bar)
        {
            DALObject.Aviso = form;
            DALObject.bar = bar;
        }
    }
}
