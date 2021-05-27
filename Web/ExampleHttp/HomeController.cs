using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using Newtonsoft.Json;
using Newtonsoft;
using Microsoft.EntityFrameworkCore;
using ExampleHttp.Models;

namespace ExampleHttp
{
    public class HomeController : Controller
    {
        string conn = "Server=localhost; Port=5432; Database=jewerly; User Id=postgres; Password=saak2108;";
        NpgsqlConnection connection; 
        public IActionResult Index()
        {
            return View();
        }
        public string Ky()
        {
            using (connection = new NpgsqlConnection(conn))
            {
                try
                {
                    //Sotrudnik sotrudnik = JsonConvert.DeserializeObject<Sotrudnik>(s);
                    connection.Open();
                    string cmd = "SELECT * FROM sotrudnik";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    Masters master = new Masters();
                    while (dataReader.Read())
                    {
                        master = new Masters()
                            {
                                Fio = (string)dataReader["fio"],
                                Address = (string)dataReader["address"],
                                IdMaster = (int)dataReader["id_sotr"],
                                Login = (string)dataReader["login"],
                                Passport = (string)dataReader["passport"],
                                Password = (string)dataReader["password"],
                                Stag = (short)dataReader["stag"]
                            };
                        
                    }
                    connection.Close();
                    string result = JsonConvert.SerializeObject(master);
                    return result;
                }
                catch
                {
                    return "Ошибка!";
                }
            }
        }
        
        public string GetMaster(string s)
        {
            

            using (connection = new NpgsqlConnection(conn))
            {
                try
                {
                    Masters mast = JsonConvert.DeserializeObject<Masters>(s);
                    //Sotrudnik sotrudnik = JsonConvert.DeserializeObject<Sotrudnik>(s);
                    connection.Open();
                    string cmd = "SELECT * FROM sotrudnik";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    Masters master = new Masters();
                    while (dataReader.Read())
                    {
                        if(mast.Login == (string)dataReader["login"] && mast.Password == (string)dataReader["password"])
                        {
                            master = new Masters()
                            {
                                Fio = (string)dataReader["fio"],
                                Address = (string)dataReader["address"],
                                IdMaster = (int)dataReader["id_sotr"],
                                Login = (string)dataReader["login"],
                                Passport = (string)dataReader["passport"],
                                Password = (string)dataReader["password"],
                                Stag = (short)dataReader["stag"]
                            };
                        }
                    }
                    connection.Close();
                    string result = JsonConvert.SerializeObject(master);
                    return result;
                }
                catch
                {
                    return "Ошибка!";
                }
            }
        }
        public string GetZakazs(string id_mast)
        {
            using (connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    string cmd = "CALL zakazs_master("+id_mast+");";
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


                    return JsonConvert.SerializeObject(zakazs);
                }
                catch
                {
                    return "Ошибка!";
                }
            }
        } // отправка заказов у мастера



    }
}
