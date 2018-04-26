using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostalCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        int x, y, z;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string height = heightTextBox.Text;
            x = int.Parse(height);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string length = lengthTextBox.Text;
            y = int.Parse(length);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string width = widthTextBox.Text;
            z = int.Parse(width);
        }

        protected void rB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string length = lengthTextBox.Text;
            y = int.Parse(length);
            string width = widthTextBox.Text;
            z = int.Parse(width);
            if (heightTextBox.Text.Length > 0)
            {
                string height = heightTextBox.Text;
                x = int.Parse(height);
                returnLabel.Text = ((x * y * z) * Convert.ToDecimal(rB.SelectedValue)).ToString();
            }
            else
            {
                returnLabel.Text = ((y * z) * Convert.ToDecimal(rB.SelectedValue)).ToString();
            }
        }

    }
}