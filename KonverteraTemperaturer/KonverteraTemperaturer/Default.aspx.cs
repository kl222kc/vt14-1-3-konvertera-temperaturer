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

                var degrees = new Dictionary<int, int>();

                TableRow row = new TableRow();

                for (int i = startTemp; i <= endTemp; i += stepTemp)
                {
                    degrees.Add(i, ConvertCelRadio.Checked ? 
                        TemperatureConverter.CelsiusToFahrenheit(i) : 
                        TemperatureConverter.FahrenheitToCelsius(i));
                }

                if (ConvertFarRadio.Checked)
                {
                    First.Text = "°F";
                    Second.Text = "°C";
                }

                foreach (var temperature in degrees.Keys)
                {
                    row = new TableRow();
                    ResultTable.Rows.Add(row);

                    TableCell cell1 = new TableCell();
                    TableCell cell2 = new TableCell();
                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);

                    cell1.Text = temperature.ToString();
                    cell2.Text = degrees[temperature].ToString();
                }

                ResultTable.Visible = true;
            }
        }
    }
}