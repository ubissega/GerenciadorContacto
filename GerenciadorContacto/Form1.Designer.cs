namespace GerenciadorContacto
{
    partial class Form1
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
            panel1 = new Panel();
            panel3 = new Panel();
            listaContactos = new DataGridView();
            label3 = new Label();
            panel4 = new Panel();
            campoSearch = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            panel2 = new Panel();
            lblConfirmAdd = new Label();
            btnSalvar = new Button();
            campoCidade = new TextBox();
            campoProvincia = new TextBox();
            campoApelido = new TextBox();
            campoNome = new TextBox();
            campoNumero = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaContactos).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(listaContactos);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.Navy;
            panel3.Location = new Point(271, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 450);
            panel3.TabIndex = 1;
            // 
            // listaContactos
            // 
            listaContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaContactos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            listaContactos.BackgroundColor = Color.DarkBlue;
            listaContactos.BorderStyle = BorderStyle.Fixed3D;
            listaContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaContactos.Dock = DockStyle.Fill;
            listaContactos.GridColor = Color.Navy;
            listaContactos.Location = new Point(0, 57);
            listaContactos.Name = "listaContactos";
            listaContactos.RowHeadersWidth = 51;
            listaContactos.RowTemplate.Height = 29;
            listaContactos.Size = new Size(529, 368);
            listaContactos.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(0, 425);
            label3.Name = "label3";
            label3.Size = new Size(529, 25);
            label3.TabIndex = 4;
            label3.Text = "lblInaxistenciaDados";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(campoSearch);
            panel4.Controls.Add(btnSearch);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(529, 32);
            panel4.TabIndex = 1;
            // 
            // campoSearch
            // 
            campoSearch.Dock = DockStyle.Fill;
            campoSearch.Location = new Point(0, 0);
            campoSearch.Name = "campoSearch";
            campoSearch.PlaceholderText = "Procure qualquer";
            campoSearch.Size = new Size(435, 27);
            campoSearch.TabIndex = 2;
            campoSearch.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Right;
            btnSearch.ForeColor = Color.DarkBlue;
            btnSearch.Location = new Point(435, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Procurar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(529, 25);
            label2.TabIndex = 0;
            label2.Text = "Lista de contactos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblConfirmAdd);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(campoCidade);
            panel2.Controls.Add(campoProvincia);
            panel2.Controls.Add(campoApelido);
            panel2.Controls.Add(campoNome);
            panel2.Controls.Add(campoNumero);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 450);
            panel2.TabIndex = 0;
            // 
            // lblConfirmAdd
            // 
            lblConfirmAdd.Dock = DockStyle.Fill;
            lblConfirmAdd.Location = new Point(0, 184);
            lblConfirmAdd.Name = "lblConfirmAdd";
            lblConfirmAdd.Size = new Size(271, 266);
            lblConfirmAdd.TabIndex = 7;
            lblConfirmAdd.Text = "TextConfirmAdd";
            lblConfirmAdd.TextAlign = ContentAlignment.MiddleCenter;
            lblConfirmAdd.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Top;
            btnSalvar.ForeColor = Color.DarkBlue;
            btnSalvar.Location = new Point(0, 155);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(271, 29);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Guardar contacto";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // campoCidade
            // 
            campoCidade.Dock = DockStyle.Top;
            campoCidade.Location = new Point(0, 128);
            campoCidade.Name = "campoCidade";
            campoCidade.PlaceholderText = "Cidade";
            campoCidade.Size = new Size(271, 27);
            campoCidade.TabIndex = 5;
            campoCidade.TextAlign = HorizontalAlignment.Center;
            // 
            // campoProvincia
            // 
            campoProvincia.Dock = DockStyle.Top;
            campoProvincia.Location = new Point(0, 101);
            campoProvincia.Name = "campoProvincia";
            campoProvincia.PlaceholderText = "Provincia";
            campoProvincia.Size = new Size(271, 27);
            campoProvincia.TabIndex = 4;
            campoProvincia.TextAlign = HorizontalAlignment.Center;
            // 
            // campoApelido
            // 
            campoApelido.Dock = DockStyle.Top;
            campoApelido.Location = new Point(0, 74);
            campoApelido.Name = "campoApelido";
            campoApelido.PlaceholderText = "Apelido";
            campoApelido.Size = new Size(271, 27);
            campoApelido.TabIndex = 3;
            campoApelido.TextAlign = HorizontalAlignment.Center;
            // 
            // campoNome
            // 
            campoNome.Dock = DockStyle.Top;
            campoNome.Location = new Point(0, 47);
            campoNome.Name = "campoNome";
            campoNome.PlaceholderText = "Nome";
            campoNome.Size = new Size(271, 27);
            campoNome.TabIndex = 2;
            campoNome.TextAlign = HorizontalAlignment.Center;
            // 
            // campoNumero
            // 
            campoNumero.Dock = DockStyle.Top;
            campoNumero.Location = new Point(0, 20);
            campoNumero.Name = "campoNumero";
            campoNumero.PlaceholderText = "Numero";
            campoNumero.Size = new Size(271, 27);
            campoNumero.TabIndex = 1;
            campoNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 20);
            label1.TabIndex = 0;
            label1.Text = "Adicine contacto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Gerenciador de contacto Ubissega";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listaContactos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private TextBox campoProvincia;
        private TextBox campoApelido;
        private TextBox campoNome;
        private TextBox campoNumero;
        private Label label1;
        private Button btnSalvar;
        private TextBox campoCidade;
        private Label lblConfirmAdd;
        private Panel panel4;
        private TextBox campoSearch;
        private Button btnSearch;
        private DataGridView listaContactos;
        private Label label3;
    }
}