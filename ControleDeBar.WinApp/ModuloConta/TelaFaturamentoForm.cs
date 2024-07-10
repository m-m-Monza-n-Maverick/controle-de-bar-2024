using ControleDeBar.Dominio.ModuloConta;

namespace ControleDeBar.WinApp.ModuloConta
{
    public partial class TelaFaturamentoForm : Form
    {
        private readonly IRepositorioConta repositorioConta;

        public TelaFaturamentoForm(IRepositorioConta repositorioConta)
        {
            InitializeComponent();
            this.repositorioConta = repositorioConta;
        }
        
        public void btnCalcular_Click(object sender, EventArgs e)
        {   
            decimal faturamento = 0;
            List<Conta> contas = repositorioConta.SelecionarTodos();
            DateTime startDate, endDate;

            if (rdbFaturamentoSempre.Checked)
                faturamento = contas.Sum(c => c.ValorTotal);

            else if (rdbFaturamentoDia.Checked)
                faturamento = contas.Where(c => c.Data.Date == DateTime.Today).Sum(c => c.ValorTotal);

            else if (rdbFaturamentoSemana.Checked)
            {
                startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                endDate = startDate.AddDays(6);
                faturamento = contas.Where(c => c.Data.Date >= startDate && c.Data.Date <= endDate).Sum(c => c.ValorTotal);
            }

            else if (rdbFaturamentoMes.Checked)
            {
                startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                endDate = startDate.AddMonths(1).AddDays(-1);
                faturamento = contas.Where(c => c.Data.Date >= startDate && c.Data.Date <= endDate).Sum(c => c.ValorTotal);
            }

            else if (rdbFaturamentoPeriodo.Checked)
            {
                startDate = txtInicioPeriodo.Value;
                endDate = txtTerminoPeriodo.Value;
                faturamento = contas.Where(c => c.Data.Date >= startDate && c.Data.Date <= endDate).Sum(c => c.ValorTotal);
            }

            faturamentoCalculado.Text = faturamento.ToString("f2");
        }
    
        private void rdbFaturamentoPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFaturamentoPeriodo.Checked)
            {
                txtInicioPeriodo.Enabled = true;
                txtTerminoPeriodo.Enabled = true;
            }
            else
            {
                txtInicioPeriodo.Enabled = false;
                txtTerminoPeriodo.Enabled = false;
            }
        }
    }
}
