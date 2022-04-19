using static System.Console;
using System;
using System.Linq;

namespace livrocsharp 
{
    class funcoesTexto 
    {
        static void Main(string[] args) 
        {
            WriteLine("----- Funções de Textos -----");

            string empresa = "Microsoft Corpotation";

            WriteLine($"Nome sem espaços:{empresa.Trim()}");
            WriteLine($"Tamanho de texte:{empresa.Length}");

            empresa = empresa.Trim();
            WriteLine($"Size variable with Trim():{empresa.Length}");
            WriteLine($"Convert to upperCase:{empresa.ToUpper()}");
            WriteLine($"Convert to lowerCase:{empresa.ToLower}");



            // ... Comparações
            var nameUpper ="CAPSLOCK NAME";
            var nameLower = "lowercase name";

            // .Comparação 1
            if (nameUpper == nameLower)
                WriteLine("1 - iqual names"); 
            else 
                WriteLine("1 - diferent names");

            // .Comparação 2
            if (nameUpper.ToLower() == nameLower)
                WriteLine("2 - iqual names");
            else
                WriteLine("2 - diferent names");

            // .Comparação 3
            if (nameUpper.Equals(nameLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - iqual names");
            else 
                WriteLine("3 - diferent names");



            // ... Remove space
            string[] nomes = {"Name by Example", "Example by Name", "Another by One"};

            foreach(var n in nomes) 
            {
                WriteLine($"{n.Remove(n.IndexOf(" "))}");
            }



            // ... Trocar valor de variável
            var novaEmpresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"texto trocado:{novaEmpresa}");



            // ... Divide e extrai cada palavra em um array
            string NivelLivro = "Este livro é básico de C#.";
            string[] blocos = NivelLivro.Split(' ');
            var contador = 1;

            foreach(var exp in blocos) 
            {
                WriteLine($"texto {contador++}:{exp}");
            }

            WriteLine($"Quantidade de palavras:{blocos.Count()}");


            // ... Substring
            string NovoLivro = "Este outro livro basico de C#";
            WriteLine(NovoLivro.Substring(5, 14));

            // ... IsNullOrEmpty
            string nome = "Alana";
            string sobrenome = null;
                if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(sobrenome))
                {
                    WriteLine($"Nome completo:{nome} {sobrenome}");
                }
                else {
                    WriteLine($"Nome:{nome}");
                }


            // ...  DateTime
            int dia = 12;
            int mes = 05;
            int ano = 2021;

            DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2021, 12, 25);

            WriteLine($"dd/MM/yyyy + hh/mm/ss:{dtAniverario}");
            WriteLine($"dd/MM/yyyy:{dtAniversario:dd/MM/yyyy}");
            WriteLine($"quarta-feita 12/maio/2021: {dtAniversario:dddd dd/MMMM/yyyy}");

            // Today and Now
            DateTime hoje = DateTime.Today;
            WriteLine($"TODAY:{hoje:dd/MM/yyyy}"); 
            //Console 06/04/2021

            DateTime DataHora = DateTime.Now;
            WriteLine($"Data e hora:{DataHora:dd/MM/yyyy hh:mm:ss}"); 
            //Console 06/04/2021 06:44:47

            // Day Month Year
            DateTime DataHora = DateTime.Now;

            WriteLine($"Dia:{DataHora.Day}"); // dia: 6
            WriteLine($"Mês:{DataHora.Month}"); // mês: 4
            WriteLine($"Ano:{DataHora.Year}"); // ano: 2021

            // Modelos de manipular datas
            DateTime dtPedido = DateTime.Today; // recebe o dia atual
            // add 35 days
            DateTime dtVencto = dtPedido.AddDays(35);
            // add two months
            DateTime dtPagto = dtVencto.AddMonths(2);

            WriteLine($"Formatação completa:{dtVecto.ToLongDateString()}");
            WriteLine($"Formatação curta:{dtVecto.ToShortDateString()}");
            WriteLine($"Dia da semana:{dtVecto.DayOfWeek}");
            WriteLine($"Dia da semana em portugues:{dtVecto.ToString("dddd", new CultureInfo("pt-BR"))}");
            WriteLine($"Numero do dia da semana:{(int)dtVecto.DayOfWeek}");
            WriteLine($"Dia do ano:{dtVecto.dayOfYear}");

            var qtdeDias = dtPagto.Subtract(dtPedido);
            WriteLine($"dias entre pedido e pagamento:{qtdeDias:dd} dias");
        
            // ... Convertendo data string em date time com tryparse/out

            string dataTexto = "15/07/2021";
            DateTime dataTextoConvertida;

            if(DateTime.TryParse(dataTexto, out dataTextoConvertida)) 
                WhiteLine("Data com conversão aceita");
            else
                WriteLine("Erro na conversão de data");
            // dará erro na conversão

            // ... datas em objetos

            public class Pedido 
            {
                public int PedidoID { get; set; }
                public DateTime DtPedido { get; set; }
                public DateTime DtVencimento() => DtPedido.AddDays(30);
                public DateTime DtPagto { get; set; }
                public TimeSpan DiasAtraso() => DtPagato.Substract(DtVencimento());
                public decimal Valor { get; set; }
                public decimal Multa => Valor * 0.10M;

                static void Main(string[] args) 
                {
                    var pedido = new Pedido 
                    {
                        PedidoID = 1,
                        DtPedido = DateTime.Today,
                        DtPagto = DateTime.Today.AddDays(45),
                        Valor = 1500
                    };

                    WriteLine(
                        $"Pedido:{pedido.pedidoID} - " 
                        + $"{pedido.DtPagto:dd/MMM/yyyy} - " 
                        + $"vencto:{pedido.DtVencimento():dd/MMMM/yyyy} - " 
                        + $"dias atrasado:{pedido.DiasAtraso().TotalDays} - "
                        + $"valor:{pedido.Valor:n2} - "
                        + $"multa:{pedido.Multa:n2}"
                    ); 
                        
                }



            }
            



















        }
    }
}