using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_006
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            int i = int.Parse(variable1TextBox.Text);
            int z = int.Parse(variable2TextBox.Text);
            int result = i + z;
            resultLabel.Text = result.ToString();      
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            int i = int.Parse(variable1TextBox.Text);
            int z = int.Parse(variable2TextBox.Text);
            int result = i - z;
            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int i = int.Parse(variable1TextBox.Text);
            int z = int.Parse(variable2TextBox.Text);
            int result = i * z;
            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            Decimal i = Decimal.Parse(variable1TextBox.Text);
            Decimal z = Decimal.Parse(variable2TextBox.Text);
            Decimal result = i / z;
            resultLabel.Text = result.ToString();
        }
    }
}