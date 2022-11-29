using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace Formulario1357
{
    internal class WriteTXT
    {
        public void ReadExcel(string readFile, string saveFile)
        {
            SLDocument excelFile = new SLDocument(readFile);
            StreamWriter txtfile = new StreamWriter(saveFile + @"\resultado.txt");

            int column = 1;
            int row = 2;

            bool check = string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column));

            while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
            {
                
                RegisterLenght registerLenght = new RegisterLenght();

                string fill = null;
                
                if(column == 1)
                {
                    fill = "02" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 11);
                    txtfile.Write(fill);

                }else if(column == 2 || column == 3)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 8);
                    txtfile.Write(fill);

                }else if(column == 4)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 2);
                    txtfile.Write(fill);
                }
                else if(column >= 5 && column < 10)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 1);
                    txtfile.Write(fill);

                }
                else if (column == 10)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 1) + "\n";
                    txtfile.Write(fill);
                }
                else if(column == 11)
                {
                    fill = "03" +  registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, 1), 11)
                                + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);
                }else if(column >= 12 && column <= 34)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);

                }else if(column == 35)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 17);
                    txtfile.Write(fill);
                }else if (column >= 36 && column < 63)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);

                }else if(column == 63)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15) + "\n";
                    txtfile.Write(fill);
                }else if (column == 64)
                {
                    fill = "04" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, 1), 11)
                                + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);
                }else if(column >= 65 && column <= 87)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);

                }else if(column == 88)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 17);
                    txtfile.Write(fill);

                }else if(column >= 89 && column < 92)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);

                }else if(column == 92){
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15) + "\n";
                    txtfile.Write(fill);
                }
                else if(column == 93)
                {
                    fill = "05" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, 1), 11)
                                + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);
                }else if(column >= 94 && column <= 96)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);
                }else if(column == 97)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 2);
                    txtfile.Write(fill);

                }else if(column >= 98 && column <= 104)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);
                }else if(column == 105)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 2);
                    txtfile.Write(fill);

                }else if(column >= 106 && column < 108)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);

                }else if (column == 108)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15) + "\n";
                    txtfile.Write(fill);
                }
                else if(column == 109)
                {
                    fill = "06" + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, 1), 11)
                                + registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 1);
                    txtfile.Write(fill);
                } else if(column == 110)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 1);
                    txtfile.Write(fill);
                }
                else if(column >= 111 && column < 125)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15);
                    txtfile.Write(fill);
                }
                else if (column == 125)
                {
                    fill = registerLenght.ConvertToRegisterLenght(excelFile.GetCellValueAsString(row, column), 15) + "\n";
                    txtfile.Write(fill);
                }


                if(string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column + 1)) == false)
                {
                    column++;
                }
                else if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    break;
                }

            }

            MessageBox.Show("Proceso Finalizado");
            txtfile.Close();
        }
    }
}
