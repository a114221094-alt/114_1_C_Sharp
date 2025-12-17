using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();

            // Call the configuration method to display all components on the form in Traditional Chinese, set font to 18pt,
            // and slightly adjust the size and vertical spacing of the components based on the text content to avoid overlap.
            // This method only changes the UI string, font, and size position, and does not change events or business logic.
            ConfigureControlsForTraditionalChinese();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay=0.0m;
            decimal hours=0.0m;
            decimal contribution = 0.0m;

            if (InputIsValid(ref hours, ref grossPay))
            {
                // Calculate contribution
                contribution = grossPay * CONTRIB_RATE;
                // Display results
                grossPayLabel.Text = grossPay.ToString("c");
                contributionLabel.Text = contribution.ToString("c");
                netPayLabel.Text = (grossPay - contribution).ToString("c");
            }
            else
            {
                // Display error message
                MessageBox.Show("Please enter valid numeric values for hours and pay rate.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // 修正：在 InputIsValid 方法中宣告 bonus 變數，並將其作為 ref 參數傳入
        private bool InputIsValid(ref decimal grosspay, ref decimal hours)
        {
            bool inputIsValid = false;
            decimal bonus = 0.0m; // 新增 bonus 變數
            if (decimal.TryParse(grossPayTextBox.Text, out grosspay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    inputIsValid = true;
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter numeric values for hours and pay rate.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter numeric values for hours and pay rate.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return inputIsValid;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        /// <summary>
        /// Add comments in Traditional Chinese and adjust all components:
        /// - Change the font of all visible components to 18pt (retain the original font style, e.g., bold).
        /// - Attempt to translate common English component texts to Traditional Chinese (based on simple correspondence by component type and name).
        /// - Automatically adjust the width and height of Labels / Buttons by measuring the text with TextRenderer, and add a small amount of padding.
        /// - Recursively process child controls layer by layer, slightly moving each control downwards to increase vertical spacing and reduce the chance of overlapping after text enlargement.
        /// 
        /// Design principles:
        /// - Do not change event bindings or control names (Name).
        /// - Do not destroy the original logic; only modify the appearance properties (Text / Font / Size / Location) during screen initialization.
        /// - The translation adopts a conservative strategy, only processing common strings or judging based on control names. It cannot cover all custom texts. For more accurate translations, please provide the corresponding source string list.
        /// </summary>
        private void ConfigureControlsForTraditionalChinese()
        {
            // Internal recursive method: process each control under the parent
            void RecurseControls(Control parent)
            {
                // Create a slight vertical offset using a local counter to make the spacing between adjacent controls more apparent
                int index = 0;
                foreach (Control c in parent.Controls)
                {
                    // Set the font to 18pt, retaining the original font family and style (e.g., Bold)
                    try
                    {
                        c.Font = new Font(c.Font.FontFamily, 18f, c.Font.Style);
                    }
                    catch
                    {
                        // If any font setting problem occurs, skip it to avoid interrupting the initialization process
                    }

                    // If the control has text, attempt conservative translation correspondence
                    if (!string.IsNullOrWhiteSpace(c.Text))
                    {
                        string original = c.Text.Trim();
                        string lowered = original.ToLowerInvariant();

                        // First, judge based on common control names (e.g., calculateButton, exitButton)
                        string name = c.Name ?? string.Empty;
                        string lowerName = name.ToLowerInvariant();

                        // Common translations for Buttons
                        if (c is Button)
                        {
                            if (lowerName.Contains("calculate") || lowered.Contains("calculate") || lowered.Contains("compute"))
                            {
                                c.Text = "計算";
                            }
                            else if (lowerName.Contains("exit") || lowered.Contains("exit") || lowered.Contains("close"))
                            {
                                c.Text = "離開";
                            }
                            else if (lowerName.Contains("clear") || lowered.Contains("clear"))
                            {
                                c.Text = "清除";
                            }
                            else if (lowered.Contains("print"))
                            {
                                c.Text = "列印";
                            }
                            else if (lowered == "ok" || lowered == "ok")
                            {
                                c.Text = "確定";
                            }
                            // If not matched by the above correspondences, retain the original text or further attempt common vocabulary replacement
                            else
                            {
                                // Common English word replacements (conservative)
                                if (lowered.Contains("calculate")) c.Text = "計算";
                                else if (lowered.Contains("submit")) c.Text = "送出";
                            }
                        }
                        // Common translation dictionary for Labels (conservative)
                        else if (c is Label)
                        {
                            if (lowered.Contains("hours") || lowered.Contains("hour")) c.Text = "工時";
                            else if (lowered.Contains("pay rate") || lowered.Contains("rate")) c.Text = "時薪";
                            else if (lowered.Contains("gross")) c.Text = "總薪資";
                            else if (lowered.Contains("net")) c.Text = "實領薪資";
                            else if (lowered.Contains("bonus")) c.Text = "獎金";
                            else if (lowered.Contains("name")) c.Text = "姓名";
                            else if (lowered.Contains("employee")) c.Text = "員工";
                            else if (lowered.Contains("result")) c.Text = "結果";
                            else if (lowered.Contains("salary")) c.Text = "薪資";
                            else if (lowered.Contains("pay")) c.Text = "薪資";
                            else if (lowered.Contains(":")) 
                            {
                                // For labels with a colon, retain the colon but attempt to translate the words on both sides
                                // For example, "Hours:" -> "工時："
                                string left = original.TrimEnd(':').Trim();
                                if (left.ToLowerInvariant().Contains("hours") || left.ToLowerInvariant().Contains("hour"))
                                    c.Text = "工時：";
                                else if (left.ToLowerInvariant().Contains("pay rate") || left.ToLowerInvariant().Contains("rate"))
                                    c.Text = "時薪：";
                            }
                        }
                        else
                        {
                            // For other controls (e.g., GroupBox, CheckBox), perform some common replacements
                            if (c is GroupBox)
                            {
                                if (lowered.Contains("employee")) c.Text = "員工資料";
                                else if (lowered.Contains("results")) c.Text = "計算結果";
                            }
                            else if (c is CheckBox)
                            {
                                if (lowered.Contains("overtime")) c.Text = "加班";
                                else if (lowered.Contains("tax")) c.Text = "扣稅";
                            }
                        }
                    }

                    // Automatically adjust the size of Button / Label based on text length, adding a small amount of padding
                    if (c is Button || c is Label)
                    {
                        try
                        {
                            Size measured = TextRenderer.MeasureText(c.Text, c.Font);
                            int paddingWidth = 20;  // Left and right space
                            int paddingHeight = 12; // Vertical space
                            c.Size = new Size(Math.Max(c.Width, measured.Width + paddingWidth),
                                              Math.Max(c.Height, measured.Height + paddingHeight));
                        }
                        catch
                        {
                            // Ignore measurement errors
                        }
                    }

                    // Fine-tune position: slightly move downwards to avoid text overlapping after enlargement
                    // The offset increases gradually based on the index, ensuring more spacing between adjacent controls
                    try
                    {
                        int extraOffset = 6 + (index / 2); // Increase offset slightly for every two controls
                        c.Location = new Point(c.Location.X, c.Location.Y + extraOffset);
                    }
                    catch
                    {
                        // Ignore position errors
                    }

                    // If the control has child controls, process them recursively
                    if (c.HasChildren)
                    {
                        RecurseControls(c);
                    }

                    index++;
                }
            }

            // Start recursive processing from the form itself
            try
            {
                RecurseControls(this);
            }
            catch
            {
                // If any error occurs, do not throw, to avoid affecting the form startup process
            }
        }
    }
}
