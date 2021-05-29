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
        public string UpdateMaster(string s)
        {
            try
            {
                Sotrudnik sotrud = new Sotrudnik();
                Masters masters = JsonConvert.DeserializeObject<Masters>(s);
                jewerlyContext context;
                using (context = new jewerlyContext())
                {
                    var dat = from st in context.Sotrudniks
                              where st.IdSotr == masters.IdMaster
                              select st;
                    foreach(Sotrudnik sotrudnik in dat)
                    {
                        sotrudnik.Address = masters.Address;
                        sotrudnik.Fio = masters.Fio;
                        sotrudnik.Login = masters.Login;
                        sotrudnik.Passport = masters.Passport;
                        sotrudnik.Password = masters.Password;
                    }
                    try
                    {
                        context.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return "ошибка";
                    } 
                }

                string result = JsonConvert.SerializeObject(masters);
                return result;
            }
            catch
            {
                return "ошибка";
            }
        } //изменение данных сотрудника 
        public string GetMaster(string s)
        {
            using (connection = new NpgsqlConnection(conn))
            {
                
                    try
                    {
                        Masters mast = JsonConvert.DeserializeObject<Masters>(s);
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
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return "ошибка";
                    }
                
            }
        } //поиск и отправка мастера 
        public string GetZakazs(string id_mast)
        {
            using (connection = new NpgsqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    string cmd = "SELECT * FROM zakazsmasters WHERE id_sotr = "+id_mast+";";
                    NpgsqlCommand command = new NpgsqlCommand(cmd, connection);
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    List<Zakazs_Master> zakazs = new List<Zakazs_Master>();//отправим
                    while (dataReader.Read())
                    {
                        zakazs.Add(new Zakazs_Master()
                        {
                            date_start = (DateTime)dataReader["data_start"],
                            Id_izd = (int)dataReader["id_izd"],
                            Razmer = (double)dataReader["razmer"],
                            Name_izd = (string)dataReader["name_izd"],
                            Polu_status = (bool)dataReader["polu_status"],
                            Spisok_rabot = (string[])dataReader["spisok_rabot"],
                            Vipoln_rabot = (string[])dataReader["list_done_job"],
                            Status = (bool)dataReader["status"],
                            Url_pic = (string)dataReader["url_pic"]
                        });
                    }
                    connection.Close();
                    return JsonConvert.SerializeObject(zakazs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "";
                }
            }
        } // отправка заказов у мастера  
        public string ZakazCompleted(string s) 
        {
            int id = Convert.ToInt32(s);
            jewerlyContext context;
            using (context = new jewerlyContext())
            {
                var dat = from st in context.Izgotovlenies
                          where st.IdIzd == id
                          select st;
                foreach (var izgotovlenie in dat)
                {
                    izgotovlenie.DataEnd = DateTime.Now;
                    izgotovlenie.Status = true;
                }               
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "-1";
                }
            }
            return "0";
        } // заказ выполнен 
        public string ZakazHalfCompleted(string s)
        {
            Zakazs_Master zakazs_ = JsonConvert.DeserializeObject<Zakazs_Master>(s);
            jewerlyContext context;
            using (context = new jewerlyContext())
            {
                var dat = from st in context.Izgotovlenies
                          where st.IdIzd == zakazs_.Id_izd
                          select st;
                foreach (var izgotovlenie in dat)
                {
                    izgotovlenie.ListDoneJob[0] = zakazs_.Vipoln_rabot[0];
                    izgotovlenie.ListDoneJob[1] = zakazs_.Vipoln_rabot[1];
                    izgotovlenie.ListDoneJob[2] = zakazs_.Vipoln_rabot[2];
                    izgotovlenie.ListDoneJob[3] = zakazs_.Vipoln_rabot[3];
                    izgotovlenie.PoluStatus = true;
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "-1";// ошибка
                }
            }
            return "0"; //успешно 
        } // заказ выполнен наполовину 

    }
}
