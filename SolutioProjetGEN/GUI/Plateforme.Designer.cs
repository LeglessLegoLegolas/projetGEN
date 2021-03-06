﻿namespace GUI
{
    partial class Plateforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plateforme));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.labelChooseFile = new System.Windows.Forms.Label();
            this.btnDechiffrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(108, 161);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Fichier ...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelChooseFile
            // 
            this.labelChooseFile.AutoSize = true;
            this.labelChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelChooseFile.Location = new System.Drawing.Point(84, 145);
            this.labelChooseFile.Name = "labelChooseFile";
            this.labelChooseFile.Size = new System.Drawing.Size(128, 13);
            this.labelChooseFile.TabIndex = 1;
            this.labelChooseFile.Text = "Veuillez choisir un fichier :";
            // 
            // btnDechiffrement
            // 
            this.btnDechiffrement.Location = new System.Drawing.Point(104, 200);
            this.btnDechiffrement.Name = "btnDechiffrement";
            this.btnDechiffrement.Size = new System.Drawing.Size(82, 23);
            this.btnDechiffrement.TabIndex = 2;
            this.btnDechiffrement.Text = "Déchiffrement";
            this.btnDechiffrement.UseVisualStyleBackColor = true;
            this.btnDechiffrement.Click += new System.EventHandler(this.btnDechiffrement_Click);
            // 
            // Plateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.backgroundPlateform;
            this.ClientSize = new System.Drawing.Size(297, 249);
            this.Controls.Add(this.btnDechiffrement);
            this.Controls.Add(this.labelChooseFile);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(313, 288);
            this.MinimumSize = new System.Drawing.Size(313, 288);
            this.Name = "Plateforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plateforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fermeture);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label labelChooseFile;
        private System.Windows.Forms.Button btnDechiffrement;
    }
}