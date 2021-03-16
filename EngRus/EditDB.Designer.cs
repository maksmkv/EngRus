
namespace EngRus
{
    partial class EditDB
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
            this.editDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addTransENG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addWordENG = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addWordRUS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addTransRUS = new System.Windows.Forms.TextBox();
            this.btnAddBD = new System.Windows.Forms.Button();
            this.btnDeleteBD = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LabelDesk = new System.Windows.Forms.Label();
            this.addDescription = new System.Windows.Forms.TextBox();
            this.LabelLink = new System.Windows.Forms.Label();
            this.addLink = new System.Windows.Forms.TextBox();
            this.btnUpdateBD = new System.Windows.Forms.Button();
            this.btnEditStringBD = new System.Windows.Forms.Button();
            this.btnApplyChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // editDataGridView
            // 
            this.editDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editDataGridView.Location = new System.Drawing.Point(12, 315);
            this.editDataGridView.Name = "editDataGridView";
            this.editDataGridView.Size = new System.Drawing.Size(776, 228);
            this.editDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Слово/фраза на английском:";
            // 
            // addTransENG
            // 
            this.addTransENG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTransENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTransENG.Location = new System.Drawing.Point(187, 46);
            this.addTransENG.Name = "addTransENG";
            this.addTransENG.Size = new System.Drawing.Size(583, 21);
            this.addTransENG.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Транскрипция английский:";
            // 
            // addWordENG
            // 
            this.addWordENG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addWordENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordENG.Location = new System.Drawing.Point(187, 19);
            this.addWordENG.Name = "addWordENG";
            this.addWordENG.Size = new System.Drawing.Size(583, 21);
            this.addWordENG.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addWordENG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addTransENG);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Английский:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addWordRUS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addTransRUS);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 75);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Русский:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Слово/фраза на русском:";
            // 
            // addWordRUS
            // 
            this.addWordRUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addWordRUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordRUS.Location = new System.Drawing.Point(187, 19);
            this.addWordRUS.Name = "addWordRUS";
            this.addWordRUS.Size = new System.Drawing.Size(583, 21);
            this.addWordRUS.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Транскрипция русская:";
            // 
            // addTransRUS
            // 
            this.addTransRUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTransRUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTransRUS.Location = new System.Drawing.Point(187, 46);
            this.addTransRUS.Name = "addTransRUS";
            this.addTransRUS.Size = new System.Drawing.Size(583, 21);
            this.addTransRUS.TabIndex = 2;
            // 
            // btnAddBD
            // 
            this.btnAddBD.Location = new System.Drawing.Point(12, 266);
            this.btnAddBD.Name = "btnAddBD";
            this.btnAddBD.Size = new System.Drawing.Size(186, 34);
            this.btnAddBD.TabIndex = 7;
            this.btnAddBD.Text = "Добавить слово/фразу в базу";
            this.btnAddBD.UseVisualStyleBackColor = true;
            this.btnAddBD.Click += new System.EventHandler(this.btnAddBD_Click);
            // 
            // btnDeleteBD
            // 
            this.btnDeleteBD.Location = new System.Drawing.Point(213, 266);
            this.btnDeleteBD.Name = "btnDeleteBD";
            this.btnDeleteBD.Size = new System.Drawing.Size(186, 34);
            this.btnDeleteBD.TabIndex = 8;
            this.btnDeleteBD.Text = "Удалить слово/фразу";
            this.btnDeleteBD.UseVisualStyleBackColor = true;
            this.btnDeleteBD.Click += new System.EventHandler(this.btnDeleteBD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.LabelDesk);
            this.groupBox3.Controls.Add(this.addDescription);
            this.groupBox3.Controls.Add(this.LabelLink);
            this.groupBox3.Controls.Add(this.addLink);
            this.groupBox3.Location = new System.Drawing.Point(12, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 75);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дополнительные поля:";
            // 
            // LabelDesk
            // 
            this.LabelDesk.AutoSize = true;
            this.LabelDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDesk.Location = new System.Drawing.Point(6, 15);
            this.LabelDesk.Name = "LabelDesk";
            this.LabelDesk.Size = new System.Drawing.Size(67, 15);
            this.LabelDesk.TabIndex = 1;
            this.LabelDesk.Text = "Описание:";
            // 
            // addDescription
            // 
            this.addDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDescription.Location = new System.Drawing.Point(187, 19);
            this.addDescription.Name = "addDescription";
            this.addDescription.Size = new System.Drawing.Size(583, 21);
            this.addDescription.TabIndex = 4;
            // 
            // LabelLink
            // 
            this.LabelLink.AutoSize = true;
            this.LabelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLink.Location = new System.Drawing.Point(6, 46);
            this.LabelLink.Name = "LabelLink";
            this.LabelLink.Size = new System.Drawing.Size(125, 15);
            this.LabelLink.TabIndex = 3;
            this.LabelLink.Text = "Ссылка на картинку:";
            // 
            // addLink
            // 
            this.addLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLink.Location = new System.Drawing.Point(187, 46);
            this.addLink.Name = "addLink";
            this.addLink.Size = new System.Drawing.Size(583, 21);
            this.addLink.TabIndex = 2;
            // 
            // btnUpdateBD
            // 
            this.btnUpdateBD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBD.Location = new System.Drawing.Point(602, 266);
            this.btnUpdateBD.Name = "btnUpdateBD";
            this.btnUpdateBD.Size = new System.Drawing.Size(186, 34);
            this.btnUpdateBD.TabIndex = 9;
            this.btnUpdateBD.Text = "Обновить базу";
            this.btnUpdateBD.UseVisualStyleBackColor = true;
            this.btnUpdateBD.Click += new System.EventHandler(this.btnUpdateBD_Click);
            // 
            // btnEditStringBD
            // 
            this.btnEditStringBD.Location = new System.Drawing.Point(405, 266);
            this.btnEditStringBD.Name = "btnEditStringBD";
            this.btnEditStringBD.Size = new System.Drawing.Size(186, 34);
            this.btnEditStringBD.TabIndex = 10;
            this.btnEditStringBD.Text = "Редактировать строку";
            this.btnEditStringBD.UseVisualStyleBackColor = true;
            this.btnEditStringBD.Click += new System.EventHandler(this.btnEditStringBD_Click);
            // 
            // btnApplyChange
            // 
            this.btnApplyChange.Location = new System.Drawing.Point(213, 266);
            this.btnApplyChange.Name = "btnApplyChange";
            this.btnApplyChange.Size = new System.Drawing.Size(186, 34);
            this.btnApplyChange.TabIndex = 11;
            this.btnApplyChange.Text = "Применить";
            this.btnApplyChange.UseVisualStyleBackColor = true;
            this.btnApplyChange.Visible = false;
            this.btnApplyChange.Click += new System.EventHandler(this.btnApplyChange_Click);
            // 
            // EditDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.btnApplyChange);
            this.Controls.Add(this.btnEditStringBD);
            this.Controls.Add(this.btnUpdateBD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDeleteBD);
            this.Controls.Add(this.btnAddBD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editDataGridView);
            this.Name = "EditDB";
            this.Text = "Редактор БД";
            this.Load += new System.EventHandler(this.EditDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView editDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addTransENG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addWordENG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addWordRUS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addTransRUS;
        private System.Windows.Forms.Button btnAddBD;
        private System.Windows.Forms.Button btnDeleteBD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LabelDesk;
        private System.Windows.Forms.TextBox addDescription;
        private System.Windows.Forms.Label LabelLink;
        private System.Windows.Forms.TextBox addLink;
        private System.Windows.Forms.Button btnUpdateBD;
        private System.Windows.Forms.Button btnEditStringBD;
        private System.Windows.Forms.Button btnApplyChange;
    }
}