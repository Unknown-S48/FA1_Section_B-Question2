namespace Section_B_Question_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitel = new Label();
            lblName = new Label();
            lblID = new Label();
            lblCitizen = new Label();
            lblResults = new Label();
            btnValidateId = new Button();
            btnGenPrf = new Button();
            txtBoxIdNum = new TextBox();
            txtBoxName = new TextBox();
            lsBoxSummary = new ListBox();
            cmbBoxCitizen = new ComboBox();
            ImgMain = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImgMain).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(475, 28);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(211, 15);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Home Affairs Digital Identity Processor";
            lblTitel.Click += lblTital_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(410, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your Name:";
            lblName.Click += lblName_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(410, 115);
            lblID.Name = "lblID";
            lblID.Size = new Size(78, 15);
            lblID.TabIndex = 2;
            lblID.Text = "Enter your ID:";
            lblID.Click += lblID_Click;
            // 
            // lblCitizen
            // 
            lblCitizen.AutoSize = true;
            lblCitizen.Location = new Point(410, 164);
            lblCitizen.Name = "lblCitizen";
            lblCitizen.Size = new Size(116, 15);
            lblCitizen.TabIndex = 3;
            lblCitizen.Text = "Choose your Citizen:";
            lblCitizen.Click += lblCitizen_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(598, 270);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 15);
            lblResults.TabIndex = 4;
            // 
            // btnValidateId
            // 
            btnValidateId.Location = new Point(636, 220);
            btnValidateId.Name = "btnValidateId";
            btnValidateId.Size = new Size(103, 28);
            btnValidateId.TabIndex = 5;
            btnValidateId.Text = "Validate ID";
            btnValidateId.UseVisualStyleBackColor = true;
            btnValidateId.Click += btnValidateId_Click;
            // 
            // btnGenPrf
            // 
            btnGenPrf.Location = new Point(636, 475);
            btnGenPrf.Name = "btnGenPrf";
            btnGenPrf.Size = new Size(103, 28);
            btnGenPrf.TabIndex = 6;
            btnGenPrf.Text = "Generate Profile";
            btnGenPrf.UseVisualStyleBackColor = true;
            btnGenPrf.Click += btnGenPrf_Click;
            // 
            // txtBoxIdNum
            // 
            txtBoxIdNum.Location = new Point(564, 112);
            txtBoxIdNum.Name = "txtBoxIdNum";
            txtBoxIdNum.PlaceholderText = "1234567890000";
            txtBoxIdNum.Size = new Size(227, 23);
            txtBoxIdNum.TabIndex = 7;
            txtBoxIdNum.TextChanged += txtBoxIdNum_TextChanged;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(564, 64);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "Name Surname";
            txtBoxName.Size = new Size(227, 23);
            txtBoxName.TabIndex = 8;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            // 
            // lsBoxSummary
            // 
            lsBoxSummary.FormattingEnabled = true;
            lsBoxSummary.Location = new Point(564, 300);
            lsBoxSummary.Name = "lsBoxSummary";
            lsBoxSummary.Size = new Size(227, 154);
            lsBoxSummary.TabIndex = 9;
            lsBoxSummary.SelectedIndexChanged += lsBoxSummary_SelectedIndexChanged;
            // 
            // cmbBoxCitizen
            // 
            cmbBoxCitizen.FormattingEnabled = true;
            cmbBoxCitizen.Location = new Point(564, 161);
            cmbBoxCitizen.Name = "cmbBoxCitizen";
            cmbBoxCitizen.Size = new Size(227, 23);
            cmbBoxCitizen.TabIndex = 10;
            cmbBoxCitizen.SelectedIndexChanged += cmbBoxCitizen_SelectedIndexChanged;
            // 
            // ImgMain
            // 
            ImgMain.Image = (Image)resources.GetObject("ImgMain.Image");
            ImgMain.Location = new Point(0, 48);
            ImgMain.Name = "ImgMain";
            ImgMain.Size = new Size(386, 513);
            ImgMain.TabIndex = 11;
            ImgMain.TabStop = false;
            ImgMain.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 610);
            Controls.Add(ImgMain);
            Controls.Add(cmbBoxCitizen);
            Controls.Add(lsBoxSummary);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxIdNum);
            Controls.Add(btnGenPrf);
            Controls.Add(btnValidateId);
            Controls.Add(lblResults);
            Controls.Add(lblCitizen);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblTitel);
            Name = "Form1";
            Text = "HomeAffairsDigitalIdentityProcessor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ImgMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblName;
        private Label lblID;
        private Label lblCitizen;
        private Label lblResults;
        private Button btnValidateId;
        private Button btnGenPrf;
        private TextBox txtBoxIdNum;
        private TextBox txtBoxName;
        private ListBox lsBoxSummary;
        private ComboBox cmbBoxCitizen;
        private PictureBox ImgMain;
    }
}
