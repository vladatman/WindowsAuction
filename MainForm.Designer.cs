namespace AuctionProgram
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.auctionTab = new System.Windows.Forms.TabPage();
            this.lotGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.createTab = new System.Windows.Forms.TabPage();
            this.houseConfirmButton = new System.Windows.Forms.Button();
            this.telephoneConfirmButton = new System.Windows.Forms.Button();
            this.carConfirmButton = new System.Windows.Forms.Button();
            this.houseExpirationDateLabel = new System.Windows.Forms.Label();
            this.houseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telephoneExpirationDateLabel = new System.Windows.Forms.Label();
            this.telephoneDatePicker = new System.Windows.Forms.DateTimePicker();
            this.carExpirationDateLabel = new System.Windows.Forms.Label();
            this.carDatePicker = new System.Windows.Forms.DateTimePicker();
            this.houseStyleTextBox = new System.Windows.Forms.TextBox();
            this.houseLocationTextBox = new System.Windows.Forms.TextBox();
            this.houseBuiltDateLabel = new System.Windows.Forms.Label();
            this.styleHouseLabel = new System.Windows.Forms.Label();
            this.locationHouseLabel = new System.Windows.Forms.Label();
            this.telephoneColorTextBox = new System.Windows.Forms.TextBox();
            this.telephoneModelTextBox = new System.Windows.Forms.TextBox();
            this.telephoneBatteryPowerTextBox = new System.Windows.Forms.TextBox();
            this.telephoneBrandTextBox = new System.Windows.Forms.TextBox();
            this.telephoneBatteryPowerLabel = new System.Windows.Forms.Label();
            this.telephoneColorLabel = new System.Windows.Forms.Label();
            this.telephoneModelLabel = new System.Windows.Forms.Label();
            this.telephoneBrandLabel = new System.Windows.Forms.Label();
            this.carColorTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carTolalKmTextBox = new System.Windows.Forms.TextBox();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.carTotalKmLabel = new System.Windows.Forms.Label();
            this.carColorLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.createHouseTitle = new System.Windows.Forms.Label();
            this.createTelephoneTitle = new System.Windows.Forms.Label();
            this.createCarTitle = new System.Windows.Forms.Label();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.disableBiddingCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.ComboBox();
            this.bidderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionDataSet = new AuctionProgram.AuctionDataSet();
            this.bidderTableAdapter = new AuctionProgram.AuctionDataSetTableAdapters.BidderTableAdapter();
            this.labelBidder = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.dataBaseTimer = new System.Windows.Forms.Timer(this.components);
            this.carExpirationTimeLabel = new System.Windows.Forms.Label();
            this.carTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telephoneExpirationTimeLabel = new System.Windows.Forms.Label();
            this.telephoneTimePicker = new System.Windows.Forms.DateTimePicker();
            this.houseExpirationTimeLabel = new System.Windows.Forms.Label();
            this.houseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.houseBuiltDatePicker = new System.Windows.Forms.DateTimePicker();
            this.contextMenu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.auctionTab.SuspendLayout();
            this.createTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.contextMenu.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // exit
            // 
            this.exit.Name = "exit";
            resources.ApplyResources(this.exit, "exit");
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.trayIcon, "trayIcon");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.auctionTab);
            this.tabControl.Controls.Add(this.createTab);
            this.tabControl.Controls.Add(this.settingsTab);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // auctionTab
            // 
            this.auctionTab.Controls.Add(this.lotGrid);
            resources.ApplyResources(this.auctionTab, "auctionTab");
            this.auctionTab.Name = "auctionTab";
            this.auctionTab.UseVisualStyleBackColor = true;
            // 
            // lotGrid
            // 
            resources.ApplyResources(this.lotGrid, "lotGrid");
            this.lotGrid.Name = "lotGrid";
            // 
            // createTab
            // 
            this.createTab.Controls.Add(this.houseBuiltDatePicker);
            this.createTab.Controls.Add(this.houseExpirationTimeLabel);
            this.createTab.Controls.Add(this.houseTimePicker);
            this.createTab.Controls.Add(this.telephoneExpirationTimeLabel);
            this.createTab.Controls.Add(this.telephoneTimePicker);
            this.createTab.Controls.Add(this.carExpirationTimeLabel);
            this.createTab.Controls.Add(this.carTimePicker);
            this.createTab.Controls.Add(this.houseConfirmButton);
            this.createTab.Controls.Add(this.telephoneConfirmButton);
            this.createTab.Controls.Add(this.carConfirmButton);
            this.createTab.Controls.Add(this.houseExpirationDateLabel);
            this.createTab.Controls.Add(this.houseDateTimePicker);
            this.createTab.Controls.Add(this.telephoneExpirationDateLabel);
            this.createTab.Controls.Add(this.telephoneDatePicker);
            this.createTab.Controls.Add(this.carExpirationDateLabel);
            this.createTab.Controls.Add(this.carDatePicker);
            this.createTab.Controls.Add(this.houseStyleTextBox);
            this.createTab.Controls.Add(this.houseLocationTextBox);
            this.createTab.Controls.Add(this.houseBuiltDateLabel);
            this.createTab.Controls.Add(this.styleHouseLabel);
            this.createTab.Controls.Add(this.locationHouseLabel);
            this.createTab.Controls.Add(this.telephoneColorTextBox);
            this.createTab.Controls.Add(this.telephoneModelTextBox);
            this.createTab.Controls.Add(this.telephoneBatteryPowerTextBox);
            this.createTab.Controls.Add(this.telephoneBrandTextBox);
            this.createTab.Controls.Add(this.telephoneBatteryPowerLabel);
            this.createTab.Controls.Add(this.telephoneColorLabel);
            this.createTab.Controls.Add(this.telephoneModelLabel);
            this.createTab.Controls.Add(this.telephoneBrandLabel);
            this.createTab.Controls.Add(this.carColorTextBox);
            this.createTab.Controls.Add(this.carModelTextBox);
            this.createTab.Controls.Add(this.carTolalKmTextBox);
            this.createTab.Controls.Add(this.carBrandTextBox);
            this.createTab.Controls.Add(this.carTotalKmLabel);
            this.createTab.Controls.Add(this.carColorLabel);
            this.createTab.Controls.Add(this.carModelLabel);
            this.createTab.Controls.Add(this.carBrandLabel);
            this.createTab.Controls.Add(this.createHouseTitle);
            this.createTab.Controls.Add(this.createTelephoneTitle);
            this.createTab.Controls.Add(this.createCarTitle);
            resources.ApplyResources(this.createTab, "createTab");
            this.createTab.Name = "createTab";
            this.createTab.UseVisualStyleBackColor = true;
            // 
            // houseConfirmButton
            // 
            resources.ApplyResources(this.houseConfirmButton, "houseConfirmButton");
            this.houseConfirmButton.Name = "houseConfirmButton";
            this.houseConfirmButton.UseVisualStyleBackColor = true;
            // 
            // telephoneConfirmButton
            // 
            resources.ApplyResources(this.telephoneConfirmButton, "telephoneConfirmButton");
            this.telephoneConfirmButton.Name = "telephoneConfirmButton";
            this.telephoneConfirmButton.UseVisualStyleBackColor = true;
            // 
            // carConfirmButton
            // 
            resources.ApplyResources(this.carConfirmButton, "carConfirmButton");
            this.carConfirmButton.Name = "carConfirmButton";
            this.carConfirmButton.UseVisualStyleBackColor = true;
            // 
            // houseExpirationDateLabel
            // 
            resources.ApplyResources(this.houseExpirationDateLabel, "houseExpirationDateLabel");
            this.houseExpirationDateLabel.Name = "houseExpirationDateLabel";
            // 
            // houseDateTimePicker
            // 
            this.houseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.houseDateTimePicker, "houseDateTimePicker");
            this.houseDateTimePicker.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.houseDateTimePicker.Name = "houseDateTimePicker";
            // 
            // telephoneExpirationDateLabel
            // 
            resources.ApplyResources(this.telephoneExpirationDateLabel, "telephoneExpirationDateLabel");
            this.telephoneExpirationDateLabel.Name = "telephoneExpirationDateLabel";
            // 
            // telephoneDatePicker
            // 
            this.telephoneDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.telephoneDatePicker, "telephoneDatePicker");
            this.telephoneDatePicker.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.telephoneDatePicker.Name = "telephoneDatePicker";
            // 
            // carExpirationDateLabel
            // 
            resources.ApplyResources(this.carExpirationDateLabel, "carExpirationDateLabel");
            this.carExpirationDateLabel.Name = "carExpirationDateLabel";
            // 
            // carDatePicker
            // 
            this.carDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.carDatePicker, "carDatePicker");
            this.carDatePicker.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.carDatePicker.Name = "carDatePicker";
            // 
            // houseStyleTextBox
            // 
            resources.ApplyResources(this.houseStyleTextBox, "houseStyleTextBox");
            this.houseStyleTextBox.Name = "houseStyleTextBox";
            // 
            // houseLocationTextBox
            // 
            resources.ApplyResources(this.houseLocationTextBox, "houseLocationTextBox");
            this.houseLocationTextBox.Name = "houseLocationTextBox";
            // 
            // houseBuiltDateLabel
            // 
            resources.ApplyResources(this.houseBuiltDateLabel, "houseBuiltDateLabel");
            this.houseBuiltDateLabel.Name = "houseBuiltDateLabel";
            // 
            // styleHouseLabel
            // 
            resources.ApplyResources(this.styleHouseLabel, "styleHouseLabel");
            this.styleHouseLabel.Name = "styleHouseLabel";
            // 
            // locationHouseLabel
            // 
            resources.ApplyResources(this.locationHouseLabel, "locationHouseLabel");
            this.locationHouseLabel.Name = "locationHouseLabel";
            // 
            // telephoneColorTextBox
            // 
            resources.ApplyResources(this.telephoneColorTextBox, "telephoneColorTextBox");
            this.telephoneColorTextBox.Name = "telephoneColorTextBox";
            // 
            // telephoneModelTextBox
            // 
            resources.ApplyResources(this.telephoneModelTextBox, "telephoneModelTextBox");
            this.telephoneModelTextBox.Name = "telephoneModelTextBox";
            // 
            // telephoneBatteryPowerTextBox
            // 
            resources.ApplyResources(this.telephoneBatteryPowerTextBox, "telephoneBatteryPowerTextBox");
            this.telephoneBatteryPowerTextBox.Name = "telephoneBatteryPowerTextBox";
            // 
            // telephoneBrandTextBox
            // 
            resources.ApplyResources(this.telephoneBrandTextBox, "telephoneBrandTextBox");
            this.telephoneBrandTextBox.Name = "telephoneBrandTextBox";
            // 
            // telephoneBatteryPowerLabel
            // 
            resources.ApplyResources(this.telephoneBatteryPowerLabel, "telephoneBatteryPowerLabel");
            this.telephoneBatteryPowerLabel.Name = "telephoneBatteryPowerLabel";
            // 
            // telephoneColorLabel
            // 
            resources.ApplyResources(this.telephoneColorLabel, "telephoneColorLabel");
            this.telephoneColorLabel.Name = "telephoneColorLabel";
            // 
            // telephoneModelLabel
            // 
            resources.ApplyResources(this.telephoneModelLabel, "telephoneModelLabel");
            this.telephoneModelLabel.Name = "telephoneModelLabel";
            // 
            // telephoneBrandLabel
            // 
            resources.ApplyResources(this.telephoneBrandLabel, "telephoneBrandLabel");
            this.telephoneBrandLabel.Name = "telephoneBrandLabel";
            // 
            // carColorTextBox
            // 
            resources.ApplyResources(this.carColorTextBox, "carColorTextBox");
            this.carColorTextBox.Name = "carColorTextBox";
            // 
            // carModelTextBox
            // 
            resources.ApplyResources(this.carModelTextBox, "carModelTextBox");
            this.carModelTextBox.Name = "carModelTextBox";
            // 
            // carTolalKmTextBox
            // 
            resources.ApplyResources(this.carTolalKmTextBox, "carTolalKmTextBox");
            this.carTolalKmTextBox.Name = "carTolalKmTextBox";
            // 
            // carBrandTextBox
            // 
            resources.ApplyResources(this.carBrandTextBox, "carBrandTextBox");
            this.carBrandTextBox.Name = "carBrandTextBox";
            // 
            // carTotalKmLabel
            // 
            resources.ApplyResources(this.carTotalKmLabel, "carTotalKmLabel");
            this.carTotalKmLabel.Name = "carTotalKmLabel";
            // 
            // carColorLabel
            // 
            resources.ApplyResources(this.carColorLabel, "carColorLabel");
            this.carColorLabel.Name = "carColorLabel";
            // 
            // carModelLabel
            // 
            resources.ApplyResources(this.carModelLabel, "carModelLabel");
            this.carModelLabel.Name = "carModelLabel";
            // 
            // carBrandLabel
            // 
            resources.ApplyResources(this.carBrandLabel, "carBrandLabel");
            this.carBrandLabel.Name = "carBrandLabel";
            // 
            // createHouseTitle
            // 
            resources.ApplyResources(this.createHouseTitle, "createHouseTitle");
            this.createHouseTitle.Name = "createHouseTitle";
            // 
            // createTelephoneTitle
            // 
            resources.ApplyResources(this.createTelephoneTitle, "createTelephoneTitle");
            this.createTelephoneTitle.Name = "createTelephoneTitle";
            // 
            // createCarTitle
            // 
            resources.ApplyResources(this.createCarTitle, "createCarTitle");
            this.createCarTitle.Name = "createCarTitle";
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.disableBiddingCheckBox);
            this.settingsTab.Controls.Add(this.label1);
            resources.ApplyResources(this.settingsTab, "settingsTab");
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // disableBiddingCheckBox
            // 
            resources.ApplyResources(this.disableBiddingCheckBox, "disableBiddingCheckBox");
            this.disableBiddingCheckBox.Name = "disableBiddingCheckBox";
            this.disableBiddingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // User
            // 
            this.User.DataSource = this.bidderBindingSource;
            this.User.DisplayMember = "name";
            this.User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.User.FormattingEnabled = true;
            resources.ApplyResources(this.User, "User");
            this.User.Name = "User";
            // 
            // bidderBindingSource
            // 
            this.bidderBindingSource.DataMember = "Bidder";
            this.bidderBindingSource.DataSource = this.auctionDataSet;
            // 
            // auctionDataSet
            // 
            this.auctionDataSet.DataSetName = "AuctionDataSet";
            this.auctionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bidderTableAdapter
            // 
            this.bidderTableAdapter.ClearBeforeFill = true;
            // 
            // labelBidder
            // 
            resources.ApplyResources(this.labelBidder, "labelBidder");
            this.labelBidder.Name = "labelBidder";
            // 
            // buttonRefresh
            // 
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Enabled = true;
            this.countdownTimer.Interval = 1000;
            // 
            // dataBaseTimer
            // 
            this.dataBaseTimer.Interval = 5000;
            // 
            // carExpirationTimeLabel
            // 
            resources.ApplyResources(this.carExpirationTimeLabel, "carExpirationTimeLabel");
            this.carExpirationTimeLabel.Name = "carExpirationTimeLabel";
            // 
            // carTimePicker
            // 
            this.carTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.carTimePicker, "carTimePicker");
            this.carTimePicker.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.carTimePicker.Name = "carTimePicker";
            // 
            // telephoneExpirationTimeLabel
            // 
            resources.ApplyResources(this.telephoneExpirationTimeLabel, "telephoneExpirationTimeLabel");
            this.telephoneExpirationTimeLabel.Name = "telephoneExpirationTimeLabel";
            // 
            // telephoneTimePicker
            // 
            this.telephoneTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.telephoneTimePicker, "telephoneTimePicker");
            this.telephoneTimePicker.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.telephoneTimePicker.Name = "telephoneTimePicker";
            // 
            // houseExpirationTimeLabel
            // 
            resources.ApplyResources(this.houseExpirationTimeLabel, "houseExpirationTimeLabel");
            this.houseExpirationTimeLabel.Name = "houseExpirationTimeLabel";
            // 
            // houseTimePicker
            // 
            this.houseTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.houseTimePicker, "houseTimePicker");
            this.houseTimePicker.MinDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.houseTimePicker.Name = "houseTimePicker";
            // 
            // houseBuiltDatePicker
            // 
            this.houseBuiltDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.houseBuiltDatePicker, "houseBuiltDatePicker");
            this.houseBuiltDatePicker.MaxDate = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            this.houseBuiltDatePicker.Name = "houseBuiltDatePicker";
            this.houseBuiltDatePicker.Value = new System.DateTime(2024, 4, 6, 0, 0, 0, 0);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelBidder);
            this.Controls.Add(this.User);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenu.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.auctionTab.ResumeLayout(false);
            this.auctionTab.PerformLayout();
            this.createTab.ResumeLayout(false);
            this.createTab.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bidderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage auctionTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.FlowLayoutPanel lotGrid;
        private AuctionDataSet auctionDataSet;
        private System.Windows.Forms.BindingSource bidderBindingSource;
        private AuctionDataSetTableAdapters.BidderTableAdapter bidderTableAdapter;
        private System.Windows.Forms.Label labelBidder;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer dataBaseTimer;
        public System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.CheckBox disableBiddingCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage createTab;
        private System.Windows.Forms.Label carTotalKmLabel;
        private System.Windows.Forms.Label carColorLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label carBrandLabel;
        private System.Windows.Forms.Label createHouseTitle;
        private System.Windows.Forms.Label createTelephoneTitle;
        private System.Windows.Forms.Label createCarTitle;
        private System.Windows.Forms.TextBox telephoneColorTextBox;
        private System.Windows.Forms.TextBox telephoneModelTextBox;
        private System.Windows.Forms.TextBox telephoneBatteryPowerTextBox;
        private System.Windows.Forms.TextBox telephoneBrandTextBox;
        private System.Windows.Forms.Label telephoneBatteryPowerLabel;
        private System.Windows.Forms.Label telephoneColorLabel;
        private System.Windows.Forms.Label telephoneModelLabel;
        private System.Windows.Forms.Label telephoneBrandLabel;
        private System.Windows.Forms.TextBox carColorTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox carTolalKmTextBox;
        private System.Windows.Forms.TextBox carBrandTextBox;
        private System.Windows.Forms.TextBox houseStyleTextBox;
        private System.Windows.Forms.TextBox houseLocationTextBox;
        private System.Windows.Forms.Label houseBuiltDateLabel;
        private System.Windows.Forms.Label styleHouseLabel;
        private System.Windows.Forms.Label locationHouseLabel;
        private System.Windows.Forms.Label carExpirationDateLabel;
        private System.Windows.Forms.DateTimePicker carDatePicker;
        private System.Windows.Forms.Label houseExpirationDateLabel;
        private System.Windows.Forms.DateTimePicker houseDateTimePicker;
        private System.Windows.Forms.Label telephoneExpirationDateLabel;
        private System.Windows.Forms.DateTimePicker telephoneDatePicker;
        private System.Windows.Forms.Button houseConfirmButton;
        private System.Windows.Forms.Button telephoneConfirmButton;
        private System.Windows.Forms.Button carConfirmButton;
        private System.Windows.Forms.Label carExpirationTimeLabel;
        private System.Windows.Forms.DateTimePicker carTimePicker;
        private System.Windows.Forms.Label houseExpirationTimeLabel;
        private System.Windows.Forms.DateTimePicker houseTimePicker;
        private System.Windows.Forms.Label telephoneExpirationTimeLabel;
        private System.Windows.Forms.DateTimePicker telephoneTimePicker;
        private System.Windows.Forms.DateTimePicker houseBuiltDatePicker;
    }
}

