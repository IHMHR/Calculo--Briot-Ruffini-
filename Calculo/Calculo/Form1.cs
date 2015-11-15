using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculo
{
    public partial class Form1 : Form
    {
        List<long> lista = new List<long>();
        double resto = 0;
        string quociente;
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
                else*/ if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    label5.Visible = true;
                }


                if (e.KeyChar == (char)13)
                    PopularPanel(int.Parse(textBox2.Text));
                else if (textBox2.Text != string.Empty && e.KeyChar != (char)8)
                    MessageBox.Show("Este campo somente aceita valores númericos e somente 1 número", "Somente 1 casa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("O campo não pode ser vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                PopularPanel(int.Parse(textBox2.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("O campo não pode ser vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopularPanel(int qtd)
        {
            try
            {
                SuspendLayout();
                while (qtd != 0)
                {
                    switch (qtd)
                    {
                        case 0:
                            //lbl.Text = "Coeficiente A";
                            break;
                        case 1:
                            var lbl = new System.Windows.Forms.Label();
                            lbl.Location = new System.Drawing.Point(25, 75);
                            lbl.Name = "Label1";
                            lbl.Text = "Coeficiente A";
                            this.Controls.Add(lbl);
                            var txt = new System.Windows.Forms.TextBox();
                            txt.Location = new System.Drawing.Point(125, 75);
                            txt.Name = "txt";
                            txt.MaxLength = 10;
                            txt.Size = new System.Drawing.Size(175, 20);
                            txt.Enabled = true;
                            txt.TabIndex = 4;
                            txt.Leave += txt_Leave;
                            this.Controls.Add(txt);
                            break;
                        case 2:
                            var lbl2 = new System.Windows.Forms.Label();
                            lbl2.Location = new System.Drawing.Point(25, 100);
                            lbl2.Name = "Label2";
                            lbl2.Text = "Coeficiente B";
                            this.Controls.Add(lbl2);
                            var txt2 = new System.Windows.Forms.TextBox();
                            txt2.Location = new System.Drawing.Point(125, 100);
                            txt2.Name = "txt2";
                            txt2.MaxLength = 10;
                            txt2.Size = new System.Drawing.Size(175, 20);
                            txt2.Enabled = true;
                            txt2.TabIndex = 6;
                            txt2.Leave += txt2_Leave;
                            this.Controls.Add(txt2);
                            break;
                        case 3:
                            var lbl3 = new System.Windows.Forms.Label();
                            lbl3.Location = new System.Drawing.Point(25, 125);
                            lbl3.Name = "Label3";
                            lbl3.Text = "Coeficiente C";
                            this.Controls.Add(lbl3);
                            var txt3 = new System.Windows.Forms.TextBox();
                            txt3.Location = new System.Drawing.Point(125, 125);
                            txt3.Name = "txt3";
                            txt3.MaxLength = 10;
                            txt3.Size = new System.Drawing.Size(175, 20);
                            txt3.Enabled = true;
                            txt3.TabIndex = 7;
                            txt3.Leave += txt3_Leave;
                            this.Controls.Add(txt3);
                            break;
                        case 4:
                            var lbl4 = new System.Windows.Forms.Label();
                            lbl4.Location = new System.Drawing.Point(25, 150);
                            lbl4.Name = "Label4";
                            lbl4.Text = "Coeficiente D";
                            this.Controls.Add(lbl4);
                            var txt4 = new System.Windows.Forms.TextBox();
                            txt4.Location = new System.Drawing.Point(125, 150);
                            txt4.Name = "txt4";
                            txt4.MaxLength = 10;
                            txt4.Size = new System.Drawing.Size(175, 20);
                            txt4.Enabled = true;
                            txt4.TabIndex = 8;
                            txt4.Leave += txt4_Leave;
                            this.Controls.Add(txt4);
                            break;
                        case 5:
                            var lbl5 = new System.Windows.Forms.Label();
                            lbl5.Location = new System.Drawing.Point(25, 175);
                            lbl5.Name = "Label5";
                            lbl5.Text = "Coeficiente E";
                            this.Controls.Add(lbl5);
                            var txt5 = new System.Windows.Forms.TextBox();
                            txt5.Location = new System.Drawing.Point(125, 175);
                            txt5.Name = "txt5";
                            txt5.MaxLength = 10;
                            txt5.Size = new System.Drawing.Size(175, 20);
                            txt5.Enabled = true;
                            txt5.TabIndex = 9;
                            txt5.Leave += txt5_Leave;
                            this.Controls.Add(txt5);
                            break;
                        case 6:
                            var lbl6 = new System.Windows.Forms.Label();
                            lbl6.Location = new System.Drawing.Point(25, 200);
                            lbl6.Name = "Label6";
                            lbl6.Text = "Coeficiente F";
                            this.Controls.Add(lbl6);
                            var txt6 = new System.Windows.Forms.TextBox();
                            txt6.Location = new System.Drawing.Point(125, 200);
                            txt6.Name = "txt6";
                            txt6.MaxLength = 10;
                            txt6.Size = new System.Drawing.Size(175, 20);
                            txt6.Enabled = true;
                            txt6.TabIndex = 10;
                            txt6.Leave += txt6_Leave;
                            this.Controls.Add(txt6);
                            break;
                        case 7:
                            var lbl7 = new System.Windows.Forms.Label();
                            lbl7.Location = new System.Drawing.Point(25, 225);
                            lbl7.Name = "Label7";
                            lbl7.Text = "Coeficiente G";
                            this.Controls.Add(lbl7);
                            var txt7 = new System.Windows.Forms.TextBox();
                            txt7.Location = new System.Drawing.Point(125, 225);
                            txt7.Name = "txt7";
                            txt7.MaxLength = 10;
                            txt7.Size = new System.Drawing.Size(175, 20);
                            txt7.Enabled = true;
                            txt7.TabIndex = 11;
                            txt7.Leave += txt7_Leave;
                            this.Controls.Add(txt7);
                            break;
                        case 8:
                            var lbl8 = new System.Windows.Forms.Label();
                            lbl8.Location = new System.Drawing.Point(25, 250);
                            lbl8.Name = "Label8";
                            lbl8.Text = "Coeficiente H";
                            this.Controls.Add(lbl8);
                            var txt8 = new System.Windows.Forms.TextBox();
                            txt8.Location = new System.Drawing.Point(125, 250);
                            txt8.Name = "txt8";
                            txt8.MaxLength = 10;
                            txt8.Size = new System.Drawing.Size(175, 20);
                            txt8.Enabled = true;
                            txt8.TabIndex = 12;
                            txt8.Leave += txt8_Leave;
                            this.Controls.Add(txt8);
                            break;
                        case 9:
                            var lbl9 = new System.Windows.Forms.Label();
                            lbl9.Location = new System.Drawing.Point(25, 275);
                            lbl9.Name = "Label9";
                            lbl9.Text = "Coeficiente I";
                            this.Controls.Add(lbl9);
                            var txt9 = new System.Windows.Forms.TextBox();
                            txt9.Location = new System.Drawing.Point(125, 275);
                            txt9.Name = "txt9";
                            txt9.MaxLength = 10;
                            txt9.Size = new System.Drawing.Size(175, 20);
                            txt9.Enabled = true;
                            txt9.TabIndex = 13;
                            txt9.Leave += txt9_Leave;
                            this.Controls.Add(txt9);
                            break;
                    }
                    qtd--;
                }
                //add 1 btn para briot-ruffini
                var btn = new System.Windows.Forms.Button();
                btn.Text = "Briot Ruffini";
                btn.Location = new System.Drawing.Point(120, 320);
                btn.Click += btn_Click;
                toolTip1.SetToolTip(btn, "Calcular usando o Método Briot Ruffini.");
                this.Controls.Add(btn);
                ResumeLayout(false);
            }
            catch(Exception)
            {
                MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt9_Leave(object sender, EventArgs e)
        {
            try
            {
                lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt8_Leave(object sender, EventArgs e)
        {
            try
            {
                lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt7_Leave(object sender, EventArgs e)
        {
            try
            {
                lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt6_Leave(object sender, EventArgs e)
        {
            try
            {
                lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt5_Leave(object sender, EventArgs e)
        {
            try
            {
                lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt4_Leave(object sender, EventArgs e)
        {
            try
            {
                if (sender.ToString() != string.Empty)
                    lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt3_Leave(object sender, EventArgs e)
        {
            try
            {
                if (sender.ToString() != string.Empty)
                    lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (sender.ToString() != string.Empty)
                    lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (sender.ToString() == "")
                    MessageBox.Show(sender.ToString());
                else
                    lista.Add(long.Parse(sender.ToString().Substring(35)));
            }
            catch (Exception)
            {
                //MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Por favor preenchar algum valor para a raíz!", "Preencher a raíz.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (lista.Count == 0 || lista.Count == 1)
                {
                    MessageBox.Show("Devem ser informados mais que 1 coeficiente", "Preencher os coeficiente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else
                {
                    //Briot Ruffini
                    long[] itens = lista.ToArray();
                    double raiz = double.Parse(textBox1.Text.Replace(",", ".")), termoInde = double.Parse(textBox3.Text.Replace(",", "."));
                    switch (lista.Count)
                    {
                        case 2:
                            resto = (((itens[0] * raiz) + itens[1]) * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x² " + (itens[0] * raiz + itens[1]);
                            break;
                        case 3:
                            resto = ((((itens[0] * raiz) + itens[1]) * raiz) + itens[2] * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x³ " + (itens[0] * raiz + itens[1]) + "x² " + ((itens[0] * raiz + itens[1]) * raiz + itens[2]);
                            break;
                        case 4:
                            resto = (((((itens[0] * raiz) + itens[1]) * raiz) + itens[2] * raiz) + itens[3] * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x4 " + (itens[0] * raiz + itens[1]) + "x3 " + ((itens[0] * raiz + itens[1]) * raiz + itens[2]) + "x2 " + (((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]);
                            break;
                        case 5:
                            resto = ((((((itens[0] * raiz) + itens[1]) * raiz) + itens[2] * raiz) + itens[3] * raiz) + itens[4] * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x5 " + (itens[0] * raiz + itens[1]) + "x4 " + ((itens[0] * raiz + itens[1]) * raiz + itens[2]) + "x3 " + (((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) + "x2 " + ((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]);
                            break;
                        case 6:
                            resto = (((((((itens[0] * raiz) + itens[1]) * raiz) + itens[2] * raiz) + itens[3] * raiz) + itens[4] * raiz) + itens[5] * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x6 " + (itens[0] * raiz + itens[1]) + "x5 " + ((itens[0] * raiz + itens[1]) * raiz + itens[2]) + "x4 " + (((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) + "x3 " + ((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) + "x2 " + (((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]);
                            break;
                        case 7:
                            resto = ((((((((itens[0] * raiz) + itens[1]) * raiz) + itens[2] * raiz) + itens[3] * raiz) + itens[4] * raiz) + itens[5] * raiz) + itens[6] * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x7 " + (itens[0] * raiz + itens[1]) + "x6 " + ((itens[0] * raiz + itens[1]) * raiz + itens[2]) + "x5 " + (((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) + "x4 " + ((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) + "x3 " + (((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) + "x2 " + ((((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) * raiz + itens[6]);
                            break;
                        case 8:
                            resto = (((((((((itens[0] * raiz) + itens[1]) * raiz) + itens[2] * raiz) + itens[3] * raiz) + itens[4] * raiz) + itens[5] * raiz) + itens[6] * raiz) + itens[7] * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x8 " + (itens[0] * raiz + itens[1]) + "x7 " + ((itens[0] * raiz + itens[1]) * raiz + itens[2]) + "x6 " + (((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) + "x5 " + ((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) + "x4 " + (((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) + "x3 " + ((((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) * raiz + itens[6]) + "x2 " + (((((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) * raiz + itens[6]) * raiz + itens[7]);
                            break;
                        case 9:
                            resto = ((((((((((itens[0] * raiz) + itens[1]) * raiz) + itens[2] * raiz) + itens[3] * raiz) + itens[4] * raiz) + itens[5] * raiz) + itens[6] * raiz) + itens[7] * raiz) + itens[8] * raiz) + termoInde;
                            quociente = itens[0].ToString() + "x9 " + (itens[0] * raiz + itens[1]) + "x8 " + ((itens[0] * raiz + itens[1]) * raiz + itens[2]) + "x7 " + (((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) + "x6 " + ((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) + "x5 " + (((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) + "x4 " + ((((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) * raiz + itens[6]) + "x3 " + (((((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) * raiz + itens[6]) * raiz + itens[7]) + "x2 " + ((((((((itens[0] * raiz + itens[1]) * raiz + itens[2]) * raiz + itens[3]) * raiz + itens[4]) * raiz + itens[5]) * raiz + itens[6]) * raiz + itens[7]) * raiz + itens[8]);
                            break;
                    }
                    if (resto != (double)0)
                    {
                        MessageBox.Show("O valor do resto é diferente de 0 ! \nO valor do resto é:" + resto, "Resto diferente de 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                    } 
                }
                MessageBox.Show("O valor do resto é: " + resto + "\nO quociente é: " + quociente, "Valores calculados", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '-' && textBox3.SelectionStart == 0)
                    e.Handled = false;
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    label4.Visible = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Me desculpe, entretanto ocorreu um erro inexperado. \nTalvez seja sua culpa!", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
