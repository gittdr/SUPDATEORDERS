using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Services;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TLIVERDED.Models;
using UploadFile = TLIVERDED.Models.UploadFile;

namespace TLIVERDED
{
    public class Program
    {

        static storedProcedure sql = new storedProcedure("miConexion");
        public static FacLabControler facLabControler = new FacLabControler();
        public static string jsonFactura = "", idSucursal = "", idTipoFactura = "", IdApiEmpresa = "";
        public string leg;
        public static List<string> result = new List<string>();
        static string Fecha;
        static string Subtotal;
        static string Totalimptrasl;
        static string Totalimpreten;
        static string Descuentos;
        static string Total;
        static string FormaPago;
        static string Condipago;
        static string MetodoPago;
        static string Moneda;
        static string RFC;
        static string CodSAT;
        static string IdProducto;
        static string Producto;
        static string Origen = "1";
        static string Destino;
        public string Ai_orden = "";

        public static List<string> results = new List<string>();
        static HtmlTable table = new HtmlTable();

        static char[] caracter = { '|' };
        static string[] words;
        public static void Main(string[] args)
        {


            Program muobject = new Program();
            
            muobject.UpdateCPReporte();
            muobject.UpdateCPReportePenafiel();
            muobject.UpdateCPReportePalacioH();

        }

        public void UpdateCPReporte()
        {
            
            DataTable RRLiver = facLabControler.getReporteLiver();
            if (RRLiver.Rows.Count > 0)
            {
                foreach (DataRow  itemRl in RRLiver.Rows)
                {
                    string rorderl = itemRl["orden"].ToString();
                    string rrsegl = itemRl["segmento"].ToString();
                    DataTable rcpp = facLabControler.GetSegmentoJCLIVERDEDCPP(rrsegl);
                    if (rcpp.Rows.Count > 0)
                    {
                        foreach (DataRow ircpp in rcpp.Rows)
                        {
                            DateTime dt = DateTime.Parse(ircpp["Fecha"].ToString());
                            string rfecha = dt.ToString("yyyy'/'MM'/'dd HH:mm:ss");
                            facLabControler.PullReportUpdateCPP(rrsegl, rfecha);
                            DataTable uporder = facLabControler.UpdateOrderHeader(rorderl, rfecha);
                            facLabControler.OrderHeader(rorderl, rfecha);
                        }

                    }
                }
            }
        }
        public void UpdateCPReportePenafiel()
        {

            DataTable RRLiver = facLabControler.getReportePenaf();
            if (RRLiver.Rows.Count > 0)
            {
                foreach (DataRow itemRl in RRLiver.Rows)
                {
                    string rorderl = itemRl["orden"].ToString();
                    string rrsegl = itemRl["segmento"].ToString();
                    DataTable rcpp = facLabControler.GetSegmentoJCPENAFIELCPP(rrsegl);
                    if (rcpp.Rows.Count > 0)
                    {
                        foreach (DataRow ircpp in rcpp.Rows)
                        {
                            DateTime dt = DateTime.Parse(ircpp["Fecha"].ToString());
                            string rfecha = dt.ToString("yyyy'/'MM'/'dd HH:mm:ss");
                            facLabControler.PullReportUpdateCPPPENAFIEL(rrsegl, rfecha);
                            DataTable uporder = facLabControler.UpdateOrderHeader(rorderl, rfecha);
                            facLabControler.OrderHeader(rorderl, rfecha);
                        }

                    }
                }
            }
        }
        public void UpdateCPReportePalacioH()
        {

            DataTable RRLiver = facLabControler.getReportePal();
            if (RRLiver.Rows.Count > 0)
            {
                foreach (DataRow itemRl in RRLiver.Rows)
                {
                    string rorderl = itemRl["orden"].ToString();
                    string rrsegl = itemRl["segmento"].ToString();
                    DataTable rcpp = facLabControler.GetSegmentoJCPALACIOHCPP(rrsegl);
                    if (rcpp.Rows.Count > 0)
                    {
                        foreach (DataRow ircpp in rcpp.Rows)
                        {
                            DateTime dt = DateTime.Parse(ircpp["Fecha"].ToString());
                            string rfecha = dt.ToString("yyyy'/'MM'/'dd HH:mm:ss");
                            facLabControler.PullReportUpdateCPPPALACIOH(rrsegl, rfecha);
                            DataTable uporder = facLabControler.UpdateOrderHeader(rorderl, rfecha);
                            facLabControler.OrderHeader(rorderl, rfecha);
                        }

                    }
                }
            }
        }
    }
}
