namespace VisionIns
{
    partial class CM004F00
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Dt_YearMonth = new DevExpress.XtraEditors.DateEdit();
            this.Tx_Word = new DevExpress.XtraEditors.TextEdit();
            this.GridRetr = new DevExpress.XtraGrid.GridControl();
            this.GridViewRetr = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColSeqno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColLotno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColIspec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColItnam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColTdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnPrevYM = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNextYM = new DevExpress.XtraEditors.SimpleButton();
            this.BtnInit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRetr = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_YearMonth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_YearMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tx_Word.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            //
            // layoutControl1
            //
            this.layoutControl1.Controls.Add(this.Dt_YearMonth);
            this.layoutControl1.Controls.Add(this.Tx_Word);
            this.layoutControl1.Controls.Add(this.GridRetr);
            this.layoutControl1.Controls.Add(this.BtnPrevYM);
            this.layoutControl1.Controls.Add(this.BtnNextYM);
            this.layoutControl1.Controls.Add(this.BtnInit);
            this.layoutControl1.Controls.Add(this.BtnRetr);
            this.layoutControl1.Controls.Add(this.BtnPrint);
            this.layoutControl1.Controls.Add(this.BtnExcel);
            this.layoutControl1.Controls.Add(this.BtnClose);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1494, 662);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            //
            // Dt_YearMonth
            //
            this.Dt_YearMonth.EditValue = null;
            this.Dt_YearMonth.Location = new System.Drawing.Point(75, 44);
            this.Dt_YearMonth.Margin = new System.Windows.Forms.Padding(2);
            this.Dt_YearMonth.Name = "Dt_YearMonth";
            this.Dt_YearMonth.Properties.AutoHeight = false;
            this.Dt_YearMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_YearMonth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_YearMonth.Properties.DisplayFormat.FormatString = "yyyy-MM";
            this.Dt_YearMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Dt_YearMonth.Properties.EditFormat.FormatString = "yyyy-MM";
            this.Dt_YearMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Dt_YearMonth.Size = new System.Drawing.Size(120, 25);
            this.Dt_YearMonth.StyleController = this.layoutControl1;
            this.Dt_YearMonth.TabIndex = 19;
            //
            // Tx_Word
            //
            this.Tx_Word.Location = new System.Drawing.Point(378, 44);
            this.Tx_Word.Margin = new System.Windows.Forms.Padding(2);
            this.Tx_Word.MinimumSize = new System.Drawing.Size(149, 23);
            this.Tx_Word.Name = "Tx_Word";
            this.Tx_Word.Properties.AutoHeight = false;
            this.Tx_Word.Size = new System.Drawing.Size(150, 27);
            this.Tx_Word.StyleController = this.layoutControl1;
            this.Tx_Word.TabIndex = 18;
            this.Tx_Word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tx_Word_KeyDown);
            //
            // GridRetr
            //
            this.GridRetr.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.GridRetr.Location = new System.Drawing.Point(24, 124);
            this.GridRetr.MainView = this.GridViewRetr;
            this.GridRetr.Margin = new System.Windows.Forms.Padding(2);
            this.GridRetr.Name = "GridRetr";
            this.GridRetr.Size = new System.Drawing.Size(1446, 514);
            this.GridRetr.TabIndex = 4;
            this.GridRetr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewRetr});
            //
            // GridViewRetr
            //
            this.GridViewRetr.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GridViewRetr.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridViewRetr.ColumnPanelRowHeight = 28;
            this.GridViewRetr.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColSeqno,
            this.GridColLotno,
            this.GridColIspec,
            this.GridColItnam,
            this.GridColTdate});
            this.GridViewRetr.GridControl = this.GridRetr;
            this.GridViewRetr.IndicatorWidth = 40;
            this.GridViewRetr.Name = "GridViewRetr";
            this.GridViewRetr.OptionsSelection.CheckBoxSelectorColumnWidth = 50;
            this.GridViewRetr.OptionsSelection.MultiSelect = true;
            this.GridViewRetr.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GridViewRetr.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewRetr.OptionsView.ColumnAutoWidth = false;
            this.GridViewRetr.OptionsView.ShowGroupPanel = false;
            //
            // GridColSeqno
            //
            this.GridColSeqno.AppearanceCell.Options.UseTextOptions = true;
            this.GridColSeqno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColSeqno.Caption = "순번";
            this.GridColSeqno.FieldName = "SEQNO";
            this.GridColSeqno.Name = "GridColSeqno";
            this.GridColSeqno.OptionsColumn.AllowEdit = false;
            this.GridColSeqno.OptionsColumn.AllowFocus = false;
            this.GridColSeqno.Visible = true;
            this.GridColSeqno.VisibleIndex = 0;
            this.GridColSeqno.Width = 80;
            //
            // GridColLotno
            //
            this.GridColLotno.AppearanceCell.Options.UseTextOptions = true;
            this.GridColLotno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColLotno.Caption = "LOT번호";
            this.GridColLotno.FieldName = "LOTNO";
            this.GridColLotno.Name = "GridColLotno";
            this.GridColLotno.OptionsColumn.AllowEdit = false;
            this.GridColLotno.OptionsColumn.AllowFocus = false;
            this.GridColLotno.Visible = true;
            this.GridColLotno.VisibleIndex = 1;
            this.GridColLotno.Width = 150;
            //
            // GridColIspec
            //
            this.GridColIspec.AppearanceCell.Options.UseTextOptions = true;
            this.GridColIspec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColIspec.Caption = "규격";
            this.GridColIspec.FieldName = "ISPEC";
            this.GridColIspec.Name = "GridColIspec";
            this.GridColIspec.OptionsColumn.AllowEdit = false;
            this.GridColIspec.OptionsColumn.AllowFocus = false;
            this.GridColIspec.Visible = true;
            this.GridColIspec.VisibleIndex = 2;
            this.GridColIspec.Width = 130;
            //
            // GridColItnam
            //
            this.GridColItnam.Caption = "품명";
            this.GridColItnam.FieldName = "ITNAM";
            this.GridColItnam.Name = "GridColItnam";
            this.GridColItnam.OptionsColumn.AllowEdit = false;
            this.GridColItnam.OptionsColumn.AllowFocus = false;
            this.GridColItnam.Visible = true;
            this.GridColItnam.VisibleIndex = 3;
            this.GridColItnam.Width = 260;
            //
            // GridColTdate
            //
            this.GridColTdate.AppearanceCell.Options.UseTextOptions = true;
            this.GridColTdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColTdate.Caption = "연-월-일";
            this.GridColTdate.FieldName = "TDATE";
            this.GridColTdate.Name = "GridColTdate";
            this.GridColTdate.OptionsColumn.AllowEdit = false;
            this.GridColTdate.OptionsColumn.AllowFocus = false;
            this.GridColTdate.Visible = true;
            this.GridColTdate.VisibleIndex = 4;
            this.GridColTdate.Width = 120;
            //
            // BtnPrevYM
            //
            this.BtnPrevYM.Location = new System.Drawing.Point(24, 44);
            this.BtnPrevYM.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrevYM.MaximumSize = new System.Drawing.Size(40, 29);
            this.BtnPrevYM.MinimumSize = new System.Drawing.Size(40, 29);
            this.BtnPrevYM.Name = "BtnPrevYM";
            this.BtnPrevYM.Size = new System.Drawing.Size(40, 29);
            this.BtnPrevYM.StyleController = this.layoutControl1;
            this.BtnPrevYM.TabIndex = 20;
            this.BtnPrevYM.TabStop = false;
            this.BtnPrevYM.Text = "<";
            this.BtnPrevYM.Click += new System.EventHandler(this.BtnPrevYM_Click);
            //
            // BtnNextYM
            //
            this.BtnNextYM.Location = new System.Drawing.Point(206, 44);
            this.BtnNextYM.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNextYM.MaximumSize = new System.Drawing.Size(40, 29);
            this.BtnNextYM.MinimumSize = new System.Drawing.Size(40, 29);
            this.BtnNextYM.Name = "BtnNextYM";
            this.BtnNextYM.Size = new System.Drawing.Size(40, 29);
            this.BtnNextYM.StyleController = this.layoutControl1;
            this.BtnNextYM.TabIndex = 21;
            this.BtnNextYM.TabStop = false;
            this.BtnNextYM.Text = ">";
            this.BtnNextYM.Click += new System.EventHandler(this.BtnNextYM_Click);
            //
            // BtnInit
            //
            this.BtnInit.Location = new System.Drawing.Point(250, 44);
            this.BtnInit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInit.MaximumSize = new System.Drawing.Size(84, 29);
            this.BtnInit.MinimumSize = new System.Drawing.Size(84, 29);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(84, 29);
            this.BtnInit.StyleController = this.layoutControl1;
            this.BtnInit.TabIndex = 22;
            this.BtnInit.TabStop = false;
            this.BtnInit.Text = "초기화";
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            //
            // BtnRetr
            //
            this.BtnRetr.Location = new System.Drawing.Point(1029, 44);
            this.BtnRetr.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRetr.MaximumSize = new System.Drawing.Size(84, 29);
            this.BtnRetr.MinimumSize = new System.Drawing.Size(84, 29);
            this.BtnRetr.Name = "BtnRetr";
            this.BtnRetr.Size = new System.Drawing.Size(84, 29);
            this.BtnRetr.StyleController = this.layoutControl1;
            this.BtnRetr.TabIndex = 10;
            this.BtnRetr.Text = "조회(F5)";
            this.BtnRetr.Click += new System.EventHandler(this.BtnRetr_Click);
            //
            // BtnPrint
            //
            this.BtnPrint.Location = new System.Drawing.Point(1118, 44);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrint.MaximumSize = new System.Drawing.Size(84, 29);
            this.BtnPrint.MinimumSize = new System.Drawing.Size(84, 29);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(84, 29);
            this.BtnPrint.StyleController = this.layoutControl1;
            this.BtnPrint.TabIndex = 13;
            this.BtnPrint.TabStop = false;
            this.BtnPrint.Text = "라벨출력";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            //
            // BtnExcel
            //
            this.BtnExcel.Location = new System.Drawing.Point(1296, 44);
            this.BtnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExcel.MaximumSize = new System.Drawing.Size(84, 29);
            this.BtnExcel.MinimumSize = new System.Drawing.Size(84, 29);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(84, 29);
            this.BtnExcel.StyleController = this.layoutControl1;
            this.BtnExcel.TabIndex = 14;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "엑셀(F8)";
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            //
            // BtnClose
            //
            this.BtnClose.Location = new System.Drawing.Point(1385, 44);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClose.MaximumSize = new System.Drawing.Size(84, 29);
            this.BtnClose.MinimumSize = new System.Drawing.Size(84, 29);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(84, 29);
            this.BtnClose.StyleController = this.layoutControl1;
            this.BtnClose.TabIndex = 15;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "닫기(ESC)";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // Root
            //
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1494, 662);
            this.Root.TextVisible = false;
            //
            // layoutControlGroup2
            //
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 80);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1474, 562);
            this.layoutControlGroup2.Text = "바코드출력";
            //
            // layoutControlItem1
            //
            this.layoutControlItem1.Control = this.GridRetr;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1450, 518);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            //
            // layoutControlGroup4
            //
            this.layoutControlGroup4.CustomizationFormText = "검색조건";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1474, 80);
            this.layoutControlGroup4.Text = "검색조건";
            //
            // layoutControlItem2
            //
            this.layoutControlItem2.Control = this.BtnPrevYM;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(44, 36);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(44, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(44, 36);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "조회년월";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 15);
            //
            // layoutControlItem3
            //
            this.layoutControlItem3.Control = this.Dt_YearMonth;
            this.layoutControlItem3.Location = new System.Drawing.Point(44, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(124, 29);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(124, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 36);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            //
            // layoutControlItem4
            //
            this.layoutControlItem4.Control = this.BtnNextYM;
            this.layoutControlItem4.Location = new System.Drawing.Point(168, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(44, 36);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(44, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(44, 36);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            //
            // layoutControlItem5
            //
            this.layoutControlItem5.Control = this.BtnInit;
            this.layoutControlItem5.Location = new System.Drawing.Point(212, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(88, 36);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(88, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(88, 36);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            //
            // layoutControlItem6
            //
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.Tx_Word;
            this.layoutControlItem6.Location = new System.Drawing.Point(300, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(178, 36);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(178, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(178, 36);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "품명/LOT검색";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 15);
            this.layoutControlItem6.TextToControlDistance = 5;
            //
            // emptySpaceItem1
            //
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(478, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(527, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            //
            // layoutControlItem7
            //
            this.layoutControlItem7.Control = this.BtnRetr;
            this.layoutControlItem7.Location = new System.Drawing.Point(1005, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(89, 36);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(89, 36);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(89, 36);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            //
            // layoutControlItem8
            //
            this.layoutControlItem8.Control = this.BtnPrint;
            this.layoutControlItem8.Location = new System.Drawing.Point(1094, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(89, 36);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(89, 36);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(89, 36);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            //
            // layoutControlItem9
            //
            this.layoutControlItem9.Control = this.BtnExcel;
            this.layoutControlItem9.Location = new System.Drawing.Point(1183, 0);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(178, 36);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(178, 36);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(178, 36);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            //
            // CM004F00
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 662);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CM004F00";
            this.Text = "바코드출력";
            this.Load += new System.EventHandler(this.CM004F00_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CM004F00_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_YearMonth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_YearMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tx_Word.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl GridRetr;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewRetr;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit Dt_YearMonth;
        private DevExpress.XtraEditors.SimpleButton BtnRetr;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private DevExpress.XtraEditors.SimpleButton BtnExcel;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.TextEdit Tx_Word;
        private DevExpress.XtraEditors.SimpleButton BtnPrevYM;
        private DevExpress.XtraEditors.SimpleButton BtnNextYM;
        private DevExpress.XtraEditors.SimpleButton BtnInit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn GridColSeqno;
        private DevExpress.XtraGrid.Columns.GridColumn GridColLotno;
        private DevExpress.XtraGrid.Columns.GridColumn GridColIspec;
        private DevExpress.XtraGrid.Columns.GridColumn GridColItnam;
        private DevExpress.XtraGrid.Columns.GridColumn GridColTdate;
    }
}
