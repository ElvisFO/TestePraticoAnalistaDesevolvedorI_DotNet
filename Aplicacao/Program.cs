using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios;

namespace Aplicacao
{
	class Program
	{
		static void Main(string[] args)
		{
			PrimeiroExercicio();

			SegundoExercicio();

			TerceiroExercicio();

			Console.Read();
		}

		#region[ PrimeiroExercicio ]

		static void PrimeiroExercicio()
		{
			Console.Write("---- PRIMEIRO EXERCICIO ---- " + Environment.NewLine);
			Console.Write(Environment.NewLine);

			Int32[] arrayUm = { 1, 2, 4, 5, 7 };
			Int32[] arrayDois = { 2, 3, 5, 6 };

			Int32[] arrayOrdenado = AnalistaDesenvolvedorI.PrimeiroExercicio(arrayUm, arrayDois);


			//exibir os elementos
			foreach (Int32 item in arrayOrdenado)
			{
				Console.Write(item);
			}

			Console.Write(Environment.NewLine);
			Console.Write(Environment.NewLine);
		}

		#endregion

		#region[ SegundoExercicio ]

		static void SegundoExercicio()
		{
			Console.Write("---- SEGUNDO EXERCICIO ----" + Environment.NewLine);
			Console.Write(Environment.NewLine);

			Int32[] array = { 1, 3, 4, 2, 5 };

			Int32? valorRetornado = AnalistaDesenvolvedorI.SegundoExercicio(array);

			if(valorRetornado != null)
				Console.Write(valorRetornado);

			Console.Write(Environment.NewLine);
			Console.Write(Environment.NewLine);
		}

		#endregion

		#region[ TerceiroExercicio ]

		static void TerceiroExercicio()
		{
			Console.Write("---- TERCEIRO EXERCICIO ----" + Environment.NewLine);
			Console.Write(Environment.NewLine);

			String numeroDigitados = "33 8 88 777 66 0 9 33 22 0 33 0 7777 666 333 8 9 2 777 33 0 7777 666 555 88 8 444 666 66";

			String frase = AnalistaDesenvolvedorI.TerceiroExercicio(numeroDigitados);

			Console.Write(frase);

			Console.Write(Environment.NewLine);
			Console.Write(Environment.NewLine);

		}

		#endregion


		}
}
