namespace EpicGamesLocator
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
            this.btnKillEpic = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIndtallationPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lGames = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGetGames = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKillEpic
            // 
            this.btnKillEpic.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKillEpic.Location = new System.Drawing.Point(13, 14);
            this.btnKillEpic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKillEpic.Name = "btnKillEpic";
            this.btnKillEpic.Size = new System.Drawing.Size(577, 50);
            this.btnKillEpic.TabIndex = 0;
            this.btnKillEpic.Text = "Exit Epic Games";
            this.btnKillEpic.UseVisualStyleBackColor = true;
            this.btnKillEpic.Click += new System.EventHandler(this.btnKillEpic_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.btnSave);
            this.grpBox.Controls.Add(this.txtIndtallationPath);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Controls.Add(this.lGames);
            this.grpBox.Controls.Add(this.btnEdit);
            this.grpBox.Controls.Add(this.btnGetGames);
            this.grpBox.Location = new System.Drawing.Point(13, 59);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(577, 350);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Miriam Libre", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "......";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(346, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIndtallationPath
            // 
            this.txtIndtallationPath.Location = new System.Drawing.Point(310, 169);
            this.txtIndtallationPath.Name = "txtIndtallationPath";
            this.txtIndtallationPath.ReadOnly = true;
            this.txtIndtallationPath.Size = new System.Drawing.Size(235, 29);
            this.txtIndtallationPath.TabIndex = 5;
            this.txtIndtallationPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Install Location ";
            // 
            // lGames
            // 
            this.lGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lGames.FullRowSelect = true;
            this.lGames.GridLines = true;
            this.lGames.HideSelection = false;
            this.lGames.Location = new System.Drawing.Point(15, 61);
            this.lGames.MultiSelect = false;
            this.lGames.Name = "lGames";
            this.lGames.Size = new System.Drawing.Size(254, 283);
            this.lGames.TabIndex = 3;
            this.lGames.UseCompatibleStateImageBehavior = false;
            this.lGames.View = System.Windows.Forms.View.Details;
            this.lGames.SelectedIndexChanged += new System.EventHandler(this.lGames_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Name";
            this.columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Name";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(346, 211);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Change location";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGetGames
            // 
            this.btnGetGames.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetGames.Location = new System.Drawing.Point(15, 28);
            this.btnGetGames.Name = "btnGetGames";
            this.btnGetGames.Size = new System.Drawing.Size(254, 27);
            this.btnGetGames.TabIndex = 0;
            this.btnGetGames.Text = "Get Games ";
            this.btnGetGames.UseVisualStyleBackColor = true;
            this.btnGetGames.Click += new System.EventHandler(this.btnGetGames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 421);
            this.Controls.Add(this.btnKillEpic);
            this.Controls.Add(this.grpBox);
            this.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Moving Games locations ( Epic games )";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKillEpic;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.ListView lGames;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGetGames;
        private System.Windows.Forms.TextBox txtIndtallationPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}

