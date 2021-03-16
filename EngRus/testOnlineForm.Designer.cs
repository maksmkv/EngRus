
namespace EngRus
{
    partial class testOnlineForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.negativeStat = new System.Windows.Forms.Label();
            this.negativePictureBox = new System.Windows.Forms.PictureBox();
            this.possitivePictureBox = new System.Windows.Forms.PictureBox();
            this.positiveStat = new System.Windows.Forms.Label();
            this.engrusWord = new System.Windows.Forms.GroupBox();
            this.wordVisible = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hintGroupBox = new System.Windows.Forms.GroupBox();
            this.firstRusChar = new System.Windows.Forms.Label();
            this.trascriptionRusWord = new System.Windows.Forms.Label();
            this.trascriptionENWord = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.negativePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possitivePictureBox)).BeginInit();
            this.engrusWord.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.hintGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.negativeStat);
            this.groupBox1.Controls.Add(this.negativePictureBox);
            this.groupBox1.Controls.Add(this.possitivePictureBox);
            this.groupBox1.Controls.Add(this.positiveStat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика:";
            // 
            // negativeStat
            // 
            this.negativeStat.AutoSize = true;
            this.negativeStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negativeStat.Location = new System.Drawing.Point(231, 22);
            this.negativeStat.Name = "negativeStat";
            this.negativeStat.Size = new System.Drawing.Size(29, 31);
            this.negativeStat.TabIndex = 3;
            this.negativeStat.Text = "0";
            // 
            // negativePictureBox
            // 
            this.negativePictureBox.Image = global::EngRus.Properties.Resources.cross;
            this.negativePictureBox.Location = new System.Drawing.Point(190, 22);
            this.negativePictureBox.Name = "negativePictureBox";
            this.negativePictureBox.Size = new System.Drawing.Size(35, 35);
            this.negativePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.negativePictureBox.TabIndex = 2;
            this.negativePictureBox.TabStop = false;
            // 
            // possitivePictureBox
            // 
            this.possitivePictureBox.Image = global::EngRus.Properties.Resources.ok;
            this.possitivePictureBox.Location = new System.Drawing.Point(6, 22);
            this.possitivePictureBox.Name = "possitivePictureBox";
            this.possitivePictureBox.Size = new System.Drawing.Size(35, 35);
            this.possitivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.possitivePictureBox.TabIndex = 1;
            this.possitivePictureBox.TabStop = false;
            // 
            // positiveStat
            // 
            this.positiveStat.AutoSize = true;
            this.positiveStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positiveStat.Location = new System.Drawing.Point(47, 22);
            this.positiveStat.Name = "positiveStat";
            this.positiveStat.Size = new System.Drawing.Size(29, 31);
            this.positiveStat.TabIndex = 0;
            this.positiveStat.Text = "0";
            // 
            // engrusWord
            // 
            this.engrusWord.Controls.Add(this.wordVisible);
            this.engrusWord.Controls.Add(this.label1);
            this.engrusWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engrusWord.Location = new System.Drawing.Point(12, 84);
            this.engrusWord.Name = "engrusWord";
            this.engrusWord.Size = new System.Drawing.Size(321, 69);
            this.engrusWord.TabIndex = 1;
            this.engrusWord.TabStop = false;
            this.engrusWord.Text = "Фраза/слово:";
            // 
            // wordVisible
            // 
            this.wordVisible.AutoSize = true;
            this.wordVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordVisible.Location = new System.Drawing.Point(49, 24);
            this.wordVisible.Name = "wordVisible";
            this.wordVisible.Size = new System.Drawing.Size(229, 24);
            this.wordVisible.TabIndex = 2;
            this.wordVisible.Text = "Слово для отображения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.translateTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перевести:";
            // 
            // translateTextBox
            // 
            this.translateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translateTextBox.Location = new System.Drawing.Point(3, 19);
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.Size = new System.Drawing.Size(315, 23);
            this.translateTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Подтвердить выбор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Взять подсказку?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hintGroupBox
            // 
            this.hintGroupBox.Controls.Add(this.label2);
            this.hintGroupBox.Controls.Add(this.firstRusChar);
            this.hintGroupBox.Controls.Add(this.trascriptionRusWord);
            this.hintGroupBox.Controls.Add(this.trascriptionENWord);
            this.hintGroupBox.Controls.Add(this.label5);
            this.hintGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintGroupBox.Location = new System.Drawing.Point(12, 336);
            this.hintGroupBox.Name = "hintGroupBox";
            this.hintGroupBox.Size = new System.Drawing.Size(321, 91);
            this.hintGroupBox.TabIndex = 3;
            this.hintGroupBox.TabStop = false;
            this.hintGroupBox.Text = "Подсказка:";
            this.hintGroupBox.Visible = false;
            // 
            // firstRusChar
            // 
            this.firstRusChar.AutoSize = true;
            this.firstRusChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstRusChar.Location = new System.Drawing.Point(139, 24);
            this.firstRusChar.Name = "firstRusChar";
            this.firstRusChar.Size = new System.Drawing.Size(29, 17);
            this.firstRusChar.TabIndex = 4;
            this.firstRusChar.Text = "1-я";
            // 
            // trascriptionRusWord
            // 
            this.trascriptionRusWord.AutoSize = true;
            this.trascriptionRusWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trascriptionRusWord.Location = new System.Drawing.Point(186, 19);
            this.trascriptionRusWord.Name = "trascriptionRusWord";
            this.trascriptionRusWord.Size = new System.Drawing.Size(115, 20);
            this.trascriptionRusWord.TabIndex = 3;
            this.trascriptionRusWord.Text = "Транскрипция";
            // 
            // trascriptionENWord
            // 
            this.trascriptionENWord.AutoSize = true;
            this.trascriptionENWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trascriptionENWord.Location = new System.Drawing.Point(186, 51);
            this.trascriptionENWord.Name = "trascriptionENWord";
            this.trascriptionENWord.Size = new System.Drawing.Size(115, 20);
            this.trascriptionENWord.TabIndex = 2;
            this.trascriptionENWord.Text = "Транскрипция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "1-я буква в слове:";
            // 
            // testOnlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 439);
            this.Controls.Add(this.hintGroupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.engrusWord);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "testOnlineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.testOnlineForm_FormClosing);
            this.Load += new System.EventHandler(this.testOnlineForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.negativePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possitivePictureBox)).EndInit();
            this.engrusWord.ResumeLayout(false);
            this.engrusWord.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.hintGroupBox.ResumeLayout(false);
            this.hintGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label positiveStat;
        private System.Windows.Forms.PictureBox possitivePictureBox;
        private System.Windows.Forms.PictureBox negativePictureBox;
        private System.Windows.Forms.Label negativeStat;
        private System.Windows.Forms.GroupBox engrusWord;
        private System.Windows.Forms.Label wordVisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox translateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox hintGroupBox;
        private System.Windows.Forms.Label trascriptionENWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label trascriptionRusWord;
        private System.Windows.Forms.Label firstRusChar;
        private System.Windows.Forms.Label label2;
    }
}