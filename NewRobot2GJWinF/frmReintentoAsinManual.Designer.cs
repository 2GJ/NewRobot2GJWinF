﻿namespace NewRobot2GJWinF
{
    partial class frmReintentoAsinManual
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAplicaBDC = new System.Windows.Forms.CheckBox();
            this.rbRetryAsy = new System.Windows.Forms.RadioButton();
            this.rbPerform = new System.Windows.Forms.RadioButton();
            this.tbExaminar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegEjecutados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btoReintento = new System.Windows.Forms.Button();
            this.RegTotal = new System.Windows.Forms.Label();
            this.lblRegTotal = new System.Windows.Forms.Label();
            this.btoExaminar = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLogActData = new System.Windows.Forms.CheckBox();
            this.rtActData = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAplicaBDC);
            this.groupBox1.Controls.Add(this.chkLogActData);
            this.groupBox1.Controls.Add(this.rbRetryAsy);
            this.groupBox1.Controls.Add(this.rbPerform);
            this.groupBox1.Controls.Add(this.tbExaminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RegEjecutados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btoReintento);
            this.groupBox1.Controls.Add(this.RegTotal);
            this.groupBox1.Controls.Add(this.lblRegTotal);
            this.groupBox1.Controls.Add(this.btoExaminar);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(588, 335);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // chkAplicaBDC
            // 
            this.chkAplicaBDC.AutoSize = true;
            this.chkAplicaBDC.Location = new System.Drawing.Point(219, 219);
            this.chkAplicaBDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAplicaBDC.Name = "chkAplicaBDC";
            this.chkAplicaBDC.Size = new System.Drawing.Size(203, 24);
            this.chkAplicaBDC.TabIndex = 47;
            this.chkAplicaBDC.Text = "Aplicar Soluciones BDC";
            this.chkAplicaBDC.UseVisualStyleBackColor = true;
            // 
            // rbRetryAsy
            // 
            this.rbRetryAsy.AutoSize = true;
            this.rbRetryAsy.Enabled = false;
            this.rbRetryAsy.Location = new System.Drawing.Point(219, 158);
            this.rbRetryAsy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRetryAsy.Name = "rbRetryAsy";
            this.rbRetryAsy.Size = new System.Drawing.Size(156, 24);
            this.rbRetryAsy.TabIndex = 46;
            this.rbRetryAsy.Text = "Por [RetryAsinch]";
            this.rbRetryAsy.UseVisualStyleBackColor = true;
            // 
            // rbPerform
            // 
            this.rbPerform.AutoSize = true;
            this.rbPerform.Checked = true;
            this.rbPerform.Enabled = false;
            this.rbPerform.Location = new System.Drawing.Point(219, 124);
            this.rbPerform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPerform.Name = "rbPerform";
            this.rbPerform.Size = new System.Drawing.Size(175, 24);
            this.rbPerform.TabIndex = 45;
            this.rbPerform.TabStop = true;
            this.rbPerform.Text = "Por [PerformActivity]";
            this.rbPerform.UseVisualStyleBackColor = true;
            // 
            // tbExaminar
            // 
            this.tbExaminar.Location = new System.Drawing.Point(36, 51);
            this.tbExaminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbExaminar.Name = "tbExaminar";
            this.tbExaminar.Size = new System.Drawing.Size(502, 26);
            this.tbExaminar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 35);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ruta de Archivo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegEjecutados
            // 
            this.RegEjecutados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegEjecutados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEjecutados.Location = new System.Drawing.Point(32, 272);
            this.RegEjecutados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegEjecutados.Name = "RegEjecutados";
            this.RegEjecutados.Size = new System.Drawing.Size(159, 38);
            this.RegEjecutados.TabIndex = 42;
            this.RegEjecutados.Text = "0";
            this.RegEjecutados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 54);
            this.label2.TabIndex = 43;
            this.label2.Text = "Registros Ejecutados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btoReintento
            // 
            this.btoReintento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btoReintento.Image = global::NewRobot2GJWinF.Properties.Resources.Reintento50X50;
            this.btoReintento.Location = new System.Drawing.Point(489, 234);
            this.btoReintento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btoReintento.Name = "btoReintento";
            this.btoReintento.Size = new System.Drawing.Size(90, 92);
            this.btoReintento.TabIndex = 41;
            this.btoReintento.UseVisualStyleBackColor = false;
            this.btoReintento.Click += new System.EventHandler(this.btoReintento_Click);
            // 
            // RegTotal
            // 
            this.RegTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.RegTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegTotal.Location = new System.Drawing.Point(33, 158);
            this.RegTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegTotal.Name = "RegTotal";
            this.RegTotal.Size = new System.Drawing.Size(158, 38);
            this.RegTotal.TabIndex = 39;
            this.RegTotal.Text = "0";
            this.RegTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegTotal
            // 
            this.lblRegTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRegTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegTotal.Location = new System.Drawing.Point(33, 105);
            this.lblRegTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegTotal.Name = "lblRegTotal";
            this.lblRegTotal.Size = new System.Drawing.Size(158, 54);
            this.lblRegTotal.TabIndex = 40;
            this.lblRegTotal.Text = "Registros Archivo";
            this.lblRegTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btoExaminar
            // 
            this.btoExaminar.Location = new System.Drawing.Point(536, 49);
            this.btoExaminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btoExaminar.Name = "btoExaminar";
            this.btoExaminar.Size = new System.Drawing.Size(40, 34);
            this.btoExaminar.TabIndex = 11;
            this.btoExaminar.Text = "....";
            this.btoExaminar.UseVisualStyleBackColor = true;
            this.btoExaminar.Click += new System.EventHandler(this.btoExaminar_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbResultado.ForeColor = System.Drawing.Color.Lime;
            this.rtbResultado.Location = new System.Drawing.Point(18, 363);
            this.rtbResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(1164, 429);
            this.rtbResultado.TabIndex = 37;
            this.rtbResultado.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtActData);
            this.groupBox2.Location = new System.Drawing.Point(615, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(568, 335);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // chkLogActData
            // 
            this.chkLogActData.AutoSize = true;
            this.chkLogActData.Location = new System.Drawing.Point(219, 252);
            this.chkLogActData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLogActData.Name = "chkLogActData";
            this.chkLogActData.Size = new System.Drawing.Size(262, 24);
            this.chkLogActData.TabIndex = 48;
            this.chkLogActData.Text = "Generar Log Actualizacion Data";
            this.chkLogActData.UseVisualStyleBackColor = true;
            this.chkLogActData.CheckedChanged += new System.EventHandler(this.chkLogActData_CheckedChanged);
            // 
            // rtActData
            // 
            this.rtActData.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtActData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtActData.Location = new System.Drawing.Point(8, 25);
            this.rtActData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtActData.Name = "rtActData";
            this.rtActData.Size = new System.Drawing.Size(552, 300);
            this.rtActData.TabIndex = 39;
            this.rtActData.Text = "";
            this.rtActData.Visible = false;
            // 
            // frmReintentoAsinManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1202, 812);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReintentoAsinManual";
            this.Text = "Reintento Manual Asincronas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btoExaminar;
        private System.Windows.Forms.TextBox tbExaminar;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RegEjecutados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btoReintento;
        private System.Windows.Forms.Label RegTotal;
        private System.Windows.Forms.Label lblRegTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRetryAsy;
        private System.Windows.Forms.RadioButton rbPerform;
        private System.Windows.Forms.CheckBox chkAplicaBDC;
        private System.Windows.Forms.RichTextBox rtActData;
        private System.Windows.Forms.CheckBox chkLogActData;
    }
}