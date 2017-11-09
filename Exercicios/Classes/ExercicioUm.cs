using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
	public class ExercicioUm
	{
		public static Int32[] orderArray(Int32[][] arrays)
		{
			List<Int32> listaComElemtosDosArrays = null;

			if (arrays != null)
			{
				listaComElemtosDosArrays = new List<Int32>();

				for (int i = 0; i <= arrays.Length-1; i++)
				{
					listaComElemtosDosArrays.AddRange(arrays[i]);
				}

				listaComElemtosDosArrays.Sort();
			}

			return listaComElemtosDosArrays.ToArray();
		}
	}
}
