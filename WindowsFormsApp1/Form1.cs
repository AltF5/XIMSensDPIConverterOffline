using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txt1CurrDPI.Text.Length > 0)
            {
                txt1CurrDPI.Select(txt1CurrDPI.Text.Length, 0);
            }
        }

        private void btnFindSenseForNewDPI_Click(object sender, EventArgs e)
        {

            // https://community.xim.tech/index.php?topic=37388.msg473450#msg473450
            //
            // FEEL = DPI * XIM Sensitivity
            //    12000 (Current DPI to keep) * 16.90 (Current Sense)   =   3000 (desired new DPI) * x [New Sensivity to find at this lower DPI]
            //    x = (12000 * 16.90) / 3000  =  4 * 16.90 = 67.60

            int currentDPI = (int)decimal.Parse(txt1CurrDPI.Text.Replace(",", ""));                  // Ex: 12,000
            decimal currentSens = decimal.Parse(txt1CurrSens.Text.Replace(",", ""));        // Ex: 16.90
            int newDesiredDPI = (int)decimal.Parse(txt1NewDPI.Text.Replace(",", ""));                // Ex: 3,000
            decimal newSenseFound_ForNewDPI = (currentDPI * currentSens) / newDesiredDPI;

            newSenseFound_ForNewDPI = Math.Round(newSenseFound_ForNewDPI, 2);
            txt1RESULT_SenseFound.Text = newSenseFound_ForNewDPI.ToString();

            

            // Info label
            decimal dpiRatio = 0;
            bool directionIncreaseSense = currentDPI > newDesiredDPI;       // Ex: If 12,000 > 3000 then the direction will be to increase the sensitivity by 4x
            string textIncreaseOrDecrease_ing = directionIncreaseSense ? "INCREASING" : "DECREASING";
            string textIncreaseOrDecrease = directionIncreaseSense ? "increase" : "decrease";

            if (currentDPI > newDesiredDPI)
            {
                dpiRatio = currentDPI / newDesiredDPI;
            }
            else
            {
                dpiRatio = newDesiredDPI / currentDPI;
            }

            lbl1ResultInfo.Text = string.Format(
                "You are {0} your DPI by a factor of: {1}.\nEffectively, what is required is apply this {1}x factor to your Sensitivity: {2} {3} {1} = {4}",
                textIncreaseOrDecrease_ing, dpiRatio, currentSens, (directionIncreaseSense ? "x" : "/"), newSenseFound_ForNewDPI);
        }

        private void btnFindEquivalentSense_KeepingYourDPI_Click(object sender, EventArgs e)
        {
            //
            // Given another user's DPI : Sense ratio, obtain that same feel-ratio for my desired DPI
            //



            // I believe this is correct.
            //
            // Take the DPI ratio between your DPI : their DPI
            //      Ex: 12,000 : 800   ==>  12,000 / 800 = 15        Ratio = 15x DECREASE to their sensitivity (since your DPI is higher. If your DPI was smaller, then it would INCREASE their sensitivty by a factor of 15x)
            // 
            // Take that ratio and apply (increase or decrease) it to their sensitivity
            //      Ex: 100  / 15 (since your DPI is higher =  6.6666666666666666666666666666667



            int youCurrentDPI = (int)decimal.Parse(txt2CurrDPI.Text.Replace(",", ""));       // Ex: 12,000 to keep
            int theirDPI = (int)decimal.Parse(txt2TheirDPI.Text.Replace(",", ""));           // Ex: 800
            decimal theirSense = decimal.Parse(txt2TheirSens.Text.Replace(",", ""));         // Ex: 100


            // Opposite as above. If your DPI is higher than theirs, then your sensitivity will be LOWER than theres
            decimal feelRatio = 0;           // The feel factor (ex: 15 in the abvoe example)
            bool directionIncreaseSense = youCurrentDPI < theirDPI;
            string textIncreaseOrDecrease = directionIncreaseSense ? "INCREASE" : "DECREASE";


            if (youCurrentDPI > theirDPI)                   // Always divide the highest
            {
                feelRatio = youCurrentDPI / theirDPI;
            }
            else
            {
                feelRatio = theirDPI / youCurrentDPI;
            }


            decimal resultingSenseForYouWithYourDPI = 0;
            if(directionIncreaseSense)
            {
                resultingSenseForYouWithYourDPI = Math.Round(theirSense * feelRatio, 2);           // INCREASE your sensitivity by this ratio, since your DPI is lower than theirs  (and you are maintaining your current DPI)
            }
            else
            {
                resultingSenseForYouWithYourDPI = Math.Round(theirSense / feelRatio, 2);           // DECREASE your sensitivity by this ratio, since your DPI is higher than theirs (and you are maintaining your current DPI)
            }

            txt2RESULT_YourSenseForTheirEquivalent.Text = resultingSenseForYouWithYourDPI.ToString();


            // Info label:
            lbl2ResultInfo.Text = string.Format(
                "For their sensitivity {0}, you must {1} their sensitivity given your\ncurrent DPI value ({2}) by their DPI:Sense \"feel-factor\" of: {3}x    = {4}",
                theirSense, textIncreaseOrDecrease, youCurrentDPI, feelRatio, resultingSenseForYouWithYourDPI);

        }


        #region Misc

        private void lbl1Example_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://community.xim.tech/index.php?topic=37388.msg473244#msg473244");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://community.xim.tech/index.php?topic=97697.msg859410#msg859410");
        }

        private void whoAmIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://community.xim.tech/index.php?action=profile;u=1501");
        }
        #endregion

        #region DPI textbox comma-formatting

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/15473216/how-to-format-a-windows-forms-textbox-with-thousand-separator-and-decimal-separt
            try
            {
                (sender as TextBox).Text = string.Format("{0:#,##0}", (int)decimal.Parse((sender as TextBox).Text.Replace(",", "")));
            }
            catch (Exception ex)
            {

            }
        }

        private void txt1NewDPI_Leave(object sender, EventArgs e)
        {
            try
            {
                (sender as TextBox).Text = string.Format("{0:#,##0}", (int)decimal.Parse((sender as TextBox).Text.Replace(",", "")));
            }
            catch (Exception ex)
            {

            }
        }

        private void txt2CurrDPI_Leave(object sender, EventArgs e)
        {
            try
            {
                (sender as TextBox).Text = string.Format("{0:#,##0}", (int)decimal.Parse((sender as TextBox).Text.Replace(",", "")));
            }
            catch (Exception ex)
            {

            }
        }

        private void txt2TheirDPI_Leave(object sender, EventArgs e)
        {
            try
            {
                (sender as TextBox).Text = string.Format("{0:#,##0}", (int)decimal.Parse((sender as TextBox).Text.Replace(",", "")));
            }
            catch (Exception ex)
            {

            }
        }

        #endregion


    }
}
