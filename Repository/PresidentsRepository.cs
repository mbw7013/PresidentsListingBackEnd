using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace CorcoranPresidentsBackEnd.Repository
{
    public class PresidentsRepository
    {


        public IEnumerable<President> GetPresidentsFromDb(bool? asc)
        {
            using (var db = new PresidentContext())
            {
                if(asc.HasValue)
                {
                    if(asc.Value)
                    {
                        var query = from president in db.Presidents
                                    orderby president.PresidentName ascending
                                    select president;
                        return query.ToList();
                    }
                    else
                    {
                        var query = from president in db.Presidents
                                    orderby president.PresidentName descending
                                    select president;
                        return query.ToList();
                    }
                }
                else
                {
                    var query = from president in db.Presidents
                                select president;
                    return query.ToList();
                }
            }
        }
    }
}