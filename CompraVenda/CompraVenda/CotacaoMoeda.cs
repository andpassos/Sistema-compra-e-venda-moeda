using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraVenda
{
    public partial class CotacaoMoeda : Form
    {
        public CotacaoMoeda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCotar_Click(object sender, EventArgs e)
        {
            int codMoeda = 0;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Dólar Americano (venda)")
                codMoeda = 1;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Dólar Americano (compra)")
                codMoeda = 10813;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Euro (venda)")
                codMoeda = 21619;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Euro (compra)")
                codMoeda = 21620;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Iene (venda)")
                codMoeda = 21621;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Iene (compra)")
                codMoeda = 21622;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Dólar Canadense (venda)")
                codMoeda = 21635;

            if (cmbMoeda.Items[cmbMoeda.SelectedIndex].ToString() == "Dólar Canadense (compra)")
                codMoeda = 21636;

            Cotar(codMoeda);
        }

        private void Cotar(int codMoeda)
        {

            var service = new Moeda.FachadaWSSGSClient();
            var cotacao = service.getUltimoValorVO(codMoeda);
            string valor = (cotacao.ultimoValor.svalor).ToString();
            MessageBox.Show("R$ " + valor);
        }
        /*
        Dólar Americano (venda)
        Dólar Americano (compra)
        Euro (venda)
        Euro (compra)
        Iene (venda)
        Iene (compra)
        Dólar Canadense (venda)
        Dólar Canadense (compra)

        1		Dólar (venda)
        10813	Dólar (compra)
        21619	Euro (venda)
        21620	Euro (compra)
        21621	Iene (venda)
        21622	Iene (compra)
        21623	Libra esterlina (venda)
        21624	Libra esterlina (compra)
        21625	Franco Suíço (venda)
        21626	Franco Suíço (compra)
        21627	Coroa Dinamarquesa (venda)
        21628	Coroa Dinamarquesa (compra)
        21629	Coroa Norueguesa (venda)
        21630	Coroa Norueguesa (compra)
        21631	Coroa Sueca (venda)
        21632	Coroa Sueca (compra)
        21633	Dólar Australiano (venda)
        21634	Dólar Australiano (compra)
        21635	Dólar Canadense (venda)
        21636	Dólar Canadense (compra)

        https://www3.bcb.gov.br/sgspub/JSP/sgsgeral/FachadaWSSGS.wsdl*/

    }
}
