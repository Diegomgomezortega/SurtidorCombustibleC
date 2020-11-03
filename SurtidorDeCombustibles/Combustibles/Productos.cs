using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Productos
{



    public class Combustible

    {
        //public Combustible[] Liquidos = new Combustible[4];  //0:Premuim-1:Super-2:Euro-3:Diesel


        public double Precio = new double();
        public double[] LitrosVendidos = new double[4];
        public int Indice= new int();
        public double MontodeVenta =new double();
        public double[] TotaldeVenta = new double[4];
        public void VentaCombustible()
        {
            
            LitrosVendidos[Indice] = MontodeVenta / Precio;
            TotaldeVenta[Indice] = TotaldeVenta[Indice] + MontodeVenta;

        }
       







    }

    







 }
    
    
    
 
       
       
    
       // LitrosVendidos[0]=90;
       // Precio[0]=65;
        //Nombre[0]=Super;
       





    

    
    

