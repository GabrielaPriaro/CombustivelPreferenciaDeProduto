//Problema "combustivel" (adaptado de URI 1134)
//Um posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
//Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma:
//1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a
//4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o
//código informado for o número 4, devendo então mostrar a mensagem "MUITO OBRIGADO", bem
//como as quantidades de cada combustível. 

namespace CombustivelPreferenciaDeProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, contAlcool, contGasolina, contDiesel;

            contAlcool = 0;
            contGasolina = 0;
            contDiesel = 0;

            do
            {
                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        contAlcool++;
                        break;
                    case 2:
                        contGasolina++;
                        break;
                    case 3: 
                        contDiesel++; 
                        break;
                }

            } while (codigo != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contAlcool}");
            Console.WriteLine($"Gasolina: {contGasolina }");
            Console.WriteLine($"Diesel: {contDiesel}");
        }
    }
}
