

class Program
{
    static void Main()
    {
        
        string resposta = "";
        // Criar uma instância da classe Estacionamento
        ClassEstacionamento estacionamento = new ClassEstacionamento(10.0f,5.0f);

       
        string placa = "";

        while (true){

            Console.Write("Digite a placa do veículo: ");
            placa = Console.ReadLine();

            if (placa == "") {
                
                Console.WriteLine("Digite S para sair, L para imprimir ou apenas enter para continuar.");
                resposta = Console.ReadLine();
                
                if (resposta.ToUpper().Equals("S") || resposta == null) 
                {
                    break;                    
                }
                
                if (resposta.ToUpper().Equals("L"))
                {
                    estacionamento.ImprimirCarrosEstacionados();
                    continue;
                }


            }

            if (estacionamento.VerificaCarroEstacionado(placa))
            {
                Console.WriteLine($"O carro com placa {placa} encontra-se estacionado. Gostaria de fechar a conta<S/N>?");
                
                resposta = Console.ReadLine();
                if (resposta.ToUpper().Equals("S") && resposta != null)
                {
                    estacionamento.FecharConta(placa);
                }
            }
            else
            { 
                estacionamento.AdicionarCarro(placa); 
            }
        }
        // Imprimir informações sobre os carros estacionados
        estacionamento.ImprimirCarrosEstacionados();
    }
}