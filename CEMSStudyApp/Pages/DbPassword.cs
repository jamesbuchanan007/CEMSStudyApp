using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class DbPassword : Form
    {
        public DbPassword()
        {
            InitializeComponent();
        }
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                var password = "spectrum";
                PasswordsLogin pw = new PasswordsLogin();

                if (textBoxPassword.Text != password)
                {
                    MessageBox.Show("Incorrect Password!!", "CEMS Study", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Hide();
                    //var pl = new PasswordsLogin();
                    //pl.Show();
                    return;
                }

                //USER WANTS TO EDIT DB AFTER ENTERING PASSWORD
                var openDb = MessageBox.Show("Edit Database?", "CEMS Study", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (openDb == DialogResult.Yes)
                {
                    Hide();
                    pw.Hide();
                    var export = new ExportDb();
                    export.Show();
                    export.TopMost = true;

                    return;
                }


                //USER WANTS TO EDIT DB AFTER ENTERING PASSWORD
                var openHyperlink = MessageBox.Show("Remove PDF Hyperlinks?", "CEMS Study", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (openHyperlink == DialogResult.Yes)
                {
                    Hide();
                    pw.Hide();
                    var rpl = new RemovePdfLinks();
                    rpl.Show();
                    rpl.TopMost = true;
                    return;
                }

                //ADD ACRONYMS
                var openAcronyms = MessageBox.Show("Add Acronyms?", "CEMS Study", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (openAcronyms == DialogResult.Yes)
                {
                    Hide();
                    pw.Hide();
                    var rpl = new AddAcronyms();
                    rpl.Show();
                    rpl.TopMost = true;
                    return;
                }


                //ADD DEFINITIONS
                var openDefinitions = MessageBox.Show("Add Definitions", "CEMS Study", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (openDefinitions == DialogResult.Yes)
                {
                    Hide();
                    pw.Hide();
                    var rpl = new AddDefinitions();
                    rpl.Show();
                    rpl.TopMost = true;
                    return;
                }


                //ADD UNITS OF MEASURE
                var openUoM = MessageBox.Show("Add Units of Measure?", "CEMS Study", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (openUoM == DialogResult.Yes)
                {
                    Hide();
                    pw.Hide();
                    var rpl = new AddUnitsofMeasure();
                    rpl.Show();
                    rpl.TopMost = true;
                    return;
                }

                //DEFAULTS BACK TO PASSWORD SCREEN
                Hide();
                PasswordsLogin passwordsLoginl = new PasswordsLogin();
                passwordsLoginl.Hide();
            }
        }
    }
}
