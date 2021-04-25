using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;


namespace Koleksiyonlar
{
    class MainClass
    {
        private static DataSet dataSet;
        private static object dataGridView1;

        public static void Main(string[] args)
        {
            string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil"};

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[].Insert(5, "İlker");

            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> {"Engin","Murat", "Kerem", "HAlil" } ;

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            Console.WriteLine("Merhaba Dünya");



            //NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=127.0.0.1; Database=Deneme; User Id=postgres; Password=123456;");

            NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=Deneme; User Id=postgres; Password=123456");

            string sql="SELECT * FROM table1 where age=5";

            

            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);

            DataSet ds = new DataSet();

            add.Fill(ds);

            //dataGridView1.DataSource = ds.Tables[0];


            Console.WriteLine(ds.Tables[0]);

            Console.WriteLine(add.Fill(ds));

            Console.WriteLine(add);

        }
    }
}
