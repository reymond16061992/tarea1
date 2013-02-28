using System;

namespace tarea1
{
	class MainClass
	{
		public static void Main ()
		{
			
			persona Persona = new persona ();
			Console.WriteLine ("Escribe tu Nombre");
			persona.nombre = Console.ReadLine();
			Console.WriteLine ("Escribe tu Telefono");
			persona.telefono = Console.ReadLine();
			Console.WriteLine ("Escribe tu Email");
			persona.email = Console.ReadLine();
			Console.WriteLine ("Escribe tu Domiciliio");
			persona.domicilio = Console.ReadLine();
			
			Console.WriteLine("");
			Console.WriteLine("Ficha Persona");
			Console.WriteLine("Nombre:" + persona.nombre);
			Console.WriteLine("Telefono:" + persona.telefono);
			Console.WriteLine("Email:" + persona.email);
			Console.WriteLine("Domicilio:" + persona.domicilio);
		}
	}
}
