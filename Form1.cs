using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1357
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ObtainTXTFile()
        {
            
            string currentDirectory = Environment.CurrentDirectory;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = currentDirectory;
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return fileDialog.FileName;
                }
                else
                {
                    return null;
                }

            }

        }

        private string ObtainExcelFile()
        {

            string currentDirectory = Environment.CurrentDirectory;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = currentDirectory;
                fileDialog.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return fileDialog.FileName;
                }
                else
                {
                    return null;
                }

            }

        }

        private string ObtainDirectory()
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if(folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowser.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }

        private void importarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            string file = ObtainTXTFile();
            string directory = ObtainDirectory();
      
            if (file != null && directory != null)
            {
                // creación de la clase Lectura TXT.
                LecturaTXT txtFile = new LecturaTXT();
                
                // Datos del registro 01.
                List<object> registro01 = txtFile.ReturnReg01(file);
                txtCUIT.Text = registro01[0].ToString();
                txtSecuencia.Text = registro01[1].ToString();
                txtCodConcepto.Text = registro01[2].ToString();
                txtTipPresentacion.Text = registro01[3].ToString();
                txtPerInformado.Text = registro01[4].ToString();
                txtCodImpuesto.Text = registro01[5].ToString();
                txtNumFormulario.Text = registro01[6].ToString();
                txtVerSistema.Text = registro01[7].ToString();  

                // Creación del archivo txt
                txtFile.ReadTxt(file, directory);
            }
                
        }

        private void exportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ObtainExcelFile();
            string directory = ObtainDirectory();
         
            if (file != null && directory != null)
            {
                WriteTXT txtFile = new WriteTXT();
                txtFile.ReadExcel(file, directory);
            }
        }

    }
}
