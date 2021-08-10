/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 30/11/2018
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gerador_de_perguntas_v3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		RichTextBox rtbVisualizar = new RichTextBox();
		RichTextBox rtbGuardar = new RichTextBox();
		
		Panel painel = new Panel();
		
		Label lab1 = new Label();
		Label lab2 = new Label();
		Label lab3 = new Label();
		Label lab4 = new Label();
		Label lab5 = new Label();
		Label lab6 = new Label();
		Label lab7 = new Label();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rtbVisualizar.Parent = this;
			rtbVisualizar.Left = 73;
			rtbVisualizar.Top =	160;
			rtbVisualizar.Width = 490;
			rtbVisualizar.Height = 446;
			rtbVisualizar.Visible = false;
			rtbVisualizar.Enabled = true;
			rtbVisualizar.MaxLength = 2147483647;
			rtbVisualizar.ReadOnly = true;
			//rtbVisualizar.Enabled = false;
			
			rtbGuardar.MaxLength = 2147483647;
			
			painel.Parent = this;
			painel.Width = 490;
			painel.Height = 400;
			painel.Top = 160;
			painel.Left = 600;
			painel.BackColor = Color.LightGray;
			painel.Visible = false;
			
			lab1.Parent = painel;
			lab1.Width = 235;
			lab1.Height = 230;
			lab1.Top = 130;
			lab1.Left = 10;
			lab1.Text = "label1";
			lab1.ForeColor = Color.Blue;
			lab1.BackColor = Color.White;
			lab1.BorderStyle = BorderStyle.FixedSingle;
			lab1.TextAlign = ContentAlignment.MiddleLeft;
			
			lab2.Parent = painel;
			lab2.Width = 225;
			lab2.Height = 90;
			lab2.Top = 20;
			lab2.Left = 260;
			lab2.BorderStyle = BorderStyle.FixedSingle;
			lab2.Text = "label2";
			lab2.TextAlign = ContentAlignment.MiddleLeft;
			
			lab3.Parent = painel;
			lab3.Width = 225;
			lab3.Height = 90;
			lab3.Top = 110;
			lab3.Left = 260;
			lab3.BorderStyle = BorderStyle.FixedSingle;
			lab3.Text = "label3";
			lab3.TextAlign = ContentAlignment.MiddleLeft;
		
			lab4.Parent = painel;
			lab4.Width = 225;
			lab4.Height = 90;
			lab4.Top = 200;
			lab4.Left = 260;
			lab4.BorderStyle = BorderStyle.FixedSingle;
			lab4.Text = "label4";
			lab4.TextAlign = ContentAlignment.MiddleLeft;
			
			lab5.Parent = painel;
			lab5.Width = 225;
			lab5.Height = 90;
			lab5.Top = 290;
			lab5.Left = 260;
			lab5.BorderStyle = BorderStyle.FixedSingle;
			lab5.Text = "label5";
			lab5.TextAlign = ContentAlignment.MiddleLeft;
			
			lab6.Parent = painel;
			lab6.Width = 215;
			lab6.Height = 45;
			lab6.Top = 80;
			lab6.Left = 20;
			lab6.Text = "label6";
			lab6.ForeColor = Color.Coral;
			lab6.BorderStyle = BorderStyle.FixedSingle;
			lab6.TextAlign = ContentAlignment.MiddleCenter;
			
			lab7.Parent = painel;
			lab7.Width = 90;
			lab7.Height = 20;
			lab7.Top = 5;
			lab7.Left = 165;
			lab7.Text = "label7";
			lab7.ForeColor = Color.Green;
			lab7.BorderStyle = BorderStyle.FixedSingle;
			lab7.TextAlign = ContentAlignment.MiddleCenter;
		}
		
		public void esconderRich() {
			richTextBox1.Visible = false;
			richTextBox2.Visible = false;
			richTextBox3.Visible = false;
			richTextBox4.Visible = false;
			richTextBox5.Visible = false;
			
			//comboDificuldade.Enabled = false;
			comboMateria.Enabled = false;
			
			rtbVisualizar.Visible = true;
			
			label6.Visible = false;
			label7.Visible = false;
			label8.Visible = false;
			label9.Visible = false;
			label10.Visible = false;
		}
		
		public void aparecerRich() {
			richTextBox1.Visible = true;
			richTextBox2.Visible = true;
			richTextBox3.Visible = true;
			richTextBox4.Visible = true;
			richTextBox5.Visible = true;
			
			//comboDificuldade.Enabled = true;
			comboMateria.Enabled = true;
			comboPergunta.Enabled = false;
			
			rtbVisualizar.Visible = false;
			
			richTextBox1.Clear();
			richTextBox2.Clear();
			richTextBox3.Clear();
			richTextBox4.Clear();
			richTextBox5.Clear();

			//comboDificuldade.Text = "";
			comboMateria.Text = "";
			comboPergunta.Text = "";
			
			comboPergunta.Items.Clear();
			
			Armazenar.Enabled = true;
			Salvar.Enabled = false;
			btnConsultar.Enabled = true;
			btnFinalizar.Enabled = false;
			btnVisualizar.Enabled = false;
			
			rtbGuardar.Clear();
			rtbVisualizar.Clear();	
			
			label6.Visible = true;
			label7.Visible = true;
			label8.Visible = true;
			label9.Visible = true;
			label10.Visible = true;
			
		}
		public void aparecerPainel() {
			lab1.Text = richTextBox1.Text;
			lab2.Text = richTextBox2.Text;
			lab3.Text = richTextBox3.Text;
			lab4.Text = richTextBox4.Text;
			lab5.Text = richTextBox5.Text;
			
			lab6.Text = comboMateria.Text;
			
			painel.Visible = true;
		}
		
		public void esconderPainel() {
			lab1.Text = "label1";
			lab2.Text = "label2";
			lab3.Text = "label3";
			lab4.Text = "label4";
			lab5.Text = "label5";
			
			lab6.Text = "label6";
			
			painel.Visible = false;
		}
		
		void ArmazenarClick(object sender, EventArgs e)
		{
			if (comboMateria.Text == "" || richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox3.Text == "" || richTextBox4.Text == "" || richTextBox5.Text == "") {
				MessageBox.Show("Para armazenar todos os campos devem ser preenchidos!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else {
				rtbVisualizar.AppendText("\n\n@\n\n" + richTextBox1.Text + "%\n" + richTextBox2.Text + "%\n" + richTextBox3.Text + "%\n" + richTextBox4.Text + "%\n" + richTextBox5.Text + "%\n");
				
				if (comboMateria.Text == "LP")
					rtbGuardar.LoadFile("BD_quiz/quiz1.txt");
				
				else if (comboMateria.Text == "IMC")
					rtbGuardar.LoadFile("BD_quiz/quiz2.txt");
				
				else if (comboMateria.Text == "TPI")
					rtbGuardar.LoadFile("BD_quiz/quiz3.txt");
				
				else if (comboMateria.Text == "AS")
					rtbGuardar.LoadFile("BD_quiz/quiz4.txt");
				
				else if (comboMateria.Text == "GSO")
					rtbGuardar.LoadFile("BD_quiz/quiz5.txt");
				
				else if (comboMateria.Text == "TLBD")
					rtbGuardar.LoadFile("BD_quiz/quiz6.txt");
				
				else if (comboMateria.Text == "LTT e II")
					rtbGuardar.LoadFile("BD_quiz/quiz7.txt");
				
				rtbVisualizar.Text = rtbGuardar.Text + rtbVisualizar.Text;
				
				Armazenar.Enabled = false;
				Salvar.Enabled = true;
				btnConsultar.Enabled = false;
				
				esconderRich();
				aparecerPainel();
				
				btnFinalizar.Enabled = true;
				//richTextBox1.Text = rtbGuardar.Text
			}
		}
		void SalvarClick(object sender, EventArgs e)
		{
			if (comboMateria.Text == "LP")
				rtbVisualizar.SaveFile("BD_quiz/quiz1.txt");
			
			else if (comboMateria.Text == "IMC")
				rtbVisualizar.SaveFile("BD_quiz/quiz2.txt");
			
			else if (comboMateria.Text == "TPI")
				rtbVisualizar.SaveFile("BD_quiz/quiz3.txt");
			
			else if (comboMateria.Text == "AS")
				rtbVisualizar.SaveFile("BD_quiz/quiz4.txt");
			
			
			else if (comboMateria.Text == "GSO")
				rtbVisualizar.SaveFile("BD_quiz/quiz5.txt");
			
			else if (comboMateria.Text == "TLBD")
				rtbVisualizar.SaveFile("BD_quiz/quiz6.txt");
			
			else if (comboMateria.Text == "LTT e II")
				rtbVisualizar.SaveFile("BD_quiz/quiz7.txt");
			
			MessageBox.Show("Operação realizada com sucesso!","Operação realização",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			aparecerRich();
			esconderPainel();
		}
		
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			if (comboMateria.Text == "")
				MessageBox.Show("Para consulta o campo matéria deve ser preenchido!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
			
			else {
				if (comboMateria.Text == "LP")
					rtbVisualizar.LoadFile("BD_quiz/quiz1.txt");
				
				else if (comboMateria.Text == "IMC")
					rtbVisualizar.LoadFile("BD_quiz/quiz2.txt");
				
				else if (comboMateria.Text == "TPI")
					rtbVisualizar.LoadFile("BD_quiz/quiz3.txt");
				
				else if (comboMateria.Text == "AS")
					rtbVisualizar.LoadFile("BD_quiz/quiz4.txt");
				
				else if (comboMateria.Text == "GSO")
					rtbVisualizar.LoadFile("BD_quiz/quiz5.txt");
				
				else if (comboMateria.Text == "TLBD")
					rtbVisualizar.LoadFile("BD_quiz/quiz6.txt");
				
				else if (comboMateria.Text == "LTT e II")
					rtbVisualizar.LoadFile("BD_quiz/quiz7.txt");
				
				string [] pergunta = rtbVisualizar.Text.Split('@');
				
				int q = pergunta.Length;
				
				for(int p = 1; p<q; p++) {
					pergunta[p] = pergunta[p].Trim();
					comboPergunta.Items.Add(pergunta[p]);
				}
				
				
				esconderRich();
				
				btnConsultar.Enabled = false;
				
				comboPergunta.Enabled = true;
				
				Armazenar.Enabled = false;
				
				btnVisualizar.Enabled = true;
				
				btnFinalizar.Enabled = true;
			}
		}
		
		string [] frase = new string [5];
		void BtnVisualizarClick(object sender, EventArgs e)
		{
			if(comboPergunta.Text == "") 
				MessageBox.Show("Para visualizar o campo pergunta deve ser preenchidos!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
			
			else {
				
				if (comboMateria.Text == "LP")
					rtbVisualizar.LoadFile("BD_quiz/quiz1.txt");
				
				else if (comboMateria.Text == "IMC")
					rtbVisualizar.LoadFile("BD_quiz/quiz2.txt");
				
				else if (comboMateria.Text == "TPI")
					rtbVisualizar.LoadFile("BD_quiz/quiz3.txt");
				
				else if (comboMateria.Text == "AS")
					rtbVisualizar.LoadFile("BD_quiz/quiz4.txt");
				
				else if (comboMateria.Text == "GSO")
					rtbVisualizar.LoadFile("BD_quiz/quiz5.txt");
				
				else if (comboMateria.Text == "TLBD")
					rtbVisualizar.LoadFile("BD_quiz/quiz6.txt");
				
				else if (comboMateria.Text == "LTT e II")
					rtbVisualizar.LoadFile("BD_quiz/quiz7.txt");
				
				string [] pergunta = rtbVisualizar.Text.Split('@');
				
				int q = pergunta.Length;
				
				for(int p = 1; p<q; p++) {
					pergunta[p] = pergunta[p].Trim();
					if (comboPergunta.Text == pergunta[p])
						frase = pergunta[p].Split('%');
				}
				richTextBox1.Text = frase[0];
				richTextBox2.Text = frase[1];
				richTextBox3.Text = frase[2];
				richTextBox4.Text = frase[3];
				richTextBox5.Text = frase[4];
				
				richTextBox1.Visible = true;
				richTextBox2.Visible = true;
				richTextBox3.Visible = true;
				richTextBox4.Visible = true;
				richTextBox5.Visible = true;
				
				rtbVisualizar.Visible = false;
				
				btnExcluir.Enabled = true;
				btnVisualizar.Enabled = false;
				
				aparecerPainel();
				
				btnFinalizar.Enabled = true;
			}
		}
		void BtnExcluirClick(object sender, EventArgs e)
		{
			if (comboMateria.Text == "LP")
				rtbVisualizar.LoadFile("BD_quiz/quiz1.txt");
			
			else if (comboMateria.Text == "IMC")
				rtbVisualizar.LoadFile("BD_quiz/quiz2.txt");
			
			else if (comboMateria.Text == "TPI")
				rtbVisualizar.LoadFile("BD_quiz/quiz3.txt");
			
			else if (comboMateria.Text == "AS")
				rtbVisualizar.LoadFile("BD_quiz/quiz4.txt");
			
			else if (comboMateria.Text == "GSO")
				rtbVisualizar.LoadFile("BD_quiz/quiz5.txt");
			
			else if (comboMateria.Text == "TLBD")
				rtbVisualizar.LoadFile("BD_quiz/quiz6.txt");
			
			else if (comboMateria.Text == "LTT e II")
				rtbVisualizar.LoadFile("BD_quiz/quiz7.txt");
			
			string [] pergunta = rtbVisualizar.Text.Split('@');
			
			int qtd = pergunta.Length;
			
			for(int p = 1; p<qtd; p++) {
				pergunta[p] = pergunta[p].Trim();
				if (comboPergunta.Text == pergunta[p])
					pergunta[p] = "";
			}
			
			rtbGuardar.Clear();
			rtbVisualizar.Clear();
			
			for(int linha = 0; linha<qtd;linha++) {
				if(pergunta[linha] != ""){
					if (linha == 0)
						rtbGuardar.Text = rtbGuardar.Text + pergunta[linha];
					else
						rtbGuardar.Text = rtbGuardar.Text + "\n\n@\n\n" + pergunta[linha];
				}
			}
			
			rtbVisualizar.AppendText(rtbGuardar.Text);
			
			if (comboMateria.Text == "LP")
				rtbVisualizar.SaveFile("BD_quiz/quiz1.txt");
			
			else if (comboMateria.Text == "IMC")
				rtbVisualizar.SaveFile("BD_quiz/quiz2.txt");
			
			else if (comboMateria.Text == "TPI")
				rtbVisualizar.SaveFile("BD_quiz/quiz3.txt");
			
			else if (comboMateria.Text == "AS")
				rtbVisualizar.SaveFile("BD_quiz/quiz4.txt");
			
			
			else if (comboMateria.Text == "GSO")
				rtbVisualizar.SaveFile("BD_quiz/quiz5.txt");
			
			else if (comboMateria.Text == "TLBD")
				rtbVisualizar.SaveFile("BD_quiz/quiz6.txt");
			
			else if (comboMateria.Text == "LTT e II")
				rtbVisualizar.SaveFile("BD_quiz/quiz7.txt");
		
			comboPergunta.Items.Clear();
			
			MessageBox.Show("Operação realizada com sucesso!","Operação realização",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			btnFinalizar.Enabled = true;
			
		}
		void BtnFinalizarClick(object sender, EventArgs e)
		{
			aparecerRich();
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			label6.Text = "Restam: " + (250 - richTextBox1.Text.Length);
		}
		void RichTextBox2TextChanged(object sender, EventArgs e)
		{
			label7.Text = "Restam: " + (120 - richTextBox2.Text.Length);
		}
		void RichTextBox3TextChanged(object sender, EventArgs e)
		{
			label8.Text = "Restam: " + (120 - richTextBox3.Text.Length);
		}
		void RichTextBox4TextChanged(object sender, EventArgs e)
		{
			label9.Text = "Restam: " + (120 - richTextBox4.Text.Length);
		}
		void RichTextBox5TextChanged(object sender, EventArgs e)
		{
			label10.Text = "Restam: " + (120 - richTextBox5.Text.Length);
		}
	}
}
