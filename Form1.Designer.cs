namespace CarProject
{
    partial class carForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carForm));
            this.setNameButton = new System.Windows.Forms.Button();
            this.driveButton = new System.Windows.Forms.Button();
            this.carNameButton = new System.Windows.Forms.Button();
            this.getGasButton = new System.Windows.Forms.Button();
            this.checkFuelButton = new System.Windows.Forms.Button();
            this.milesButton = new System.Windows.Forms.Button();
            this.mpgButton = new System.Windows.Forms.Button();
            this.checkSpeedButton = new System.Windows.Forms.Button();
            this.setSpeedButton = new System.Windows.Forms.Button();
            this.tankCapacityButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // setNameButton
            // 
            this.setNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setNameButton.Location = new System.Drawing.Point(522, 169);
            this.setNameButton.Name = "setNameButton";
            this.setNameButton.Size = new System.Drawing.Size(75, 39);
            this.setNameButton.TabIndex = 1;
            this.setNameButton.Text = "Set Car Name";
            this.setNameButton.UseVisualStyleBackColor = true;
            this.setNameButton.Click += new System.EventHandler(this.setNameButton_Click);
            // 
            // driveButton
            // 
            this.driveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveButton.Location = new System.Drawing.Point(1, 286);
            this.driveButton.Name = "driveButton";
            this.driveButton.Size = new System.Drawing.Size(69, 44);
            this.driveButton.TabIndex = 2;
            this.driveButton.Text = "Drive";
            this.driveButton.UseVisualStyleBackColor = true;
            this.driveButton.Click += new System.EventHandler(this.driveButton_Click);
            // 
            // carNameButton
            // 
            this.carNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameButton.Location = new System.Drawing.Point(441, 169);
            this.carNameButton.Name = "carNameButton";
            this.carNameButton.Size = new System.Drawing.Size(75, 39);
            this.carNameButton.TabIndex = 3;
            this.carNameButton.Text = "Check Car Name";
            this.carNameButton.UseVisualStyleBackColor = true;
            this.carNameButton.Click += new System.EventHandler(this.carNameButton_Click);
            // 
            // getGasButton
            // 
            this.getGasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getGasButton.Location = new System.Drawing.Point(250, 248);
            this.getGasButton.Name = "getGasButton";
            this.getGasButton.Size = new System.Drawing.Size(68, 32);
            this.getGasButton.TabIndex = 4;
            this.getGasButton.Text = "Get Gas";
            this.getGasButton.UseVisualStyleBackColor = true;
            this.getGasButton.Click += new System.EventHandler(this.getGasButton_Click);
            // 
            // checkFuelButton
            // 
            this.checkFuelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFuelButton.Location = new System.Drawing.Point(110, 248);
            this.checkFuelButton.Name = "checkFuelButton";
            this.checkFuelButton.Size = new System.Drawing.Size(42, 54);
            this.checkFuelButton.TabIndex = 5;
            this.checkFuelButton.Text = "Check Fuel";
            this.checkFuelButton.UseVisualStyleBackColor = true;
            this.checkFuelButton.Click += new System.EventHandler(this.checkFuelButton_Click);
            // 
            // milesButton
            // 
            this.milesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesButton.Location = new System.Drawing.Point(312, 248);
            this.milesButton.Name = "milesButton";
            this.milesButton.Size = new System.Drawing.Size(56, 68);
            this.milesButton.TabIndex = 7;
            this.milesButton.Text = "Miles Driven";
            this.milesButton.UseVisualStyleBackColor = true;
            this.milesButton.Click += new System.EventHandler(this.milesButton_Click);
            // 
            // mpgButton
            // 
            this.mpgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpgButton.Location = new System.Drawing.Point(250, 277);
            this.mpgButton.Name = "mpgButton";
            this.mpgButton.Size = new System.Drawing.Size(68, 39);
            this.mpgButton.TabIndex = 8;
            this.mpgButton.Text = "MPG";
            this.mpgButton.UseVisualStyleBackColor = true;
            this.mpgButton.Click += new System.EventHandler(this.mpgButton_Click);
            // 
            // checkSpeedButton
            // 
            this.checkSpeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSpeedButton.Location = new System.Drawing.Point(165, 335);
            this.checkSpeedButton.Name = "checkSpeedButton";
            this.checkSpeedButton.Size = new System.Drawing.Size(112, 30);
            this.checkSpeedButton.TabIndex = 9;
            this.checkSpeedButton.Text = "Check Speed";
            this.checkSpeedButton.UseVisualStyleBackColor = true;
            this.checkSpeedButton.Click += new System.EventHandler(this.checkSpeedButton_Click);
            // 
            // setSpeedButton
            // 
            this.setSpeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSpeedButton.Location = new System.Drawing.Point(334, 335);
            this.setSpeedButton.Name = "setSpeedButton";
            this.setSpeedButton.Size = new System.Drawing.Size(112, 30);
            this.setSpeedButton.TabIndex = 10;
            this.setSpeedButton.Text = "Set Speed";
            this.setSpeedButton.UseVisualStyleBackColor = true;
            this.setSpeedButton.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // tankCapacityButton
            // 
            this.tankCapacityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tankCapacityButton.Location = new System.Drawing.Point(165, 169);
            this.tankCapacityButton.Name = "tankCapacityButton";
            this.tankCapacityButton.Size = new System.Drawing.Size(72, 39);
            this.tankCapacityButton.TabIndex = 11;
            this.tankCapacityButton.Text = "Tank Capacity";
            this.tankCapacityButton.UseVisualStyleBackColor = true;
            this.tankCapacityButton.Click += new System.EventHandler(this.tankCapacityButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "road5.PNG");
            this.imageList1.Images.SetKeyName(1, "road4.PNG");
            this.imageList1.Images.SetKeyName(2, "road3.PNG");
            this.imageList1.Images.SetKeyName(3, "road2.PNG");
            this.imageList1.Images.SetKeyName(4, "road1.PNG");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // carForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tankCapacityButton);
            this.Controls.Add(this.setSpeedButton);
            this.Controls.Add(this.checkSpeedButton);
            this.Controls.Add(this.mpgButton);
            this.Controls.Add(this.milesButton);
            this.Controls.Add(this.checkFuelButton);
            this.Controls.Add(this.getGasButton);
            this.Controls.Add(this.carNameButton);
            this.Controls.Add(this.driveButton);
            this.Controls.Add(this.setNameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "carForm";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.carForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button setNameButton;
        private System.Windows.Forms.Button driveButton;
        private System.Windows.Forms.Button carNameButton;
        private System.Windows.Forms.Button getGasButton;
        private System.Windows.Forms.Button checkFuelButton;
        private System.Windows.Forms.Button milesButton;
        private System.Windows.Forms.Button mpgButton;
        private System.Windows.Forms.Button checkSpeedButton;
        private System.Windows.Forms.Button setSpeedButton;
        private System.Windows.Forms.Button tankCapacityButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

