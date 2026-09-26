using System;

public class Socio
{
	public int Id { get; set; }
	public string Nombre { get; set; }
	public string Apellido { get; set; }
	public string Dni { get; set; }
	public DateTime FechaNacimiento { get; set; }
	public string Direccion { get; set; }
	public string Telefono { get; set;}
	public DateTime FechaAlta { get; set; }
	public bool Estado { get; set; }

	public void DarDeAlta()
	{
		FechaAlta = DateTime.Now;
		Estado = true;
	}
	}
}
