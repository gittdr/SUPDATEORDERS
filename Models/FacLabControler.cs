using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLIVERDED.Models
{
    public class FacLabControler
    {
        public ModelFact modelFact = new ModelFact();

        public DataTable facturas()
        {
            return this.modelFact.getFacturas();
        }
        public void GetMerc(string Ai_orden, string Av_cmd_code, string Av_cmd_description, string Af_weight, string Av_weightunit, string Af_count, string Av_countunit)
        {
            this.modelFact.GetMerc(Ai_orden, Av_cmd_code, Av_cmd_description, Af_weight, Av_weightunit, Af_count, Av_countunit);
        }
        public void DeleteMerc(string Ai_orden)
        {
            this.modelFact.DeleteMerc(Ai_orden);
        }
        public void OrderHeader(string leg, string rfecha)
        {
            this.modelFact.OrderHeader(leg, rfecha);
        }
        public DataTable GetLeg()
        {
            return this.modelFact.getLeg();
        }
        public DataTable ObtSegmento(string orden)
        {
            return this.modelFact.ObtSegmento(orden);
        }
        public DataTable ExisteSegmentos(string seg)
        {
            return this.modelFact.ExisteSegmentos(seg);
        }
        public DataTable GetEstatus(string orden)
        {
            return this.modelFact.GetEstatus(orden);
        }
        public DataTable SelectLegHeader(string orseg)
        {
            return this.modelFact.SelectLegHeader(orseg);
        }
        public DataTable ExisteStatus(string seg)
        {
            return this.modelFact.ExisteStatus(seg);
        }
        public DataTable GetSegmentoRepetido(string leg)
        {
            return this.modelFact.GetSegmentoRepetido(leg);
        }
        public DataTable GetSegmentoJr(string leg)
        {
            return this.modelFact.GetSegmentoJr(leg);
        }
        public DataTable GetSegmentoRepetidoReporte(string leg)
        {
            return this.modelFact.GetSegmentoRepetidoReporte(leg);
        }
        public DataTable TieneMercancias(string leg)
        {
            return this.modelFact.TieneMercancias(leg);
        }
        public void GetMerca(string Ai_orden, string segmentod, string Av_cmd_code, string Av_cmd_description, string Af_weight, string Av_weightunit, string Af_count, string Av_countunit)
        {
            this.modelFact.GetMerca(Ai_orden, segmentod, Av_cmd_code, Av_cmd_description, Af_weight, Av_weightunit, Af_count, Av_countunit);
        }
        public void PullReport(string rrseg)
        {
            this.modelFact.PullReport(rrseg);
        }
        public void PullReportUpdate(string Ai_orden,string rrseg,string rrbillto,string rrestatus,string fechatim)
        {
            this.modelFact.PullReportUpdate(Ai_orden,rrseg, rrbillto, rrestatus, fechatim);
        }
        public void PullReportUpdate2(string Ai_orden, string rrseg)
        {
            this.modelFact.PullReportUpdate2(Ai_orden, rrseg);
        }
        public void PullOrderReport(string Ai_orden)
        {
            this.modelFact.PullOrderReport(Ai_orden);
        }
        public void DeleteMerca(string segmentod)
        {
            this.modelFact.DeleteMerca(segmentod);
        }
        public DataTable ExisteSegmento(string leg)
        {
            return this.modelFact.ExisteSegmento(leg);
        }
        public DataTable UpdateLeg(string leg, string tipom)
        {
            return this.modelFact.UpdateLeg(leg, tipom);
        }
        public DataTable UpdateOrderHeader(string orheader, string fecha)
        {
            return this.modelFact.UpdateOrderHeader(orheader, fecha);
        }
        public DataTable VerErrores(string leg)
        {
            return this.modelFact.VerErrores(leg);
        }

        public DataTable facturasClientes()
        {
            return this.modelFact.getFacturasClientes();
        }

        public DataTable facturasGeneradas()
        {
            return this.modelFact.getFacturasGeneradas();
        }


        public DataTable FacturasPorProcesar(string billto)
        {
            return this.modelFact.getFacturasPorProcesar(billto);
        }

        public DataTable FacturasPorProcesarLiverpool()
        {
            return this.modelFact.getFacturasPorProcesarLivepool();
        }

        public DataTable detalleFacturas(string fact)
        {
            return this.modelFact.getDatosFacturas(fact);
        }

        public DataTable FacturaFacturaAdendaReferencia(string orden)
        {
            return this.modelFact.getFacturaAdendaReferencia(orden);
        }

        public DataTable detalle(string p)
        {
            return this.modelFact.getDetalle(p);
        }

        public DataTable detalle33p(string p)
        {
            return this.modelFact.getDetalle33(p);
        }

        public DataTable estatus(string fact)
        {
            return this.modelFact.getInvoice(fact);
        }

        public void actualizaFactura(string fact, string comprobante, int mbnumber)
        {
            this.modelFact.updateFactura(fact, comprobante, mbnumber);
        }
        public void enviarNotificacion(string leg, string titulo,string mensaje)
        {
            this.modelFact.enviarNotificacion(leg, titulo ,mensaje);
        }
        public void RegEjecucion()
        {
            this.modelFact.RegEjecucion();
        }

        public string minInvoice(string ivh)
        {
            DataTable lastInvoice = this.modelFact.getLastInvoice(ivh);
            if (lastInvoice.Rows.Count != 0 && lastInvoice != null)
                return lastInvoice.Rows[0].ItemArray[0].ToString();
            return "";
        }

        public string facturaValida(string ivh)
        {
            string str = this.minInvoice(ivh);
            if (str.Equals(""))
                return ivh;
            return str;
        }
        public void correcionGeneradas(

      string fact,
      string serie,

      string rutaPdf,
      string rutaXML,

      string UID
      )
        {
            this.modelFact.correcionGeneradas(fact, serie, rutaPdf, rutaXML, UID);
        }


        public void generadas(
          string folioFactura,
          string serieFactura,
          string uuidFactura,
          string pdf_xml_descargaFactura,
          string pdf_descargaFactura,
          string xlm_descargaFactura,
          string cancelFactura,
          string LegNum,
          string Fecha,
          string Total,
          string Moneda,
          string RFC,
          string Origen,
          string Destino
      )
        {
            this.modelFact.actualizaGeneradas(folioFactura, serieFactura, uuidFactura, pdf_xml_descargaFactura, pdf_descargaFactura, xlm_descargaFactura, cancelFactura, LegNum, Fecha, Total, Moneda, RFC, Origen, Destino);
        }

        public void insertfaltantes(
         string folioFactura,
         string serieFactura,
         string uuidFactura,
         string pdf_xml_descargaFactura,
         string pdf_descargaFactura,
         string xlm_descargaFactura,
         string cancelFactura,
         string LegNum,
         string Fecha,
         string Total,
         string Moneda,
         string RFC,
         string Origen,
         string Destino
     )
        {
            this.modelFact.insertfaltantes(folioFactura, serieFactura, uuidFactura, pdf_xml_descargaFactura, pdf_descargaFactura, xlm_descargaFactura, cancelFactura, LegNum, Fecha, Total, Moneda, RFC, Origen, Destino);
        }

        public void ErroresgeneradasCP(
            string Fecha,
            string Folio,
            string Erro1,
            string Erro2,
            string Erro3,
            string Erro4,
            string Erro5,
            string Erro6,
            string Erro7
    )
        {
            this.modelFact.ErrorGeneradasCP(Fecha, Folio, Erro1, Erro2, Erro3, Erro4, Erro5, Erro6, Erro7);
        }
    }
}
