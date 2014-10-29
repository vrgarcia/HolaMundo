using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace HolaMundo
{
	public class Lista
	{
		private List<int> v;
		public Lista()
		{
			this.v=new List<int>();
		}
		public void Add(int x)
		{
			this.Add(x);
		}
		public int[] List
		{
			get
			{
				return this.v.ToArray();
			}
		}
		/*public List<int> List
		{
			haciendo esto nos exponemos a que el resto de clases puedan acceder sin pasar por Add
			get
			{
				return this.v;
			}
		}*/
	}


	/*class Producto
	{
		private int precio;
		public int Precio
		{
			get
			{
				return (int) {this.precio/166.386};
				//si el atrib fuera publico la division no la dejaria hacer asi, por eso no se usan getters y setters
			}
		}
	}*/

	//class Persona: Object, en caso de derivar de otra clase
	public class Persona
	{
		private string nombre;
		private int edad;
		public Persona(string n, int e)
		{
			this.nombre=n;
			//this.x es opcional si no hay ambigüedad
			this.edad=e;
		}
/*
		public string GetNombre()
		{
			return this.nombre;
		}
		public int GetEdad()
		{
			return this.edad;
		}
*/
		//en c# se usan propiedades, ni getters ni setters como tal, aunque son equivalentes
		public string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre=value;
			}
		}
		public int Edad
		{
			get
			{
				return this.edad;
			}
			set
			{
				this.edad=value;
			}
		}
		//Si se pone esto hay que borrar la declaracion de los atributos del principio.
		//de este modo ya se crean solos, junto con sus métodos get y set. El resto quedaria igual
		/*
		public string Nobre
		{
			get; set;
		}
		public int Edad
		{
			get; set;
		}*/
		public override string ToString()
		{
			return string.Format("(to string) {0} de {1} años.", this.Nombre, this.Edad);
			//return string.Format("(to string) {0} de {1} años.", this.GetNombre(), this.GetEdad());
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			char ch;
			int x;	//si no se les asigna nada ya vienen con 0
			long l;
			//uint ux; es entero sin signo, no se recomienda porque ya no tiene sentido

			float f;
			double y;

			string s = "   hola   ";
			string s2 = s.Trim ();

			//leer de teclado
			string nombre;
			int edad;
			Consola.Consola.Print("(CONSOLA) Nombre: ");	//usando la libreria consola que hicimos antes
			Console.Write("Nombre: ");
			nombre=Console.ReadLine();
			//si se pide un numero luego de la entrada hay que convertirlo
			Console.Write("Edad: ");
			edad=Convert.ToInt32(Console.ReadLine());

			int[] v = new int[5]{1, 2, 3, 4, 5};

			Persona p=new Persona(nombre, edad);
			//Se puede omitir el tipo de la referencia siempre y cuando vaya acompañado de una asignacion. Tampoco es muy recomendable, solo usar si queda clarisisimo que es lo que se pone a lado.
			//var p=new Persona(nombre, edad);

			//Console.WriteLine("Hello World, "+nombre+" de "+edad+" años.");
			//Console.WriteLine("(Clase) Hello World, "+p.GetNombre()+" de "+p.GetEdad()+" años.");
			Console.WriteLine(p.ToString());

			Console.WriteLine(string.Format("Hello world, {0} de {1} años.", nombre, edad));
			//con writeline puede funcionar SIN string.format, pero en otros casos es necesario ponerlo

			Console.Write('[');
			//recorrer vector y visualizar elementos
			for(int i=0; i<v.Length; ++i)
			{
				Console.Write(v[i] + " ");
			}
			Console.WriteLine("]");

			//foreach
			Console.Write('[');
			foreach(int elem in v)
			{
				Console.Write(elem+" ");
			}
			Console.WriteLine("]");
		}
	}
}