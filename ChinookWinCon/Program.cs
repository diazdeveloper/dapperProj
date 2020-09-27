using System;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using ChinookWinCon.Models;
using System.Data;
using System.Configuration;
using System.Linq;

namespace ChinookWinCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var genre = new List<Genre>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["chinook"].ConnectionString))
            {
                genre = db.Query<Genre>("Select * from Genre").ToList();
            }

            foreach (var item in genre)
            {
                Console.WriteLine($"UID {item.GenreId}: {item.Name}");

            }

            Console.WriteLine("Good By!");
        }
    }
}
