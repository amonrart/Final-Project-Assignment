using System.Text;

namespace Final_Project_Assignment
{
    public partial class Form1 : Form
    {
        GPAEN GPAen = new GPAEN();
        GPACA GPAca = new GPACA();
        GPAOB GPAob = new GPAOB();
        GPADA GPAda = new GPADA();
        GPASC GPAsc = new GPASC();
        GPAUS GPAus = new GPAUS();
        GPAPR GPApr = new GPAPR();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTAD_Click(object sender, EventArgs e)
        {
            string name = this.TBName.Text;
            string GPAEN = this.TBEN.Text;
            string GPACA = this.TBCA.Text;
            string GPAOB = this.TBOB.Text;
            string GPADA = this.TBDA.Text;
            string GPASC = this.TBSC.Text;
            string GPAUS = this.TBUS.Text;
            string GPAPR = this.TBPR.Text;
            int n = dataGridView1.Rows.Add(); 
            dataGridView1.Rows[n].Cells[0].Value = TBName.Text;
            dataGridView1.Rows[n].Cells[1].Value = TBEN.Text;
            dataGridView1.Rows[n].Cells[2].Value = TBCA.Text;
            dataGridView1.Rows[n].Cells[3].Value = TBOB.Text;
            dataGridView1.Rows[n].Cells[4].Value = TBDA.Text;
            dataGridView1.Rows[n].Cells[5].Value = TBSC.Text;
            dataGridView1.Rows[n].Cells[6].Value = TBUS.Text;
            dataGridView1.Rows[n].Cells[7].Value = TBPR.Text;
            double dGPAca = Convert.ToDouble(GPACA);
            GPAca.addGPA(dGPAca, name);

            double maxGPAca = GPAca.getMax();
            labelGPACA.Text = maxGPAca.ToString();
            labelNameCal.Text = GPAca.getMaxName().ToString();
            
            double dGPAda = Convert.ToDouble(GPADA);
            GPAda.addGPA(dGPAda, name);

            double maxGPAda = GPAda.getMax();
            labelGPADA.Text = maxGPAda.ToString();
            labelNameData.Text = GPAda.getMaxName().ToString();

            double dGPAen = Convert.ToDouble(GPAEN);
            GPAen.addGPA(dGPAen, name);

            double maxGPAen = GPAen.getMax();
            labelGPAEN.Text = maxGPAen.ToString();
            labelNameEnglish.Text = GPAen.getMaxName().ToString();

            double dGPAob = Convert.ToDouble(GPAOB);
            GPAob.addGPA(dGPAob, name);

            double maxGPAob = GPAob.getMax();
            labelGPAOB.Text = maxGPAob.ToString();
            labelNameOOP.Text = GPAob.getMaxName().ToString();

            double dGPApr = Convert.ToDouble(GPAPR);
            GPApr.addGPA(dGPApr, name);

            double maxGPApr = GPApr.getMax();
            labelGPAPR.Text = maxGPApr.ToString();
            labelNameStatistic.Text = GPApr.getMaxName().ToString();

            double dGPAsc = Convert.ToDouble(GPASC);
            GPAsc.addGPA(dGPAsc, name);

            double maxGPAsc = GPAsc.getMax();
            labelGPASC.Text = maxGPAsc.ToString();
            labelNameScience.Text = GPAsc.getMaxName().ToString();

            double dGPAus = Convert.ToDouble(GPAUS);
            GPAus.addGPA(dGPAus, name);

            double maxGPAus = GPAus.getMax();
            labelGPAUS.Text = maxGPAus.ToString();
            labelNameUser.Text = GPAus.getMaxName().ToString();
            TBName.Text = "";
            TBEN.Text = "";
            TBCA.Text = "";
            TBDA.Text = "";
            TBOB.Text = "";
            TBPR.Text = "";
            TBSC.Text = "";
            TBUS.Text = "";

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            TBName.Text = row.Cells[0].Value.ToString();
            TBEN.Text = row.Cells[1].Value.ToString();
            TBCA.Text = row.Cells[2].Value.ToString();
            TBOB.Text = row.Cells[3].Value.ToString();
            TBDA.Text = row.Cells[4].Value.ToString();
            TBSC.Text = row.Cells[5].Value.ToString();
            TBUS.Text = row.Cells[6].Value.ToString();
            TBPR.Text = row.Cells[7].Value.ToString();
        }

        

        private void BTRE_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            for(int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            labelNameCal.Text = GPAca.reName().ToString(); 
            labelGPACA.Text = GPAca.reMax().ToString();
            labelNameEnglish.Text = GPAen.reName().ToString(); 
            labelGPAEN.Text = GPAen.reMax().ToString();
            labelNameOOP.Text = GPAob.reName().ToString(); 
            labelGPAOB.Text = GPAob.reMax().ToString();
            labelNameData.Text = GPAda.reName().ToString(); 
            labelGPADA.Text = GPAda.reMax().ToString();
            labelNameScience.Text = GPAsc.reName().ToString(); 
            labelGPASC.Text = GPAsc.reMax().ToString();
            labelNameUser.Text = GPAus.reName().ToString();
            labelGPAUS.Text = GPAus.reMax().ToString();
            labelNameStatistic.Text = GPApr.reName().ToString();
            labelGPAPR.Text = GPApr.reMax().ToString();

        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CAV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8); 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}