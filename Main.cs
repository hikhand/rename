using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rename.Properties;

namespace rename
{
    public partial class Rename : Form
    {
        public Rename()
        {
            InitializeComponent();
        }



        //Part of ALL THE FORM
        private string path = "";

        private void Main_Load(object sender, EventArgs e)
        {
            DisableProcessBtn(Replace_Btn_Rename, Path_TB_Path);

            DisableProcessBtn(Add_Btn_Add, Path_TB_Path);

            ProcessBtn_ToolTip(Replace_Btn_Rename, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder,
                               Resources.RenameFileAndFolder, Resources.RenameJustFile,
                               Resources.RenameJustFolder);

            ProcessBtn_ToolTip(Add_Btn_Add, Add_Cb_AddToFile, Add_Cb_AddToFolder, Resources.RenameFileAndFolder,
                               Resources.RenameJustFile, Resources.RenameJustFolder);
        }

        private FileSystemInfo[] GetDir(RadioButton CurrentDirRadioButton)
        {
            var dirinfo = new DirectoryInfo(path);
            var entries = dirinfo.GetFileSystemInfos("**",
                                                     CurrentDirRadioButton.Checked
                                                         ? SearchOption.TopDirectoryOnly
                                                         : SearchOption.AllDirectories);
            return entries;
        }

