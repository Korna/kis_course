namespace kis_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listRoute = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textLength = new System.Windows.Forms.TextBox();
            this.textStart = new System.Windows.Forms.TextBox();
            this.textEnd = new System.Windows.Forms.TextBox();
            this.textRouteNum = new System.Windows.Forms.TextBox();
            this.textCountryID = new System.Windows.Forms.TextBox();
            this.textCoordinates = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonIDK = new System.Windows.Forms.Button();
            this.textSort = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRoute
            // 
            this.listRoute.FormattingEnabled = true;
            this.listRoute.Location = new System.Drawing.Point(12, 12);
            this.listRoute.Name = "listRoute";
            this.listRoute.Size = new System.Drawing.Size(294, 160);
            this.listRoute.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 178);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "ShowKey";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.buttonShow);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(112, 207);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(79, 12);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(100, 20);
            this.textLength.TabIndex = 4;
            this.textLength.Text = "1800";
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(79, 38);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(100, 20);
            this.textStart.TabIndex = 5;
            this.textStart.Text = "starterrino";
            // 
            // textEnd
            // 
            this.textEnd.Location = new System.Drawing.Point(79, 64);
            this.textEnd.Name = "textEnd";
            this.textEnd.Size = new System.Drawing.Size(100, 20);
            this.textEnd.TabIndex = 6;
            this.textEnd.Text = "endinno";
            // 
            // textRouteNum
            // 
            this.textRouteNum.Location = new System.Drawing.Point(79, 90);
            this.textRouteNum.Name = "textRouteNum";
            this.textRouteNum.Size = new System.Drawing.Size(100, 20);
            this.textRouteNum.TabIndex = 7;
            // 
            // textCountryID
            // 
            this.textCountryID.Location = new System.Drawing.Point(79, 116);
            this.textCountryID.Name = "textCountryID";
            this.textCountryID.Size = new System.Drawing.Size(100, 20);
            this.textCountryID.TabIndex = 8;
            this.textCountryID.Text = "5";
            // 
            // textCoordinates
            // 
            this.textCoordinates.Location = new System.Drawing.Point(79, 142);
            this.textCoordinates.Name = "textCoordinates";
            this.textCoordinates.Size = new System.Drawing.Size(100, 20);
            this.textCoordinates.TabIndex = 9;
            this.textCoordinates.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "end";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "routeNum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "countryID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "coordinates";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(288, 360);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(119, 20);
            this.textBox7.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "sum of paths";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSum);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textLength);
            this.panel1.Controls.Add(this.textStart);
            this.panel1.Controls.Add(this.textEnd);
            this.panel1.Controls.Add(this.textRouteNum);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textCountryID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textCoordinates);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(377, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 171);
            this.panel1.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "delete(num)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDelete);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(319, 236);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(203, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonAdd);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(599, 339);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(111, 33);
            this.buttonCreate.TabIndex = 23;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(602, 378);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(108, 31);
            this.buttonDrop.TabIndex = 24;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // buttonIDK
            // 
            this.buttonIDK.Location = new System.Drawing.Point(112, 178);
            this.buttonIDK.Name = "buttonIDK";
            this.buttonIDK.Size = new System.Drawing.Size(75, 23);
            this.buttonIDK.TabIndex = 25;
            this.buttonIDK.Text = "ShowIDK";
            this.buttonIDK.UseVisualStyleBackColor = true;
            this.buttonIDK.Click += new System.EventHandler(this.buttonIDK_Click);
            // 
            // textSort
            // 
            this.textSort.Location = new System.Drawing.Point(193, 178);
            this.textSort.Name = "textSort";
            this.textSort.Size = new System.Drawing.Size(113, 20);
            this.textSort.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 421);
            this.Controls.Add(this.textSort);
            this.Controls.Add(this.buttonIDK);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.listRoute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRoute;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.TextBox textEnd;
        private System.Windows.Forms.TextBox textRouteNum;
        private System.Windows.Forms.TextBox textCountryID;
        private System.Windows.Forms.TextBox textCoordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Button buttonIDK;
        private System.Windows.Forms.TextBox textSort;
    }
}

