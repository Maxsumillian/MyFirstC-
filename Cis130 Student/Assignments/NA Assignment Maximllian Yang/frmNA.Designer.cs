namespace NA_Assignment_Maximllian_Yang
{
    partial class frmNA
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
            lblHelloWorld = new Label();
            lblName = new Label();
            lblFood = new Label();
            btnShow = new Button();
            btnHide = new Button();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHelloWorld.Location = new Point(104, 81);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(166, 32);
            lblHelloWorld.TabIndex = 0;
            lblHelloWorld.Text = "Hello, World!";
            lblHelloWorld.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(210, 153);
            lblName.Name = "lblName";
            lblName.Size = new Size(349, 32);
            lblName.TabIndex = 1;
            lblName.Text = "My name is Maximillian Yang";
            lblName.Click += label2_Click;
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFood.Location = new Point(406, 222);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(301, 32);
            lblFood.TabIndex = 2;
            lblFood.Text = "My Favorite food is Steak";
            lblFood.Click += label3_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(177, 312);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 3;
            btnShow.Text = "&Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button1_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(536, 312);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(75, 23);
            btnHide.TabIndex = 4;
            btnHide.Text = "&Hide";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // frmNA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(lblFood);
            Controls.Add(lblName);
            Controls.Add(lblHelloWorld);
            Name = "frmNA";
            Text = "NA Assignment - Maximillian Yang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloWorld;
        private Label lblName;
        private Label lblFood;
        private Button btnShow;
        private Button btnHide;
    }
}
