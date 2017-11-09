using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.Classes;

namespace Exercicios
{
    public class AnalistaDesenvolvedorI
    {
		#region[ PrimeiroExercicio ]

		public static Int32[] PrimeiroExercicio(params Int32[][] arrays)
		{
			Int32[] arrayNumeros = null;
			arrayNumeros = ExercicioUm.orderArray(arrays);

			return arrayNumeros;

		}

		#endregion

		#region[ SegundoExercicio ]

		public static Int32? SegundoExercicio(Int32[] array)
		{
			Int32? segundoMaiorNumero = null;

			segundoMaiorNumero = ExercicioDois.segundoMaiorValor(array);
			return segundoMaiorNumero;
		}

		#endregion

		#region[ TerceiroExercicio ]

		public static String TerceiroExercicio(String numeros)
		{
			String frase = string.Empty;

			frase = ExercicioTres.fraseDigitada(numeros);
			return frase;
		}

		#endregion
	}
}
