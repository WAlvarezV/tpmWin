using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercaClick.Inicio
{    
    public class InitialData
    {
        ServicioInventario.ServicioInventario servInventario;
        public object[] listCategoria;
        public object[] listSubCategoria;
        public object[] listMarca;
        public object[] listProductos;
        public InitialData()
        {
            servInventario = new ServicioInventario.ServicioInventario();
            loadInitialData();
        }

        private void loadInitialData()
        {
            listCategoria = servInventario.listarTipoDato("CATEGORIA");
            listSubCategoria = servInventario.listarTipoDato("SUBCATEGORIA");
            listMarca = servInventario.listarTipoDato("MARCA");



        }

        #region funciones generales

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        //convierte un string en formato hora compatible para almacenar en tipo TIME en BD
        public string stringTohora(string hora)
        {
            //06:00 a.m.            
            int h = Int32.Parse(hora.Substring(0, hora.IndexOf(':')));
            string mer = hora.Substring(hora.IndexOf(' ') + 1, 1);
            string nuevaHora = "";
            if (mer.Equals("p") && h < 12)
            {
                h = h + 12;
                nuevaHora = "" + h + ":" + hora.Substring(hora.IndexOf(':'), 2) + ":00";
            }
            else
            {
                nuevaHora = hora.Substring(0, hora.IndexOf(' ')) + ":00";
            }

            return nuevaHora;
        }
        //convierte un string en formato hora para visualizar en formato 12 Horas
        public string horaTostring(string hora)
        {
            int h = Int32.Parse(hora.Substring(0, 2));
            string nuevaHora = "";
            if (h >= 12)
            {
                if (h > 12)
                    h = h - 12;
                nuevaHora = h.ToString().PadLeft(2, '0') + ":" + hora.Substring(3, 2) + " p.m.";
            }
            else
            {
                nuevaHora = hora.Substring(0, 5) + " a.m.";
            }

            return nuevaHora;
        }
        #endregion


    }
}
