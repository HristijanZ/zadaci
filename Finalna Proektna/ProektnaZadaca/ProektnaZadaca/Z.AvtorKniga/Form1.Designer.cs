namespace Z.AvtorKniga
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelkniga = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.Label();
            this.labelmesto = new System.Windows.Forms.Label();
            this.labeloblast = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbprezime = new System.Windows.Forms.TextBox();
            this.tbgodina = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbklas = new System.Windows.Forms.TextBox();
            this.tbmakedonski = new System.Windows.Forms.TextBox();
            this.tbmatematika = new System.Windows.Forms.TextBox();
            this.tbfizicko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbprogramiranje = new System.Windows.Forms.TextBox();
            this.tbrobotika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmikro = new System.Windows.Forms.TextBox();
            this.tbbazi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbmrezi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnprebarajime = new System.Windows.Forms.Button();
            this.btnPrezimepobaraj = new System.Windows.Forms.Button();
            this.tbprebarajime = new System.Windows.Forms.TextBox();
            this.tbprebarajprezime = new System.Windows.Forms.TextBox();
            this.tbprebarajgodina = new System.Windows.Forms.TextBox();
            this.tbprebarajklas = new System.Windows.Forms.TextBox();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnprosekucenik = new System.Windows.Forms.Button();
            this.tbprosekime = new System.Windows.Forms.TextBox();
            this.tbprosekprezime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnprosekklas = new System.Windows.Forms.Button();
            this.tbprosekklas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelkniga
            // 
            this.labelkniga.AutoSize = true;
            this.labelkniga.Location = new System.Drawing.Point(27, 24);
            this.labelkniga.Name = "labelkniga";
            this.labelkniga.Size = new System.Drawing.Size(27, 13);
            this.labelkniga.TabIndex = 0;
            this.labelkniga.Text = "Ime ";
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Location = new System.Drawing.Point(27, 50);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(44, 13);
            this.prezime.TabIndex = 1;
            this.prezime.Text = "Prezime";
            // 
            // labelmesto
            // 
            this.labelmesto.AutoSize = true;
            this.labelmesto.Location = new System.Drawing.Point(27, 76);
            this.labelmesto.Name = "labelmesto";
            this.labelmesto.Size = new System.Drawing.Size(41, 13);
            this.labelmesto.TabIndex = 2;
            this.labelmesto.Text = "Godina";
            // 
            // labeloblast
            // 
            this.labeloblast.AutoSize = true;
            this.labeloblast.Location = new System.Drawing.Point(27, 102);
            this.labeloblast.Name = "labeloblast";
            this.labeloblast.Size = new System.Drawing.Size(27, 13);
            this.labeloblast.TabIndex = 3;
            this.labeloblast.Text = "Klas";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(122, 24);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(121, 20);
            this.tbIme.TabIndex = 4;
            // 
            // tbprezime
            // 
            this.tbprezime.Location = new System.Drawing.Point(122, 50);
            this.tbprezime.Name = "tbprezime";
            this.tbprezime.Size = new System.Drawing.Size(121, 20);
            this.tbprezime.TabIndex = 5;
            // 
            // tbgodina
            // 
            this.tbgodina.Location = new System.Drawing.Point(122, 76);
            this.tbgodina.Name = "tbgodina";
            this.tbgodina.Size = new System.Drawing.Size(121, 20);
            this.tbgodina.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(331, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(685, 280);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(30, 348);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(119, 37);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbklas
            // 
            this.tbklas.Location = new System.Drawing.Point(122, 102);
            this.tbklas.Name = "tbklas";
            this.tbklas.Size = new System.Drawing.Size(121, 20);
            this.tbklas.TabIndex = 9;
            // 
            // tbmakedonski
            // 
            this.tbmakedonski.Location = new System.Drawing.Point(122, 128);
            this.tbmakedonski.Name = "tbmakedonski";
            this.tbmakedonski.Size = new System.Drawing.Size(121, 20);
            this.tbmakedonski.TabIndex = 10;
            // 
            // tbmatematika
            // 
            this.tbmatematika.Location = new System.Drawing.Point(122, 154);
            this.tbmatematika.Name = "tbmatematika";
            this.tbmatematika.Size = new System.Drawing.Size(121, 20);
            this.tbmatematika.TabIndex = 11;
            // 
            // tbfizicko
            // 
            this.tbfizicko.Location = new System.Drawing.Point(122, 180);
            this.tbfizicko.Name = "tbfizicko";
            this.tbfizicko.Size = new System.Drawing.Size(121, 20);
            this.tbfizicko.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Makedonski jazik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Matematika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fizicko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "OOP";
            // 
            // tbprogramiranje
            // 
            this.tbprogramiranje.Location = new System.Drawing.Point(122, 206);
            this.tbprogramiranje.Name = "tbprogramiranje";
            this.tbprogramiranje.Size = new System.Drawing.Size(121, 20);
            this.tbprogramiranje.TabIndex = 17;
            // 
            // tbrobotika
            // 
            this.tbrobotika.Location = new System.Drawing.Point(122, 232);
            this.tbrobotika.Name = "tbrobotika";
            this.tbrobotika.Size = new System.Drawing.Size(121, 20);
            this.tbrobotika.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Robotika";
            // 
            // tbmikro
            // 
            this.tbmikro.Location = new System.Drawing.Point(122, 258);
            this.tbmikro.Name = "tbmikro";
            this.tbmikro.Size = new System.Drawing.Size(121, 20);
            this.tbmikro.TabIndex = 20;
            // 
            // tbbazi
            // 
            this.tbbazi.Location = new System.Drawing.Point(122, 284);
            this.tbbazi.Name = "tbbazi";
            this.tbbazi.Size = new System.Drawing.Size(121, 20);
            this.tbbazi.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mikrokompijuteri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bazi na podatoci";
            // 
            // tbmrezi
            // 
            this.tbmrezi.Location = new System.Drawing.Point(122, 310);
            this.tbmrezi.Name = "tbmrezi";
            this.tbmrezi.Size = new System.Drawing.Size(121, 20);
            this.tbmrezi.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mrezi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "Prebaraj po klas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "Prebaraj po godina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPrebarajGodina_Click);
            // 
            // btnprebarajime
            // 
            this.btnprebarajime.Location = new System.Drawing.Point(413, 340);
            this.btnprebarajime.Name = "btnprebarajime";
            this.btnprebarajime.Size = new System.Drawing.Size(122, 37);
            this.btnprebarajime.TabIndex = 30;
            this.btnprebarajime.Text = "Prebaraj po ime";
            this.btnprebarajime.UseVisualStyleBackColor = true;
            this.btnprebarajime.Click += new System.EventHandler(this.btnprebarajime_Click);
            // 
            // btnPrezimepobaraj
            // 
            this.btnPrezimepobaraj.Location = new System.Drawing.Point(541, 340);
            this.btnPrezimepobaraj.Name = "btnPrezimepobaraj";
            this.btnPrezimepobaraj.Size = new System.Drawing.Size(122, 37);
            this.btnPrezimepobaraj.TabIndex = 31;
            this.btnPrezimepobaraj.Text = "Prebaraj po prezime";
            this.btnPrezimepobaraj.UseVisualStyleBackColor = true;
            this.btnPrezimepobaraj.Click += new System.EventHandler(this.btnPrezimepobaraj_Click);
            // 
            // tbprebarajime
            // 
            this.tbprebarajime.Location = new System.Drawing.Point(413, 383);
            this.tbprebarajime.Name = "tbprebarajime";
            this.tbprebarajime.Size = new System.Drawing.Size(122, 20);
            this.tbprebarajime.TabIndex = 32;
            // 
            // tbprebarajprezime
            // 
            this.tbprebarajprezime.Location = new System.Drawing.Point(541, 383);
            this.tbprebarajprezime.Name = "tbprebarajprezime";
            this.tbprebarajprezime.Size = new System.Drawing.Size(122, 20);
            this.tbprebarajprezime.TabIndex = 33;
            // 
            // tbprebarajgodina
            // 
            this.tbprebarajgodina.Location = new System.Drawing.Point(669, 383);
            this.tbprebarajgodina.Name = "tbprebarajgodina";
            this.tbprebarajgodina.Size = new System.Drawing.Size(122, 20);
            this.tbprebarajgodina.TabIndex = 34;
            // 
            // tbprebarajklas
            // 
            this.tbprebarajklas.Location = new System.Drawing.Point(797, 383);
            this.tbprebarajklas.Name = "tbprebarajklas";
            this.tbprebarajklas.Size = new System.Drawing.Size(122, 20);
            this.tbprebarajklas.TabIndex = 35;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(30, 391);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(119, 37);
            this.btnBrisi.TabIndex = 36;
            this.btnBrisi.Text = "Izbrisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnprosekucenik
            // 
            this.btnprosekucenik.Location = new System.Drawing.Point(1081, 137);
            this.btnprosekucenik.Name = "btnprosekucenik";
            this.btnprosekucenik.Size = new System.Drawing.Size(122, 37);
            this.btnprosekucenik.TabIndex = 37;
            this.btnprosekucenik.Text = "Prosek na ucenik";
            this.btnprosekucenik.UseVisualStyleBackColor = true;
            this.btnprosekucenik.Click += new System.EventHandler(this.btnprosekucenik_Click);
            // 
            // tbprosekime
            // 
            this.tbprosekime.Location = new System.Drawing.Point(1149, 76);
            this.tbprosekime.Name = "tbprosekime";
            this.tbprosekime.Size = new System.Drawing.Size(122, 20);
            this.tbprosekime.TabIndex = 38;
            // 
            // tbprosekprezime
            // 
            this.tbprosekprezime.Location = new System.Drawing.Point(1149, 102);
            this.tbprosekprezime.Name = "tbprosekprezime";
            this.tbprosekprezime.Size = new System.Drawing.Size(122, 20);
            this.tbprosekprezime.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1099, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1099, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Prezime";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(1077, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Prosek na ucenik";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(1077, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Prosek na klas";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnprosekklas
            // 
            this.btnprosekklas.Location = new System.Drawing.Point(1081, 267);
            this.btnprosekklas.Name = "btnprosekklas";
            this.btnprosekklas.Size = new System.Drawing.Size(122, 37);
            this.btnprosekklas.TabIndex = 44;
            this.btnprosekklas.Text = "Prosek na klas";
            this.btnprosekklas.UseVisualStyleBackColor = true;
            this.btnprosekklas.Click += new System.EventHandler(this.btnprosekklas_Click);
            // 
            // tbprosekklas
            // 
            this.tbprosekklas.Location = new System.Drawing.Point(1149, 234);
            this.tbprosekklas.Name = "tbprosekklas";
            this.tbprosekklas.Size = new System.Drawing.Size(122, 20);
            this.tbprosekklas.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1064, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Vnesi go klasot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1372, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbprosekklas);
            this.Controls.Add(this.btnprosekklas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbprosekprezime);
            this.Controls.Add(this.tbprosekime);
            this.Controls.Add(this.btnprosekucenik);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.tbprebarajklas);
            this.Controls.Add(this.tbprebarajgodina);
            this.Controls.Add(this.tbprebarajprezime);
            this.Controls.Add(this.tbprebarajime);
            this.Controls.Add(this.btnPrezimepobaraj);
            this.Controls.Add(this.btnprebarajime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbmrezi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbbazi);
            this.Controls.Add(this.tbmikro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbrobotika);
            this.Controls.Add(this.tbprogramiranje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbfizicko);
            this.Controls.Add(this.tbmatematika);
            this.Controls.Add(this.tbmakedonski);
            this.Controls.Add(this.tbklas);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbgodina);
            this.Controls.Add(this.tbprezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.labeloblast);
            this.Controls.Add(this.labelmesto);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.labelkniga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkniga;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label labelmesto;
        private System.Windows.Forms.Label labeloblast;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbprezime;
        private System.Windows.Forms.TextBox tbgodina;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbklas;
        private System.Windows.Forms.TextBox tbmakedonski;
        private System.Windows.Forms.TextBox tbmatematika;
        private System.Windows.Forms.TextBox tbfizicko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbprogramiranje;
        private System.Windows.Forms.TextBox tbrobotika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmikro;
        private System.Windows.Forms.TextBox tbbazi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbmrezi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnprebarajime;
        private System.Windows.Forms.Button btnPrezimepobaraj;
        private System.Windows.Forms.TextBox tbprebarajime;
        private System.Windows.Forms.TextBox tbprebarajprezime;
        private System.Windows.Forms.TextBox tbprebarajgodina;
        private System.Windows.Forms.TextBox tbprebarajklas;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnprosekucenik;
        private System.Windows.Forms.TextBox tbprosekime;
        private System.Windows.Forms.TextBox tbprosekprezime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnprosekklas;
        private System.Windows.Forms.TextBox tbprosekklas;
        private System.Windows.Forms.Label label13;
    }
}

