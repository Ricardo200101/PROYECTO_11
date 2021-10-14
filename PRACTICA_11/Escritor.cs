using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace PRACTICA_11
{
    class Escritor
    {
       
        public int _Name { get; set; }
        public string _Country { get; set; }
        public string _Fecha { get; set; }
        public string _Obras { get; set; }
      

     
        private Crud crud = new Crud();

        public MySqlDataReader getEscritor()
        {
            string query = "SELECT bookId,title,subtitle,ISBN,publishedDate FROM book";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }
    }
}
