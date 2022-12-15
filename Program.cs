namespace PortuguesExercicios
{  
    public class Program
    {
        static void Main(string[] args)
        {  
          //1-Faça um programa que peça ao utilizador 3 notas, guarde-as num vetor e
          //apresente a média final lendo as notas do vetor.
          /*int[] notas = new int [3];
          int soma = 0, media;

          for (int i = 0; i < notas.Length; i++)
          {
            Console.WriteLine("Insira nota: ");
            int input = Convert.ToInt32(Console.ReadLine());
            soma += input;
          }
          media = soma/3;
          Console.WriteLine("A media é: " + media);*/
         
          Console.WriteLine("///////////////////////////////////////////////////////////");
          //2-Faça programa que guarde num vetor os nomes de pelo ao menos 3 alunos da turma.
          //Deve permitir ao utilizador ao inserir numero do aluno(indici do vetor)
          //Indicar qual nome do mesmo.

          /*string[] nomes = new string [3];

          for (int i = 0; i < nomes.Length; i++)
          {
             Console.WriteLine("Digite nome do aluno: " + (i+1));
             nomes[i] = Console.ReadLine();
          }
          Console.WriteLine("Digite o numero do aluno (0 a 2): ");
          int posicao = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Nome pela posição: " + nomes[posicao]);*/

          Console.WriteLine("///////////////////////////////////////////////////////////");
          //3-Faça um programa que receba 3 valores inteiros e os coloque em um vetor
          //em seguida exiba-os em ordem inversa à ordem de entrada.

          /*int [] Valores = new int[3];

          for (int i = 0; i <= 2; i++)
          {
            Console.WriteLine("Insira valor: ");
            Valores[i]=Convert.ToInt32(Console.ReadLine());
          }
          Console.WriteLine("Reverse order: ");
          for (int i = 2; i >= 0; i--)
          {
            Console.WriteLine( Valores[i]);
          }*/

          Console.WriteLine("///////////////////////////////////////////////////////////");
          //4-Faça um programa que utilize uma extrutura de repetição para ler 5 numeros armazenando-os
          //em um vetor e calcule e exiba a media entre eles. Em seguida o programa deve apresentar todos
          //os valores armazenados no vetor que sejam menores que a media.

          /*Random rnd = new Random();
          double[] numeros = new double[5];
          double soma=0, media;

          for (int i = 0; i < numeros.Length; i++)
          {
            numeros[i] =  rnd.Next(1,10);
            soma += numeros[i];
            Console.WriteLine("Numeros: " + numeros[i]);
          }
            media = soma / numeros.Length;
            Console.WriteLine("Media: " + media);
        
          for (int i = 0; i < numeros.Length; i++)
          {
            if (numeros[i] < media)
            {
                Console.WriteLine("Numeros abaixo da media: " + numeros[i]);
            }
          }*/

           Console.WriteLine("///////////////////////////////////////////////////////////");
           //5-Faça um programa que ordene de forma crescente e decrescente um vetor, 
           //Sugere-se pesquisa na internet pelo topico "Bubble sort".
        
           Console.WriteLine("/////////////////////Sorting arrays////////////////////////");
           int[] metodos = {30, 12, 57, 22}; 
           Array.Sort(metodos);
           //Array.Reverse(metodos);
           for (int i = 0; i < metodos.Length; i++)
           {
             Console.WriteLine(metodos[i]);
           }

           Console.WriteLine("////////Using Bubble sort method///////");
           /*int[] a= {3, 2, 7, 5, 8, 4, 1};
           int t;
           Console.WriteLine("The array is: ");

           for (int i = 0; i < a.Length; i++)
           {
             Console.WriteLine(a[i]);
           }

           //Bubble sort starts
           for (int j = 0; j < a.Length -1; j++)
           {
              for (int i = 0; i < a.Length - 1; i++)
              {
                //Swap values
                if (a[i] > a[i + 1])
                {
                  t = a[i + 1];
                  a[i + 1] = a[i];
                  a[i] = t;
                }
              }
           }
           Console.WriteLine("The sorted Array:" );
           foreach ( int aray in a)
           {
              Console.WriteLine(aray + "");
           }*/

          Console.WriteLine("////////Random numbers exemple////////");
           /*Random rnds = new Random();
           int[] itens = new int[10]; 

           Console.WriteLine("aleatorios: ");
           for (int i = 0; i < itens.Length; i++)
           {
                itens[i] = rnds.Next(1, 20);
                Console.WriteLine(itens[i]);
           } */   

        }
    }
}
