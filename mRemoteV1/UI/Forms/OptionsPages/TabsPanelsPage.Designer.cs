

namespace mRemoteNG.UI.Forms.OptionsPages
{
	
    public sealed partial class TabsPanelsPage : OptionsPage
	{
			
		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
			
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
			
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabsPanelsPage));
            this.chkAlwaysShowPanelTabs = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.chkIdentifyQuickConnectTabs = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.chkOpenNewTabRightOfSelected = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.chkAlwaysShowPanelSelectionDlg = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.chkShowLogonInfoOnTabs = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.chkDoubleClickClosesTab = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.chkShowProtocolOnTabs = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.chkCreateEmptyPanelOnStart = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.txtBoxPanelName = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.lblPanelName = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.chkShowHostnameOnTabs = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.SuspendLayout();
            // 
            // chkAlwaysShowPanelTabs
            // 
            this.chkAlwaysShowPanelTabs._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkAlwaysShowPanelTabs.AutoSize = true;
            this.chkAlwaysShowPanelTabs.Location = new System.Drawing.Point(5, 6);
            this.chkAlwaysShowPanelTabs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkAlwaysShowPanelTabs.Name = "chkAlwaysShowPanelTabs";
            this.chkAlwaysShowPanelTabs.Size = new System.Drawing.Size(247, 29);
            this.chkAlwaysShowPanelTabs.TabIndex = 0;
            this.chkAlwaysShowPanelTabs.Text = "Always show panel tabs";
            this.chkAlwaysShowPanelTabs.UseVisualStyleBackColor = true;
            // 
            // chkIdentifyQuickConnectTabs
            // 
            this.chkIdentifyQuickConnectTabs._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkIdentifyQuickConnectTabs.AutoSize = true;
            this.chkIdentifyQuickConnectTabs.Location = new System.Drawing.Point(5, 214);
            this.chkIdentifyQuickConnectTabs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkIdentifyQuickConnectTabs.Name = "chkIdentifyQuickConnectTabs";
            this.chkIdentifyQuickConnectTabs.Size = new System.Drawing.Size(517, 29);
            this.chkIdentifyQuickConnectTabs.TabIndex = 4;
            this.chkIdentifyQuickConnectTabs.Text = global::mRemoteNG.Language.strIdentifyQuickConnectTabs;
            this.chkIdentifyQuickConnectTabs.UseVisualStyleBackColor = true;
            // 
            // chkOpenNewTabRightOfSelected
            // 
            this.chkOpenNewTabRightOfSelected._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkOpenNewTabRightOfSelected.AutoSize = true;
            this.chkOpenNewTabRightOfSelected.Location = new System.Drawing.Point(5, 48);
            this.chkOpenNewTabRightOfSelected.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkOpenNewTabRightOfSelected.Name = "chkOpenNewTabRightOfSelected";
            this.chkOpenNewTabRightOfSelected.Size = new System.Drawing.Size(497, 29);
            this.chkOpenNewTabRightOfSelected.TabIndex = 1;
            this.chkOpenNewTabRightOfSelected.Text = "Open new tab to the right of the currently selected tab";
            this.chkOpenNewTabRightOfSelected.UseVisualStyleBackColor = true;
            // 
            // chkAlwaysShowPanelSelectionDlg
            // 
            this.chkAlwaysShowPanelSelectionDlg._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkAlwaysShowPanelSelectionDlg.AutoSize = true;
            this.chkAlwaysShowPanelSelectionDlg.Location = new System.Drawing.Point(5, 299);
            this.chkAlwaysShowPanelSelectionDlg.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkAlwaysShowPanelSelectionDlg.Name = "chkAlwaysShowPanelSelectionDlg";
            this.chkAlwaysShowPanelSelectionDlg.Size = new System.Drawing.Size(570, 29);
            this.chkAlwaysShowPanelSelectionDlg.TabIndex = 6;
            this.chkAlwaysShowPanelSelectionDlg.Text = "Always show panel selection dialog when opening connectins";
            this.chkAlwaysShowPanelSelectionDlg.UseVisualStyleBackColor = true;
            // 
            // chkShowLogonInfoOnTabs
            // 
            this.chkShowLogonInfoOnTabs._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkShowLogonInfoOnTabs.AutoSize = true;
            this.chkShowLogonInfoOnTabs.Location = new System.Drawing.Point(5, 90);
            this.chkShowLogonInfoOnTabs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkShowLogonInfoOnTabs.Name = "chkShowLogonInfoOnTabs";
            this.chkShowLogonInfoOnTabs.Size = new System.Drawing.Size(364, 29);
            this.chkShowLogonInfoOnTabs.TabIndex = 2;
            this.chkShowLogonInfoOnTabs.Text = "Show logon information on tab names";
            this.chkShowLogonInfoOnTabs.UseVisualStyleBackColor = true;
            // 
            // chkDoubleClickClosesTab
            // 
            this.chkDoubleClickClosesTab._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkDoubleClickClosesTab.AutoSize = true;
            this.chkDoubleClickClosesTab.Location = new System.Drawing.Point(5, 257);
            this.chkDoubleClickClosesTab.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkDoubleClickClosesTab.Name = "chkDoubleClickClosesTab";
            this.chkDoubleClickClosesTab.Size = new System.Drawing.Size(277, 29);
            this.chkDoubleClickClosesTab.TabIndex = 5;
            this.chkDoubleClickClosesTab.Text = "Double click on tab closes it";
            this.chkDoubleClickClosesTab.UseVisualStyleBackColor = true;
            // 
            // chkShowProtocolOnTabs
            // 
            this.chkShowProtocolOnTabs._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkShowProtocolOnTabs.AutoSize = true;
            this.chkShowProtocolOnTabs.Location = new System.Drawing.Point(5, 172);
            this.chkShowProtocolOnTabs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkShowProtocolOnTabs.Name = "chkShowProtocolOnTabs";
            this.chkShowProtocolOnTabs.Size = new System.Drawing.Size(295, 29);
            this.chkShowProtocolOnTabs.TabIndex = 3;
            this.chkShowProtocolOnTabs.Text = "Show protocols on tab names";
            this.chkShowProtocolOnTabs.UseVisualStyleBackColor = true;
            // 
            // chkCreateEmptyPanelOnStart
            // 
            this.chkCreateEmptyPanelOnStart._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkCreateEmptyPanelOnStart.AutoSize = true;
            this.chkCreateEmptyPanelOnStart.Location = new System.Drawing.Point(5, 341);
            this.chkCreateEmptyPanelOnStart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkCreateEmptyPanelOnStart.Name = "chkCreateEmptyPanelOnStart";
            this.chkCreateEmptyPanelOnStart.Size = new System.Drawing.Size(456, 29);
            this.chkCreateEmptyPanelOnStart.TabIndex = 7;
            this.chkCreateEmptyPanelOnStart.Text = "Create an empty panel when mRemoteNG starts";
            this.chkCreateEmptyPanelOnStart.UseVisualStyleBackColor = true;
            this.chkCreateEmptyPanelOnStart.CheckedChanged += new System.EventHandler(this.chkCreateEmptyPanelOnStart_CheckedChanged);
            // 
            // txtBoxPanelName
            // 
            this.txtBoxPanelName.Location = new System.Drawing.Point(78, 408);
            this.txtBoxPanelName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxPanelName.Name = "txtBoxPanelName";
            this.txtBoxPanelName.Size = new System.Drawing.Size(388, 29);
            this.txtBoxPanelName.TabIndex = 8;
            // 
            // lblPanelName
            // 
            this.lblPanelName.AutoSize = true;
            this.lblPanelName.Location = new System.Drawing.Point(73, 378);
            this.lblPanelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPanelName.Name = "lblPanelName";
            this.lblPanelName.Size = new System.Drawing.Size(122, 25);
            this.lblPanelName.TabIndex = 9;
            this.lblPanelName.Text = "Panel name:";
            // 
            // chkShowHostnameOnTabs
            // 
            this.chkShowHostnameOnTabs._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkShowHostnameOnTabs.AutoSize = true;
            this.chkShowHostnameOnTabs.Location = new System.Drawing.Point(5, 131);
            this.chkShowHostnameOnTabs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkShowHostnameOnTabs.Name = "chkShowHostnameOnTabs";
            this.chkShowHostnameOnTabs.Size = new System.Drawing.Size(323, 29);
            this.chkShowHostnameOnTabs.TabIndex = 10;
            this.chkShowHostnameOnTabs.Text = "Show hostname/ip on tab names";
            this.chkShowHostnameOnTabs.UseVisualStyleBackColor = true;
            // 
            // TabsPanelsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkShowHostnameOnTabs);
            this.Controls.Add(this.lblPanelName);
            this.Controls.Add(this.txtBoxPanelName);
            this.Controls.Add(this.chkCreateEmptyPanelOnStart);
            this.Controls.Add(this.chkAlwaysShowPanelTabs);
            this.Controls.Add(this.chkIdentifyQuickConnectTabs);
            this.Controls.Add(this.chkOpenNewTabRightOfSelected);
            this.Controls.Add(this.chkAlwaysShowPanelSelectionDlg);
            this.Controls.Add(this.chkShowLogonInfoOnTabs);
            this.Controls.Add(this.chkDoubleClickClosesTab);
            this.Controls.Add(this.chkShowProtocolOnTabs);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TabsPanelsPage";
            this.PageIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PageIcon")));
            this.Size = new System.Drawing.Size(1118, 902);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal Controls.Base.NGCheckBox chkAlwaysShowPanelTabs;
		internal Controls.Base.NGCheckBox chkIdentifyQuickConnectTabs;
		internal Controls.Base.NGCheckBox chkOpenNewTabRightOfSelected;
		internal Controls.Base.NGCheckBox chkAlwaysShowPanelSelectionDlg;
		internal Controls.Base.NGCheckBox chkShowLogonInfoOnTabs;
		internal Controls.Base.NGCheckBox chkDoubleClickClosesTab;
		internal Controls.Base.NGCheckBox chkShowProtocolOnTabs;
        private Controls.Base.NGCheckBox chkCreateEmptyPanelOnStart;
        private Controls.Base.NGTextBox txtBoxPanelName;
        private Controls.Base.NGLabel lblPanelName;
        internal Controls.Base.NGCheckBox chkShowHostnameOnTabs;
    }
}
