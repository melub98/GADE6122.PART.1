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
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

           
                this.MoveUP = new System.Windows.Forms.Button();
                this.MoveDown = new System.Windows.Forms.Button();
                this.MoveRight = new System.Windows.Forms.Button();
                this.MoveLeft = new System.Windows.Forms.Button();
                this.AttackRight = new System.Windows.Forms.Button();
                this.AttackDown = new System.Windows.Forms.Button();
                this.AttackUp = new System.Windows.Forms.Button();
                this.AttackLeft = new System.Windows.Forms.Button();
                this.MapLabel = new System.Windows.Forms.Label();
                this.PlayerStats_lbl = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // MoveUP
                // 
                this.MoveUP.Location = new System.Drawing.Point(700, 315);
                this.MoveUP.Name = "MoveUP";
                this.MoveUP.Size = new System.Drawing.Size(94, 50);
                this.MoveUP.TabIndex = 0;
                this.MoveUP.Text = "Move up";
                this.MoveUP.UseVisualStyleBackColor = true;
                // 
                // MoveDown
                // 
                this.MoveDown.Location = new System.Drawing.Point(700, 406);
                this.MoveDown.Name = "MoveDown";
                this.MoveDown.Size = new System.Drawing.Size(94, 50);
                this.MoveDown.TabIndex = 1;
                this.MoveDown.Text = "Move Down";
                this.MoveDown.UseVisualStyleBackColor = true;
                // 
                // MoveRight
                // 
                this.MoveRight.Location = new System.Drawing.Point(793, 371);
                this.MoveRight.Name = "MoveRight";
                this.MoveRight.Size = new System.Drawing.Size(94, 29);
                this.MoveRight.TabIndex = 2;
                this.MoveRight.Text = "Move Right";
                this.MoveRight.UseVisualStyleBackColor = true;
                // 
                // MoveLeft
                // 
                this.MoveLeft.Location = new System.Drawing.Point(609, 371);
                this.MoveLeft.Name = "MoveLeft";
                this.MoveLeft.Size = new System.Drawing.Size(94, 29);
                this.MoveLeft.TabIndex = 3;
                this.MoveLeft.Text = "Move Left";
                this.MoveLeft.UseVisualStyleBackColor = true;
                // 
                // AttackRight
                // 
                this.AttackRight.Location = new System.Drawing.Point(212, 360);
                this.AttackRight.Name = "AttackRight";
                this.AttackRight.Size = new System.Drawing.Size(94, 50);
                this.AttackRight.TabIndex = 6;
                this.AttackRight.Text = "Attack Right";
                this.AttackRight.UseVisualStyleBackColor = true;
                // 
                // AttackDown
                // 
                this.AttackDown.Location = new System.Drawing.Point(112, 406);
                this.AttackDown.Name = "AttackDown";
                this.AttackDown.Size = new System.Drawing.Size(94, 50);
                this.AttackDown.TabIndex = 5;
                this.AttackDown.Text = "Attack Down";
                this.AttackDown.UseVisualStyleBackColor = true;
                // 
                // AttackUp
                // 
                this.AttackUp.Location = new System.Drawing.Point(112, 315);
                this.AttackUp.Name = "AttackUp";
                this.AttackUp.Size = new System.Drawing.Size(94, 50);
                this.AttackUp.TabIndex = 4;
                this.AttackUp.Text = "Attack up";
                this.AttackUp.UseVisualStyleBackColor = true;
                // 
                // AttackLeft
                // 
                this.AttackLeft.Location = new System.Drawing.Point(12, 371);
                this.AttackLeft.Name = "AttackLeft";
                this.AttackLeft.Size = new System.Drawing.Size(94, 50);
                this.AttackLeft.TabIndex = 8;
                this.AttackLeft.Text = "Attack Left";
                this.AttackLeft.UseVisualStyleBackColor = true;
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
                // GameView
                // 
                this.AccessibleName = "GameView";
                this.ClientSize = new System.Drawing.Size(914, 505);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.PlayerStats_lbl);
                this.Controls.Add(this.MapLabel);
                this.Controls.Add(this.AttackLeft);
                this.Controls.Add(this.AttackRight);
                this.Controls.Add(this.AttackDown);
                this.Controls.Add(this.AttackUp);
                this.Controls.Add(this.MoveLeft);
                this.Controls.Add(this.MoveRight);
                this.Controls.Add(this.MoveDown);
                this.Controls.Add(this.MoveUP);
                this.Name = "GameView";
                this.Text = "GAMEVIEW";
                this.ResumeLayout(false);
                this.PerformLayout();

            

        }

        #endregion



        private StatusStrip statusStrip1;
    }
}