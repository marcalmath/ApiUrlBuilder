using ApiUrlBuilder.Models;
using ApiUrlBuilder.Services;
using System.Diagnostics;
using System.Reflection;

namespace ApiUrlBuilder;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        cmbModelo.DataSource = Enum.GetValues(typeof(ModeloFiscal));
        
        cmbModelo.SelectedIndex = 0;
    }

    private void btnGerarUrl_Click(object sender, EventArgs e)
    {
        ApiProcesso processo;

        if (rdoConsultarNotas.Checked)
            processo = ApiProcesso.ConsultarNotas;
        else if (rdoConsultarPdf.Checked)
            processo = ApiProcesso.ConsultarPdf;
        else if (rdoConsultarXml.Checked)
            processo = ApiProcesso.ConsultarXml;
        else
        {
            MessageBox.Show("Selecione um processo para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var config = new ApiConfig
        {
            Ambiente = txtAmbiente.Text.Trim(),
            Porta = int.Parse(txtPorta.Text),
            Modelo = (int)cmbModelo.SelectedItem!,
            BatchId = string.IsNullOrWhiteSpace(txtBatchId.Text)
            ? null
            : int.Parse(txtBatchId.Text),
            Chave = txtChaveAcesso.Text.Trim(),// implementar validação depois
            Processo = processo
        };

        var service = new UrlBuilderService();

        string url = service.BuildUrl(processo, config);

        txtUrlGerada.Text = url;
    }

    private void btnCopiarUrl_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUrlGerada.Text))
        {
            MessageBox.Show("Não há URL para copiar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        Clipboard.SetText(txtUrlGerada.Text);
        MessageBox.Show("URL copiada com sucesso!");
    }
}
