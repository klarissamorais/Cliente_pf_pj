using System;
namespace Atividade
{
    class Programa
    {
        static void Main(string[] args)
        {

            float val_pag;
            Console.WriteLine("Informar Pessoa fisica(f) ou juridica(j)");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                Pessoa_fisica pf = new Pessoa_fisica();
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                string caminhoArquivo = @"C:\Users\klari\OneDrive\Área de Trabalho\SENAI\Atividade\Dados_pf.txt";
                bool cpfEncontrado = false;

                using (StreamReader arquivo = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        if (linha == pf.cpf)
                        {
                            cpfEncontrado = true;
                            break;
                        }
                    }
                }

                if (!cpfEncontrado)
                {
                    Console.WriteLine("CPF não encontrado no arquivo.");

                    Console.WriteLine("Informar Nome:");
                    pf.nome = Console.ReadLine();
                    Console.WriteLine("Informar RG:");
                    pf.rg = Console.ReadLine();
                    Console.WriteLine("Informar Endereço:");
                    pf.endereco = Console.ReadLine();

                    using (StreamWriter arquivoEscrita = new StreamWriter(caminhoArquivo, true))
                    {
                        arquivoEscrita.WriteLine(pf.cpf);
                        arquivoEscrita.WriteLine(pf.nome);
                        arquivoEscrita.WriteLine(pf.rg);
                        arquivoEscrita.WriteLine(pf.endereco);
                    }
                }
                
                Console.WriteLine("Informar valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("----Pessoa Fisica-----");
                Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));

            }


            if (var_tipo == "j")
            {
                Pessoa_juridica pj = new Pessoa_juridica();
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Endereço");
                pj.endereco = Console.ReadLine();
                Console.WriteLine("Informar valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("----Pessoa Juridica-----");
                Console.WriteLine("Total a pagar: " + pj.total.ToString("C"));
            }
        }
    }
}