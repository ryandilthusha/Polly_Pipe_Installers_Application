
namespace Polly_Pipe
{
    partial class EmployeeTypes_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTypes_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_medicines = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgv_employee_types = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_employee_typeID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_employee_type = new System.Windows.Forms.TextBox();
            this.btn_Clear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel_medicines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee_types)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_medicines
            // 
            this.panel_medicines.BackColor = System.Drawing.Color.White;
            this.panel_medicines.Controls.Add(this.label17);
            this.panel_medicines.Controls.Add(this.label8);
            this.panel_medicines.Controls.Add(this.btn_back);
            this.panel_medicines.Controls.Add(this.dgv_employee_types);
            this.panel_medicines.Controls.Add(this.bunifuGradientPanel1);
            this.panel_medicines.Controls.Add(this.btn_Clear);
            this.panel_medicines.Controls.Add(this.btn_Delete);
            this.panel_medicines.Controls.Add(this.btn_Edit);
            this.panel_medicines.Controls.Add(this.btn_Save);
            this.panel_medicines.Location = new System.Drawing.Point(65, 37);
            this.panel_medicines.Name = "panel_medicines";
            this.panel_medicines.Size = new System.Drawing.Size(698, 495);
            this.panel_medicines.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(627, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 22);
            this.label17.TabIndex = 25;
            this.label17.Text = "BACK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(405, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 30);
            this.label8.TabIndex = 24;
            this.label8.Text = "Employee Types";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageActive = null;
            this.btn_back.Location = new System.Drawing.Point(620, 406);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(64, 53);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 26;
            this.btn_back.TabStop = false;
            this.btn_back.Zoom = 10;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_employee_types
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_employee_types.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_employee_types.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employee_types.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_employee_types.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_employee_types.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employee_types.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_employee_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee_types.DoubleBuffered = true;
            this.dgv_employee_types.EnableHeadersVisualStyles = false;
            this.dgv_employee_types.HeaderBgColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_employee_types.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_employee_types.Location = new System.Drawing.Point(361, 99);
            this.dgv_employee_types.Name = "dgv_employee_types";
            this.dgv_employee_types.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_employee_types.Size = new System.Drawing.Size(251, 232);
            this.dgv_employee_types.TabIndex = 23;
            this.dgv_employee_types.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_types_CellContentClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.label24);
            this.bunifuGradientPanel1.Controls.Add(this.txt_employee_typeID);
            this.bunifuGradientPanel1.Controls.Add(this.label20);
            this.bunifuGradientPanel1.Controls.Add(this.label13);
            this.bunifuGradientPanel1.Controls.Add(this.txt_employee_type);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(73, 68);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(247, 263);
            this.bunifuGradientPanel1.TabIndex = 20;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(14, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 20);
            this.label24.TabIndex = 33;
            this.label24.Text = "Employee Type ID";
            // 
            // txt_employee_typeID
            // 
            this.txt_employee_typeID.Enabled = false;
            this.txt_employee_typeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employee_typeID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_employee_typeID.Location = new System.Drawing.Point(18, 30);
            this.txt_employee_typeID.Name = "txt_employee_typeID";
            this.txt_employee_typeID.Size = new System.Drawing.Size(86, 22);
            this.txt_employee_typeID.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(2, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 21);
            this.label20.TabIndex = 21;
            this.label20.Text = "Employee Type Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(17, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "Employee Type";
            // 
            // txt_employee_type
            // 
            this.txt_employee_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employee_type.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_employee_type.Location = new System.Drawing.Point(21, 144);
            this.txt_employee_type.Name = "txt_employee_type";
            this.txt_employee_type.Size = new System.Drawing.Size(170, 22);
            this.txt_employee_type.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.ActiveBorderThickness = 1;
            this.btn_Clear.ActiveCornerRadius = 20;
            this.btn_Clear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Clear.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Clear.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.ButtonText = "Clear";
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Clear.IdleBorderThickness = 2;
            this.btn_Clear.IdleCornerRadius = 20;
            this.btn_Clear.IdleFillColor = System.Drawing.Color.White;
            this.btn_Clear.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Clear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Clear.Location = new System.Drawing.Point(256, 406);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(138, 41);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.ActiveBorderThickness = 1;
            this.btn_Delete.ActiveCornerRadius = 20;
            this.btn_Delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Delete.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.IdleBorderThickness = 2;
            this.btn_Delete.IdleCornerRadius = 20;
            this.btn_Delete.IdleFillColor = System.Drawing.Color.White;
            this.btn_Delete.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.Location = new System.Drawing.Point(455, 339);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(138, 41);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ActiveBorderThickness = 1;
            this.btn_Edit.ActiveCornerRadius = 20;
            this.btn_Edit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Edit.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Edit.BackColor = System.Drawing.Color.White;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.IdleBorderThickness = 2;
            this.btn_Edit.IdleCornerRadius = 20;
            this.btn_Edit.IdleFillColor = System.Drawing.Color.White;
            this.btn_Edit.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Edit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.Location = new System.Drawing.Point(256, 339);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(138, 41);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ActiveBorderThickness = 1;
            this.btn_Save.ActiveCornerRadius = 20;
            this.btn_Save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Save.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.IdleBorderThickness = 2;
            this.btn_Save.IdleCornerRadius = 20;
            this.btn_Save.IdleFillColor = System.Drawing.Color.White;
            this.btn_Save.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.Location = new System.Drawing.Point(73, 339);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(138, 41);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // EmployeeTypes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(847, 593);
            this.Controls.Add(this.panel_medicines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeTypes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeTypes_Form";
            this.panel_medicines.ResumeLayout(false);
            this.panel_medicines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee_types)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_medicines;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_employee_typeID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_employee_type;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Clear;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Delete;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Save;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_employee_types;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuImageButton btn_back;
    }
}