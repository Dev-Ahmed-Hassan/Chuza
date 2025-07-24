namespace Rock_Paper_Scisor
{
    partial class Form1
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
            btnR = new Button();
            btnP = new Button();
            btnS = new Button();
            CPUPIC = new PictureBox();
            PLAYER_PIC = new PictureBox();
            lb1 = new Label();
            lb2 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)CPUPIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).BeginInit();
            SuspendLayout();
            // 
            // btnR
            // 
            btnR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnR.Location = new Point(49, 381);
            btnR.Name = "btnR";
            btnR.Size = new Size(108, 37);
            btnR.TabIndex = 1;
            btnR.Tag = "R";
            btnR.Text = "Rock";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += MakeChoiceEvent;
            // 
            // btnP
            // 
            btnP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnP.Location = new Point(329, 381);
            btnP.Name = "btnP";
            btnP.Size = new Size(108, 37);
            btnP.TabIndex = 2;
            btnP.Tag = "P";
            btnP.Text = "Paper";
            btnP.UseVisualStyleBackColor = true;
            btnP.Click += MakeChoiceEvent;
            // 
            // btnS
            // 
            btnS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnS.Location = new Point(614, 381);
            btnS.Name = "btnS";
            btnS.Size = new Size(108, 37);
            btnS.TabIndex = 3;
            btnS.Tag = "S";
            btnS.Text = "Scissor";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += MakeChoiceEvent;
            // 
            // CPUPIC
            // 
            CPUPIC.Location = new Point(337, 51);
            CPUPIC.Name = "CPUPIC";
            CPUPIC.Size = new Size(100, 100);
            CPUPIC.SizeMode = PictureBoxSizeMode.Zoom;
            CPUPIC.TabIndex = 4;
            CPUPIC.TabStop = false;
            // 
            // PLAYER_PIC
            // 
            PLAYER_PIC.Location = new Point(337, 231);
            PLAYER_PIC.Name = "PLAYER_PIC";
            PLAYER_PIC.Size = new Size(100, 100);
            PLAYER_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            PLAYER_PIC.TabIndex = 6;
            PLAYER_PIC.TabStop = false;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.Location = new Point(318, 9);
            lb1.Name = "lb1";
            lb1.Size = new Size(138, 21);
            lb1.TabIndex = 7;
            lb1.Text = "Computer Choice";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb2.Location = new Point(329, 346);
            lb2.Name = "lb2";
            lb2.Size = new Size(108, 21);
            lb2.TabIndex = 8;
            lb2.Text = "Player Choice";
            lb2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 158);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 9;
            label1.Text = "Player Result";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(614, 158);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 10;
            label2.Text = "Computer Result";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(PLAYER_PIC);
            Controls.Add(CPUPIC);
            Controls.Add(btnS);
            Controls.Add(btnP);
            Controls.Add(btnR);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CPUPIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnR;
        private Button btnP;
        private Button btnS;
        private PictureBox CPU_PIC;
        private PictureBox CPUPIC;
        private PictureBox PLAYER_PIC;
        private Label lb1;
        private Label lb2;
        private Label label1;
        private Label label2;
    }
}
