using Bizentro.AppFramework.UI.Module;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

using Bizentro.AppFramework.UI.Controls;

namespace Bizentro.App.UI.FI.F2316MA2_CKO166
{

    public class ModuleInitializer : Bizentro.AppFramework.UI.Module.Module
    {
        [InjectionConstructor]
        public ModuleInitializer([ServiceDependency] WorkItem rootWorkItem)
            : base(rootWorkItem) { }

        protected override void RegisterModureViewer()
        {
            base.AddModule<ModuleViewer>();
        }
    }

    partial class ModuleViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.uniTBL_OuterMost = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainCondition = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.lblOrgId = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.lblBdgYymmFr = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.popORG_CD = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.lblORG_CD = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.popOrgId = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.cboBdgCtrlUnit = new Bizentro.AppFramework.UI.Controls.uniCombo(this.components);
            this.lblBdgCtrlUnit = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.dtBdgYymm = new Bizentro.AppFramework.UI.Controls.uniDateTerm();
            this.uniTBL_MainReference = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainBatch = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainData = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniGrid1 = new Bizentro.AppFramework.UI.Controls.uniGrid(this.components);
            this.popBdgCdFr = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.lblBdgCdTo = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.popBdgCdTo = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.lblBdgCdFr = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniTBL_OuterMost.SuspendLayout();
            this.uniTBL_MainCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBdgCtrlUnit)).BeginInit();
            this.uniTBL_MainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // uniTBL_OuterMost
            // 
            this.uniTBL_OuterMost.AutoFit = false;
            this.uniTBL_OuterMost.AutoFitColumnCount = 4;
            this.uniTBL_OuterMost.AutoFitRowCount = 4;
            this.uniTBL_OuterMost.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_OuterMost.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_OuterMost.ColumnCount = 1;
            this.uniTBL_OuterMost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uniTBL_OuterMost.ConditionRowCount = 3;
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainCondition, 0, 2);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainReference, 0, 0);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainBatch, 0, 6);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainData, 0, 4);
            this.uniTBL_OuterMost.DefaultRowSize = 23;
            this.uniTBL_OuterMost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_OuterMost.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_OuterMost.HEIGHT_TYPE_00_REFERENCE = 21F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01 = 6F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01_CONDITION = 38F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02 = 9F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03_BOTTOM = 28F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_04 = 1F;
            this.uniTBL_OuterMost.Location = new System.Drawing.Point(1, 10);
            this.uniTBL_OuterMost.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_OuterMost.Name = "uniTBL_OuterMost";
            this.uniTBL_OuterMost.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_OuterMost.RowCount = 8;
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.uniTBL_OuterMost.Size = new System.Drawing.Size(804, 503);
            this.uniTBL_OuterMost.SizeTD5 = 14F;
            this.uniTBL_OuterMost.SizeTD6 = 36F;
            this.uniTBL_OuterMost.TabIndex = 0;
            this.uniTBL_OuterMost.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainCondition
            // 
            this.uniTBL_MainCondition.AutoFit = false;
            this.uniTBL_MainCondition.AutoFitColumnCount = 4;
            this.uniTBL_MainCondition.AutoFitRowCount = 4;
            this.uniTBL_MainCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.uniTBL_MainCondition.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainCondition.ColumnCount = 4;
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.Controls.Add(this.lblBdgCdFr, 0, 2);
            this.uniTBL_MainCondition.Controls.Add(this.lblOrgId, 0, 0);
            this.uniTBL_MainCondition.Controls.Add(this.lblBdgYymmFr, 0, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popBdgCdTo, 3, 2);
            this.uniTBL_MainCondition.Controls.Add(this.popORG_CD, 3, 1);
            this.uniTBL_MainCondition.Controls.Add(this.lblBdgCdTo, 2, 2);
            this.uniTBL_MainCondition.Controls.Add(this.lblORG_CD, 2, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popOrgId, 1, 0);
            this.uniTBL_MainCondition.Controls.Add(this.popBdgCdFr, 1, 2);
            this.uniTBL_MainCondition.Controls.Add(this.dtBdgYymm, 1, 1);
            this.uniTBL_MainCondition.Controls.Add(this.cboBdgCtrlUnit, 3, 0);
            this.uniTBL_MainCondition.Controls.Add(this.lblBdgCtrlUnit, 2, 0);
            this.uniTBL_MainCondition.DefaultRowSize = 23;
            this.uniTBL_MainCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainCondition.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainCondition.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainCondition.Location = new System.Drawing.Point(0, 27);
            this.uniTBL_MainCondition.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainCondition.Name = "uniTBL_MainCondition";
            this.uniTBL_MainCondition.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.uniTBL_MainCondition.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Condition;
            this.uniTBL_MainCondition.RowCount = 4;
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainCondition.Size = new System.Drawing.Size(804, 84);
            this.uniTBL_MainCondition.SizeTD5 = 14F;
            this.uniTBL_MainCondition.SizeTD6 = 36F;
            this.uniTBL_MainCondition.TabIndex = 1;
            this.uniTBL_MainCondition.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // lblOrgId
            // 
            appearance2.TextHAlignAsString = "Left";
            appearance2.TextVAlignAsString = "Middle";
            this.lblOrgId.Appearance = appearance2;
            this.lblOrgId.AutoPopupID = null;
            this.lblOrgId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrgId.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblOrgId.Location = new System.Drawing.Point(15, 6);
            this.lblOrgId.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lblOrgId.Name = "lblOrgId";
            this.lblOrgId.Size = new System.Drawing.Size(97, 22);
            this.lblOrgId.StyleSetName = "Default";
            this.lblOrgId.TabIndex = 1;
            this.lblOrgId.Text = "Department Change ID";
            this.lblOrgId.UseMnemonic = false;
            // 
            // lblBdgYymmFr
            // 
            appearance3.TextHAlignAsString = "Left";
            appearance3.TextVAlignAsString = "Middle";
            this.lblBdgYymmFr.Appearance = appearance3;
            this.lblBdgYymmFr.AutoPopupID = null;
            this.lblBdgYymmFr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBdgYymmFr.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblBdgYymmFr.Location = new System.Drawing.Point(15, 29);
            this.lblBdgYymmFr.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lblBdgYymmFr.Name = "lblBdgYymmFr";
            this.lblBdgYymmFr.Size = new System.Drawing.Size(97, 22);
            this.lblBdgYymmFr.StyleSetName = "Default";
            this.lblBdgYymmFr.TabIndex = 5;
            this.lblBdgYymmFr.Text = "예산기준년월";
            this.lblBdgYymmFr.UseMnemonic = false;
            // 
            // popORG_CD
            // 
            this.popORG_CD.AllowMultiValue = false;
            this.popORG_CD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popORG_CD.AutoPopupCodeParameter = null;
            this.popORG_CD.AutoPopupID = null;
            this.popORG_CD.AutoPopupNameParameter = null;
            this.popORG_CD.CodeMaxLength = 10;
            this.popORG_CD.CodeName = "";
            this.popORG_CD.CodeSize = 100;
            this.popORG_CD.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popORG_CD.CodeTextBoxName = null;
            this.popORG_CD.CodeValue = "";
            this.popORG_CD.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.ReadOnly;
            this.popORG_CD.Location = new System.Drawing.Point(513, 30);
            this.popORG_CD.LockedField = false;
            this.popORG_CD.Margin = new System.Windows.Forms.Padding(0);
            this.popORG_CD.Name = "popORG_CD";
            this.popORG_CD.NameDisplay = true;
            this.popORG_CD.NameId = null;
            this.popORG_CD.NameMaxLength = 50;
            this.popORG_CD.NamePopup = false;
            this.popORG_CD.NameSize = 150;
            this.popORG_CD.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popORG_CD.Parameter = null;
            this.popORG_CD.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popORG_CD.PopupId = null;
            this.popORG_CD.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popORG_CD.QueryIfEnterKeyPressed = true;
            this.popORG_CD.RequiredField = false;
            this.popORG_CD.Size = new System.Drawing.Size(271, 21);
            this.popORG_CD.SmartComboType = Bizentro.AppFramework.UI.Controls.SmartComboType.Default;
            this.popORG_CD.TabIndex = 4;
            this.popORG_CD.uniALT = "예산부서그룹";
            this.popORG_CD.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.popORG_CD.UseDynamicFormat = false;
            this.popORG_CD.ValueTextBoxName = null;
            this.popORG_CD.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popORG_CD_BeforePopupOpen);
            this.popORG_CD.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popORG_CD_AfterPopupClosed);
            // 
            // lblORG_CD
            // 
            appearance5.TextHAlignAsString = "Left";
            appearance5.TextVAlignAsString = "Middle";
            this.lblORG_CD.Appearance = appearance5;
            this.lblORG_CD.AutoPopupID = null;
            this.lblORG_CD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblORG_CD.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblORG_CD.Location = new System.Drawing.Point(416, 29);
            this.lblORG_CD.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lblORG_CD.Name = "lblORG_CD";
            this.lblORG_CD.Size = new System.Drawing.Size(97, 22);
            this.lblORG_CD.StyleSetName = "Default";
            this.lblORG_CD.TabIndex = 3;
            this.lblORG_CD.Text = "예산부서그룹";
            this.lblORG_CD.UseMnemonic = false;
            // 
            // popOrgId
            // 
            this.popOrgId.AllowMultiValue = false;
            this.popOrgId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popOrgId.AutoPopupCodeParameter = null;
            this.popOrgId.AutoPopupID = null;
            this.popOrgId.AutoPopupNameParameter = null;
            this.popOrgId.CodeMaxLength = 10;
            this.popOrgId.CodeName = "";
            this.popOrgId.CodeSize = 100;
            this.popOrgId.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popOrgId.CodeTextBoxName = null;
            this.popOrgId.CodeValue = "";
            this.popOrgId.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popOrgId.Location = new System.Drawing.Point(112, 7);
            this.popOrgId.LockedField = false;
            this.popOrgId.Margin = new System.Windows.Forms.Padding(0);
            this.popOrgId.Name = "popOrgId";
            this.popOrgId.NameDisplay = true;
            this.popOrgId.NameId = null;
            this.popOrgId.NameMaxLength = 50;
            this.popOrgId.NamePopup = false;
            this.popOrgId.NameSize = 150;
            this.popOrgId.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popOrgId.Parameter = null;
            this.popOrgId.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popOrgId.PopupId = null;
            this.popOrgId.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popOrgId.QueryIfEnterKeyPressed = true;
            this.popOrgId.RequiredField = false;
            this.popOrgId.Size = new System.Drawing.Size(271, 21);
            this.popOrgId.SmartComboType = Bizentro.AppFramework.UI.Controls.SmartComboType.Default;
            this.popOrgId.TabIndex = 6;
            this.popOrgId.uniALT = "부서개편ID";
            this.popOrgId.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.popOrgId.UseDynamicFormat = false;
            this.popOrgId.ValueTextBoxName = null;
            this.popOrgId.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popOrgId_BeforePopupOpen);
            this.popOrgId.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popOrgId_AfterPopupClosed);
            // 
            // cboBdgCtrlUnit
            // 
            this.cboBdgCtrlUnit.AddEmptyRow = false;
            this.cboBdgCtrlUnit.AllowDrop = true;
            this.cboBdgCtrlUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboBdgCtrlUnit.ComboFrom = "";
            this.cboBdgCtrlUnit.ComboMajorCd = "";
            this.cboBdgCtrlUnit.ComboSelect = "";
            this.cboBdgCtrlUnit.ComboType = Bizentro.AppFramework.UI.Variables.enumDef.ComboType.MajorCode;
            this.cboBdgCtrlUnit.ComboWhere = "";
            this.cboBdgCtrlUnit.DropDownListWidth = -1;
            this.cboBdgCtrlUnit.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cboBdgCtrlUnit.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.cboBdgCtrlUnit.Location = new System.Drawing.Point(513, 7);
            this.cboBdgCtrlUnit.LockedField = false;
            this.cboBdgCtrlUnit.Margin = new System.Windows.Forms.Padding(0);
            this.cboBdgCtrlUnit.Name = "cboBdgCtrlUnit";
            this.cboBdgCtrlUnit.RequiredField = false;
            this.cboBdgCtrlUnit.Size = new System.Drawing.Size(120, 21);
            this.cboBdgCtrlUnit.Style = Bizentro.AppFramework.UI.Controls.Combo_Style.Default;
            this.cboBdgCtrlUnit.StyleSetName = "Default";
            this.cboBdgCtrlUnit.TabIndex = 12;
            this.cboBdgCtrlUnit.uniALT = null;
            this.cboBdgCtrlUnit.Visible = false;
            // 
            // lblBdgCtrlUnit
            // 
            appearance6.TextHAlignAsString = "Left";
            appearance6.TextVAlignAsString = "Middle";
            this.lblBdgCtrlUnit.Appearance = appearance6;
            this.lblBdgCtrlUnit.AutoPopupID = null;
            this.lblBdgCtrlUnit.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblBdgCtrlUnit.Location = new System.Drawing.Point(416, 6);
            this.lblBdgCtrlUnit.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lblBdgCtrlUnit.Name = "lblBdgCtrlUnit";
            this.lblBdgCtrlUnit.Size = new System.Drawing.Size(97, 22);
            this.lblBdgCtrlUnit.StyleSetName = "Default";
            this.lblBdgCtrlUnit.TabIndex = 13;
            this.lblBdgCtrlUnit.Text = "Budget Ctrl Unit";
            this.lblBdgCtrlUnit.UseMnemonic = false;
            this.lblBdgCtrlUnit.Visible = false;
            // 
            // dtBdgYymm
            // 
            this.dtBdgYymm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtBdgYymm.DateType = Bizentro.AppFramework.UI.Variables.enumDef.DateType.Default;
            this.dtBdgYymm.FieldTypeFrom = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.dtBdgYymm.FieldTypeTo = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.dtBdgYymm.Location = new System.Drawing.Point(112, 30);
            this.dtBdgYymm.Margin = new System.Windows.Forms.Padding(0);
            this.dtBdgYymm.MonthViewStyle = Bizentro.AppFramework.UI.Variables.enumDef.DateTermStyle.SingleMonthView;
            this.dtBdgYymm.Name = "dtBdgYymm";
            this.dtBdgYymm.Size = new System.Drawing.Size(225, 21);
            this.dtBdgYymm.Style = Bizentro.AppFramework.UI.Controls.DateTime_Style.YYYYMM;
            this.dtBdgYymm.TabIndex = 2;
            this.dtBdgYymm.uniFromALT = "예산년월[From]";
            this.dtBdgYymm.uniFromValue = new System.DateTime(2007, 8, 1, 0, 0, 0, 0);
            this.dtBdgYymm.uniTabSameValue = false;
            this.dtBdgYymm.uniToALT = "예산년월[To]";
            this.dtBdgYymm.uniToValue = new System.DateTime(2007, 8, 1, 0, 0, 0, 0);
            // 
            // uniTBL_MainReference
            // 
            this.uniTBL_MainReference.AutoFit = false;
            this.uniTBL_MainReference.AutoFitColumnCount = 4;
            this.uniTBL_MainReference.AutoFitRowCount = 4;
            this.uniTBL_MainReference.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainReference.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainReference.ColumnCount = 3;
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.DefaultRowSize = 25;
            this.uniTBL_MainReference.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainReference.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainReference.Location = new System.Drawing.Point(0, 0);
            this.uniTBL_MainReference.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainReference.Name = "uniTBL_MainReference";
            this.uniTBL_MainReference.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainReference.RowCount = 1;
            this.uniTBL_MainReference.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.uniTBL_MainReference.Size = new System.Drawing.Size(804, 21);
            this.uniTBL_MainReference.SizeTD5 = 14F;
            this.uniTBL_MainReference.SizeTD6 = 36F;
            this.uniTBL_MainReference.TabIndex = 2;
            this.uniTBL_MainReference.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainBatch
            // 
            this.uniTBL_MainBatch.AutoFit = false;
            this.uniTBL_MainBatch.AutoFitColumnCount = 4;
            this.uniTBL_MainBatch.AutoFitRowCount = 4;
            this.uniTBL_MainBatch.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainBatch.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainBatch.ColumnCount = 5;
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.DefaultRowSize = 25;
            this.uniTBL_MainBatch.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainBatch.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainBatch.Location = new System.Drawing.Point(0, 474);
            this.uniTBL_MainBatch.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainBatch.Name = "uniTBL_MainBatch";
            this.uniTBL_MainBatch.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainBatch.RowCount = 1;
            this.uniTBL_MainBatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.uniTBL_MainBatch.Size = new System.Drawing.Size(804, 28);
            this.uniTBL_MainBatch.SizeTD5 = 14F;
            this.uniTBL_MainBatch.SizeTD6 = 36F;
            this.uniTBL_MainBatch.TabIndex = 3;
            this.uniTBL_MainBatch.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainData
            // 
            this.uniTBL_MainData.AutoFit = false;
            this.uniTBL_MainData.AutoFitColumnCount = 4;
            this.uniTBL_MainData.AutoFitRowCount = 4;
            this.uniTBL_MainData.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainData.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainData.ColumnCount = 1;
            this.uniTBL_MainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.Controls.Add(this.uniGrid1, 0, 0);
            this.uniTBL_MainData.DefaultRowSize = 23;
            this.uniTBL_MainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainData.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainData.HEIGHT_TYPE_00_REFERENCE = 25F;
            this.uniTBL_MainData.HEIGHT_TYPE_01 = 9F;
            this.uniTBL_MainData.HEIGHT_TYPE_01_CONDITION = 40F;
            this.uniTBL_MainData.HEIGHT_TYPE_02 = 9F;
            this.uniTBL_MainData.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainData.HEIGHT_TYPE_03 = 9F;
            this.uniTBL_MainData.HEIGHT_TYPE_03_BOTTOM = 25F;
            this.uniTBL_MainData.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainData.Location = new System.Drawing.Point(0, 120);
            this.uniTBL_MainData.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainData.Name = "uniTBL_MainData";
            this.uniTBL_MainData.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Data;
            this.uniTBL_MainData.RowCount = 1;
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uniTBL_MainData.Size = new System.Drawing.Size(804, 351);
            this.uniTBL_MainData.SizeTD5 = 14F;
            this.uniTBL_MainData.SizeTD6 = 36F;
            this.uniTBL_MainData.TabIndex = 4;
            this.uniTBL_MainData.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniGrid1
            // 
            this.uniGrid1.AddEmptyRow = false;
            this.uniGrid1.DirectPaste = false;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            appearance7.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.uniGrid1.DisplayLayout.Appearance = appearance7;
            this.uniGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.uniGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.GroupByBox.Appearance = appearance8;
            appearance9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance9;
            this.uniGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance10.BackColor2 = System.Drawing.SystemColors.Control;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance10;
            this.uniGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.uniGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uniGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance11;
            this.uniGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.uniGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.uniGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance13.BorderColor = System.Drawing.Color.Silver;
            appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.uniGrid1.DisplayLayout.Override.CellAppearance = appearance13;
            this.uniGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.uniGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance14.BackColor = System.Drawing.SystemColors.Control;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance14;
            appearance15.TextHAlignAsString = "Left";
            this.uniGrid1.DisplayLayout.Override.HeaderAppearance = appearance15;
            this.uniGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.uniGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance16.BackColor = System.Drawing.SystemColors.Window;
            appearance16.BorderColor = System.Drawing.Color.Silver;
            this.uniGrid1.DisplayLayout.Override.RowAppearance = appearance16;
            this.uniGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uniGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance17;
            this.uniGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uniGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uniGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniGrid1.EnableContextMenu = true;
            this.uniGrid1.EnableGridFilterMenu = false;
            this.uniGrid1.EnableGridInfoContextMenu = true;
            this.uniGrid1.ExceptInExcel = false;
            this.uniGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniGrid1.gComNumDec = Bizentro.AppFramework.UI.Variables.enumDef.ComDec.Decimal;
            this.uniGrid1.GridStyle = Bizentro.AppFramework.UI.Variables.enumDef.GridStyle.Master;
            this.uniGrid1.Location = new System.Drawing.Point(0, 0);
            this.uniGrid1.Margin = new System.Windows.Forms.Padding(0);
            this.uniGrid1.Name = "uniGrid1";
            this.uniGrid1.OutlookGroupBy = Bizentro.AppFramework.UI.Variables.enumDef.IsOutlookGroupBy.No;
            this.uniGrid1.PopupDeleteMenuVisible = true;
            this.uniGrid1.PopupInsertMenuVisible = true;
            this.uniGrid1.PopupUndoMenuVisible = true;
            this.uniGrid1.Search = Bizentro.AppFramework.UI.Variables.enumDef.IsSearch.Yes;
            this.uniGrid1.ShowHeaderCheck = true;
            this.uniGrid1.Size = new System.Drawing.Size(804, 351);
            this.uniGrid1.StyleSetName = "uniGrid_Query";
            this.uniGrid1.TabIndex = 0;
            this.uniGrid1.Text = "uniGrid1";
            this.uniGrid1.UseDynamicFormat = false;
            this.uniGrid1.AfterRowActivate += new System.EventHandler(this.uniGrid1_AfterRowActivate);
            // 
            // popBdgCdFr
            // 
            this.popBdgCdFr.AllowMultiValue = false;
            this.popBdgCdFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popBdgCdFr.AutoPopupCodeParameter = null;
            this.popBdgCdFr.AutoPopupID = null;
            this.popBdgCdFr.AutoPopupNameParameter = null;
            this.popBdgCdFr.CodeMaxLength = 10;
            this.popBdgCdFr.CodeName = "";
            this.popBdgCdFr.CodeSize = 100;
            this.popBdgCdFr.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popBdgCdFr.CodeTextBoxName = null;
            this.popBdgCdFr.CodeValue = "";
            this.popBdgCdFr.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popBdgCdFr.Location = new System.Drawing.Point(112, 53);
            this.popBdgCdFr.LockedField = false;
            this.popBdgCdFr.Margin = new System.Windows.Forms.Padding(0);
            this.popBdgCdFr.Name = "popBdgCdFr";
            this.popBdgCdFr.NameDisplay = true;
            this.popBdgCdFr.NameId = null;
            this.popBdgCdFr.NameMaxLength = 50;
            this.popBdgCdFr.NamePopup = false;
            this.popBdgCdFr.NameSize = 150;
            this.popBdgCdFr.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popBdgCdFr.Parameter = null;
            this.popBdgCdFr.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popBdgCdFr.PopupId = null;
            this.popBdgCdFr.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popBdgCdFr.QueryIfEnterKeyPressed = true;
            this.popBdgCdFr.RequiredField = false;
            this.popBdgCdFr.Size = new System.Drawing.Size(271, 21);
            this.popBdgCdFr.SmartComboType = Bizentro.AppFramework.UI.Controls.SmartComboType.Default;
            this.popBdgCdFr.TabIndex = 10;
            this.popBdgCdFr.uniALT = "시작예산";
            this.popBdgCdFr.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.popBdgCdFr.UseDynamicFormat = false;
            this.popBdgCdFr.ValueTextBoxName = null;
            this.popBdgCdFr.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popBdgCdFr_BeforePopupOpen);
            this.popBdgCdFr.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popBdgCdFr_AfterPopupClosed);
            // 
            // lblBdgCdTo
            // 
            appearance4.TextHAlignAsString = "Left";
            appearance4.TextVAlignAsString = "Middle";
            this.lblBdgCdTo.Appearance = appearance4;
            this.lblBdgCdTo.AutoPopupID = null;
            this.lblBdgCdTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBdgCdTo.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblBdgCdTo.Location = new System.Drawing.Point(416, 52);
            this.lblBdgCdTo.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lblBdgCdTo.Name = "lblBdgCdTo";
            this.lblBdgCdTo.Size = new System.Drawing.Size(97, 22);
            this.lblBdgCdTo.StyleSetName = "Default";
            this.lblBdgCdTo.TabIndex = 7;
            this.lblBdgCdTo.Text = "To Budget";
            this.lblBdgCdTo.UseMnemonic = false;
            // 
            // popBdgCdTo
            // 
            this.popBdgCdTo.AllowMultiValue = false;
            this.popBdgCdTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popBdgCdTo.AutoPopupCodeParameter = null;
            this.popBdgCdTo.AutoPopupID = null;
            this.popBdgCdTo.AutoPopupNameParameter = null;
            this.popBdgCdTo.CodeMaxLength = 10;
            this.popBdgCdTo.CodeName = "";
            this.popBdgCdTo.CodeSize = 100;
            this.popBdgCdTo.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popBdgCdTo.CodeTextBoxName = null;
            this.popBdgCdTo.CodeValue = "";
            this.popBdgCdTo.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popBdgCdTo.Location = new System.Drawing.Point(513, 53);
            this.popBdgCdTo.LockedField = false;
            this.popBdgCdTo.Margin = new System.Windows.Forms.Padding(0);
            this.popBdgCdTo.Name = "popBdgCdTo";
            this.popBdgCdTo.NameDisplay = true;
            this.popBdgCdTo.NameId = null;
            this.popBdgCdTo.NameMaxLength = 50;
            this.popBdgCdTo.NamePopup = false;
            this.popBdgCdTo.NameSize = 150;
            this.popBdgCdTo.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popBdgCdTo.Parameter = null;
            this.popBdgCdTo.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popBdgCdTo.PopupId = null;
            this.popBdgCdTo.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popBdgCdTo.QueryIfEnterKeyPressed = true;
            this.popBdgCdTo.RequiredField = false;
            this.popBdgCdTo.Size = new System.Drawing.Size(271, 21);
            this.popBdgCdTo.SmartComboType = Bizentro.AppFramework.UI.Controls.SmartComboType.Default;
            this.popBdgCdTo.TabIndex = 8;
            this.popBdgCdTo.uniALT = "종료예산";
            this.popBdgCdTo.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.popBdgCdTo.UseDynamicFormat = false;
            this.popBdgCdTo.ValueTextBoxName = null;
            this.popBdgCdTo.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popBdgCdTo_BeforePopupOpen);
            this.popBdgCdTo.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popBdgCdTo_AfterPopupClosed);
            // 
            // lblBdgCdFr
            // 
            appearance1.TextHAlignAsString = "Left";
            appearance1.TextVAlignAsString = "Middle";
            this.lblBdgCdFr.Appearance = appearance1;
            this.lblBdgCdFr.AutoPopupID = null;
            this.lblBdgCdFr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBdgCdFr.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblBdgCdFr.Location = new System.Drawing.Point(15, 52);
            this.lblBdgCdFr.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lblBdgCdFr.Name = "lblBdgCdFr";
            this.lblBdgCdFr.Size = new System.Drawing.Size(97, 22);
            this.lblBdgCdFr.StyleSetName = "Default";
            this.lblBdgCdFr.TabIndex = 9;
            this.lblBdgCdFr.Text = "From Budget";
            this.lblBdgCdFr.UseMnemonic = false;
            // 
            // ModuleViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uniTBL_OuterMost);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "ModuleViewer";
            this.Size = new System.Drawing.Size(815, 523);
            this.Controls.SetChildIndex(this.uniTBL_OuterMost, 0);
            this.Controls.SetChildIndex(this.uniLabel_Path, 0);
            this.uniTBL_OuterMost.ResumeLayout(false);
            this.uniTBL_MainCondition.ResumeLayout(false);
            this.uniTBL_MainCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBdgCtrlUnit)).EndInit();
            this.uniTBL_MainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_OuterMost;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainReference;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainBatch;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainData;
        private Bizentro.AppFramework.UI.Controls.uniGrid uniGrid1;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainCondition;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblORG_CD;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblOrgId;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblBdgYymmFr;
        private Bizentro.AppFramework.UI.Controls.uniDateTerm dtBdgYymm;
        private Bizentro.AppFramework.UI.Controls.uniOpenPopup popORG_CD;
        private Bizentro.AppFramework.UI.Controls.uniOpenPopup popOrgId;
        private Bizentro.AppFramework.UI.Controls.uniCombo cboBdgCtrlUnit;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblBdgCtrlUnit;
        private uniLabel lblBdgCdFr;
        private uniOpenPopup popBdgCdTo;
        private uniLabel lblBdgCdTo;
        private uniOpenPopup popBdgCdFr;
    }
}
