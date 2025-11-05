namespace SistemaUNI.Vista
{
    partial class FrmRegistro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreFac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoFac = new System.Windows.Forms.TextBox();
            this.btnAgregarFac = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregaCarrera = new System.Windows.Forms.Button();
            this.tbCodigoCarrera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreCarrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.tbPrecioCarrera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Facultad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carreras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAsignar);
            this.tabPage3.Controls.Add(this.cmbCarrera);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(566, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asignar Carrera";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarFac);
            this.groupBox1.Controls.Add(this.tbCodigoFac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNombreFac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Facultad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tbNombreFac
            // 
            this.tbNombreFac.Location = new System.Drawing.Point(28, 57);
            this.tbNombreFac.Name = "tbNombreFac";
            this.tbNombreFac.Size = new System.Drawing.Size(225, 22);
            this.tbNombreFac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // tbCodigoFac
            // 
            this.tbCodigoFac.Location = new System.Drawing.Point(28, 118);
            this.tbCodigoFac.Name = "tbCodigoFac";
            this.tbCodigoFac.Size = new System.Drawing.Size(225, 22);
            this.tbCodigoFac.TabIndex = 3;
            // 
            // btnAgregarFac
            // 
            this.btnAgregarFac.Location = new System.Drawing.Point(28, 160);
            this.btnAgregarFac.Name = "btnAgregarFac";
            this.btnAgregarFac.Size = new System.Drawing.Size(225, 52);
            this.btnAgregarFac.TabIndex = 4;
            this.btnAgregarFac.Text = "Agregar";
            this.btnAgregarFac.UseVisualStyleBackColor = true;
            this.btnAgregarFac.Click += new System.EventHandler(this.btnAgregarFac_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPrecioCarrera);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAgregaCarrera);
            this.groupBox2.Controls.Add(this.tbCodigoCarrera);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbNombreCarrera);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(24, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Carrera";
            // 
            // btnAgregaCarrera
            // 
            this.btnAgregaCarrera.Location = new System.Drawing.Point(28, 242);
            this.btnAgregaCarrera.Name = "btnAgregaCarrera";
            this.btnAgregaCarrera.Size = new System.Drawing.Size(225, 52);
            this.btnAgregaCarrera.TabIndex = 6;
            this.btnAgregaCarrera.Text = "Agregar";
            this.btnAgregaCarrera.UseVisualStyleBackColor = true;
            this.btnAgregaCarrera.Click += new System.EventHandler(this.btnAgregaCarrera_Click);
            // 
            // tbCodigoCarrera
            // 
            this.tbCodigoCarrera.Location = new System.Drawing.Point(28, 118);
            this.tbCodigoCarrera.Name = "tbCodigoCarrera";
            this.tbCodigoCarrera.Size = new System.Drawing.Size(225, 22);
            this.tbCodigoCarrera.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // tbNombreCarrera
            // 
            this.tbNombreCarrera.Location = new System.Drawing.Point(28, 57);
            this.tbNombreCarrera.Name = "tbNombreCarrera";
            this.tbNombreCarrera.Size = new System.Drawing.Size(225, 22);
            this.tbNombreCarrera.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Facultades";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 59);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(208, 303);
            this.treeView1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Carreras";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(264, 59);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(273, 24);
            this.cmbCarrera.TabIndex = 3;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(264, 89);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(107, 38);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // tbPrecioCarrera
            // 
            this.tbPrecioCarrera.Location = new System.Drawing.Point(28, 192);
            this.tbPrecioCarrera.Name = "tbPrecioCarrera";
            this.tbPrecioCarrera.Size = new System.Drawing.Size(130, 22);
            this.tbPrecioCarrera.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Precio:";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRegistro";
            this.Text = "Registros";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarFac;
        private System.Windows.Forms.TextBox tbCodigoFac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreFac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregaCarrera;
        private System.Windows.Forms.TextBox tbCodigoCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrecioCarrera;
        private System.Windows.Forms.Label label7;
    }
}