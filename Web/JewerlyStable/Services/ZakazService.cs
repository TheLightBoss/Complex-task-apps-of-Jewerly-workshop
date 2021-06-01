using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jewerly;
using JewerlyStable;
using Npgsql;

namespace Jewerly.Services
{
    public class ZakazService
    {
        readonly jewerly_newContext DB = new();
        public bool InsertZakaz(Zakaz zakaz)
        {
            DB.Zakazs.Add(zakaz);
            DB.SaveChanges();
            return true;
        }
        public SetCena SetCena(int idIzd)
        {
            var query = (from m in DB.SetCenas
                         where m.IdIzdspr == idIzd
                         select m).FirstOrDefault();

            return query;
        }
        public Cena CenaDetal(int izd_sprizd)// получение данных для формирования цены
        {
            DataTable data = new();
            NpgsqlDataAdapter adapter = new("SELECT * FROM public.\"SetCena\" " +
                $"where id_izdspr = {izd_sprizd}", "Host=localhost;Port=5432;Database=jewerly_new;Username=postgres;Password=1234");
            adapter.Fill(data);
            Cena result = new()
            {
                Koeff = data.Rows[0].Field<decimal>("koeff"),
                Price_mater = data.Rows[0].Field<decimal>("price_mater")
            };
            return result;
        }
        public IEnumerable<ZakazForClient> GetZakazForClient(string id_user)
        {
            var query =  DB.ZakazForClients.ToList().Where(c => c.IdClient == id_user);
            return query;
        }
    }
}
