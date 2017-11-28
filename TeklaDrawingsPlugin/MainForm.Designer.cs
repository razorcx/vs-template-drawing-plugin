using System.Windows.Forms;

namespace TeklaDrawingsPlugin
{
	partial class MainForm : Tekla.Structures.Dialog.PluginFormBase
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.OkApplyModifyGetOnOffCancel = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
			this.SaveLoadSaveAs = new Tekla.Structures.Dialog.UIControls.SaveLoad();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ParametersTabPage = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OkApplyModifyGetOnOffCancel
			// 
			this.structuresExtender.SetAttributeName(this.OkApplyModifyGetOnOffCancel, null);
			this.structuresExtender.SetAttributeTypeName(this.OkApplyModifyGetOnOffCancel, null);
			this.structuresExtender.SetBindPropertyName(this.OkApplyModifyGetOnOffCancel, null);
			this.OkApplyModifyGetOnOffCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.OkApplyModifyGetOnOffCancel.Location = new System.Drawing.Point(0, 385);
			this.OkApplyModifyGetOnOffCancel.Name = "OkApplyModifyGetOnOffCancel";
			this.OkApplyModifyGetOnOffCancel.Size = new System.Drawing.Size(534, 29);
			this.OkApplyModifyGetOnOffCancel.TabIndex = 15;
			this.OkApplyModifyGetOnOffCancel.OkClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OkClicked);
			this.OkApplyModifyGetOnOffCancel.ModifyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ModifyClicked);
			this.OkApplyModifyGetOnOffCancel.CancelClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_CancelClicked);
			this.OkApplyModifyGetOnOffCancel.OnOffClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OnOffClicked);
			this.OkApplyModifyGetOnOffCancel.GetClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_GetClicked);
			this.OkApplyModifyGetOnOffCancel.ApplyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ApplyClicked);
			// 
			// SaveLoadSaveAs
			// 
			this.structuresExtender.SetAttributeName(this.SaveLoadSaveAs, null);
			this.structuresExtender.SetAttributeTypeName(this.SaveLoadSaveAs, null);
			this.SaveLoadSaveAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.structuresExtender.SetBindPropertyName(this.SaveLoadSaveAs, null);
			this.SaveLoadSaveAs.Dock = System.Windows.Forms.DockStyle.Top;
			this.SaveLoadSaveAs.Location = new System.Drawing.Point(0, 0);
			this.SaveLoadSaveAs.Name = "SaveLoadSaveAs";
			this.SaveLoadSaveAs.SaveAsText = "";
			this.SaveLoadSaveAs.Size = new System.Drawing.Size(534, 43);
			this.SaveLoadSaveAs.TabIndex = 16;
			// 
			// tabControl1
			// 
			this.structuresExtender.SetAttributeName(this.tabControl1, null);
			this.structuresExtender.SetAttributeTypeName(this.tabControl1, null);
			this.structuresExtender.SetBindPropertyName(this.tabControl1, null);
			this.tabControl1.Controls.Add(this.ParametersTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 43);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(534, 342);
			this.tabControl1.TabIndex = 17;
			// 
			// ParametersTabPage
			// 
			this.structuresExtender.SetAttributeName(this.ParametersTabPage, null);
			this.structuresExtender.SetAttributeTypeName(this.ParametersTabPage, null);
			this.structuresExtender.SetBindPropertyName(this.ParametersTabPage, null);
			this.ParametersTabPage.Location = new System.Drawing.Point(4, 22);
			this.ParametersTabPage.Name = "ParametersTabPage";
			this.ParametersTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ParametersTabPage.Size = new System.Drawing.Size(526, 316);
			this.ParametersTabPage.TabIndex = 2;
			this.ParametersTabPage.Text = "albl_Parameters";
			this.ParametersTabPage.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.structuresExtender.SetAttributeName(this, null);
			this.structuresExtender.SetAttributeTypeName(this, null);
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.structuresExtender.SetBindPropertyName(this, null);
			this.ClientSize = new System.Drawing.Size(534, 414);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.SaveLoadSaveAs);
			this.Controls.Add(this.OkApplyModifyGetOnOffCancel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Drawings Plug-in";
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel OkApplyModifyGetOnOffCancel;
		private Tekla.Structures.Dialog.UIControls.SaveLoad SaveLoadSaveAs;
		private TabControl tabControl1;
		private TabPage ParametersTabPage;
	}
}
