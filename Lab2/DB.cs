using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace Lab2P4
{
    class DB
    {
        public void Select(IDbConnection connection)
        {
            var regions = connection.Query<Region>("SELECT * FROM Region");

            foreach (var item in regions)
            {
                Console.WriteLine($"{item.RegionID}: {item.RegionDescription}");
            }
                    
        }

        public void Insert(IDbConnection connection, Region region)
        {
            connection.Execute("INSERT INTO Region(RegionID, RegionDescription, VALUES(@is, @desc)", 
                new
                {
                    id = id,
                    desc = region.RegionDescription
                });

        }
	public void Delete(string connection, int id)
        {
            using IDbConnection connect = new SqlConnection(connection);
            
            connect.Execute("DELETE FROM Region WHERE RegionID=@id", new { id = id, });

        }
    }
}
