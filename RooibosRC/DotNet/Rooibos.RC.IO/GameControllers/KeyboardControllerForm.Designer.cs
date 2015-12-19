namespace Rooibos.RC.IO.GameControllers
{
    partial class KeyboardControllerForm
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
            this.btnPowerDown = new System.Windows.Forms.Button();
            this.btnPowerUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.buttonRudderLeft = new System.Windows.Forms.Button();
            this.buttonRudderRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPowerDown
            // 
            this.btnPowerDown.Location = new System.Drawing.Point(509, 113);
            this.btnPowerDown.Name = "btnPowerDown";
            this.btnPowerDown.Size = new System.Drawing.Size(75, 61);
            this.btnPowerDown.TabIndex = 17;
            this.btnPowerDown.Text = "L";
            this.btnPowerDown.UseVisualStyleBackColor = true;
            this.btnPowerDown.Click += new System.EventHandler(this.btnPowerDown_Click);
            // 
            // btnPowerUp
            // 
            this.btnPowerUp.Location = new System.Drawing.Point(509, 46);
            this.btnPowerUp.Name = "btnPowerUp";
            this.btnPowerUp.Size = new System.Drawing.Size(75, 61);
            this.btnPowerUp.TabIndex = 16;
            this.btnPowerUp.Text = "P";
            this.btnPowerUp.UseVisualStyleBackColor = true;
            this.btnPowerUp.Click += new System.EventHandler(this.btnPowerUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(187, 96);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 61);
            this.btnRight.TabIndex = 15;
            this.btnRight.Text = "D";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(25, 96);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 61);
            this.btnLeft.TabIndex = 14;
            this.btnLeft.Text = "A";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(106, 130);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 61);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "S";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(106, 63);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 61);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "W";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // buttonRudderLeft
            // 
            this.buttonRudderLeft.Location = new System.Drawing.Point(299, 205);
            this.buttonRudderLeft.Name = "buttonRudderLeft";
            this.buttonRudderLeft.Size = new System.Drawing.Size(75, 61);
            this.buttonRudderLeft.TabIndex = 19;
            this.buttonRudderLeft.Text = "H";
            this.buttonRudderLeft.UseVisualStyleBackColor = true;
            this.buttonRudderLeft.Click += new System.EventHandler(this.buttonRudderLeft_Click);
            // 
            // buttonRudderRight
            // 
            this.buttonRudderRight.Location = new System.Drawing.Point(380, 205);
            this.buttonRudderRight.Name = "buttonRudderRight";
            this.buttonRudderRight.Size = new System.Drawing.Size(75, 61);
            this.buttonRudderRight.TabIndex = 18;
            this.buttonRudderRight.Text = "J";
            this.buttonRudderRight.UseVisualStyleBackColor = true;
            this.buttonRudderRight.Click += new System.EventHandler(this.buttonRudderRight_Click);
            // 
            // KeyboardControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 295);
            this.Controls.Add(this.buttonRudderLeft);
            this.Controls.Add(this.buttonRudderRight);
            this.Controls.Add(this.btnPowerDown);
            this.Controls.Add(this.btnPowerUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "KeyboardControllerForm";
            this.Text = "KeyboardControllerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPowerDown;
        private System.Windows.Forms.Button btnPowerUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button buttonRudderLeft;
        private System.Windows.Forms.Button buttonRudderRight;
    }
}