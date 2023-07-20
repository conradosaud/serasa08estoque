namespace Aula08Estoque
{

    public partial class Form1 : Form
    {

        // Variáveis globais
        List<string> produtoNome = new List<string>(); 
        List<int> produtoQuantidade = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // Minhas funções
        void adicionaProduto()
        {
            string nome = txtNome.Text;
            int qnt = int.Parse( txtQuantidade.Text );
            produtoNome.Add( nome );
            produtoQuantidade.Add(qnt);
        }

        void atualizaInterface()
        {
            int quantidade_cadastrada = produtoNome.Count();
            lblCadastrados.Text = quantidade_cadastrada.ToString();
        }

        void limpaCampos()
        {
            txtNome.Text = "";
            txtQuantidade.Text = "";
            txtNome.Focus();
        }

        void verProduto( bool primeiro )
        {

            if ( listaEstaVazia() == true )
            {
                MessageBox.Show("Você não pode ver a lista ainda...");
                return;
            }

            string nome;
            int quantidade;

            if( primeiro == true )
            {
                nome = produtoNome[0];
                quantidade = produtoQuantidade[0];
            }
            else
            {
                nome = produtoNome[ produtoNome.Count() - 1 ];
                quantidade = produtoQuantidade[ produtoQuantidade.Count() - 1 ];
            }

            MessageBox.Show($"Nome: {nome}, Quantidade: {quantidade}");
        }

        void removeProduto()
        {
            if( listaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode remover");
            }
            else
            {
                produtoNome.RemoveAt(0);
                produtoQuantidade.RemoveAt(0);
            }            
        }

        bool listaEstaVazia()
        {
            if( produtoNome.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        string meuNome()
        {
            return "Conrado";
        }

        // -----------------------

        private void button1_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();
            limpaCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verProduto( true );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verProduto( false );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            removeProduto();
            atualizaInterface();
        }

        
    }
}