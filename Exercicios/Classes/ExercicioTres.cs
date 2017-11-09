using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
	public class ExercicioTres
	{
		public static String fraseDigitada(String numeros)
		{
			String frase = "";
			Dictionary<Int32, Char> baseComLetras = sequenciaDeCaracteres();
			String[] numeroDigitados = numeros.Split(' ');

			for (int i = 0; i <= numeroDigitados.Length - 1; i++)
			{

				Int32 key = Convert.ToInt32(numeroDigitados[i]);

				Char letra = baseComLetras[key];
				frase += letra;
			}

			return frase;
		}

		private static Dictionary<Int32, Char> sequenciaDeCaracteres()
		{

			Dictionary<Int32, Char> sequenciaChaveValor = new Dictionary<Int32, Char>();
			sequenciaChaveValor.Add(0, ' ');
			sequenciaChaveValor.Add(2, 'A');
			sequenciaChaveValor.Add(22, 'B');
			sequenciaChaveValor.Add(222, 'C');
			sequenciaChaveValor.Add(3, 'D');
			sequenciaChaveValor.Add(33, 'E');
			sequenciaChaveValor.Add(333, 'F');
			sequenciaChaveValor.Add(4, 'G');
			sequenciaChaveValor.Add(44, 'H');
			sequenciaChaveValor.Add(444, 'I');
			sequenciaChaveValor.Add(5, 'J');
			sequenciaChaveValor.Add(55, 'K');
			sequenciaChaveValor.Add(555, 'L');
			sequenciaChaveValor.Add(6, 'M');
			sequenciaChaveValor.Add(66, 'N');
			sequenciaChaveValor.Add(666, 'O');
			sequenciaChaveValor.Add(7, 'P');
			sequenciaChaveValor.Add(77, 'Q');
			sequenciaChaveValor.Add(777, 'R');
			sequenciaChaveValor.Add(7777, 'S');
			sequenciaChaveValor.Add(8, 'T');
			sequenciaChaveValor.Add(88, 'U');
			sequenciaChaveValor.Add(888, 'V');
			sequenciaChaveValor.Add(9, 'W');
			sequenciaChaveValor.Add(99, 'X');
			sequenciaChaveValor.Add(999, 'Y');
			sequenciaChaveValor.Add(9999, 'Z');

			return sequenciaChaveValor;
		}
	}
}
