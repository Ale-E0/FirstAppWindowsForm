using System.ComponentModel;

namespace ColleoniWWF
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxTitolo = new System.Windows.Forms.TextBox();
            this.boxStagioni = new System.Windows.Forms.TextBox();
            this.boxEpisodi = new System.Windows.Forms.TextBox();
            this.boxGenere = new System.Windows.Forms.TextBox();
            this.boxPaese = new System.Windows.Forms.TextBox();
            this.boxAnno = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(101, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stagioni:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(101, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Episodi:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(101, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genere:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(101, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paese:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(101, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Anno:";
            // 
            // boxTitolo
            // 
            this.boxTitolo.Location = new System.Drawing.Point(172, 45);
            this.boxTitolo.Name = "boxTitolo";
            this.boxTitolo.Size = new System.Drawing.Size(100, 20);
            this.boxTitolo.TabIndex = 6;
            // 
            // boxStagioni
            // 
            this.boxStagioni.Location = new System.Drawing.Point(172, 71);
            this.boxStagioni.Name = "boxStagioni";
            this.boxStagioni.Size = new System.Drawing.Size(100, 20);
            this.boxStagioni.TabIndex = 7;
            // 
            // boxEpisodi
            // 
            this.boxEpisodi.Location = new System.Drawing.Point(172, 97);
            this.boxEpisodi.Name = "boxEpisodi";
            this.boxEpisodi.Size = new System.Drawing.Size(100, 20);
            this.boxEpisodi.TabIndex = 8;
            // 
            // boxGenere
            // 
            this.boxGenere.Location = new System.Drawing.Point(172, 123);
            this.boxGenere.Name = "boxGenere";
            this.boxGenere.Size = new System.Drawing.Size(100, 20);
            this.boxGenere.TabIndex = 9;
            // 
            // boxPaese
            // 
            this.boxPaese.Location = new System.Drawing.Point(172, 149);
            this.boxPaese.Name = "boxPaese";
            this.boxPaese.Size = new System.Drawing.Size(100, 20);
            this.boxPaese.TabIndex = 10;
            // 
            // boxAnno
            // 
            this.boxAnno.Location = new System.Drawing.Point(172, 175);
            this.boxAnno.Name = "boxAnno";
            this.boxAnno.Size = new System.Drawing.Size(100, 20);
            this.boxAnno.TabIndex = 11;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(172, 237);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 12;
            this.confirm.Text = "Aggiungi";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(671, 391);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 13;
            this.close.Text = "Chiudi";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // labelConfirm
            // 
            this.labelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelConfirm.Location = new System.Drawing.Point(368, 40);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(154, 155);
            this.labelConfirm.TabIndex = 14;
            this.labelConfirm.Text = "...";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.close);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.boxAnno);
            this.Controls.Add(this.boxPaese);
            this.Controls.Add(this.boxGenere);
            this.Controls.Add(this.boxEpisodi);
            this.Controls.Add(this.boxStagioni);
            this.Controls.Add(this.boxTitolo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelConfirm;

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button confirm;

        private System.Windows.Forms.TextBox boxAnno;
        private System.Windows.Forms.TextBox boxEpisodi;
        private System.Windows.Forms.TextBox boxGenere;
        private System.Windows.Forms.TextBox boxPaese;
        private System.Windows.Forms.TextBox boxStagioni;
        private System.Windows.Forms.TextBox boxTitolo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}