using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Productos
{



    public class Combustible

    {



        //public decimal[] PrecioCombustible = new decimal[4];//0:Premuim-1:Super-2:Euro-3:Diesel
        //public decimal[] LitrosVendidos = new decimal[4];
        //public string[] Nombre = new string[4];
        //public int Indice = new int();
        //public decimal MontodeVenta = new decimal();
        //public decimal[] TotaldeVenta = new decimal[4];
        public decimal PrecioCombustible = new decimal();
        public decimal Litros = new decimal();
        public decimal MontodeVenta = new decimal();
        public decimal TotaldeVenta = new decimal();
        //public string Nombre = new string();
        
        public decimal VentaCombustible(decimal Litros)
        {
            Litros= MontodeVenta / PrecioCombustible;
            TotaldeVenta = TotaldeVenta + MontodeVenta;

            //LitrosVendidos[Indice] = MontodeVenta / PrecioCombustible[Indice];
            //TotaldeVenta[Indice] = TotaldeVenta[Indice] + MontodeVenta;
            //return TotaldeVenta;
            return Litros;


        }

        
        







    }
    
   

}
    

 
       
       
    
       // LitrosVendidos[0]=90;
       // Precio[0]=65;
        //Nombre[0]=Super;
       





    

    
    

