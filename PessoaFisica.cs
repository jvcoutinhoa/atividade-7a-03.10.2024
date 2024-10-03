namespace Controle_Clientes {

    public class PessoaFisica : Clientes {

        public string cpf {get; set;}
        public string rg {get; set;}

           public override void Pagar_Imposto(float v)
        {
            valor = v; 
            valorImposto = valor * 10/100;
            total = valor + valorImposto;
        }
    }
}
