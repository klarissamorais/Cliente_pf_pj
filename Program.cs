using System;
namespace Atividade{
    class Program{
        static void Main(string[] args){
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Informar Pessoa fisica(f) ou juridica(j)");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "f"){
                // se for pessoa fisica
                Pessoa_fisica pf = new Pessoa_fisica(); 
                //pf tem o tipo Pessoa_fisica e vai levar toda a estrutura da classe Pessoa_fisica, é um objeto. Além de herdar os atributos da classe pai, Clientes.
                pf.nome= var_nome;
                pf.endereco= var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf= Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg= Console.ReadLine();
                Console.WriteLine("Informar valor de compra:");
                val_pag= float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("----Pessoa Fisica-----");
                Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));
            }
            if(var_tipo == "j"){
                Pessoa_juridica pj = new Pessoa_juridica();
                pj.nome= var_nome;
                pj.endereco= var_endereco;
                Console.WriteLine("Informar CPF:");
                pj.cnpj= Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie= Console.ReadLine(); 
                Console.WriteLine("Informar valor de compra:");
                val_pag= float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("----Pessoa Juridica-----");
                Console.WriteLine("Total a pagar: " + pj.total.ToString("C"));
            }

        }
    }
}