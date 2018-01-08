using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegExTester
{
    public partial class RegExTesterForm : Form
    {
        public RegExTesterForm()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            try
            {
                var r = new Regex(textBoxRegEx.Text);

                foreach (Match m in r.Matches(textBoxTestString.Text))
                {
                    listBoxResults.Items.Add(string.Format("{0,3} : {1}", m.Index, m.Value));
                }

                if (listBoxResults.Items.Count > 0)
                {
                    listBoxResults.SelectedItem = listBoxResults.Items[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
