using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sozluk.Controllers
{
    public class SozlukController : Controller
    {
        // GET: Sozluk
        public ActionResult Index()
        {
            return View();
        }
        public string Ceviri(string kdil, string hdil, string kelime)
        {
            SozlukContex db = new SozlukContex();
            string sonuc = db.Database.SqlQuery<string>("exec sp_ceviri @kaynak, @hedef, @kelime",
                new SqlParameter("kaynak", kdil),
                new SqlParameter("hedef", hdil),
                new SqlParameter("kelime", kelime)
                ).FirstOrDefault();
            return "Kelimenin " + hdil + " karşılığı: " + sonuc;
        }
        public ActionResult CeviriForm()
        {
            return View();
        }
    }
}