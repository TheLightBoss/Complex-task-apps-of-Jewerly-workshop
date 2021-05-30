using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft;
using Npgsql;
using Jewerly.Model_API;

namespace Jewerly
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        string connectionStr = "Server=localhost; Port=5432; Database=jewerly; User Id=postgres; Password=saak2108;";
        NpgsqlConnection connection;
        string cmd;
        [HttpPost]
        public string GetZakazs(string id_mast)
        {
            string result = "";
            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    cmd = "CALL zakazs_master";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    List<Zakazs_Master> zakazs = new List<Zakazs_Master>();//отправим
                    while (dataReader.Read())
                    {
                        zakazs.Add(new Zakazs_Master()
                        {
                            date_start = (DateTime)dataReader["izgotovlenie.data_start"],
                            Id_izd = (int)dataReader["izdelie.id_izd"],
                            Name_izd = (string)dataReader["izdelie_spr.name_izd"],
                            Polu_status = (bool)dataReader["izgotovlenie.polu_status"],
                            Spisok_rabot = (string[])dataReader["rabota.spisok_rabot"],
                            Status = (bool)dataReader["izgotovlenie.status"],
                            Vipoln_rabot = (string[])dataReader["izgotovlenie.list_done_job"],
                            Url_pic = (string)dataReader["izdelie_spr.url_pic "]
                        }); 
                    }
                    connection.Close();


                    result = JsonConvert.SerializeObject(zakazs);
                    return result;
                }
                catch
                {

                    return result;
                }
            }
        } // отправка заказов у мастера

        [HttpPost]
        public string GetMasters(string s)
        {
            string result = "";
            
            using (connection = new NpgsqlConnection(connectionStr))
            {
                try
                {
                    Masters sotrudnik = JsonConvert.DeserializeObject<Masters>(s);
                    connection.Open();
                    cmd = "SELECT * FROM sotrudnik";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    Masters masters = new Masters(); //отправим
                    while (dataReader.Read())
                    {
                        //если это наш сотрудник то сохраняем его 
                        if((string)dataReader["login"]== sotrudnik.Login && (string)dataReader["password"] == sotrudnik.Password) masters = new Masters((int)dataReader["id_sotr"], (string)dataReader["fio"], (string)dataReader["address"],(string)dataReader["passport"],(short)dataReader["stag"],(string)dataReader["login"],(string)dataReader["password"]);
                    }
                    connection.Close();
                    result = JsonConvert.SerializeObject(masters);
                    return result; 
                }
                catch
                {
                    return result;
                }
            }
        } // отправка мастеров


        [HttpPost]
        public string GetStr()
        {
            return "должен вывести это на экран по этому url...";
        }

    }
}
