namespace GADE6122.PART._1
{
    partial class GameView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnMoveUP = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.MapLabel = new System.Windows.Forms.Label();
            this.PlayerStats_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnMoveUP
            // 
            this.btnMoveUP.Location = new System.Drawing.Point(700, 315);
            this.btnMoveUP.Name = "btnMoveUP";
            this.btnMoveUP.Size = new System.Drawing.Size(94, 50);
            this.btnMoveUP.TabIndex = 0;
            this.btnMoveUP.Text = "Move up";
            this.btnMoveUP.UseVisualStyleBackColor = true;
            this.btnMoveUP.Click += new System.EventHandler(this.btnMoveUP_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(700, 406);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(94, 50);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(793, 371);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(94, 29);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = "Move Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(609, 371);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(94, 29);
            this.btnMoveLeft.TabIndex = 3;
            this.btnMoveLeft.Text = "Move Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(92, 315);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(62, 50);
            this.btnAttackUp.TabIndex = 4;
            this.btnAttackUp.Text = "Attack Up";
            this.btnAttackUp.UseMnemonic = false;
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.Location = new System.Drawing.Point(296, 115);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(0, 20);
            this.MapLabel.TabIndex = 9;
            // 
            // PlayerStats_lbl
            // 
            this.PlayerStats_lbl.AutoSize = true;
            this.PlayerStats_lbl.Location = new System.Drawing.Point(599, 115);
            this.PlayerStats_lbl.Name = "PlayerStats_lbl";
            this.PlayerStats_lbl.Size = new System.Drawing.Size(0, 20);
            this.PlayerStats_lbl.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "You can use arrow keys for movements";
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(92, 406);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(62, 50);
            this.btnAttackDown.TabIndex = 12;
            this.btnAttackDown.Text = "Attack Down";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(24, 360);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(62, 50);
            this.btnAttackLeft.TabIndex = 13;
            this.btnAttackLeft.Text = "Attack Left";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(160, 360);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(62, 50);
            this.btnAttackRight.TabIndex = 14;
            this.btnAttackRight.Text = "Attack Right";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            // 
            // GameView
            // 
            this.AccessibleName = "GameView";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 505);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerStats_lbl);
            this.Controls.Add(this.MapLabel);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUP);
            this.Name = "GameView";
            this.Text = "GAMEVIEW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private StatusStrip statusStrip1;
        private Button btnAttackDown;
        private Button btnAttackLeft;
        private Button btnAttackRight;
    }
}