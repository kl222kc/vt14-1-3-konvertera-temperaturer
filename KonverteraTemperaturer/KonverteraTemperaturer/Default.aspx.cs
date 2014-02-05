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
            int startTemp = int.Parse(StartTempTextBox.Text);
            int endTemp = int.Parse(EndTempTextBox.Text);
            int stepTemp = int.Parse(IncreaseTempTextBox.Text);

            int result = TemperatureConverter.FahrenheitToCelsius(startTemp);

            Result.Text = result.ToString();

        }
    }
}