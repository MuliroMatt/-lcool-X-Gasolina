namespace Projeto_Cálculo_Alcool_ou_Gasolina
{
    public partial class Form1 : Form
    {
        double valAlcool, valGasolina, valTotal;
        public Form1()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            txtAlcool.Clear();
            txtGasolina.Clear();
            lblOpcao.Text = "";
            txtAlcool.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //1. VERIFICAR SE OS CAMPOS ESTÃO PREENCHIDOS
            if (txtAlcool.Text == "" || txtGasolina.Text == "")
            {
                MessageBox.Show("Forneça os valores!","Álcool x Gasolina", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //2. RECEBER OS VALORES NAS VARIÁVEIS
                valAlcool=Convert.ToDouble(txtAlcool.Text);
                valGasolina=Convert.ToDouble(txtGasolina.Text);

                //3. EFETUAR O CÁLCULO
                valTotal = valAlcool / valGasolina;

                //4. VERIFICAR MELHOR OPÇÃO
                if(valTotal < 0.7)
                {
                    lblOpcao.Text = "ÁLCOOL";
                }
                else
                {
                    lblOpcao.Text = "GASOLINA";
                }
                
            }


        }
    }
}