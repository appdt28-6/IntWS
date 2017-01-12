using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterimobelWS.Models
{
    public class VisitInst
    {
        private int _visi_id;
        public int visi_id
        {
            get { return _visi_id; }
            set { _visi_id = value; }
        }

        private int _inst_id;
        public int inst_id
        {
            get { return _inst_id; }
            set { _inst_id = value; }
        }

        private int _cust_id;
        public int cust_id
        {
            get { return _cust_id; }
            set { _cust_id = value; }
        }

        private string _visi_date;
        public string visi_date
        {
            get { return _visi_date; }
            set { _visi_date = value; }
        }

        private string _cust_name;
        public string cust_name
        {
            get { return _cust_name; }
            set { _cust_name = value; }
        }

        private string _cust_phone;
        public string cust_phone
        {
            get { return _cust_phone; }
            set { _cust_phone = value; }
        }

        private string _cust_mail;
        public string cust_mail
        {
            get { return _cust_mail; }
            set { _cust_mail = value; }
        }

        private string _cust_dir;
        public string cust_dir
        {
            get { return _cust_dir; }
            set { _cust_dir = value; }
        }

        private string _cust_longitud;
        public string cust_longitud
        {
            get { return _cust_longitud; }
            set { _cust_longitud = value; }
        }
        private string _cust_latitud;
        public string cust_latitud
        {
            get { return _cust_latitud; }
            set { _cust_latitud = value; }
        }

        public VisitInst(int visi_id, int inst_id, string visi_date,int cust_id,string cust_name, string cust_phone, string cust_mail, string cust_dir, string cust_longitud, string cust_latitud)
        {
            this.visi_id = visi_id;
            this.inst_id = inst_id;
            this.visi_date = visi_date;
            this.cust_id = cust_id;
            this.cust_name = cust_name;
            this.cust_phone = cust_phone;
            this.cust_mail = cust_mail;
            this.cust_dir = cust_dir;
            this.cust_longitud = cust_longitud;
            this.cust_latitud = cust_latitud;

        }

    }
}