
namespace Task_1
{
    partial class frmUI
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
            this.bttnUp = new System.Windows.Forms.Button();
            this.bttnRight = new System.Windows.Forms.Button();
            this.bttnDown = new System.Windows.Forms.Button();
            this.bttnLeft = new System.Windows.Forms.Button();
            this.grpBxStats = new System.Windows.Forms.GroupBox();
            this.redStats = new System.Windows.Forms.RichTextBox();
            this.grpbxAttack = new System.Windows.Forms.GroupBox();
            this.EnemycomboBox = new System.Windows.Forms.ComboBox();
            this.bttnAttack = new System.Windows.Forms.Button();
            this.redLog = new System.Windows.Forms.RichTextBox();
            this.redEnemyStats = new System.Windows.Forms.RichTextBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBxStats.SuspendLayout();
            this.grpbxAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnUp
            // 
            this.bttnUp.BackColor = System.Drawing.Color.Silver;
            this.bttnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnUp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnUp.Location = new System.Drawing.Point(673, 144);
            this.bttnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnUp.Name = "bttnUp";
            this.bttnUp.Size = new System.Drawing.Size(85, 36);
            this.bttnUp.TabIndex = 0;
            this.bttnUp.Text = "^";
            this.bttnUp.UseVisualStyleBackColor = false;
            this.bttnUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnRight
            // 
            this.bttnRight.BackColor = System.Drawing.Color.Silver;
            this.bttnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnRight.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnRight.Location = new System.Drawing.Point(753, 184);
            this.bttnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnRight.Name = "bttnRight";
            this.bttnRight.Size = new System.Drawing.Size(85, 36);
            this.bttnRight.TabIndex = 1;
            this.bttnRight.Text = ">";
            this.bttnRight.UseVisualStyleBackColor = false;
            this.bttnRight.Click += new System.EventHandler(this.bttnRight_Click);
            // 
            // bttnDown
            // 
            this.bttnDown.BackColor = System.Drawing.Color.Silver;
            this.bttnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnDown.Location = new System.Drawing.Point(673, 225);
            this.bttnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnDown.Name = "bttnDown";
            this.bttnDown.Size = new System.Drawing.Size(85, 36);
            this.bttnDown.TabIndex = 2;
            this.bttnDown.Text = "V";
            this.bttnDown.UseVisualStyleBackColor = false;
            this.bttnDown.Click += new System.EventHandler(this.bttnDown_Click);
            // 
            // bttnLeft
            // 
            this.bttnLeft.BackColor = System.Drawing.Color.Silver;
            this.bttnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnLeft.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnLeft.Location = new System.Drawing.Point(594, 184);
            this.bttnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnLeft.Name = "bttnLeft";
            this.bttnLeft.Size = new System.Drawing.Size(85, 36);
            this.bttnLeft.TabIndex = 3;
            this.bttnLeft.Text = "<";
            this.bttnLeft.UseVisualStyleBackColor = false;
            this.bttnLeft.Click += new System.EventHandler(this.bttnLeft_Click);
            // 
            // grpBxStats
            // 
            this.grpBxStats.BackColor = System.Drawing.Color.White;
            this.grpBxStats.Controls.Add(this.redStats);
            this.grpBxStats.Location = new System.Drawing.Point(299, 29);
            this.grpBxStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxStats.Name = "grpBxStats";
            this.grpBxStats.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxStats.Size = new System.Drawing.Size(273, 97);
            this.grpBxStats.TabIndex = 4;
            this.grpBxStats.TabStop = false;
            this.grpBxStats.Text = "Stats";
            // 
            // redStats
            // 
            this.redStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.redStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redStats.Location = new System.Drawing.Point(10, 20);
            this.redStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redStats.Name = "redStats";
            this.redStats.Size = new System.Drawing.Size(253, 68);
            this.redStats.TabIndex = 1;
            this.redStats.Text = "";
            // 
            // grpbxAttack
            // 
            this.grpbxAttack.BackColor = System.Drawing.Color.White;
            this.grpbxAttack.Controls.Add(this.EnemycomboBox);
            this.grpbxAttack.Controls.Add(this.bttnAttack);
            this.grpbxAttack.Controls.Add(this.redLog);
            this.grpbxAttack.Controls.Add(this.redEnemyStats);
            this.grpbxAttack.Location = new System.Drawing.Point(299, 158);
            this.grpbxAttack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxAttack.Name = "grpbxAttack";
            this.grpbxAttack.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxAttack.Size = new System.Drawing.Size(273, 184);
            this.grpbxAttack.TabIndex = 0;
            this.grpbxAttack.TabStop = false;
            this.grpbxAttack.Text = "Attack";
            // 
            // EnemycomboBox
            // 
            this.EnemycomboBox.FormattingEnabled = true;
            this.EnemycomboBox.Location = new System.Drawing.Point(5, 20);
            this.EnemycomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnemycomboBox.Name = "EnemycomboBox";
            this.EnemycomboBox.Size = new System.Drawing.Size(263, 23);
            this.EnemycomboBox.TabIndex = 5;
            this.EnemycomboBox.Text = "--Select Enemy--";
            // 
            // bttnAttack
            // 
            this.bttnAttack.BackColor = System.Drawing.Color.Silver;
            this.bttnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnAttack.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAttack.Location = new System.Drawing.Point(5, 97);
            this.bttnAttack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAttack.Name = "bttnAttack";
            this.bttnAttack.Size = new System.Drawing.Size(262, 22);
            this.bttnAttack.TabIndex = 4;
            this.bttnAttack.Text = "ATTACK";
            this.bttnAttack.UseVisualStyleBackColor = false;
            this.bttnAttack.Click += new System.EventHandler(this.bttnAttack_Click);
            // 
            // redLog
            // 
            this.redLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.redLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redLog.Location = new System.Drawing.Point(5, 123);
            this.redLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redLog.Name = "redLog";
            this.redLog.Size = new System.Drawing.Size(263, 58);
            this.redLog.TabIndex = 3;
            this.redLog.Text = "";
            // 
            // redEnemyStats
            // 
            this.redEnemyStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.redEnemyStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redEnemyStats.Location = new System.Drawing.Point(5, 44);
            this.redEnemyStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redEnemyStats.Name = "redEnemyStats";
            this.redEnemyStats.Size = new System.Drawing.Size(263, 49);
            this.redEnemyStats.TabIndex = 2;
            this.redEnemyStats.Text = "";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMap.Location = new System.Drawing.Point(38, 29);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(122, 23);
            this.lblMap.TabIndex = 5;
            this.lblMap.Text = "XXXXXXXXXX";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(661, 306);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Shop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(849, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.grpbxAttack);
            this.Controls.Add(this.grpBxStats);
            this.Controls.Add(this.bttnLeft);
            this.Controls.Add(this.bttnDown);
            this.Controls.Add(this.bttnRight);
            this.Controls.Add(this.bttnUp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUI";
            this.Text = "Goblins and Heroes - The Game";
            this.Load += new System.EventHandler(this.PlayerUI_Load);
            this.grpBxStats.ResumeLayout(false);
            this.grpbxAttack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnUp;
        private System.Windows.Forms.Button bttnRight;
        private System.Windows.Forms.Button bttnDown;
        private System.Windows.Forms.Button bttnLeft;
        private System.Windows.Forms.GroupBox grpBxStats;
        private System.Windows.Forms.RichTextBox redStats;
        private System.Windows.Forms.GroupBox grpbxAttack;
        private System.Windows.Forms.Button bttnAttack;
        private System.Windows.Forms.RichTextBox redLog;
        private System.Windows.Forms.RichTextBox redEnemyStats;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.ComboBox EnemycomboBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}