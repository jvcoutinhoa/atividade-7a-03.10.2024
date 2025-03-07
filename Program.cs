﻿using Controle_Clientes;

Console.WriteLine("Informe nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informar endereço: ");
string endereco = Console.ReadLine();

Console.WriteLine("Pessoa física (f) ou jurídica (j): ");
string tipo = Console.ReadLine();

if(tipo == "f") {

    PessoaFisica pf = new PessoaFisica() {
        nome = nome,
        endereco = endereco
    };

    Console.WriteLine("Informar o CPF: ");
    pf.cpf = Console.ReadLine();

    Console.WriteLine("Informar o RG: ");
    pf.rg = Console.ReadLine();

    Console.WriteLine("Informar o valor de compra: ");
    float valor = float.Parse(Console.ReadLine());

    pf.Pagar_Imposto(valor);

    Console.WriteLine("********* Pessoa Física **********");
    Console.WriteLine("Nome: " + pf.nome);
    Console.WriteLine("Endereço: " + pf.endereco);
    Console.WriteLine("CPF: " + pf.cpf);
    Console.WriteLine("RG: " + pf.rg);
    Console.WriteLine("Valor de compra: " + pf.valor.ToString("c"));
    Console.WriteLine("Imposto: " + pf.valorImposto);
    Console.WriteLine("Total a pagar: " + pf.total.ToString("c"));
}

else if(tipo == "j") {

      PessoaJuridica pj = new PessoaJuridica() {
        nome = nome,
        endereco = endereco
};

Console.WriteLine("Informar CNPJ: ");
pj.cnpj = Console.ReadLine();

Console.WriteLine("Informar IE: ");
pj.ie = Console.ReadLine();

Console.WriteLine("Informar o valor de compra: ");
float valor = float.Parse(Console.ReadLine());

pj.Pagar_Imposto(valor);

    Console.WriteLine("********* Pessoa Jurídica **********");
    Console.WriteLine("Nome: " + pj.nome);
    Console.WriteLine("Endereço: " + pj.endereco);
    Console.WriteLine("CNPJ: " + pj.cnpj);
    Console.WriteLine("IE: " + pj.ie);
    Console.WriteLine("Valor de compra: " + pj.valor.ToString("c"));
    Console.WriteLine("Imposto: " + pj.valorImposto);
    Console.WriteLine("Total a pagar: " + pj.total.ToString("c"));

}
