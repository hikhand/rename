﻿namespace rename
{
    partial class Rename
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rename));
            this.TT_main = new System.Windows.Forms.ToolTip(this.components);
            this.Replace_Btn_Clear = new System.Windows.Forms.Button();
            this.Add_Btn_Clear = new System.Windows.Forms.Button();
            this.Replace_RB_CurrentDir = new System.Windows.Forms.RadioButton();
            this.Replace_RB_AllDir = new System.Windows.Forms.RadioButton();
            this.GbPath = new System.Windows.Forms.GroupBox();
            this.Path_TB_Path = new System.Windows.Forms.TextBox();
            this.Path_Llbl_Path = new System.Windows.Forms.LinkLabel();
            this.GbReplace = new System.Windows.Forms.GroupBox();
            this.Replace_Btn_Rename = new System.Windows.Forms.Button();
            this.Replace_CB_ReplaceFolder = new System.Windows.Forms.CheckBox();
            this.Replace_CB_ReplaceFile = new System.Windows.Forms.CheckBox();
            this.Replace_Lbl_To = new System.Windows.Forms.Label();
            this.Replace_TB_To = new System.Windows.Forms.TextBox();
            this.Replace_TB_From = new System.Windows.Forms.TextBox();
            this.Replace_Lbl_ReplaceFrom = new System.Windows.Forms.Label();
            this.Fbd_Path = new System.Windows.Forms.FolderBrowserDialog();
            this.SS_main = new System.Windows.Forms.StatusStrip();
            this.Rename_SS_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.GbAddToEnd = new System.Windows.Forms.GroupBox();
            this.Add_Cb_AddToFirst = new System.Windows.Forms.CheckBox();
            this.Add_Btn_Add = new System.Windows.Forms.Button();
            this.Add_Rb_AllDir = new System.Windows.Forms.RadioButton();
            this.Add_Tb_Text = new System.Windows.Forms.TextBox();
            this.Add_Rb_CurrentDir = new System.Windows.Forms.RadioButton();
            this.Add_Lbl_TextToAdd = new System.Windows.Forms.Label();
            this.Add_Cb_AddToFolder = new System.Windows.Forms.CheckBox();
            this.Add_Cb_AddToFile = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbPath.SuspendLayout();
            this.GbReplace.SuspendLayout();
            this.SS_main.SuspendLayout();
            this.GbAddToEnd.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Replace_Btn_Clear
            // 
            this.Replace_Btn_Clear.Location = new System.Drawing.Point(201, 98);
            this.Replace_Btn_Clear.Name = "Replace_Btn_Clear";
            this.Replace_Btn_Clear.Size = new System.Drawing.Size(80, 25);
            this.Replace_Btn_Clear.TabIndex = 8;
            this.Replace_Btn_Clear.Text = "Clear";
            this.TT_main.SetToolTip(this.Replace_Btn_Clear, "Back fields to default");
            this.Replace_Btn_Clear.UseVisualStyleBackColor = true;
            this.Replace_Btn_Clear.Click += new System.EventHandler(this.Replace_Btn_Clear_Click);
            // 
            // Add_Btn_Clear
            // 
            this.Add_Btn_Clear.Location = new System.Drawing.Point(201, 112);
            this.Add_Btn_Clear.Name = "Add_Btn_Clear";
            this.Add_Btn_Clear.Size = new System.Drawing.Size(80, 25);
            this.Add_Btn_Clear.TabIndex = 14;
            this.Add_Btn_Clear.Text = "Clear";
            this.TT_main.SetToolTip(this.Add_Btn_Clear, "Back fields to default");
            this.Add_Btn_Clear.UseVisualStyleBackColor = true;
            this.Add_Btn_Clear.Click += new System.EventHandler(this.Add_Btn_Clear_Click);
            // 
            // Replace_RB_CurrentDir
            // 
            this.Replace_RB_CurrentDir.AutoSize = true;
            this.Replace_RB_CurrentDir.Checked = true;
            this.Replace_RB_CurrentDir.Location = new System.Drawing.Point(110, 74);
            this.Replace_RB_CurrentDir.Name = "Replace_RB_CurrentDir";
            this.Replace_RB_CurrentDir.Size = new System.Drawing.Size(115, 19);
            this.Replace_RB_CurrentDir.TabIndex = 6;
            this.Replace_RB_CurrentDir.TabStop = true;
            this.Replace_RB_CurrentDir.Text = "Current directory";
            this.TT_main.SetToolTip(this.Replace_RB_CurrentDir, "Replace the names of files that are\r\nexist only in this folder.");
            this.Replace_RB_CurrentDir.UseVisualStyleBackColor = true;
            // 
            // Replace_RB_AllDir
            // 
            this.Replace_RB_AllDir.AutoSize = true;
            this.Replace_RB_AllDir.Location = new System.Drawing.Point(233, 74);
            this.Replace_RB_AllDir.Name = "Replace_RB_AllDir";
            this.Replace_RB_AllDir.Size = new System.Drawing.Size(97, 19);
            this.Replace_RB_AllDir.TabIndex = 6;
            this.Replace_RB_AllDir.Text = "All directories";
            this.TT_main.SetToolTip(this.Replace_RB_AllDir, "Replace the names of files that are\r\nexist in this and all of sub folders");
            this.Replace_RB_AllDir.UseVisualStyleBackColor = true;
            // 
            // GbPath
            // 
            this.GbPath.BackColor = System.Drawing.Color.White;
            this.GbPath.Controls.Add(this.Path_TB_Path);
            this.GbPath.Controls.Add(this.Path_Llbl_Path);
            this.GbPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbPath.Location = new System.Drawing.Point(3, 28);
            this.GbPath.Name = "GbPath";
            this.GbPath.Size = new System.Drawing.Size(376, 54);
            this.GbPath.TabIndex = 0;
            this.GbPath.TabStop = false;
            this.GbPath.Text = "Source Folder";
            // 
            // Path_TB_Path
            // 
            this.Path_TB_Path.AcceptsReturn = true;
            this.Path_TB_Path.AcceptsTab = true;
            this.Path_TB_Path.BackColor = System.Drawing.Color.Ivory;
            this.Path_TB_Path.Location = new System.Drawing.Point(110, 20);
            this.Path_TB_Path.Name = "Path_TB_Path";
            this.Path_TB_Path.Size = new System.Drawing.Size(252, 23);
            this.Path_TB_Path.TabIndex = 0;
            this.Path_TB_Path.TextChanged += new System.EventHandler(this.Path_TB_Path_TextChanged);
            // 
            // Path_Llbl_Path
            // 
            this.Path_Llbl_Path.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.Path_Llbl_Path.AutoSize = true;
            this.Path_Llbl_Path.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Path_Llbl_Path.LinkColor = System.Drawing.Color.White;
            this.Path_Llbl_Path.Location = new System.Drawing.Point(9, 20);
            this.Path_Llbl_Path.Name = "Path_Llbl_Path";
            this.Path_Llbl_Path.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.Path_Llbl_Path.Size = new System.Drawing.Size(89, 23);
            this.Path_Llbl_Path.TabIndex = 1;
            this.Path_Llbl_Path.TabStop = true;
            this.Path_Llbl_Path.Text = "Source Folder";
            this.Path_Llbl_Path.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Path_Llbl_Path_LinkClicked);
            // 
            // GbReplace
            // 
            this.GbReplace.BackColor = System.Drawing.Color.White;
            this.GbReplace.Controls.Add(this.Replace_Btn_Clear);
            this.GbReplace.Controls.Add(this.Replace_Btn_Rename);
            this.GbReplace.Controls.Add(this.Replace_RB_AllDir);
            this.GbReplace.Controls.Add(this.Replace_RB_CurrentDir);
            this.GbReplace.Controls.Add(this.Replace_CB_ReplaceFolder);
            this.GbReplace.Controls.Add(this.Replace_CB_ReplaceFile);
            this.GbReplace.Controls.Add(this.Replace_Lbl_To);
            this.GbReplace.Controls.Add(this.Replace_TB_To);
            this.GbReplace.Controls.Add(this.Replace_TB_From);
            this.GbReplace.Controls.Add(this.Replace_Lbl_ReplaceFrom);
            this.GbReplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbReplace.Location = new System.Drawing.Point(3, 88);
            this.GbReplace.Name = "GbReplace";
            this.GbReplace.Size = new System.Drawing.Size(376, 128);
            this.GbReplace.TabIndex = 1;
            this.GbReplace.TabStop = false;
            this.GbReplace.Text = "replace";
            // 
            // Replace_Btn_Rename
            // 
            this.Replace_Btn_Rename.Location = new System.Drawing.Point(287, 98);
            this.Replace_Btn_Rename.Name = "Replace_Btn_Rename";
            this.Replace_Btn_Rename.Size = new System.Drawing.Size(80, 25);
            this.Replace_Btn_Rename.TabIndex = 7;
            this.Replace_Btn_Rename.Text = "Rename";
            this.Replace_Btn_Rename.UseVisualStyleBackColor = true;
            this.Replace_Btn_Rename.Click += new System.EventHandler(this.Replace_Btn_Rename_Click);
            // 
            // Replace_CB_ReplaceFolder
            // 
            this.Replace_CB_ReplaceFolder.AutoSize = true;
            this.Replace_CB_ReplaceFolder.Location = new System.Drawing.Point(233, 51);
            this.Replace_CB_ReplaceFolder.Name = "Replace_CB_ReplaceFolder";
            this.Replace_CB_ReplaceFolder.Size = new System.Drawing.Size(139, 19);
            this.Replace_CB_ReplaceFolder.TabIndex = 5;
            this.Replace_CB_ReplaceFolder.Text = "Replace folder names";
            this.Replace_CB_ReplaceFolder.UseVisualStyleBackColor = true;
            this.Replace_CB_ReplaceFolder.CheckedChanged += new System.EventHandler(this.Replace_CB_ReplaceFolder_CheckedChanged);
            // 
            // Replace_CB_ReplaceFile
            // 
            this.Replace_CB_ReplaceFile.AutoSize = true;
            this.Replace_CB_ReplaceFile.Checked = true;
            this.Replace_CB_ReplaceFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Replace_CB_ReplaceFile.Location = new System.Drawing.Point(110, 51);
            this.Replace_CB_ReplaceFile.Name = "Replace_CB_ReplaceFile";
            this.Replace_CB_ReplaceFile.Size = new System.Drawing.Size(124, 19);
            this.Replace_CB_ReplaceFile.TabIndex = 4;
            this.Replace_CB_ReplaceFile.Text = "Replace file names";
            this.Replace_CB_ReplaceFile.UseVisualStyleBackColor = true;
            this.Replace_CB_ReplaceFile.CheckedChanged += new System.EventHandler(this.Replace_CB_ReplaceFile_CheckedChanged);
            // 
            // Replace_Lbl_To
            // 
            this.Replace_Lbl_To.AutoSize = true;
            this.Replace_Lbl_To.Location = new System.Drawing.Point(226, 23);
            this.Replace_Lbl_To.Name = "Replace_Lbl_To";
            this.Replace_Lbl_To.Size = new System.Drawing.Size(21, 15);
            this.Replace_Lbl_To.TabIndex = 2;
            this.Replace_Lbl_To.Text = "To";
            // 
            // Replace_TB_To
            // 
            this.Replace_TB_To.Location = new System.Drawing.Point(252, 20);
            this.Replace_TB_To.Name = "Replace_TB_To";
            this.Replace_TB_To.Size = new System.Drawing.Size(110, 23);
            this.Replace_TB_To.TabIndex = 3;
            this.Replace_TB_To.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Replace_TB_To_KeyDown);
            // 
            // Replace_TB_From
            // 
            this.Replace_TB_From.Location = new System.Drawing.Point(110, 19);
            this.Replace_TB_From.Name = "Replace_TB_From";
            this.Replace_TB_From.Size = new System.Drawing.Size(110, 23);
            this.Replace_TB_From.TabIndex = 2;
            this.Replace_TB_From.TextChanged += new System.EventHandler(this.Replace_TB_From_TextChanged);
            this.Replace_TB_From.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Replace_TB_From_KeyDown);
            // 
            // Replace_Lbl_ReplaceFrom
            // 
            this.Replace_Lbl_ReplaceFrom.AutoSize = true;
            this.Replace_Lbl_ReplaceFrom.Location = new System.Drawing.Point(15, 22);
            this.Replace_Lbl_ReplaceFrom.Name = "Replace_Lbl_ReplaceFrom";
            this.Replace_Lbl_ReplaceFrom.Size = new System.Drawing.Size(80, 15);
            this.Replace_Lbl_ReplaceFrom.TabIndex = 0;
            this.Replace_Lbl_ReplaceFrom.Text = "Replace  from";
            // 
            // Fbd_Path
            // 
            this.Fbd_Path.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SS_main
            // 
            this.SS_main.BackColor = System.Drawing.Color.White;
            this.SS_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rename_SS_Status});
            this.SS_main.Location = new System.Drawing.Point(0, 379);
            this.SS_main.Name = "SS_main";
            this.SS_main.Size = new System.Drawing.Size(384, 22);
            this.SS_main.TabIndex = 2;
            this.SS_main.Text = "status Strip";
            // 
            // Rename_SS_Status
            // 
            this.Rename_SS_Status.Name = "Rename_SS_Status";
            this.Rename_SS_Status.Size = new System.Drawing.Size(39, 17);
            this.Rename_SS_Status.Text = "Ready";
            // 
            // GbAddToEnd
            // 
            this.GbAddToEnd.BackColor = System.Drawing.Color.White;
            this.GbAddToEnd.Controls.Add(this.Add_Cb_AddToFirst);
            this.GbAddToEnd.Controls.Add(this.Add_Btn_Clear);
            this.GbAddToEnd.Controls.Add(this.Add_Btn_Add);
            this.GbAddToEnd.Controls.Add(this.Add_Rb_AllDir);
            this.GbAddToEnd.Controls.Add(this.Add_Tb_Text);
            this.GbAddToEnd.Controls.Add(this.Add_Rb_CurrentDir);
            this.GbAddToEnd.Controls.Add(this.Add_Lbl_TextToAdd);
            this.GbAddToEnd.Controls.Add(this.Add_Cb_AddToFolder);
            this.GbAddToEnd.Controls.Add(this.Add_Cb_AddToFile);
            this.GbAddToEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbAddToEnd.Location = new System.Drawing.Point(3, 222);
            this.GbAddToEnd.Name = "GbAddToEnd";
            this.GbAddToEnd.Size = new System.Drawing.Size(376, 143);
            this.GbAddToEnd.TabIndex = 3;
            this.GbAddToEnd.TabStop = false;
            this.GbAddToEnd.Text = "Add to the end";
            // 
            // Add_Cb_AddToFirst
            // 
            this.Add_Cb_AddToFirst.AutoSize = true;
            this.Add_Cb_AddToFirst.Location = new System.Drawing.Point(262, 21);
            this.Add_Cb_AddToFirst.Name = "Add_Cb_AddToFirst";
            this.Add_Cb_AddToFirst.Size = new System.Drawing.Size(105, 19);
            this.Add_Cb_AddToFirst.TabIndex = 9;
            this.Add_Cb_AddToFirst.Text = "Add to the first";
            this.Add_Cb_AddToFirst.UseVisualStyleBackColor = true;
            // 
            // Add_Btn_Add
            // 
            this.Add_Btn_Add.Location = new System.Drawing.Point(287, 112);
            this.Add_Btn_Add.Name = "Add_Btn_Add";
            this.Add_Btn_Add.Size = new System.Drawing.Size(80, 25);
            this.Add_Btn_Add.TabIndex = 13;
            this.Add_Btn_Add.Text = "Add";
            this.Add_Btn_Add.UseVisualStyleBackColor = true;
            this.Add_Btn_Add.Click += new System.EventHandler(this.Add_Btn_Add_Click);
            // 
            // Add_Rb_AllDir
            // 
            this.Add_Rb_AllDir.AutoSize = true;
            this.Add_Rb_AllDir.Location = new System.Drawing.Point(233, 74);
            this.Add_Rb_AllDir.Name = "Add_Rb_AllDir";
            this.Add_Rb_AllDir.Size = new System.Drawing.Size(97, 19);
            this.Add_Rb_AllDir.TabIndex = 12;
            this.Add_Rb_AllDir.Text = "All directories";
            this.Add_Rb_AllDir.UseVisualStyleBackColor = true;
            // 
            // Add_Tb_Text
            // 
            this.Add_Tb_Text.Location = new System.Drawing.Point(110, 19);
            this.Add_Tb_Text.Name = "Add_Tb_Text";
            this.Add_Tb_Text.Size = new System.Drawing.Size(141, 23);
            this.Add_Tb_Text.TabIndex = 8;
            this.Add_Tb_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Add_Tb_Text_KeyDown);
            // 
            // Add_Rb_CurrentDir
            // 
            this.Add_Rb_CurrentDir.AutoSize = true;
            this.Add_Rb_CurrentDir.Checked = true;
            this.Add_Rb_CurrentDir.Location = new System.Drawing.Point(110, 74);
            this.Add_Rb_CurrentDir.Name = "Add_Rb_CurrentDir";
            this.Add_Rb_CurrentDir.Size = new System.Drawing.Size(115, 19);
            this.Add_Rb_CurrentDir.TabIndex = 12;
            this.Add_Rb_CurrentDir.TabStop = true;
            this.Add_Rb_CurrentDir.Text = "Current directory";
            this.Add_Rb_CurrentDir.UseVisualStyleBackColor = true;
            // 
            // Add_Lbl_TextToAdd
            // 
            this.Add_Lbl_TextToAdd.AutoSize = true;
            this.Add_Lbl_TextToAdd.Location = new System.Drawing.Point(15, 22);
            this.Add_Lbl_TextToAdd.Name = "Add_Lbl_TextToAdd";
            this.Add_Lbl_TextToAdd.Size = new System.Drawing.Size(75, 15);
            this.Add_Lbl_TextToAdd.TabIndex = 0;
            this.Add_Lbl_TextToAdd.Text = "Text to add : ";
            // 
            // Add_Cb_AddToFolder
            // 
            this.Add_Cb_AddToFolder.AutoSize = true;
            this.Add_Cb_AddToFolder.Location = new System.Drawing.Point(233, 51);
            this.Add_Cb_AddToFolder.Name = "Add_Cb_AddToFolder";
            this.Add_Cb_AddToFolder.Size = new System.Drawing.Size(134, 19);
            this.Add_Cb_AddToFolder.TabIndex = 11;
            this.Add_Cb_AddToFolder.Text = "Add to folder names";
            this.Add_Cb_AddToFolder.UseVisualStyleBackColor = true;
            this.Add_Cb_AddToFolder.CheckedChanged += new System.EventHandler(this.Add_Cb_AddToFolder_CheckedChanged);
            // 
            // Add_Cb_AddToFile
            // 
            this.Add_Cb_AddToFile.AutoSize = true;
            this.Add_Cb_AddToFile.Checked = true;
            this.Add_Cb_AddToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Add_Cb_AddToFile.Location = new System.Drawing.Point(110, 51);
            this.Add_Cb_AddToFile.Name = "Add_Cb_AddToFile";
            this.Add_Cb_AddToFile.Size = new System.Drawing.Size(119, 19);
            this.Add_Cb_AddToFile.TabIndex = 10;
            this.Add_Cb_AddToFile.Text = "Add to file names";
            this.Add_Cb_AddToFile.UseVisualStyleBackColor = true;
            this.Add_Cb_AddToFile.CheckedChanged += new System.EventHandler(this.Add_Cb_AddToFile_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.GbAddToEnd);
            this.Controls.Add(this.SS_main);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GbReplace);
            this.Controls.Add(this.GbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Rename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simple Renamer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GbPath.ResumeLayout(false);
            this.GbPath.PerformLayout();
            this.GbReplace.ResumeLayout(false);
            this.GbReplace.PerformLayout();
            this.SS_main.ResumeLayout(false);
            this.SS_main.PerformLayout();
            this.GbAddToEnd.ResumeLayout(false);
            this.GbAddToEnd.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip TT_main;
        private System.Windows.Forms.GroupBox GbPath;
        private System.Windows.Forms.TextBox Path_TB_Path;
        private System.Windows.Forms.LinkLabel Path_Llbl_Path;
        private System.Windows.Forms.GroupBox GbReplace;
        private System.Windows.Forms.FolderBrowserDialog Fbd_Path;
        private System.Windows.Forms.Label Replace_Lbl_To;
        private System.Windows.Forms.TextBox Replace_TB_To;
        private System.Windows.Forms.TextBox Replace_TB_From;
        private System.Windows.Forms.Label Replace_Lbl_ReplaceFrom;
        private System.Windows.Forms.CheckBox Replace_CB_ReplaceFile;
        private System.Windows.Forms.CheckBox Replace_CB_ReplaceFolder;
        private System.Windows.Forms.RadioButton Replace_RB_AllDir;
        private System.Windows.Forms.RadioButton Replace_RB_CurrentDir;
        private System.Windows.Forms.Button Replace_Btn_Rename;
        private System.Windows.Forms.Button Replace_Btn_Clear;
        private System.Windows.Forms.StatusStrip SS_main;
        private System.Windows.Forms.ToolStripStatusLabel Rename_SS_Status;
        private System.Windows.Forms.GroupBox GbAddToEnd;
        private System.Windows.Forms.Button Add_Btn_Clear;
        private System.Windows.Forms.Button Add_Btn_Add;
        private System.Windows.Forms.RadioButton Add_Rb_AllDir;
        private System.Windows.Forms.TextBox Add_Tb_Text;
        private System.Windows.Forms.RadioButton Add_Rb_CurrentDir;
        private System.Windows.Forms.Label Add_Lbl_TextToAdd;
        private System.Windows.Forms.CheckBox Add_Cb_AddToFolder;
        private System.Windows.Forms.CheckBox Add_Cb_AddToFile;
        private System.Windows.Forms.CheckBox Add_Cb_AddToFirst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

