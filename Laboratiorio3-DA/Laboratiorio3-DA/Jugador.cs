using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratiorio3_DA
{
    // sofia cambie internal por public 
    public class Jugador
    {
        String nombre;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        public string Nombre { get; set; }
        public Jugador AmigoSecreto { get; set; }

        public Jugador(String nombre, String correo, String endulzadaIdeal, String regaloIdeal)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.endulzadaIdeal = endulzadaIdeal;
            this.regaloIdeal = regaloIdeal;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getCorreo()
        {
            return correo;
        }

        public String getEndulzadaIdeal()
        {
            return endulzadaIdeal;
        }

        public String getRegaloIdeal()
        {
            return regaloIdeal;
        }

        public String getAmigoSecretoNombre()
        {
            return AmigoSecretoAsignado?.getNombre();  // Devuelve el nombre del amigo secreto si no es null, de lo contrario devuelve null.
        }

        public Jugador AmigoSecretoAsignado { get; set; }

        public String mostrarJugador()
        {
            return $"Jugador: {this.nombre}, {this.correo}, {this.endulzadaIdeal}, {this.regaloIdeal}, Amigo Secreto: {this.AmigoSecretoAsignado?.getNombre() ?? "No asignado"}";
        }

        public override string ToString()
        {
            if (AmigoSecretoAsignado != null)
                return $"{getNombre()} -> {AmigoSecretoAsignado.getNombre()}";
            else
                return $"{getNombre()} -> No asignado";
        }
    }
    }