        private bool ThereIsNoFile(int numberOfEntries, CheckBox checkBoxFile, CheckBox checkBoxFolder, TextBox source)
        {
            if (numberOfEntries == 0)
            {
                MessageBox.Show(
                    "there is no " +
                    (checkBoxFile.Checked && checkBoxFolder.Checked
                         ? "file or folder"
                         : checkBoxFile.Checked && !checkBoxFolder.Checked ? "file" : "folder") +
                    " with special keyword '" + source.Text + "' to rename", Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private void SuccessfullyRenamedStatus(int numberOfEntries, CheckBox checkBoxFile, CheckBox checkBoxFolder)
        {
            Rename_SS_Status.Text = "'" + numberOfEntries + "'" +
                                    (checkBoxFile.Checked && checkBoxFolder.Checked
                                         ? "' files and folders "
                                         : checkBoxFile.Checked && !checkBoxFolder.Checked
                                               ? "' files "
                                               : "' folders ") +
                                    " Successfully renamed.";
        }

        private bool FieldsReady(CheckBox fileCb, CheckBox folderCb, TextBox textBox, string errorTextBox)
        {
            if ((!fileCb.Checked && !folderCb.Checked) || textBox.Text == "" || !Directory.Exists(path))
            {
                string error = textBox.Text == "" ? errorTextBox : "";
                error += !fileCb.Checked && !folderCb.Checked
                             ? "\n- you have to select one of the check boxes 'current directory' or 'all directories'"
                             : "";
                error += !Directory.Exists(path) ? "\n- The directory you entered doesn't exist." : "";

                MessageBox.Show(error, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Rename_SS_Status.Text = "there is few problem!";
                return false;
            }
            return true;
        }

        private int GetInfo(ref string fullFileNames, RadioButton currentDir, CheckBox checkBoxFile,
                            CheckBox checkBoxFolder, TextBox source)
        {
            int numEntries = 0;
            foreach (var entry in GetDir(currentDir))
            {
                string newName = checkBoxFolder.Checked
                                     ? source.Text + entry.Name
                                     : entry.Name + source.Text;
                int dirLength = entry.FullName.Length - entry.Name.Length;
                string newFullName = entry.FullName.Remove(dirLength) + newName;

                if (Directory.Exists(entry.FullName) && entry.Name != newFullName &&
                    checkBoxFolder.Checked)
                {
                    numEntries++;
                    fullFileNames += '-' + entry.FullName.Replace(path, "") + Environment.NewLine;
                }
                else if (!Directory.Exists(entry.FullName) && checkBoxFile.Checked &&
                         entry.FullName != newFullName)
                {
                    numEntries++;
                    fullFileNames += '-' + entry.FullName.Replace(path, "") + Environment.NewLine;
                }
            }
            return numEntries;
        }

        private void ProcessBtn_ToolTip(Button processBtn, CheckBox checkBoxFile, CheckBox checkBoxFolder,
                                string fileAndFolder, string justFile, string justFolder)
        {
            string buttonToolTip = checkBoxFile.Checked && checkBoxFolder.Checked
                                       ? fileAndFolder
                                       : checkBoxFile.Checked && !checkBoxFolder.Checked
                                             ? justFile
                                             : !checkBoxFile.Checked && checkBoxFolder.Checked ? justFolder : "";
            TT_main.SetToolTip(processBtn, buttonToolTip);
        }

        private void DisableProcessBtn(Button processBtn, TextBox source)
        {
            processBtn.Enabled = source.Text != "";
        }

        private void DisableProcessBtn(Button processBtn, CheckBox checkBoxFile, CheckBox checkBoxFolder)
        {
            processBtn.Enabled = checkBoxFile.Checked || checkBoxFolder.Checked;
        }



        //part of PATH
        private void Path_Llbl_Path_LinkClicked(object sender, EventArgs e)
        {
            DialogResult selectPath = Fbd_Path.ShowDialog();
            if (selectPath != DialogResult.OK) return;
            path = Fbd_Path.SelectedPath;
            Path_TB_Path.Text = path;
        }

        private void Path_TB_Path_TextChanged(object sender, EventArgs e)
        {
            DisableProcessBtn(Replace_Btn_Rename, Path_TB_Path);
            DisableProcessBtn(Add_Btn_Add, Path_TB_Path);
            if (Path_TB_Path.Text != "")
                Path_TB_Path.TabIndex = 2;

            path = Path_TB_Path.Text;
            Rename_SS_Status.Text = Directory.Exists(path)
                                        ? "Directory '" + path + "'  is correct"
                                        : Path_TB_Path.Text != "" ? "Directory '" + path + "' doesn't exist" : "Ready";

            ProcessBtn_ToolTip(Replace_Btn_Rename, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder,
                               Resources.RenameFileAndFolder, Resources.RenameJustFile,
                               Resources.RenameJustFolder);
        }



        //part of REPLACE
        private void Replace_CB_ReplaceFile_CheckedChanged(object sender, EventArgs e)
        {
            ProcessBtn_ToolTip(Replace_Btn_Rename, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder,
                               Resources.RenameFileAndFolder, Resources.RenameJustFile,
                               Resources.RenameJustFolder);
        }

        private void Replace_CB_ReplaceFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (Replace_CB_ReplaceFolder.Checked)
            {
                Replace_RB_AllDir.Enabled = false;
                Replace_RB_CurrentDir.Checked = true;
            }
            else
            {
                Replace_RB_AllDir.Enabled = true;
            }
            ProcessBtn_ToolTip(Replace_Btn_Rename, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder,
                               Resources.RenameFileAndFolder, Resources.RenameJustFile,
                               Resources.RenameJustFolder);
        }

        private void Replace_Btn_Rename_Click(object sender, EventArgs e)
        {
            if (!FieldsReady(Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder, Replace_TB_From,
                             "- source keyword text box is empty.")) return;

            string fullFileNames = "";
            int numEntries = GetInfo(ref fullFileNames, Replace_RB_CurrentDir, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder, Replace_TB_From);

            if (ThereIsNoFile(numEntries, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder, Replace_TB_From)) return;

            string askText = "'" + numEntries +
                             (Replace_CB_ReplaceFile.Checked && Replace_CB_ReplaceFolder.Checked
                                  ? "' files and folders "
                                  : Replace_CB_ReplaceFile.Checked && !Replace_CB_ReplaceFolder.Checked
                                        ? "' files "
                                        : "' folders ") + "are selected. are you sure you want to rename them?" +
                             Environment.NewLine +
                             "From '" + Replace_TB_From.Text + "' To '" + Replace_TB_To.Text + "'." +
                             Environment.NewLine + fullFileNames;
            AskToReplace askToRename = new AskToReplace {AskTexts = askText};
            askToRename.ShowDialog();
            if (!askToRename.AskResult) return;


            foreach (var entry in GetDir(Replace_RB_CurrentDir))
            {
                string newName = entry.Name.Replace(Replace_TB_From.Text, Replace_TB_To.Text);
                int newnameLength = entry.FullName.Length - entry.Name.Length;
                string newFullName = entry.FullName.Remove(newnameLength) + newName;

                if (Directory.Exists(entry.FullName) && entry.FullName != newFullName &&
                    Replace_CB_ReplaceFolder.Checked)
                {
                    Directory.Move(entry.FullName, newFullName);
                }
                else if (entry.FullName != newFullName && Replace_CB_ReplaceFile.Checked &&
                         !Directory.Exists(entry.FullName))
                {
                    File.Move(entry.FullName, newFullName);
                }
            }

            SuccessfullyRenamedStatus(numEntries, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder);
        }

        private void Replace_Btn_Clear_Click(object sender, EventArgs e)
        {
            Replace_TB_From.Text = "";
            Replace_TB_To.Text = "";
            Replace_CB_ReplaceFile.Checked = true;
            Replace_CB_ReplaceFolder.Checked = false;
            Replace_RB_CurrentDir.Checked = true;
            Rename_SS_Status.Text = Resources.FieldsCleared;
        }

        private void Replace_TB_From_TextChanged(object sender, EventArgs e)
        {
            DisableProcessBtn(Replace_Btn_Rename, Replace_TB_From);
        }

        private void Replace_TB_From_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Replace_Btn_Rename_Click(sender, e);
            }
        }

        private void Replace_TB_To_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Replace_Btn_Rename_Click(sender, e);
            }
        }


