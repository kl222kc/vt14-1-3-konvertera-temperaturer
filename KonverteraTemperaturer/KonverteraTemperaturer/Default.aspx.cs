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

                //int result = TemperatureConverter.FahrenheitToCelsius(startTemp);

                List<int> result = new List<int>();

                TableRow row = new TableRow();   

                for (int i = startTemp; i < endTemp; i += stepTemp)
                {
                    result.Add(i);
                }

                result.Add(endTemp);

                for (int i = 0; i < result.Count; i++)
                {
                    int result2 = TemperatureConverter.CelsiusToFahrenheit(result[i]);

                    row = new TableRow();

                    TableCell cell1 = new TableCell();
                    TableCell cell2 = new TableCell();

                    cell1.Text = result[i].ToString();
                    cell2.Text = result2.ToString();

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);

                    ResultTable.Rows.Add(row);
                    
                }

                

            }

        }
    }
}