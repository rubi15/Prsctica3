using System;
using System.Collections;

namespace Practica3
{
	class Program
	{
		
		public Hashtable agregar(Hashtable tabla){
						
			for(int i=0; i<=3; i++){
			
			personas per= new personas();
				
		    Console.WriteLine("\n *Introduzca su codigo: *\n");
		       per.codigo=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Introduzca su nombre: \n");
			   per.nombre= Console.ReadLine();
			
		    Console.WriteLine("Introduzca su telefono: \n");
			   per.telefono=double.Parse (Console.ReadLine());
			
		    Console.WriteLine("Introduzca su facebook: \n");
			   per.facebook= Console.ReadLine();
			
			
			   tabla.Add(per.codigo,per);
			   
		}
			return tabla;
		}
			
	public Hashtable editar(Hashtable tabla){	
			
			for(int i=0; i<2; i++)
			{
				
				Console.WriteLine("Ingrese el codigo que decea editar:");
			    double codigo=double.Parse (Console.ReadLine());
				
			    if(tabla.ContainsKey(codigo))
			    {
			    	
			    	personas editar = (personas)(tabla[codigo]);
			    	
			Console.WriteLine("Introduzca su nombre: \n");
			   Console.WriteLine(editar.nombre);
			
		    Console.WriteLine("Introduzca su telefono: \n");
		        Console.WriteLine(editar.telefono);
			
		    Console.WriteLine("Introduzca su facebook: \n");
		       Console.WriteLine(editar.facebook);
		    
		              Console.WriteLine(" ** Datos editados **");
			   	
			Console.WriteLine(" nombre: \n");
			   editar.nombre= Console.ReadLine ();
			
		    Console.WriteLine(" telefono: \n");
		       editar.nombre= Console.ReadLine ();
			
		    Console.WriteLine(" facebook: \n");
		       editar.nombre= Console.ReadLine ();
			 }
			    else{
			    	Console.WriteLine("El codigo que ingreso es incorrecto: \n");
		  }
	   }
			return tabla;
	}
		public Hashtable Eliminar(Hashtable tabla){
			for(int i=0; i<2; i++){
				
				Console.WriteLine("Ingrese el codigo de la persona que decea eliminar: \n");
			    double codigo=double.Parse (Console.ReadLine());
			    
			    if(tabla.ContainsKey(codigo)){
			    	
			    	Console.WriteLine("Esta seguro de que decea eliminar estos datos: \n");
			    	Console.WriteLine("1.- SI \n 2.- NO");
			    	
			    	int opc = int.Parse(Console.ReadLine());
			    	
			    	if(opc==1)
			    	{
			    		
			    		tabla.Remove(codigo);
			    	}
			    	else{
			    		Console.WriteLine("No se eliminaron los datos. ");
			    	}
			    }
			    else{	
			    	Console.WriteLine("El codigo que ingreso es incorrecto. ");
			    }
			    
			    Console.WriteLine("Los datos fueron eliminados:");
			       System.Threading.Thread.Sleep(1000);
			}
			return tabla;
		} 
		
		public void Mostrar (Hashtable tabla)
		{
			
			ICollection personas = tabla.Values;

			foreach(object objeto in personas){

				personas p = (personas) objeto;
				

				Console.WriteLine ("Codigo:\n" + p.codigo);
				Console.WriteLine ("Nombre:\n" + p.nombre);
				Console.WriteLine ("Telefono:\n" + p.facebook);
				Console.WriteLine ("Facebook:\n" + p.telefono);

			}
	  }
		
		public static void Main(string[] args)
		{	
		Hashtable tabla= new Hashtable();	
		
			new Program().agregar(tabla);
			new Program().editar(tabla);
			new Program().Eliminar(tabla);
			new Program().Mostrar(tabla);
			      
		}
			
		
		
		
		
	}
  }
