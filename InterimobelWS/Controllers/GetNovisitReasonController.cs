using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterimobelWS.Models;

namespace InterimobelWS.Controllers
{
    public class GetNovisitReasonController : Controller
    {
        // GET: SetVisitInstaller
        public ActionResult Index()
        {
            string inst_id = Convert.ToString(Request.QueryString["instid"]);
            int visitid = Convert.ToInt32(Request.QueryString["visitid"]);
            int custid = Convert.ToInt32(Request.QueryString["custid"]);
            string lat = Convert.ToString(Request.QueryString["lat"]);
            string lon = Convert.ToString(Request.QueryString["lon"]);
            string reason= Convert.ToString(Request.QueryString["reason"]);
            TimeZoneMX horamx = new TimeZoneMX();
            var hora = horamx.GetHoraMX();
            var fecha = horamx.GetDateMX();
            var fechac= horamx.GetFechaMX();
            var succes = "";

            using (AppDTEntities objDataContext = new AppDTEntities())
            {
                try { 
                    NOTVISIT nOTVISIT = new NOTVISIT();
                    // fields to be insert
                    nOTVISIT.inst_id = inst_id;
                    nOTVISIT.vist_id = visitid;
                    nOTVISIT.novi_date = fechac;
                    nOTVISIT.novi_reazon =reason;
                    objDataContext.NOTVISIT.Add(nOTVISIT);
                    ///////////////////
                    VISITA_REGISTRO vISITA = new VISITA_REGISTRO();
                    // fields to be insert
                    vISITA.inst_id = int.Parse(inst_id);
                    vISITA.reg_lat = lat;
                    vISITA.reg_lon = lon;
                    vISITA.cust_id = custid;
                    vISITA.reg_date = fecha;
                    vISITA.reg_ini = hora;
                    vISITA.reg_end = hora;
                    vISITA.visi_id = visitid;
                    vISITA.reg_status = 3;
                    objDataContext.VISITA_REGISTRO.Add(vISITA);

                    objDataContext.SaveChanges();
                succes = "Ok";
                }catch(Exception e)
                {
                    succes = "NoOk";
                }
            }
            
            return Json(new { succes }, JsonRequestBehavior.AllowGet);
        }
    }
}