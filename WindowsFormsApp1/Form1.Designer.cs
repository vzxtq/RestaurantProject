using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnShowReceipt;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.TextBox txtAddressLabel;
        private System.Windows.Forms.Label lblAddressDetails;
        private System.Windows.Forms.TextBox txtAddressDetails;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label lblAddresses;
        private System.Windows.Forms.ComboBox cmbAddresses;
        private System.Windows.Forms.Button btnEditAddress;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.RadioButton rdoPickup;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.Label lblDeliveryCost;
        private WindowsFormsApp1.RoundedPanel panelList;
        private WindowsFormsApp1.RoundedPanel panelDetails;
        private WindowsFormsApp1.RoundedPanel panelCustomer;
        private WindowsFormsApp1.RoundedPanel panelAddress;
        private WindowsFormsApp1.RoundedPanel panelDelivery;
        private WindowsFormsApp1.RoundedPanel panelOrders;
        private System.Windows.Forms.Label lblDishComments;
        private System.Windows.Forms.TextBox txtDishComment;
        private System.Windows.Forms.Label lblDishScore;
        private System.Windows.Forms.ComboBox cmbDishScore;
        private System.Windows.Forms.Button btnAddDishComment;
        private System.Windows.Forms.ListBox lstDishComments;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private WindowsFormsApp1.RoundedPanel panelGallery;
        public System.Windows.Forms.FlowLayoutPanel flowGallery;
        private System.Windows.Forms.Button btnUploadPhoto;
        private Color primaryColor = Color.FromArgb(63, 81, 181);
        private Color accentColor = Color.FromArgb(255, 64, 129);
        private Color backgroundLight = Color.FromArgb(250, 250, 250);
        private Color textDark = Color.FromArgb(33, 33, 33);
        private Color textLight = Color.FromArgb(250, 250, 250);

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelList = new WindowsFormsApp1.RoundedPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.panelDetails = new WindowsFormsApp1.RoundedPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.lblDishComments = new System.Windows.Forms.Label();
            this.txtDishComment = new System.Windows.Forms.TextBox();
            this.lblDishScore = new System.Windows.Forms.Label();
            this.cmbDishScore = new System.Windows.Forms.ComboBox();
            this.btnAddDishComment = new System.Windows.Forms.Button();
            this.lstDishComments = new System.Windows.Forms.ListBox();
            this.panelCustomer = new WindowsFormsApp1.RoundedPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panelAddress = new WindowsFormsApp1.RoundedPanel();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddressLabel = new System.Windows.Forms.TextBox();
            this.lblAddressDetails = new System.Windows.Forms.Label();
            this.txtAddressDetails = new System.Windows.Forms.TextBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.lblAddresses = new System.Windows.Forms.Label();
            this.cmbAddresses = new System.Windows.Forms.ComboBox();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.panelDelivery = new WindowsFormsApp1.RoundedPanel();
            this.rdoPickup = new System.Windows.Forms.RadioButton();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.panelOrders = new WindowsFormsApp1.RoundedPanel();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnShowReceipt = new System.Windows.Forms.Button();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.panelGallery = new WindowsFormsApp1.RoundedPanel();
            this.flowGallery = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelAddress.SuspendLayout();
            this.panelDelivery.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelGallery.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelList.BorderColor = System.Drawing.Color.Gray;
            this.panelList.BorderThickness = 2;
            this.panelList.Controls.Add(this.lblSearch);
            this.panelList.Controls.Add(this.txtSearch);
            this.panelList.Controls.Add(this.dgvDishes);
            this.panelList.CornerRadius = 18;
            this.panelList.Location = new System.Drawing.Point(20, 20);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(20);
            this.panelList.PanelBackColor = System.Drawing.Color.White;
            this.panelList.Size = new System.Drawing.Size(700, 480);
            this.panelList.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblSearch.Location = new System.Drawing.Point(10, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(140, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvDishes
            // 
            this.dgvDishes.AllowUserToAddRows = false;
            this.dgvDishes.AllowUserToDeleteRows = false;
            this.dgvDishes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDishes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDishes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDishes.ColumnHeadersHeight = 37;
            this.dgvDishes.EnableHeadersVisualStyles = false;
            this.dgvDishes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.dgvDishes.Location = new System.Drawing.Point(10, 50);
            this.dgvDishes.MultiSelect = false;
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.ReadOnly = true;
            this.dgvDishes.RowHeadersWidth = 66;
            this.dgvDishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishes.Size = new System.Drawing.Size(670, 410);
            this.dgvDishes.TabIndex = 0;
            this.dgvDishes.SelectionChanged += new System.EventHandler(this.dgvDishes_SelectionChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelDetails.BorderColor = System.Drawing.Color.Gray;
            this.panelDetails.BorderThickness = 2;
            this.panelDetails.Controls.Add(this.labelName);
            this.panelDetails.Controls.Add(this.txtName);
            this.panelDetails.Controls.Add(this.labelDescription);
            this.panelDetails.Controls.Add(this.txtDescription);
            this.panelDetails.Controls.Add(this.labelPrice);
            this.panelDetails.Controls.Add(this.txtPrice);
            this.panelDetails.Controls.Add(this.button1);
            this.panelDetails.Controls.Add(this.button2);
            this.panelDetails.Controls.Add(this.button3);
            this.panelDetails.Controls.Add(this.button4);
            this.panelDetails.Controls.Add(this.buttonLoad);
            this.panelDetails.Controls.Add(this.lblDishComments);
            this.panelDetails.Controls.Add(this.txtDishComment);
            this.panelDetails.Controls.Add(this.lblDishScore);
            this.panelDetails.Controls.Add(this.cmbDishScore);
            this.panelDetails.Controls.Add(this.btnAddDishComment);
            this.panelDetails.Controls.Add(this.lstDishComments);
            this.panelDetails.CornerRadius = 18;
            this.panelDetails.Location = new System.Drawing.Point(740, 20);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Padding = new System.Windows.Forms.Padding(20);
            this.panelDetails.PanelBackColor = System.Drawing.Color.White;
            this.panelDetails.Size = new System.Drawing.Size(420, 480);
            this.panelDetails.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labelName.Location = new System.Drawing.Point(20, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.Location = new System.Drawing.Point(120, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 39);
            this.txtName.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labelDescription.Location = new System.Drawing.Point(20, 65);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(143, 32);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.Location = new System.Drawing.Point(20, 95);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(370, 60);
            this.txtDescription.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labelPrice.Location = new System.Drawing.Point(20, 165);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(73, 32);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrice.Location = new System.Drawing.Point(120, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(270, 39);
            this.txtPrice.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(120, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(220, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(310, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Save to XML";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(20, 255);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(370, 36);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load from XML";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // lblDishComments
            // 
            this.lblDishComments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDishComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDishComments.Location = new System.Drawing.Point(20, 300);
            this.lblDishComments.Name = "lblDishComments";
            this.lblDishComments.Size = new System.Drawing.Size(200, 25);
            this.lblDishComments.TabIndex = 11;
            this.lblDishComments.Text = "Comments and Ratings:";
            // 
            // txtDishComment
            // 
            this.txtDishComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDishComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDishComment.Location = new System.Drawing.Point(20, 330);
            this.txtDishComment.Name = "txtDishComment";
            this.txtDishComment.Size = new System.Drawing.Size(150, 36);
            this.txtDishComment.TabIndex = 12;
            // 
            // lblDishScore
            // 
            this.lblDishScore.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDishScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDishScore.Location = new System.Drawing.Point(180, 330);
            this.lblDishScore.Name = "lblDishScore";
            this.lblDishScore.Size = new System.Drawing.Size(45, 32);
            this.lblDishScore.TabIndex = 13;
            this.lblDishScore.Text = "Score:";
            // 
            // cmbDishScore
            // 
            this.cmbDishScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDishScore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDishScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDishScore.Location = new System.Drawing.Point(225, 330);
            this.cmbDishScore.Name = "cmbDishScore";
            this.cmbDishScore.Size = new System.Drawing.Size(50, 38);
            this.cmbDishScore.TabIndex = 14;
            // 
            // btnAddDishComment
            // 
            this.btnAddDishComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnAddDishComment.FlatAppearance.BorderSize = 0;
            this.btnAddDishComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDishComment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDishComment.ForeColor = System.Drawing.Color.White;
            this.btnAddDishComment.Location = new System.Drawing.Point(280, 330);
            this.btnAddDishComment.Name = "btnAddDishComment";
            this.btnAddDishComment.Size = new System.Drawing.Size(50, 32);
            this.btnAddDishComment.TabIndex = 15;
            this.btnAddDishComment.Text = "Add";
            this.btnAddDishComment.UseVisualStyleBackColor = false;
            this.btnAddDishComment.Click += new System.EventHandler(this.btnAddDishComment_Click);
            // 
            // lstDishComments
            // 
            this.lstDishComments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstDishComments.ItemHeight = 25;
            this.lstDishComments.Location = new System.Drawing.Point(20, 370);
            this.lstDishComments.Name = "lstDishComments";
            this.lstDishComments.Size = new System.Drawing.Size(310, 54);
            this.lstDishComments.TabIndex = 16;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelCustomer.BorderColor = System.Drawing.Color.Gray;
            this.panelCustomer.BorderThickness = 2;
            this.panelCustomer.Controls.Add(this.lblUserName);
            this.panelCustomer.Controls.Add(this.txtUserName);
            this.panelCustomer.Controls.Add(this.btnAddUser);
            this.panelCustomer.Controls.Add(this.lblUsers);
            this.panelCustomer.Controls.Add(this.cmbUsers);
            this.panelCustomer.Controls.Add(this.btnEditUser);
            this.panelCustomer.Controls.Add(this.btnDeleteUser);
            this.panelCustomer.CornerRadius = 18;
            this.panelCustomer.Location = new System.Drawing.Point(20, 520);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Padding = new System.Windows.Forms.Padding(16);
            this.panelCustomer.PanelBackColor = System.Drawing.Color.White;
            this.panelCustomer.Size = new System.Drawing.Size(570, 80);
            this.panelCustomer.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblUserName.Location = new System.Drawing.Point(15, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(120, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "New User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserName.Location = new System.Drawing.Point(15, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 36);
            this.txtUserName.TabIndex = 1;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(160, 30);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(80, 36);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblUsers.Location = new System.Drawing.Point(260, 10);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(80, 20);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "Select User:";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUsers.Location = new System.Drawing.Point(260, 30);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(120, 38);
            this.cmbUsers.TabIndex = 4;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(390, 30);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(60, 36);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(455, 30);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(60, 36);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // panelAddress
            // 
            this.panelAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelAddress.BorderColor = System.Drawing.Color.Gray;
            this.panelAddress.BorderThickness = 2;
            this.panelAddress.Controls.Add(this.lblAddressLabel);
            this.panelAddress.Controls.Add(this.txtAddressLabel);
            this.panelAddress.Controls.Add(this.lblAddressDetails);
            this.panelAddress.Controls.Add(this.txtAddressDetails);
            this.panelAddress.Controls.Add(this.btnAddAddress);
            this.panelAddress.Controls.Add(this.lblAddresses);
            this.panelAddress.Controls.Add(this.cmbAddresses);
            this.panelAddress.Controls.Add(this.btnEditAddress);
            this.panelAddress.Controls.Add(this.btnDeleteAddress);
            this.panelAddress.CornerRadius = 18;
            this.panelAddress.Location = new System.Drawing.Point(600, 520);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Padding = new System.Windows.Forms.Padding(16);
            this.panelAddress.PanelBackColor = System.Drawing.Color.White;
            this.panelAddress.Size = new System.Drawing.Size(560, 80);
            this.panelAddress.TabIndex = 3;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAddressLabel.Location = new System.Drawing.Point(15, 10);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(100, 20);
            this.lblAddressLabel.TabIndex = 0;
            this.lblAddressLabel.Text = "Label(Home):";
            // 
            // txtAddressLabel
            // 
            this.txtAddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddressLabel.Location = new System.Drawing.Point(15, 30);
            this.txtAddressLabel.Name = "txtAddressLabel";
            this.txtAddressLabel.Size = new System.Drawing.Size(100, 36);
            this.txtAddressLabel.TabIndex = 1;
            // 
            // lblAddressDetails
            // 
            this.lblAddressDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddressDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAddressDetails.Location = new System.Drawing.Point(120, 10);
            this.lblAddressDetails.Name = "lblAddressDetails";
            this.lblAddressDetails.Size = new System.Drawing.Size(100, 20);
            this.lblAddressDetails.TabIndex = 2;
            this.lblAddressDetails.Text = "Address Details:";
            // 
            // txtAddressDetails
            // 
            this.txtAddressDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddressDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddressDetails.Location = new System.Drawing.Point(120, 30);
            this.txtAddressDetails.Name = "txtAddressDetails";
            this.txtAddressDetails.Size = new System.Drawing.Size(180, 36);
            this.txtAddressDetails.TabIndex = 3;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnAddAddress.FlatAppearance.BorderSize = 0;
            this.btnAddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAddress.ForeColor = System.Drawing.Color.White;
            this.btnAddAddress.Location = new System.Drawing.Point(305, 30);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(90, 36);
            this.btnAddAddress.TabIndex = 4;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // lblAddresses
            // 
            this.lblAddresses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAddresses.Location = new System.Drawing.Point(400, 10);
            this.lblAddresses.Name = "lblAddresses";
            this.lblAddresses.Size = new System.Drawing.Size(100, 20);
            this.lblAddresses.TabIndex = 5;
            this.lblAddresses.Text = "Select Address:";
            // 
            // cmbAddresses
            // 
            this.cmbAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddresses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAddresses.Location = new System.Drawing.Point(400, 30);
            this.cmbAddresses.Name = "cmbAddresses";
            this.cmbAddresses.Size = new System.Drawing.Size(100, 38);
            this.cmbAddresses.TabIndex = 6;
            this.cmbAddresses.SelectedIndexChanged += new System.EventHandler(this.cmbAddresses_SelectedIndexChanged);
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnEditAddress.FlatAppearance.BorderSize = 0;
            this.btnEditAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditAddress.ForeColor = System.Drawing.Color.White;
            this.btnEditAddress.Location = new System.Drawing.Point(505, 5);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(50, 36);
            this.btnEditAddress.TabIndex = 7;
            this.btnEditAddress.Text = "Edit";
            this.btnEditAddress.UseVisualStyleBackColor = false;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDeleteAddress.FlatAppearance.BorderSize = 0;
            this.btnDeleteAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAddress.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAddress.Location = new System.Drawing.Point(499, 46);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(61, 38);
            this.btnDeleteAddress.TabIndex = 8;
            this.btnDeleteAddress.Text = "Delete";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // panelDelivery
            // 
            this.panelDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelDelivery.BorderColor = System.Drawing.Color.Gray;
            this.panelDelivery.BorderThickness = 2;
            this.panelDelivery.Controls.Add(this.rdoPickup);
            this.panelDelivery.Controls.Add(this.rdoDelivery);
            this.panelDelivery.Controls.Add(this.lblDeliveryCost);
            this.panelDelivery.CornerRadius = 18;
            this.panelDelivery.Location = new System.Drawing.Point(740, 520);
            this.panelDelivery.Name = "panelDelivery";
            this.panelDelivery.Padding = new System.Windows.Forms.Padding(16);
            this.panelDelivery.PanelBackColor = System.Drawing.Color.White;
            this.panelDelivery.Size = new System.Drawing.Size(420, 80);
            this.panelDelivery.TabIndex = 9;
            // 
            // rdoPickup
            // 
            this.rdoPickup.Checked = true;
            this.rdoPickup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoPickup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdoPickup.Location = new System.Drawing.Point(20, 20);
            this.rdoPickup.Name = "rdoPickup";
            this.rdoPickup.Size = new System.Drawing.Size(80, 25);
            this.rdoPickup.TabIndex = 0;
            this.rdoPickup.TabStop = true;
            this.rdoPickup.Text = "Pickup";
            this.rdoPickup.CheckedChanged += new System.EventHandler(this.rdoPickup_CheckedChanged);
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rdoDelivery.Location = new System.Drawing.Point(120, 20);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(80, 25);
            this.rdoDelivery.TabIndex = 1;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.CheckedChanged += new System.EventHandler(this.rdoDelivery_CheckedChanged);
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblDeliveryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.lblDeliveryCost.Location = new System.Drawing.Point(220, 20);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(180, 25);
            this.lblDeliveryCost.TabIndex = 2;
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelOrders.BorderColor = System.Drawing.Color.Gray;
            this.panelOrders.BorderThickness = 2;
            this.panelOrders.Controls.Add(this.lstOrders);
            this.panelOrders.CornerRadius = 18;
            this.panelOrders.Location = new System.Drawing.Point(20, 610);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Padding = new System.Windows.Forms.Padding(18);
            this.panelOrders.PanelBackColor = System.Drawing.Color.White;
            this.panelOrders.Size = new System.Drawing.Size(700, 100);
            this.panelOrders.TabIndex = 4;
            // 
            // lstOrders
            // 
            this.lstOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstOrders.ItemHeight = 30;
            this.lstOrders.Location = new System.Drawing.Point(0, 7);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(700, 90);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 842);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1368, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 14);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCreateOrder.FlatAppearance.BorderSize = 0;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Location = new System.Drawing.Point(740, 610);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(150, 40);
            this.btnCreateOrder.TabIndex = 5;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(910, 610);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(120, 40);
            this.btnEditOrder.TabIndex = 6;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(1040, 610);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(120, 40);
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnShowReceipt
            // 
            this.btnShowReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnShowReceipt.FlatAppearance.BorderSize = 0;
            this.btnShowReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReceipt.ForeColor = System.Drawing.Color.White;
            this.btnShowReceipt.Location = new System.Drawing.Point(910, 660);
            this.btnShowReceipt.Name = "btnShowReceipt";
            this.btnShowReceipt.Size = new System.Drawing.Size(250, 40);
            this.btnShowReceipt.TabIndex = 8;
            this.btnShowReceipt.Text = "Show Receipt";
            this.btnShowReceipt.UseVisualStyleBackColor = false;
            this.btnShowReceipt.Click += new System.EventHandler(this.btnShowReceipt_Click);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblOrderStatus.Location = new System.Drawing.Point(740, 570);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(100, 25);
            this.lblOrderStatus.TabIndex = 10;
            this.lblOrderStatus.Text = "Order Status:";
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "Received",
            "Confirmed",
            "Preparing",
            "In Delivery",
            "Delivered"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(850, 570);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(180, 38);
            this.cmbOrderStatus.TabIndex = 11;
            this.cmbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cmbOrderStatus_SelectedIndexChanged);
            // 
            // panelGallery
            // 
            this.panelGallery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelGallery.BorderColor = System.Drawing.Color.Gray;
            this.panelGallery.BorderThickness = 2;
            this.panelGallery.Controls.Add(this.flowGallery);
            this.panelGallery.CornerRadius = 18;
            this.panelGallery.Location = new System.Drawing.Point(1160, 20);
            this.panelGallery.Name = "panelGallery";
            this.panelGallery.Padding = new System.Windows.Forms.Padding(16);
            this.panelGallery.PanelBackColor = System.Drawing.Color.White;
            this.panelGallery.Size = new System.Drawing.Size(180, 480);
            this.panelGallery.TabIndex = 12;
            // 
            // flowGallery
            // 
            this.flowGallery.AutoScroll = true;
            this.flowGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowGallery.Location = new System.Drawing.Point(16, 16);
            this.flowGallery.Name = "flowGallery";
            this.flowGallery.Size = new System.Drawing.Size(148, 448);
            this.flowGallery.TabIndex = 0;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUploadPhoto.Location = new System.Drawing.Point(1160, 510);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(180, 36);
            this.btnUploadPhoto.TabIndex = 20;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1368, 864);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelAddress);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnShowReceipt);
            this.Controls.Add(this.panelDelivery);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.cmbOrderStatus);
            this.Controls.Add(this.panelGallery);
            this.Controls.Add(this.btnUploadPhoto);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.Text = "Modern Dish Manager";
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            this.panelDelivery.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelGallery.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ApplyPanelStyle(RoundedPanel panel)
        {
            panel.BackColor = backgroundLight;
            panel.CornerRadius = 20;
            panel.Padding = new Padding(25);
            panel.BorderStyle = BorderStyle.None;
        }
    }
}