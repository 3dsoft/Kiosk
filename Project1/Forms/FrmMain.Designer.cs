namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMenu4 = new System.Windows.Forms.Label();
            this.lblMenu3 = new System.Windows.Forms.Label();
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCartClear = new System.Windows.Forms.Button();
            this.btnCartCompute = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuDown = new System.Windows.Forms.Button();
            this.btnMenuUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(708, 490);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnMenuDown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMenuUp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(908, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 490);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblMenu4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblMenu3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblMenu2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMenu1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 762);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblMenu4
            // 
            this.lblMenu4.BackColor = System.Drawing.Color.Firebrick;
            this.lblMenu4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu4.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.lblMenu4.ForeColor = System.Drawing.Color.White;
            this.lblMenu4.Location = new System.Drawing.Point(10, 450);
            this.lblMenu4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu4.Name = "lblMenu4";
            this.lblMenu4.Size = new System.Drawing.Size(180, 100);
            this.lblMenu4.TabIndex = 4;
            this.lblMenu4.Text = "Side";
            this.lblMenu4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu4.Click += new System.EventHandler(this.LblMenu1_Click);
            this.lblMenu4.MouseLeave += new System.EventHandler(this.LblMenu1_MouseLeave);
            this.lblMenu4.MouseHover += new System.EventHandler(this.LblMenu1_MouseHover);
            // 
            // lblMenu3
            // 
            this.lblMenu3.BackColor = System.Drawing.Color.Firebrick;
            this.lblMenu3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu3.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.lblMenu3.ForeColor = System.Drawing.Color.White;
            this.lblMenu3.Location = new System.Drawing.Point(10, 350);
            this.lblMenu3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu3.Name = "lblMenu3";
            this.lblMenu3.Size = new System.Drawing.Size(180, 100);
            this.lblMenu3.TabIndex = 3;
            this.lblMenu3.Text = "Drink";
            this.lblMenu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu3.Click += new System.EventHandler(this.LblMenu1_Click);
            this.lblMenu3.MouseLeave += new System.EventHandler(this.LblMenu1_MouseLeave);
            this.lblMenu3.MouseHover += new System.EventHandler(this.LblMenu1_MouseHover);
            // 
            // lblMenu2
            // 
            this.lblMenu2.BackColor = System.Drawing.Color.Firebrick;
            this.lblMenu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu2.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.lblMenu2.ForeColor = System.Drawing.Color.White;
            this.lblMenu2.Location = new System.Drawing.Point(10, 250);
            this.lblMenu2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Size = new System.Drawing.Size(180, 100);
            this.lblMenu2.TabIndex = 2;
            this.lblMenu2.Text = "McMorning";
            this.lblMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu2.Click += new System.EventHandler(this.LblMenu1_Click);
            this.lblMenu2.MouseLeave += new System.EventHandler(this.LblMenu1_MouseLeave);
            this.lblMenu2.MouseHover += new System.EventHandler(this.LblMenu1_MouseHover);
            // 
            // lblMenu1
            // 
            this.lblMenu1.BackColor = System.Drawing.Color.Firebrick;
            this.lblMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu1.ForeColor = System.Drawing.Color.White;
            this.lblMenu1.Location = new System.Drawing.Point(10, 150);
            this.lblMenu1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(180, 100);
            this.lblMenu1.TabIndex = 1;
            this.lblMenu1.Text = "BURGER";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu1.Click += new System.EventHandler(this.LblMenu1_Click);
            this.lblMenu1.MouseLeave += new System.EventHandler(this.LblMenu1_MouseLeave);
            this.lblMenu1.MouseHover += new System.EventHandler(this.LblMenu1_MouseHover);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.OldLace;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(201, 490);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(9);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(567, 272);
            this.flowLayoutPanel2.TabIndex = 4;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCartClear);
            this.panel1.Controls.Add(this.btnCartCompute);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(771, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 237);
            this.panel1.TabIndex = 6;
            // 
            // btnCartClear
            // 
            this.btnCartClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCartClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCartClear.ForeColor = System.Drawing.Color.Black;
            this.btnCartClear.Location = new System.Drawing.Point(13, 179);
            this.btnCartClear.Name = "btnCartClear";
            this.btnCartClear.Size = new System.Drawing.Size(210, 51);
            this.btnCartClear.TabIndex = 5;
            this.btnCartClear.Text = "비 우 기";
            this.btnCartClear.UseVisualStyleBackColor = false;
            this.btnCartClear.Click += new System.EventHandler(this.BtnCartClear_Click);
            // 
            // btnCartCompute
            // 
            this.btnCartCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCartCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCartCompute.ForeColor = System.Drawing.Color.Black;
            this.btnCartCompute.Location = new System.Drawing.Point(13, 58);
            this.btnCartCompute.Name = "btnCartCompute";
            this.btnCartCompute.Size = new System.Drawing.Size(210, 115);
            this.btnCartCompute.TabIndex = 4;
            this.btnCartCompute.Text = "계  산";
            this.btnCartCompute.UseVisualStyleBackColor = false;
            this.btnCartCompute.Click += new System.EventHandler(this.BtnCartCompute_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.Location = new System.Drawing.Point(99, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 41);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "\\0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "총 금 액 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project1.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuDown
            // 
            this.btnMenuDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMenuDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuDown.FlatAppearance.BorderSize = 0;
            this.btnMenuDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDown.Image = global::Project1.Properties.Resources.down_arrow2;
            this.btnMenuDown.Location = new System.Drawing.Point(3, 247);
            this.btnMenuDown.Name = "btnMenuDown";
            this.btnMenuDown.Size = new System.Drawing.Size(94, 240);
            this.btnMenuDown.TabIndex = 1;
            this.btnMenuDown.UseVisualStyleBackColor = false;
            this.btnMenuDown.Click += new System.EventHandler(this.BtnMenuUp_Click);
            // 
            // btnMenuUp
            // 
            this.btnMenuUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMenuUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuUp.FlatAppearance.BorderSize = 0;
            this.btnMenuUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUp.Image = global::Project1.Properties.Resources.up_arrow2;
            this.btnMenuUp.Location = new System.Drawing.Point(3, 3);
            this.btnMenuUp.Name = "btnMenuUp";
            this.btnMenuUp.Size = new System.Drawing.Size(94, 238);
            this.btnMenuUp.TabIndex = 0;
            this.btnMenuUp.UseVisualStyleBackColor = false;
            this.btnMenuUp.Click += new System.EventHandler(this.BtnMenuUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1008, 762);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnMenuUp;
        private System.Windows.Forms.Button btnMenuDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenu4;
        private System.Windows.Forms.Label lblMenu3;
        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCartCompute;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCartClear;
    }
}

