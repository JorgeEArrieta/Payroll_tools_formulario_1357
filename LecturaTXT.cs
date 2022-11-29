using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetLight;
using System.Windows.Forms;

namespace Formulario1357
{
    internal class LecturaTXT
    {
        // Archivo de texto
        private List<string> lecturaTXT = new List<string>();
        
        // Lista donde se van a guardar los datos correspondientes a cada empleado.
        private List<object> registroEmpleado = new List<object>();

        public List<object> ReturnReg01(string openFile)
        {
            // Lectura del archivo txt.
            StreamReader txtFile = new StreamReader(openFile);
            
            // Lista para guardar los valores del registro 01.
            List<object> reg01 = new List<object>();


            string linea = txtFile.ReadLine();

            MessageBox.Show(linea.Substring(2, 11));

            long cuit = long.Parse(linea.Substring(2, 11));
            int perInformado = Int32.Parse(linea.Substring(13, 6));
            int secuencia = Int32.Parse(linea.Substring(19, 2));
            int codImpuesto = Int32.Parse(linea.Substring(21, 4));
            int codConcepto = Int32.Parse(linea.Substring(25, 3));
            int numFormulario = Int32.Parse(linea.Substring(28, 4));
            int tipPresentacion = Int32.Parse(linea.Substring(32, 1));
            int verSistema = Int32.Parse(linea.Substring(33, 5));

            reg01.Add(cuit);
            reg01.Add(perInformado);
            reg01.Add(secuencia);
            reg01.Add(codImpuesto);
            reg01.Add(codConcepto);
            reg01.Add(numFormulario);
            reg01.Add(tipPresentacion);
            reg01.Add(verSistema);

            txtFile.Close();

            return reg01;
        }

