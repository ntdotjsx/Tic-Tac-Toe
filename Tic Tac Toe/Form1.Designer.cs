namespace Tic_Tac_Toe
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
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            NewGame = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // A1
            // 
            A1.Location = new Point(12, 12);
            A1.Name = "A1";
            A1.Size = new Size(100, 100);
            A1.TabIndex = 0;
            A1.UseVisualStyleBackColor = true;
            A1.Click += A1_Click;
            A1.MouseEnter += button_enter;
            A1.MouseLeave += button_leave;
            // 
            // A2
            // 
            A2.Location = new Point(118, 12);
            A2.Name = "A2";
            A2.Size = new Size(100, 100);
            A2.TabIndex = 1;
            A2.UseVisualStyleBackColor = true;
            A2.Click += A2_Click;
            A2.MouseEnter += button_enter;
            A2.MouseLeave += button_leave;
            // 
            // A3
            // 
            A3.Location = new Point(224, 12);
            A3.Name = "A3";
            A3.Size = new Size(100, 100);
            A3.TabIndex = 2;
            A3.UseVisualStyleBackColor = true;
            A3.Click += A3_Click;
            A3.MouseEnter += button_enter;
            A3.MouseLeave += button_leave;
            // 
            // B1
            // 
            B1.Location = new Point(12, 118);
            B1.Name = "B1";
            B1.Size = new Size(100, 100);
            B1.TabIndex = 3;
            B1.UseVisualStyleBackColor = true;
            B1.Click += B1_Click;
            B1.MouseEnter += button_enter;
            B1.MouseLeave += button_leave;
            // 
            // B2
            // 
            B2.Location = new Point(118, 118);
            B2.Name = "B2";
            B2.Size = new Size(100, 100);
            B2.TabIndex = 4;
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            B2.MouseEnter += button_enter;
            B2.MouseLeave += button_leave;
            // 
            // B3
            // 
            B3.Location = new Point(224, 118);
            B3.Name = "B3";
            B3.Size = new Size(100, 100);
            B3.TabIndex = 5;
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            B3.MouseEnter += button_enter;
            B3.MouseLeave += button_leave;
            // 
            // C1
            // 
            C1.Location = new Point(12, 224);
            C1.Name = "C1";
            C1.Size = new Size(100, 100);
            C1.TabIndex = 6;
            C1.UseVisualStyleBackColor = true;
            C1.Click += C1_Click;
            C1.MouseEnter += button_enter;
            C1.MouseLeave += button_leave;
            // 
            // C2
            // 
            C2.Location = new Point(118, 224);
            C2.Name = "C2";
            C2.Size = new Size(100, 100);
            C2.TabIndex = 7;
            C2.UseVisualStyleBackColor = true;
            C2.Click += C2_Click;
            C2.MouseEnter += button_enter;
            C2.MouseLeave += button_leave;
            // 
            // C3
            // 
            C3.Location = new Point(224, 224);
            C3.Name = "C3";
            C3.Size = new Size(100, 100);
            C3.TabIndex = 8;
            C3.UseVisualStyleBackColor = true;
            C3.Click += C3_Click;
            C3.MouseEnter += button_enter;
            C3.MouseLeave += button_leave;
            // 
            // NewGame
            // 
            NewGame.Location = new Point(330, 180);
            NewGame.Name = "NewGame";
            NewGame.Size = new Size(114, 44);
            NewGame.TabIndex = 9;
            NewGame.Text = "New Game";
            NewGame.UseVisualStyleBackColor = true;
            NewGame.Click += NewGame_Click;
            // 
            // button1
            // 
            button1.Location = new Point(330, 230);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 10;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(330, 280);
            button2.Name = "button2";
            button2.Size = new Size(111, 44);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NewGame);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button NewGame;
        private Button button1;
        private Button button2;
    }
}