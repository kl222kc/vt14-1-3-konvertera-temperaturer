using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KonverteraTemperaturer.Model;

namespace KonverteraTemperaturer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TempButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int startTemp = int.Parse(StartTempTextBox.Text);
                int endTemp = int.Parse(EndTempTextBox.Text);
                int stepTemp = int.Parse(IncreaseTempTextBox.Text);

                List<int> degreesC = new List<int>();
                List<int> degreesF = new List<int>();

                TableRow row = new TableRow();

                for (int i = startTemp; i < endTemp; i += stepTemp)
                {
                    if (ConvertCelRadio.Checked)
                    {
                        degreesC.Add(i);
                        degreesF.Add(TemperatureConverter.CelsiusToFahrenheit(i));
                    }

                    if (ConvertFarRadio.Checked)
                    {
                        degreesF.Add(i);
                        degreesC.Add(TemperatureConverter.FahrenheitToCelsius(i));
                    }
                }

                if (ConvertCelRadio.Checked)
                {

                    degreesC.Add(endTemp);
                    degreesF.Add(TemperatureConverter.CelsiusToFahrenheit(endTemp));

                    row = new TableRow();

                    TableCell cell1 = new TableCell();
                    TableCell cell2 = new TableCell();

                    cell1.Text = "C";
                    cell2.Text = "F";

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);

                    ResultTable.Rows.Add(row);
                }

                if (ConvertFarRadio.Checked)
                {

                    degreesF.Add(endTemp);
                    degreesC.Add(TemperatureConverter.FahrenheitToCelsius(endTemp));

                    row = new TableRow();

                    TableCell cell1 = new TableCell();
                    TableCell cell2 = new TableCell();

                    cell1.Text = "F";
                    cell2.Text = "C";

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);

                    ResultTable.Rows.Add(row);
                }

                for (int i = 0; i < degreesC.Count; i++)
                {

                    row = new TableRow();

                    TableCell cell1 = new TableCell();
                    TableCell cell2 = new TableCell();

                    if (ConvertCelRadio.Checked)
                    {
                        cell1.Text = degreesC[i].ToString();
                        cell2.Text = degreesF[i].ToString();
                    }

                    if (ConvertFarRadio.Checked)
                    {
                        cell1.Text = degreesF[i].ToString();
                        cell2.Text = degreesC[i].ToString();
                    }

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);

                    ResultTable.Rows.Add(row);
                    
                }

                

            }

        }
    }
}