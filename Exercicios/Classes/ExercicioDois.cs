using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
	public class ExercicioDois
	{
		public static Int32? segundoMaiorValor(Int32[] array)
		{
			Int32? segundoMaiorValor = null;

			if (array != null)
			{
				List<Int32> listaDeNumeros = array.ToList();
				listaDeNumeros.Sort();
				int size = listaDeNumeros.Count;

				//Evitando a exception ArrayIndexOutOfBoundsException caso seja passado um array 
				//com somente um elemeto. Nesse caso estou retornando null, pois não existe segundo maior valor
				if (size >= 2)
					segundoMaiorValor = listaDeNumeros[size - 2];
			}

			return segundoMaiorValor;
		}
	}
}
