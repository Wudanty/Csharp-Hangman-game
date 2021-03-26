namespace Wisielec
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.labelLetter = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelWordView = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBoxHG = new System.Windows.Forms.PictureBox();
            this.timerGameState = new System.Timers.Timer();
            this.LabelWordTextBox = new System.Windows.Forms.Label();
            this.labelGameResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerGameState)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(14, 75);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(88, 27);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(14, 44);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(185, 23);
            this.textBoxWord.TabIndex = 1;
            this.textBoxWord.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Location = new System.Drawing.Point(25, 171);
            this.textBoxLetter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(25, 23);
            this.textBoxLetter.TabIndex = 4;
            // 
            // labelLetter
            // 
            this.labelLetter.Location = new System.Drawing.Point(14, 151);
            this.labelLetter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLetter.Name = "labelLetter";
            this.labelLetter.Size = new System.Drawing.Size(117, 16);
            this.labelLetter.TabIndex = 5;
            this.labelLetter.Text = "Write a letter.";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(14, 201);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(88, 27);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // labelWordView
            // 
            this.labelWordView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWordView.Location = new System.Drawing.Point(372, 44);
            this.labelWordView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWordView.Name = "labelWordView";
            this.labelWordView.Size = new System.Drawing.Size(315, 148);
            this.labelWordView.TabIndex = 7;
            this.labelWordView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(112, 75);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 27);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBoxHG
            // 
            this.pictureBoxHG.Location = new System.Drawing.Point(406, 269);
            this.pictureBoxHG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxHG.Name = "pictureBoxHG";
            this.pictureBoxHG.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxHG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHG.TabIndex = 9;
            this.pictureBoxHG.TabStop = false;
            // 
            // timerGameState
            // 
            this.timerGameState.Enabled = true;
            this.timerGameState.SynchronizingObject = this;
            this.timerGameState.Elapsed += new System.Timers.ElapsedEventHandler(this.timerGameState_Elapsed);
            // 
            // LabelWordTextBox
            // 
            this.LabelWordTextBox.Location = new System.Drawing.Point(14, 21);
            this.LabelWordTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWordTextBox.Name = "LabelWordTextBox";
            this.LabelWordTextBox.Size = new System.Drawing.Size(186, 20);
            this.LabelWordTextBox.TabIndex = 10;
            this.LabelWordTextBox.Text = "Enter your word/sentence here.";
            // 
            // labelGameResult
            // 
            this.labelGameResult.AutoSize = true;
            this.labelGameResult.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGameResult.Location = new System.Drawing.Point(25, 323);
            this.labelGameResult.Name = "labelGameResult";
            this.labelGameResult.Size = new System.Drawing.Size(0, 65);
            this.labelGameResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 516);
            this.Controls.Add(this.labelGameResult);
            this.Controls.Add(this.LabelWordTextBox);
            this.Controls.Add(this.pictureBoxHG);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelWordView);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelLetter);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerGameState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LabelWordTextBox;

        private System.Timers.Timer timerGameState;

        private System.Windows.Forms.PictureBox pictureBoxHG;

        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.Label labelWordView;

        private System.Windows.Forms.Button buttonCheck;

        private System.Windows.Forms.Label labelLetter;
        private System.Windows.Forms.TextBox textBoxLetter;

        private System.Windows.Forms.TextBox textBoxWord;

        private System.Windows.Forms.Button buttonStart;

        #endregion

        private System.Windows.Forms.Label labelGameResult;
    }
}