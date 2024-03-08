using System;

	public class Program {
		public static void Main(string[] args)
		{
		  int indice = 13, soma = 0;
			for (int k = 0; indice > k; k++) {
			  soma += k;
			}
			Console.Write($"{soma}");
		}
}

/* resultado SOMA = 78 */