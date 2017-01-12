﻿
﻿using InterimobelWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterimobelWS.Controllers
{
    public class GetInicioVisitaController : Controller
    {
        // GET: SetVisitInstaller
        public ActionResult Index()
        {
            int inst_id = Convert.ToInt32(Request.QueryString["instid"]);
            int visitid = Convert.ToInt32(Request.QueryString["visitid"]);
            int custid = Convert.ToInt32(Request.QueryString["custid"]);
            string lat = Convert.ToString(Request.QueryString["lat"]);
            string lon = Convert.ToString(Request.QueryString["lon"]);
            string reason = Convert.ToString(Request.QueryString["reason"]);
            TimeZoneMX horamx = new TimeZoneMX();
            var hora = horamx.GetHoraMX();
            var fecha = horamx.GetDateMX();
            var succes = "";

            using (AppDTEntities objDataContext = new AppDTEntities())
            {
                try
                {
                    VISITA_REGISTRO vISITA = new VISITA_REGISTRO();
                    // fields to be insert
                    vISITA.inst_id = inst_id;
                    vISITA.reg_lat = lat;
                    vISITA.reg_lon = lon;
                    vISITA.cust_id = custid;
                    vISITA.reg_date = fecha;
                    vISITA.reg_ini = hora;
                    vISITA.reg_end = hora;
                    vISITA.visi_id = visitid;
                    vISITA.reg_status = 1;
                    objDataContext.VISITA_REGISTRO.Add(vISITA);

                    objDataContext.SaveChanges();
                    succes = "Ok";
                }
                catch (Exception e)
                {
                    succes = "NoOk";
                }
            }

            return Json(new { succes }, JsonRequestBehavior.AllowGet);
        }
    }
}
