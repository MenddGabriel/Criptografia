using System;

namespace Encriptador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tres passadas em todo o texto
            // Deslocado  3 posicao para direita (a deve virar d)
            // S A linha deve ser invertida (aditrevni)
            // T qualquer caractere a partir da metade, deslocados uma posição para a esquerda 'b' vira 'a')


            string texto = Console.ReadLine().ToString();

            //
            int[] asciiCodes = new int[texto.Length];
            string P = string.Empty;
            for (int i = 0; i < texto.Length; i++)
            {
                int x = ((int)texto[i]) + 3;
                asciiCodes[i] = (char)x;
                P += ((char)asciiCodes[i]).ToString();
            }

            //Console.WriteLine(P);


            //Invertendo Segundo passo
            string S = string.Empty;
            char[] invertendo = new char[texto.Length];
            int j = 0;
            for (int i = P.Length - 1; i >= 0; i--)
            {
                invertendo[j] = P[i];
                S += ((char)invertendo[j]).ToString();
                j++;
            }

            //Console.WriteLine(S);

            //Terceiro passo
            string T = string.Empty;
            char[] voltandoUm = new char[texto.Length];
            int truncado = texto.Length / 2;
            for (int i = 0; i < S.Length; i++)
            {

                voltandoUm[i] = S[i];

                if (i >= truncado)
                {
                    int x = (int)voltandoUm[i];
                    x -= 1;
                    voltandoUm[i] = (char)x;
                }

                T += ((char)voltandoUm[i]).ToString();

            }

            Console.WriteLine(T);
        }
    }
}
