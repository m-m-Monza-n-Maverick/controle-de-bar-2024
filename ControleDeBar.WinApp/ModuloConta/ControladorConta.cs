﻿using ControladeDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloPedido;
using ControleDeBar.WinApp.Compartilhado;
namespace ControleDeBar.WinApp.ModuloConta
{
    public class ControladorConta(IRepositorioConta repositorioConta, IRepositorioPedido repositorioPedido, ControleDeBarDbContext dbContext) : ControladorBase
    {
        TabelaContaControl tabelaConta;

        #region ToolTips
        public override string TipoCadastro { get => "Conta"; }
        public override string ToolTipAdicionar { get => "Cadastrar uma nova conta"; }
        public override string ToolTipEditar { get => "Editar uma conta existente"; }
        public override string ToolTipExcluir { get => "Excluir uma conta existente"; }
        #endregion

        #region CRUD
        public override void Adicionar()
        {
            TelaContaForm telaProduto = new(dbContext);
            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Conta novoRegistro = telaProduto.Conta;

            foreach (Pedido p in novoRegistro.Pedidos)
                repositorioPedido.Cadastrar(p);

            RealizarAcao(
                () => repositorioConta.Cadastrar(novoRegistro),
                novoRegistro, "cadastrado");
        }
        public override void Editar()
        {
            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            List<Conta> disciplinasCadastradas = repositorioConta.SelecionarTodos();

            TelaContaForm telaConta = new(dbContext)
            {
                Conta = registroSelecionado
            };

            DialogResult resultado = telaConta.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Conta registroEditado = telaConta.Conta;

            RealizarAcao(
                () => repositorioConta.Editar(registroSelecionado.Id, registroEditado),
                registroEditado, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteExcluir(registroSelecionado)) return;

            RealizarAcao(
                () => repositorioConta.Excluir(registroSelecionado.Id),
                registroSelecionado, "excluído");
        }
        #endregion

        public override UserControl ObterListagem()
        {
            tabelaConta ??= new TabelaContaControl();

            CarregarRegistros();

            return tabelaConta;
        }
        public override void CarregarRegistros()
            => tabelaConta.AtualizarRegistros(repositorioConta.SelecionarTodos());
    }
}
