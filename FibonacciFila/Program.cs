namespace FibonacciFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine(">>> Fibonacci <<<");

            bool resultadoTry;
            int tamanho, temp = 0, anterior = 0, atual = 1;
            FilaNumero fila = new FilaNumero();

            do
            {
                Console.WriteLine("Digite a quantidade de numeros da sequencia:");
                Console.Write("R: ");

                resultadoTry = int.TryParse(Console.ReadLine(), out tamanho);

            } while (!resultadoTry);

            if (tamanho <= 0)
            {
                Console.WriteLine("Numero incorreto!");
            }
            else
            {
                if (tamanho >= 1)
                    fila.Enqueue(new Numero(anterior));
                if (tamanho >= 2)
                    fila.Enqueue(new Numero(atual));
                for (int i = 2; i < tamanho; i++)
                {
                    temp = atual + anterior;
                    anterior = atual;
                    atual = temp;

                    fila.Enqueue(new Numero(atual));
                }

                Console.WriteLine("Sequencia fibonacci: ");
                fila.Print();
            }
            Console.ReadKey();
        }
    }
}
