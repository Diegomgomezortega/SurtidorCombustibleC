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
        public decimal Precio = new decimal();
        public decimal res = new decimal();
        public decimal MontodeVenta = new decimal();
        public decimal TotaldeVenta = new decimal();

        
        
        public decimal LitrosVenta(decimal res)
        {
            res= MontodeVenta / Precio;
            TotaldeVenta = TotaldeVenta + MontodeVenta;
                        
            return res;
        }
        

        
    }

    

}
    

 
       
       
  



    

    
    

