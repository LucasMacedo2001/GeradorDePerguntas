/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 30/11/2018
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace gerador_de_perguntas_v3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboPergunta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.RichTextBox richTextBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Armazenar;
		private System.Windows.Forms.Button Salvar;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnVisualizar;
		private System.Windows.Forms.ComboBox comboMateria;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboDificuldade;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnFinalizar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboPergunta = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.richTextBox5 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Armazenar = new System.Windows.Forms.Button();
			this.Salvar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnVisualizar = new System.Windows.Forms.Button();
			this.comboMateria = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboDificuldade = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnFinalizar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboPergunta
			// 
			this.comboPergunta.Enabled = false;
			this.comboPergunta.FormattingEnabled = true;
			this.comboPergunta.Location = new System.Drawing.Point(73, 89);
			this.comboPergunta.Name = "comboPergunta";
			this.comboPergunta.Size = new System.Drawing.Size(490, 21);
			this.comboPergunta.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pergunta:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(73, 160);
			this.richTextBox1.MaxLength = 250;
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(490, 75);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(73, 288);
			this.richTextBox2.MaxLength = 120;
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(490, 65);
			this.richTextBox2.TabIndex = 3;
			this.richTextBox2.Text = "";
			this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2TextChanged);
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(73, 399);
			this.richTextBox3.MaxLength = 120;
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(490, 65);
			this.richTextBox3.TabIndex = 4;
			this.richTextBox3.Text = "";
			this.richTextBox3.TextChanged += new System.EventHandler(this.RichTextBox3TextChanged);
			// 
			// richTextBox4
			// 
			this.richTextBox4.Location = new System.Drawing.Point(73, 478);
			this.richTextBox4.MaxLength = 120;
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(490, 65);
			this.richTextBox4.TabIndex = 5;
			this.richTextBox4.Text = "";
			this.richTextBox4.TextChanged += new System.EventHandler(this.RichTextBox4TextChanged);
			// 
			// richTextBox5
			// 
			this.richTextBox5.Location = new System.Drawing.Point(73, 556);
			this.richTextBox5.MaxLength = 120;
			this.richTextBox5.Name = "richTextBox5";
			this.richTextBox5.Size = new System.Drawing.Size(490, 65);
			this.richTextBox5.TabIndex = 6;
			this.richTextBox5.Text = "";
			this.richTextBox5.TextChanged += new System.EventHandler(this.RichTextBox5TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 288);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 34);
			this.label2.TabIndex = 7;
			this.label2.Text = "Resposta certa:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 399);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 34);
			this.label3.TabIndex = 8;
			this.label3.Text = "Respostas erradas:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Armazenar
			// 
			this.Armazenar.Location = new System.Drawing.Point(73, 12);
			this.Armazenar.Name = "Armazenar";
			this.Armazenar.Size = new System.Drawing.Size(65, 58);
			this.Armazenar.TabIndex = 9;
			this.Armazenar.Text = "Visualizar";
			this.Armazenar.UseVisualStyleBackColor = true;
			this.Armazenar.Click += new System.EventHandler(this.ArmazenarClick);
			// 
			// Salvar
			// 
			this.Salvar.Enabled = false;
			this.Salvar.Location = new System.Drawing.Point(155, 12);
			this.Salvar.Name = "Salvar";
			this.Salvar.Size = new System.Drawing.Size(65, 58);
			this.Salvar.TabIndex = 10;
			this.Salvar.Text = "Salvar";
			this.Salvar.UseVisualStyleBackColor = true;
			this.Salvar.Click += new System.EventHandler(this.SalvarClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(236, 12);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(63, 58);
			this.btnConsultar.TabIndex = 11;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// btnVisualizar
			// 
			this.btnVisualizar.Enabled = false;
			this.btnVisualizar.Location = new System.Drawing.Point(318, 12);
			this.btnVisualizar.Name = "btnVisualizar";
			this.btnVisualizar.Size = new System.Drawing.Size(65, 58);
			this.btnVisualizar.TabIndex = 12;
			this.btnVisualizar.Text = "Visualizar Pergunta";
			this.btnVisualizar.UseVisualStyleBackColor = true;
			this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizarClick);
			// 
			// comboMateria
			// 
			this.comboMateria.FormattingEnabled = true;
			this.comboMateria.Items.AddRange(new object[] {
			"LP",
			"IMC",
			"TPI",
			"AS",
			"GSO",
			"TLBD",
			"LTT e II"});
			this.comboMateria.Location = new System.Drawing.Point(73, 124);
			this.comboMateria.Name = "comboMateria";
			this.comboMateria.Size = new System.Drawing.Size(121, 21);
			this.comboMateria.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Materia:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboDificuldade
			// 
			this.comboDificuldade.Enabled = false;
			this.comboDificuldade.FormattingEnabled = true;
			this.comboDificuldade.Items.AddRange(new object[] {
			"1",
			"2",
			"3"});
			this.comboDificuldade.Location = new System.Drawing.Point(291, 123);
			this.comboDificuldade.Name = "comboDificuldade";
			this.comboDificuldade.Size = new System.Drawing.Size(48, 21);
			this.comboDificuldade.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(221, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Dificuldade:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Enabled = false;
			this.btnExcluir.Location = new System.Drawing.Point(401, 12);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(65, 58);
			this.btnExcluir.TabIndex = 17;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.Enabled = false;
			this.btnFinalizar.Location = new System.Drawing.Point(564, 12);
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(65, 58);
			this.btnFinalizar.TabIndex = 18;
			this.btnFinalizar.Text = "Cancelar";
			this.btnFinalizar.UseVisualStyleBackColor = true;
			this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizarClick);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(645, 12);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(65, 58);
			this.btnSair.TabIndex = 19;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btn
			// 
			this.btn.Enabled = false;
			this.btn.Location = new System.Drawing.Point(483, 12);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(65, 58);
			this.btn.TabIndex = 20;
			this.btn.Text = "Alterar";
			this.btn.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(75, 236);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 14);
			this.label6.TabIndex = 21;
			this.label6.Text = "Restam: 250";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(75, 354);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 14);
			this.label7.TabIndex = 22;
			this.label7.Text = "Restam: 120";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(73, 464);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 14);
			this.label8.TabIndex = 23;
			this.label8.Text = "Restam: 120";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(73, 543);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 14);
			this.label9.TabIndex = 24;
			this.label9.Text = "Restam: 120";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(75, 622);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 14);
			this.label10.TabIndex = 25;
			this.label10.Text = "Restam: 120";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1129, 639);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnFinalizar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboDificuldade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboMateria);
			this.Controls.Add(this.btnVisualizar);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.Salvar);
			this.Controls.Add(this.Armazenar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox5);
			this.Controls.Add(this.richTextBox4);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboPergunta);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Name = "MainForm";
			this.Text = "gerador-de-perguntas-v3";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
