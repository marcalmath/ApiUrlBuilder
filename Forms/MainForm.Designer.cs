namespace ApiUrlBuilder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpAmbiente = new GroupBox();
            txtPorta = new TextBox();
            lblPorta = new Label();
            txtAmbiente = new TextBox();
            lblAmbiente = new Label();
            grpParametros = new GroupBox();
            txtChaveAcesso = new TextBox();
            lblChaveAcesso = new Label();
            txtBatchId = new TextBox();
            lblBatchId = new Label();
            cmbModelo = new ComboBox();
            lblModelo = new Label();
            grpProcesso = new GroupBox();
            rdoConsultarXml = new RadioButton();
            rdoConsultarPdf = new RadioButton();
            rdoConsultarNotas = new RadioButton();
            btnGerarUrl = new Button();
            btnCopiarUrl = new Button();
            grpResultado = new GroupBox();
            txtUrlGerada = new TextBox();
            grpAmbiente.SuspendLayout();
            grpParametros.SuspendLayout();
            grpProcesso.SuspendLayout();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // grpAmbiente
            // 
            grpAmbiente.Controls.Add(txtPorta);
            grpAmbiente.Controls.Add(lblPorta);
            grpAmbiente.Controls.Add(txtAmbiente);
            grpAmbiente.Controls.Add(lblAmbiente);
            grpAmbiente.Location = new Point(12, 12);
            grpAmbiente.Name = "grpAmbiente";
            grpAmbiente.Size = new Size(443, 72);
            grpAmbiente.TabIndex = 0;
            grpAmbiente.TabStop = false;
            grpAmbiente.Text = "Configuração do Ambiente";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(313, 23);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(80, 23);
            txtPorta.TabIndex = 1;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Location = new Point(269, 26);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new Size(38, 15);
            lblPorta.TabIndex = 1;
            lblPorta.Text = "Porta:";
            // 
            // txtAmbiente
            // 
            txtAmbiente.Location = new Point(75, 23);
            txtAmbiente.Name = "txtAmbiente";
            txtAmbiente.Size = new Size(150, 23);
            txtAmbiente.TabIndex = 0;
            // 
            // lblAmbiente
            // 
            lblAmbiente.AutoSize = true;
            lblAmbiente.Location = new Point(7, 26);
            lblAmbiente.Name = "lblAmbiente";
            lblAmbiente.Size = new Size(62, 15);
            lblAmbiente.TabIndex = 0;
            lblAmbiente.Text = "Ambiente:";
            // 
            // grpParametros
            // 
            grpParametros.Controls.Add(txtChaveAcesso);
            grpParametros.Controls.Add(lblChaveAcesso);
            grpParametros.Controls.Add(txtBatchId);
            grpParametros.Controls.Add(lblBatchId);
            grpParametros.Controls.Add(cmbModelo);
            grpParametros.Controls.Add(lblModelo);
            grpParametros.Location = new Point(12, 90);
            grpParametros.Name = "grpParametros";
            grpParametros.Size = new Size(443, 100);
            grpParametros.TabIndex = 1;
            grpParametros.TabStop = false;
            grpParametros.Text = "Parâmetros de Pesquisa";
            // 
            // txtChaveAcesso
            // 
            txtChaveAcesso.Location = new Point(123, 64);
            txtChaveAcesso.Name = "txtChaveAcesso";
            txtChaveAcesso.Size = new Size(310, 23);
            txtChaveAcesso.TabIndex = 5;
            // 
            // lblChaveAcesso
            // 
            lblChaveAcesso.AutoSize = true;
            lblChaveAcesso.Location = new Point(18, 67);
            lblChaveAcesso.Name = "lblChaveAcesso";
            lblChaveAcesso.Size = new Size(99, 15);
            lblChaveAcesso.TabIndex = 4;
            lblChaveAcesso.Text = "Chave de Acesso:";
            // 
            // txtBatchId
            // 
            txtBatchId.Location = new Point(313, 29);
            txtBatchId.Name = "txtBatchId";
            txtBatchId.Size = new Size(120, 23);
            txtBatchId.TabIndex = 3;
            // 
            // lblBatchId
            // 
            lblBatchId.AutoSize = true;
            lblBatchId.Location = new Point(274, 32);
            lblBatchId.Name = "lblBatchId";
            lblBatchId.Size = new Size(33, 15);
            lblBatchId.TabIndex = 2;
            lblBatchId.Text = "Lote:";
            // 
            // cmbModelo
            // 
            cmbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(75, 29);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(80, 23);
            cmbModelo.TabIndex = 1;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(18, 32);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 0;
            lblModelo.Text = "Modelo:";
            // 
            // grpProcesso
            // 
            grpProcesso.Controls.Add(rdoConsultarXml);
            grpProcesso.Controls.Add(rdoConsultarPdf);
            grpProcesso.Controls.Add(rdoConsultarNotas);
            grpProcesso.Location = new Point(12, 196);
            grpProcesso.Name = "grpProcesso";
            grpProcesso.Size = new Size(443, 53);
            grpProcesso.TabIndex = 2;
            grpProcesso.TabStop = false;
            grpProcesso.Text = "Defina o Processo";
            // 
            // rdoConsultarXml
            // 
            rdoConsultarXml.AutoSize = true;
            rdoConsultarXml.Location = new Point(313, 22);
            rdoConsultarXml.Name = "rdoConsultarXml";
            rdoConsultarXml.Size = new Size(103, 19);
            rdoConsultarXml.TabIndex = 2;
            rdoConsultarXml.TabStop = true;
            rdoConsultarXml.Text = "Consultar XML";
            rdoConsultarXml.UseVisualStyleBackColor = true;
            // 
            // rdoConsultarPdf
            // 
            rdoConsultarPdf.AutoSize = true;
            rdoConsultarPdf.Location = new Point(167, 22);
            rdoConsultarPdf.Name = "rdoConsultarPdf";
            rdoConsultarPdf.Size = new Size(100, 19);
            rdoConsultarPdf.TabIndex = 1;
            rdoConsultarPdf.TabStop = true;
            rdoConsultarPdf.Text = "Consultar PDF";
            rdoConsultarPdf.UseVisualStyleBackColor = true;
            // 
            // rdoConsultarNotas
            // 
            rdoConsultarNotas.AutoSize = true;
            rdoConsultarNotas.Location = new Point(6, 22);
            rdoConsultarNotas.Name = "rdoConsultarNotas";
            rdoConsultarNotas.Size = new Size(110, 19);
            rdoConsultarNotas.TabIndex = 0;
            rdoConsultarNotas.TabStop = true;
            rdoConsultarNotas.Text = "Consultar Notas";
            rdoConsultarNotas.UseVisualStyleBackColor = true;
            // 
            // btnGerarUrl
            // 
            btnGerarUrl.BackColor = Color.LightGreen;
            btnGerarUrl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarUrl.Location = new Point(164, 255);
            btnGerarUrl.Name = "btnGerarUrl";
            btnGerarUrl.Size = new Size(115, 34);
            btnGerarUrl.TabIndex = 3;
            btnGerarUrl.Text = "Gerar URL";
            btnGerarUrl.UseVisualStyleBackColor = false;
            btnGerarUrl.Click += btnGerarUrl_Click;
            // 
            // btnCopiarUrl
            // 
            btnCopiarUrl.BackColor = Color.LightSkyBlue;
            btnCopiarUrl.Location = new Point(12, 415);
            btnCopiarUrl.Name = "btnCopiarUrl";
            btnCopiarUrl.Size = new Size(75, 23);
            btnCopiarUrl.TabIndex = 4;
            btnCopiarUrl.Text = "Copiar URL";
            btnCopiarUrl.UseVisualStyleBackColor = false;
            btnCopiarUrl.Click += btnCopiarUrl_Click;
            // 
            // grpResultado
            // 
            grpResultado.Controls.Add(txtUrlGerada);
            grpResultado.Location = new Point(12, 346);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(443, 63);
            grpResultado.TabIndex = 5;
            grpResultado.TabStop = false;
            grpResultado.Text = "URL Gerada";
            // 
            // txtUrlGerada
            // 
            txtUrlGerada.Dock = DockStyle.Fill;
            txtUrlGerada.Location = new Point(3, 19);
            txtUrlGerada.Multiline = true;
            txtUrlGerada.Name = "txtUrlGerada";
            txtUrlGerada.ReadOnly = true;
            txtUrlGerada.ScrollBars = ScrollBars.Vertical;
            txtUrlGerada.Size = new Size(437, 41);
            txtUrlGerada.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(grpResultado);
            Controls.Add(btnCopiarUrl);
            Controls.Add(btnGerarUrl);
            Controls.Add(grpProcesso);
            Controls.Add(grpParametros);
            Controls.Add(grpAmbiente);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            grpAmbiente.ResumeLayout(false);
            grpAmbiente.PerformLayout();
            grpParametros.ResumeLayout(false);
            grpParametros.PerformLayout();
            grpProcesso.ResumeLayout(false);
            grpProcesso.PerformLayout();
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAmbiente;
        private TextBox txtAmbiente;
        private Label lblAmbiente;
        private TextBox txtPorta;
        private Label lblPorta;
        private GroupBox grpParametros;
        private ComboBox cmbModelo;
        private Label lblModelo;
        private Label lblBatchId;
        private TextBox txtBatchId;
        private TextBox txtChaveAcesso;
        private Label lblChaveAcesso;
        private GroupBox grpProcesso;
        private RadioButton rdoConsultarXml;
        private RadioButton rdoConsultarPdf;
        private RadioButton rdoConsultarNotas;
        private Button btnGerarUrl;
        private Button btnCopiarUrl;
        private GroupBox grpResultado;
        private TextBox txtUrlGerada;
    }
}