        public void ReadTxt(string openFile, string saveFile)
        {
            // Archivo de texto.
            StreamReader txtfile = new StreamReader(openFile);

            // ArchivoExcel
            SLDocument excelFile = new SLDocument();

            // Clase Data Frame
            DataFrame tDatos = new DataFrame();
            
            // Genero los datos para el DataTable
            tDatos.CreateColumns();

            // Variable donde se van a guardar las lineas del archivo.
            String linea;

            // lee el archivo de texto.
            linea = txtfile.ReadLine();

            while (linea != null)
            {
                lecturaTXT.Add(linea);
                linea = txtfile.ReadLine();
            }

            txtfile.Close();

            // Guarda los datos obtenidos en el listado registroEmpleado.

            for (int i = 0; i < lecturaTXT.Count; i++)
            {
                String codigo = lecturaTXT[i].Substring(0, 2);

                switch (codigo)
                {
                    case "02":
                        LeerRegistro02(registroEmpleado, lecturaTXT, i);
                        break;
                    case "03":
                        LeerRegistro03(registroEmpleado, lecturaTXT, i);
                        break;
                    case "04":
                        LeerRegistro04(registroEmpleado, lecturaTXT, i);
                        break;
                    case "05":
                        LeerRegistro05(registroEmpleado, lecturaTXT, i);
                        break;
                    case "06":
                        LeerRegistro06(registroEmpleado, lecturaTXT, i);
                        
                        // Paso los datos al DataTable
                        
                        tDatos.tablaDatos.Rows.Add(registroEmpleado.ToArray());

                        // Limpio el List.
                        registroEmpleado.Clear();

                        break;
                }
            }

            // Se guardan los datos en el archivo excel.
            excelFile.ImportDataTable(1, 1, tDatos.tablaDatos, true);
            excelFile.SaveAs(saveFile + @"\excel.xlsx");
            MessageBox.Show("Fin");
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 02.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro02 (List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Primer línea de registro correspondiente al empleado
            String cuil = archivoTexto[i].Substring(2, 11);
            String periodoDesde = archivoTexto[i].Substring(13, 8);
            String periodoHasta = archivoTexto[i].Substring(21, 8);
            String meses = archivoTexto[i].Substring(29, 2);
            String beneficio = archivoTexto[i].Substring(31, 1);
            String transporte = archivoTexto[i].Substring(32, 1);
            String ley27424 = archivoTexto[i].Substring(33, 1);
            String ley27549 = archivoTexto[i].Substring(34, 1);
            String ley27555 = archivoTexto[i].Substring(35, 1);
            String ley19101 = archivoTexto[i].Substring(36, 1);


            // Guarda los datos en el registro.
            arrayEmpleado.Add(cuil);
            arrayEmpleado.Add(periodoDesde);
            arrayEmpleado.Add(periodoHasta);
            arrayEmpleado.Add(meses);
            arrayEmpleado.Add(beneficio);
            arrayEmpleado.Add(transporte);
            arrayEmpleado.Add(ley27424);
            arrayEmpleado.Add(ley27549);
            arrayEmpleado.Add(ley27555);
            arrayEmpleado.Add(ley19101);
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 03.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro03(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Segunda línea de registro correspondiente al empleado

            Decimal remBrutaGravada = Decimal.Parse(archivoTexto[i].Substring(13, 15)) / 100;
            Decimal retNoHabitualesGravadas = Decimal.Parse(archivoTexto[i].Substring(28, 15)) / 100;
            Decimal sacPrimerCuotaGrav = Decimal.Parse(archivoTexto[i].Substring(43, 15)) / 100;
            Decimal sacSegCuotaGrav = Decimal.Parse(archivoTexto[i].Substring(58, 15)) / 100;
            Decimal hsExtrasGrav = Decimal.Parse(archivoTexto[i].Substring(73, 15)) / 100;
            Decimal movViaticosGrav = Decimal.Parse(archivoTexto[i].Substring(88, 15)) / 100;
            Decimal matDidacticoGrav = Decimal.Parse(archivoTexto[i].Substring(103, 15)) / 100;
            Decimal remuneracionExenta = Decimal.Parse(archivoTexto[i].Substring(118, 15)) / 100;
            Decimal remExentaHsExtras = Decimal.Parse(archivoTexto[i].Substring(133, 15)) / 100;
            Decimal movViaticosExenta = Decimal.Parse(archivoTexto[i].Substring(148, 15)) / 100;
            Decimal matDidacticoExento = Decimal.Parse(archivoTexto[i].Substring(163, 15)) / 100;
            Decimal remOtrosEmpRemBruta = Decimal.Parse(archivoTexto[i].Substring(178, 15)) / 100;
            Decimal remOtrosEmpRetNoHab = Decimal.Parse(archivoTexto[i].Substring(193, 15)) / 100;
            Decimal remOtrosEmpSAC1Grav = Decimal.Parse(archivoTexto[i].Substring(208, 15)) / 100;
            Decimal remOtrosEmpSAC2Grav = Decimal.Parse(archivoTexto[i].Substring(223, 15)) / 100;
            Decimal remOtrosEmpHsExtrasGrav = Decimal.Parse(archivoTexto[i].Substring(238, 15)) / 100;
            Decimal remOtrosEmpMovViatGrav = Decimal.Parse(archivoTexto[i].Substring(253, 15)) / 100;
            Decimal remOtrosEmpMatDidacticoGrav = Decimal.Parse(archivoTexto[i].Substring(268, 15)) / 100;
            Decimal remOtrosEmpRemExenta = Decimal.Parse(archivoTexto[i].Substring(283, 15)) / 100;
            Decimal remOtrosEmpHsExtrasExenta = Decimal.Parse(archivoTexto[i].Substring(298, 15)) / 100;
            Decimal remOtrosEmpMovViatExenta = Decimal.Parse(archivoTexto[i].Substring(313, 15)) / 100;
            Decimal remOtrosEmpMatDidacExento = Decimal.Parse(archivoTexto[i].Substring(328, 15)) / 100;
            Decimal totRemuneracionGravada = Decimal.Parse(archivoTexto[i].Substring(343, 15)) / 100;
            Decimal totRemuneracionExenta = Decimal.Parse(archivoTexto[i].Substring(358, 15)) / 100;
            Decimal totalRemuneraciones = Decimal.Parse(archivoTexto[i].Substring(373, 17)) / 100;
            Decimal retNoHabitualesExenta = Decimal.Parse(archivoTexto[i].Substring(390, 15)) / 100;
            Decimal sacPrimerCuotaExenta = Decimal.Parse(archivoTexto[i].Substring(405, 15)) / 100;
            Decimal sacSegCuotaExenta = Decimal.Parse(archivoTexto[i].Substring(420, 15)) / 100;
            Decimal ajPerAntRemuGravada = Decimal.Parse(archivoTexto[i].Substring(435, 15)) / 100;
            Decimal ajPerAntRemExenta = Decimal.Parse(archivoTexto[i].Substring(450, 15)) / 100;
            Decimal remOtrosEmpRetNoHabExenta = Decimal.Parse(archivoTexto[i].Substring(455, 15)) / 100;
            Decimal remOtrosEmpSAC1Exento = Decimal.Parse(archivoTexto[i].Substring(480, 15)) / 100;
            Decimal RemOtrosEmpSAC2Exento = Decimal.Parse(archivoTexto[i].Substring(495, 15)) / 100;
            Decimal RemOtrosEmpAjPerAntRemGravada = Decimal.Parse(archivoTexto[i].Substring(510, 15)) / 100;
            Decimal RemOtrosEmpAjPerAntRemExenta = Decimal.Parse(archivoTexto[i].Substring(525, 15)) / 100;
            Decimal remExentaLey27549 = Decimal.Parse(archivoTexto[i].Substring(540, 15)) / 100;
            Decimal remOtrosEmpleosLey27549 = Decimal.Parse(archivoTexto[i].Substring(555, 15)) / 100;
            Decimal bonoProductividadGravado = Decimal.Parse(archivoTexto[i].Substring(570, 15)) / 100;
            Decimal falloCajaGravada = Decimal.Parse(archivoTexto[i].Substring(585, 15)) / 100;
            Decimal similarNaturalezaGravada = Decimal.Parse(archivoTexto[i].Substring(600, 15)) / 100;
            Decimal bonoProductividadExento = Decimal.Parse(archivoTexto[i].Substring(615, 15)) / 100;
            Decimal falloCajaExento = Decimal.Parse(archivoTexto[i].Substring(630, 15)) / 100;
            Decimal similarNaturalezaExento = Decimal.Parse(archivoTexto[i].Substring(645, 15)) / 100;
            Decimal gastosTeletrabajoExento = Decimal.Parse(archivoTexto[i].Substring(660, 15)) / 100;
            Decimal ley19101Exento = Decimal.Parse(archivoTexto[i].Substring(675, 15)) / 100;
            Decimal RemOtrosEmpBonoProdGravado = Decimal.Parse(archivoTexto[i].Substring(690, 15)) / 100;
            Decimal RemOtrosEmpFalloCajaGravado = Decimal.Parse(archivoTexto[i].Substring(705, 15)) / 100;
            Decimal RemOtrosEmpSimilNaturalezaGrav = Decimal.Parse(archivoTexto[i].Substring(720, 15)) / 100;
            Decimal RemOtrosEmpBonoProducExento = Decimal.Parse(archivoTexto[i].Substring(735, 15)) / 100;
            Decimal RemOtrosEmpFalloCajaExento = Decimal.Parse(archivoTexto[i].Substring(750, 15)) / 100;
            Decimal RemOtrosEmpSimilNatuExento = Decimal.Parse(archivoTexto[i].Substring(765, 15)) / 100;
            Decimal RemOtrosEmpGastosTeletraExento = Decimal.Parse(archivoTexto[i].Substring(780, 15)) / 100;
            Decimal RemOtrosEmpLey19101Exento = Decimal.Parse(archivoTexto[i].Substring(795, 15)) / 100;

            // Guarda datos en Lista
            arrayEmpleado.Add(remBrutaGravada);
            arrayEmpleado.Add(retNoHabitualesGravadas);
            arrayEmpleado.Add(sacPrimerCuotaGrav);
            arrayEmpleado.Add(sacSegCuotaGrav);
            arrayEmpleado.Add(hsExtrasGrav);
            arrayEmpleado.Add(movViaticosGrav);
            arrayEmpleado.Add(matDidacticoGrav);
            arrayEmpleado.Add(remuneracionExenta);
            arrayEmpleado.Add(remExentaHsExtras);
            arrayEmpleado.Add(movViaticosExenta);
            arrayEmpleado.Add(matDidacticoExento);
            arrayEmpleado.Add(remOtrosEmpRemBruta);
            arrayEmpleado.Add(remOtrosEmpRetNoHab);
            arrayEmpleado.Add(remOtrosEmpSAC1Grav);
            arrayEmpleado.Add(remOtrosEmpSAC2Grav);
            arrayEmpleado.Add(remOtrosEmpHsExtrasGrav);
            arrayEmpleado.Add(remOtrosEmpMovViatGrav);
            arrayEmpleado.Add(remOtrosEmpMatDidacticoGrav);
            arrayEmpleado.Add(remOtrosEmpRemExenta);
            arrayEmpleado.Add(remOtrosEmpHsExtrasExenta);
            arrayEmpleado.Add(remOtrosEmpMovViatExenta);
            arrayEmpleado.Add(remOtrosEmpMatDidacExento);
            arrayEmpleado.Add(totRemuneracionGravada);
            arrayEmpleado.Add(totRemuneracionExenta);
            arrayEmpleado.Add(totalRemuneraciones);
            arrayEmpleado.Add(retNoHabitualesExenta);
            arrayEmpleado.Add(sacPrimerCuotaExenta);
            arrayEmpleado.Add(sacSegCuotaExenta);
            arrayEmpleado.Add(ajPerAntRemuGravada);
            arrayEmpleado.Add(ajPerAntRemExenta);
            arrayEmpleado.Add(remOtrosEmpRetNoHabExenta);
            arrayEmpleado.Add(remOtrosEmpSAC1Exento);
            arrayEmpleado.Add(RemOtrosEmpSAC2Exento);
            arrayEmpleado.Add(RemOtrosEmpAjPerAntRemGravada);
            arrayEmpleado.Add(RemOtrosEmpAjPerAntRemExenta);
            arrayEmpleado.Add(remExentaLey27549);
            arrayEmpleado.Add(remOtrosEmpleosLey27549);
            arrayEmpleado.Add(bonoProductividadGravado);
            arrayEmpleado.Add(falloCajaGravada);
            arrayEmpleado.Add(similarNaturalezaGravada);
            arrayEmpleado.Add(bonoProductividadExento);
            arrayEmpleado.Add(falloCajaExento);
            arrayEmpleado.Add(similarNaturalezaExento);
            arrayEmpleado.Add(gastosTeletrabajoExento);
            arrayEmpleado.Add(ley19101Exento);
            arrayEmpleado.Add(RemOtrosEmpBonoProdGravado);
            arrayEmpleado.Add(RemOtrosEmpFalloCajaGravado);
            arrayEmpleado.Add(RemOtrosEmpSimilNaturalezaGrav);
            arrayEmpleado.Add(RemOtrosEmpBonoProducExento);
            arrayEmpleado.Add(RemOtrosEmpFalloCajaExento);
            arrayEmpleado.Add(RemOtrosEmpSimilNatuExento);
            arrayEmpleado.Add(RemOtrosEmpGastosTeletraExento);
            arrayEmpleado.Add(RemOtrosEmpLey19101Exento);

        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 04.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro04(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Tercer línea de registro correspondiente al empleado

            Decimal aporteJubilatorio = Decimal.Parse(archivoTexto[i].Substring(13, 15)) / 100;
            Decimal aporteJubilatorioOtrosEmp = Decimal.Parse(archivoTexto[i].Substring(28, 15)) / 100;
            Decimal aporteObraSocial = Decimal.Parse(archivoTexto[i].Substring(43, 15)) / 100;
            Decimal aporteObraSocialOtrosEmp = Decimal.Parse(archivoTexto[i].Substring(58, 15)) / 100;
            Decimal cuotaSindical = Decimal.Parse(archivoTexto[i].Substring(73, 15)) / 100;
            Decimal cuotaSindicalOtrosEmpleos = Decimal.Parse(archivoTexto[i].Substring(88, 15)) / 100;
            Decimal cuotaMedicoAsistencial = Decimal.Parse(archivoTexto[i].Substring(103, 15)) / 100;
            Decimal primasSeguroVida = Decimal.Parse(archivoTexto[i].Substring(118, 15)) / 100;
            Decimal seguroMuerteMixta = Decimal.Parse(archivoTexto[i].Substring(133, 15)) / 100;
            Decimal seguroRetiroPrivado = Decimal.Parse(archivoTexto[i].Substring(148, 15)) / 100;
            Decimal cuotaparteFCI = Decimal.Parse(archivoTexto[i].Substring(163, 15)) / 100;
            Decimal gastosSepelio = Decimal.Parse(archivoTexto[i].Substring(178, 15)) / 100;
            Decimal viajanteComercio = Decimal.Parse(archivoTexto[i].Substring(193, 15)) / 100;
            Decimal donaciones = Decimal.Parse(archivoTexto[i].Substring(208, 15)) / 100;
            Decimal dtosObligatorios = Decimal.Parse(archivoTexto[i].Substring(223, 15)) / 100;
            Decimal honorariosServMedica = Decimal.Parse(archivoTexto[i].Substring(238, 15)) / 100;
            Decimal intCreditoHipotecario = Decimal.Parse(archivoTexto[i].Substring(253, 15)) / 100;
            Decimal fondoRiesgoSGR = Decimal.Parse(archivoTexto[i].Substring(269, 15)) / 100;
            Decimal otrasDeducCajaComp = Decimal.Parse(archivoTexto[i].Substring(283, 15)) / 100;
            Decimal alquileres = Decimal.Parse(archivoTexto[i].Substring(298, 15)) / 100;
            Decimal empleadosDomestico = Decimal.Parse(archivoTexto[i].Substring(313, 15)) / 100;
            Decimal viaticos = Decimal.Parse(archivoTexto[i].Substring(328, 15)) / 100;
            Decimal indumentaria = Decimal.Parse(archivoTexto[i].Substring(343, 15)) / 100;
            Decimal otrasDeducciones = Decimal.Parse(archivoTexto[i].Substring(358, 15)) / 100;
            Decimal totalDeducciones = Decimal.Parse(archivoTexto[i].Substring(373, 17)) / 100;
            Decimal otrasDeducApJub = Decimal.Parse(archivoTexto[i].Substring(390, 15)) / 100;
            Decimal otrasDeducCajaProvNac = Decimal.Parse(archivoTexto[i].Substring(405, 15)) / 100;
            Decimal otrasDeducRG2442 = Decimal.Parse(archivoTexto[i].Substring(420, 15)) / 100;
            Decimal otrasDeducFondoCompPrev = Decimal.Parse(archivoTexto[i].Substring(435, 15)) / 100;

            // Guarda datos en listado.
            arrayEmpleado.Add(aporteJubilatorio);
            arrayEmpleado.Add(aporteJubilatorioOtrosEmp);
            arrayEmpleado.Add(aporteObraSocial);
            arrayEmpleado.Add(aporteObraSocialOtrosEmp);
            arrayEmpleado.Add(cuotaSindical);
            arrayEmpleado.Add(cuotaSindicalOtrosEmpleos);
            arrayEmpleado.Add(cuotaMedicoAsistencial);
            arrayEmpleado.Add(primasSeguroVida);
            arrayEmpleado.Add(seguroMuerteMixta);
            arrayEmpleado.Add(seguroRetiroPrivado);
            arrayEmpleado.Add(cuotaparteFCI);
            arrayEmpleado.Add(gastosSepelio);
            arrayEmpleado.Add(viajanteComercio);
            arrayEmpleado.Add(donaciones);
            arrayEmpleado.Add(dtosObligatorios);
            arrayEmpleado.Add(honorariosServMedica);
            arrayEmpleado.Add(intCreditoHipotecario);
            arrayEmpleado.Add(fondoRiesgoSGR);
            arrayEmpleado.Add(otrasDeducCajaComp);
            arrayEmpleado.Add(alquileres);
            arrayEmpleado.Add(empleadosDomestico);
            arrayEmpleado.Add(viaticos);
            arrayEmpleado.Add(indumentaria);
            arrayEmpleado.Add(otrasDeducciones);
            arrayEmpleado.Add(totalDeducciones);
            arrayEmpleado.Add(otrasDeducApJub);
            arrayEmpleado.Add(otrasDeducCajaProvNac);
            arrayEmpleado.Add(otrasDeducRG2442);
            arrayEmpleado.Add(otrasDeducFondoCompPrev);
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 05.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro05(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Cuarta línea de registro correspondiente al empleado
            Decimal gananciaNoImponible = Decimal.Parse(archivoTexto[i].Substring(13, 15)) / 100;
            Decimal deduccionEspecial = Decimal.Parse(archivoTexto[i].Substring(28, 15)) / 100;
            Decimal deduccionEspecifica = Decimal.Parse(archivoTexto[i].Substring(43, 15)) / 100;
            Decimal conyuge = Decimal.Parse(archivoTexto[i].Substring(58, 15)) / 100;
            String cantidadHijos = archivoTexto[i].Substring(73, 2);
            Decimal hijos = Decimal.Parse(archivoTexto[i].Substring(75, 15)) / 100;
            Decimal totalCargasFamilia = Decimal.Parse(archivoTexto[i].Substring(90, 15)) / 100;
            Decimal totalDeduccionesArt30 = Decimal.Parse(archivoTexto[i].Substring(105, 15)) / 100;
            Decimal remSujetaImpAntes = Decimal.Parse(archivoTexto[i].Substring(120, 15)) / 100;
            Decimal deduccionIncA = Decimal.Parse(archivoTexto[i].Substring(135, 15)) / 100;
            Decimal deduccionIncB = Decimal.Parse(archivoTexto[i].Substring(150, 15)) / 100;
            Decimal remSujetaImpuesto = Decimal.Parse(archivoTexto[i].Substring(165, 15)) / 100;
            String cantHijosInca = archivoTexto[i].Substring(180, 2);
            Decimal hijosIncapacitados = Decimal.Parse(archivoTexto[i].Substring(182, 15)) / 100;
            Decimal dedIncremPrimerParrafo = Decimal.Parse(archivoTexto[i].Substring(197, 15)) / 100;
            Decimal dedIncremSegundoParrafo = Decimal.Parse(archivoTexto[i].Substring(212, 15)) / 100;

            // Guarda datos en lista.
            arrayEmpleado.Add(gananciaNoImponible);
            arrayEmpleado.Add(deduccionEspecial);
            arrayEmpleado.Add(deduccionEspecifica);
            arrayEmpleado.Add(conyuge);
            arrayEmpleado.Add(cantidadHijos);
            arrayEmpleado.Add(hijos);
            arrayEmpleado.Add(totalCargasFamilia);
            arrayEmpleado.Add(totalDeduccionesArt30);
            arrayEmpleado.Add(remSujetaImpAntes);
            arrayEmpleado.Add(deduccionIncA);
            arrayEmpleado.Add(deduccionIncB);
            arrayEmpleado.Add(remSujetaImpuesto);
            arrayEmpleado.Add(cantHijosInca);
            arrayEmpleado.Add(hijosIncapacitados);
            arrayEmpleado.Add(dedIncremPrimerParrafo);
            arrayEmpleado.Add(dedIncremSegundoParrafo);
        }

        /// <summary>
        /// Extrae los datos, desde un objeto tipo List, del registro 06.
        /// </summary>
        /// <param name="arrayEmpleado">List. Guarda en el list los datos que extrae.</param>
        /// <param name="archivoTexto">List. Lista de donde extrae los datos.</param>
        /// <param name="i">Int. Indica el indice del List -> archivoTexto.</param>
        protected void LeerRegistro06(List<Object> arrayEmpleado, List<string> archivoTexto, int i)
        {
            // Lee los datos correspondientes al registro 06.

            Int32 alicuotaArt94 = Int32.Parse(archivoTexto[i].Substring(13, 1));
            Int32 alicuotaAplicable = Int32.Parse(archivoTexto[i].Substring(14, 1));
            Decimal impuestoDeterminado = Decimal.Parse(archivoTexto[i].Substring(15, 15)) / 100;
            Decimal impuestoRetenido = Decimal.Parse(archivoTexto[i].Substring(30, 15)) / 100;
            Decimal pagosCuenta = Decimal.Parse(archivoTexto[i].Substring(45, 15)) / 100;
            Decimal saldo = Decimal.Parse(archivoTexto[i].Substring(60, 15)) / 100;
            Decimal pagCtaCreditosDebitos = Decimal.Parse(archivoTexto[i].Substring(75, 15)) / 100;
            Decimal pagCtaRetAduaneras = Decimal.Parse(archivoTexto[i].Substring(90, 15)) / 100;
            Decimal pagCtaRG3819 = Decimal.Parse(archivoTexto[i].Substring(105, 15)) / 100;
            Decimal pagCtaLey27424 = Decimal.Parse(archivoTexto[i].Substring(120, 15)) / 100;
            Decimal pagCtaIncA = Decimal.Parse(archivoTexto[i].Substring(135, 15)) / 100;
            Decimal pagCtaIncB = Decimal.Parse(archivoTexto[i].Substring(150, 15)) / 100;
            Decimal pagCtaIncC = Decimal.Parse(archivoTexto[i].Substring(165, 15)) / 100;
            Decimal pagCtaIncD = Decimal.Parse(archivoTexto[i].Substring(180, 15)) / 100;
            Decimal pagCtaIncE = Decimal.Parse(archivoTexto[i].Substring(195, 15)) / 100;
            Decimal pagCtaCredFondo = Decimal.Parse(archivoTexto[i].Substring(210, 15)) / 100;
            Decimal pagCtaRG3819II = Decimal.Parse(archivoTexto[i].Substring(225, 15)) / 100;

            // Guarda datos en lista.
            arrayEmpleado.Add(alicuotaArt94);
            arrayEmpleado.Add(alicuotaAplicable);
            arrayEmpleado.Add(impuestoDeterminado);
            arrayEmpleado.Add(impuestoRetenido);
            arrayEmpleado.Add(pagosCuenta);
            arrayEmpleado.Add(saldo);
            arrayEmpleado.Add(pagCtaCreditosDebitos);
            arrayEmpleado.Add(pagCtaRetAduaneras);
            arrayEmpleado.Add(pagCtaRG3819);
            arrayEmpleado.Add(pagCtaLey27424);
            arrayEmpleado.Add(pagCtaIncA);
            arrayEmpleado.Add(pagCtaIncB);
            arrayEmpleado.Add(pagCtaIncC);
            arrayEmpleado.Add(pagCtaIncD);
            arrayEmpleado.Add(pagCtaIncE);
            arrayEmpleado.Add(pagCtaCredFondo);
            arrayEmpleado.Add(pagCtaRG3819II);
        }
    }
}