        //Part of ADD TO END
        private void Add_Btn_Add_Click(object sender, EventArgs e)
        {
            if (!FieldsReady(Add_Cb_AddToFile, Add_Cb_AddToFolder, Add_Tb_Text, "- there is no text in TextBox to use it.")) return;

            string fullFileNames = "";
            int numEntries = GetInfo(ref fullFileNames, Add_Rb_CurrentDir, Add_Cb_AddToFile, Add_Cb_AddToFolder, Add_Tb_Text);

            if (ThereIsNoFile(numEntries, Add_Cb_AddToFile, Add_Cb_AddToFolder, Add_Tb_Text)) return;

            string askText = "'" + numEntries +
                             (Add_Cb_AddToFile.Checked && Add_Cb_AddToFolder.Checked
                                  ? "' files and folders "
                                  : Add_Cb_AddToFile.Checked && !Add_Cb_AddToFolder.Checked
                                        ? "' files " : "' folders ") + "are selected. are you sure you want to rename them?" +
                             Environment.NewLine + fullFileNames;
            AskToReplace askToRename = new AskToReplace {AskTexts = askText};
            askToRename.ShowDialog();
            if (!askToRename.AskResult) return;

            foreach (var entry in GetDir(Add_Rb_CurrentDir))
            {
                string newName = Add_Cb_AddToFolder.Checked
                                     ? Add_Tb_Text.Text + entry.Name
                                     : entry.Name + Add_Tb_Text.Text; 
                int dirLength = entry.FullName.Length - entry.Name.Length;
                string newFullName = entry.FullName.Remove(dirLength) + newName;


                if (Directory.Exists(entry.FullName) && entry.Name != newFullName &&
                    Add_Cb_AddToFolder.Checked)
                {
                    Directory.Move(entry.FullName, newFullName);
                }
                else if (entry.FullName != newFullName && Add_Cb_AddToFile.Checked && !Directory.Exists(entry.FullName))
                {
                    File.Move(entry.FullName, newFullName);
                }
            }

            SuccessfullyRenamedStatus(numEntries, Add_Cb_AddToFile, Add_Cb_AddToFolder);

        }

        private void Add_Cb_AddToFile_CheckedChanged(object sender, EventArgs e)
        {
            ProcessBtn_ToolTip(Add_Btn_Add, Add_Cb_AddToFile, Add_Cb_AddToFolder, Resources.RenameFileAndFolder,
                               Resources.RenameJustFile, Resources.RenameJustFolder);
            DisableProcessBtn(Replace_Btn_Rename, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder);
        }

        private void Add_Cb_AddToFolder_CheckedChanged(object sender, EventArgs e)
        {
            DisableProcessBtn(Replace_Btn_Rename, Replace_CB_ReplaceFile, Replace_CB_ReplaceFolder);
            if (Add_Cb_AddToFolder.Checked)
            {
                Add_Rb_AllDir.Enabled = false;
                Add_Cb_AddToFile.Checked = true;
            }
            else
                Add_Rb_CurrentDir.Checked = true;

            ProcessBtn_ToolTip(Add_Btn_Add, Add_Cb_AddToFile, Add_Cb_AddToFolder, Resources.RenameFileAndFolder,
                               Resources.RenameJustFile, Resources.RenameJustFolder);
        }

        private void Add_Btn_Clear_Click(object sender, EventArgs e)
        {
            Add_Tb_Text.Text = "";
            Add_Cb_AddToFile.Checked = true;
            Add_Cb_AddToFolder.Checked = false;
            Add_Rb_CurrentDir.Checked = true;
            Rename_SS_Status.Text = Resources.FieldsCleared;
        }

        private void Add_Tb_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Add_Btn_Add_Click(Add_Tb_Text, e);
                Add_Btn_Add_Click(sender, e);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }


    }
}