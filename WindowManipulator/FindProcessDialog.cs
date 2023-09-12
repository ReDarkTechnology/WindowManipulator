using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using NativeInvoker;

namespace WindowManipulator
{
    public partial class FindProcessDialog : Form
    {
        public MainForm mainForm;
        public List<ProcessInfo> selectedInfos = new List<ProcessInfo>();
        public FindProcessDialog(Form host = null)
        {
            mainForm = host as MainForm;
            InitializeComponent();

            if (host != null) host.GotFocus += (object sender, EventArgs e) => Focus();
            var procs = Process.GetProcesses();
            foreach (var proc in procs)
            {
                if (!string.IsNullOrWhiteSpace(proc.MainWindowTitle))
                {
                    string[] subItems = {
                        proc.ProcessName,
                        proc.MainWindowTitle
                    };
                    var item = new ListViewItem(subItems, 0);
                    item.Tag = proc;
                    listView1.Items.Add(item);
                }
            }

            var enumNames = Enum.GetNames(typeof(NativeWindowState));
            foreach(var name in enumNames)
                stateDropdown.Items.Add(name);
            stateDropdown.SelectedIndex = 5;
        }

        void Button1Click(object sender, EventArgs e)
        {
            if (selectedInfos.Count > 0)
            {
                var list = new List<string>();
                foreach (var info in selectedInfos)
                {
                    try
                    {
                        var window = WindowManager.GetWindow(info.ProcessWindowTitle, ChangeStateBox.Checked ? (NativeWindowState)stateDropdown.SelectedIndex : NativeWindowState.ShowNA);
                        if (window != null)
                        {
                            mainForm.AddWindow(window, info);
                            Dispose();
                        }
                        else
                        {
                            list.Add($"{info.ProcessName}: Window couldn't be found");
                        }
                    }
                    catch (Exception ex)
                    {
                        list.Add($"{info.ProcessName}: {ex.Message}\n{ex.StackTrace}");
                    }
                }

                if(list.Count > 0)
                    MessageBox.Show(string.Join("\n", list), "Error");
            }
            else
            {
                MessageBox.Show("Error: No process is selected", "Error");
            }
        }

        void ListView1SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = Utility.GetSelectedItems(listView1);
            if (selectedItems.Length > 0)
            {
                selectedInfos.Clear();
                foreach (var a in selectedItems)
                {
                    selectedInfos.Add(GetInfo(a));
                }
            }
        }

        public ProcessInfo GetInfo(ListViewItem item)
        {
            var info = new ProcessInfo();
            var selected = item;
            info.Process = selected.Tag as Process;
            info.ProcessName = selected.Text;
            info.ProcessWindowTitle = selected.SubItems[1].Text;
            return info;
        }

        void ListView1MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var selectedItems = Utility.GetSelectedItems(listView1);
                if (selectedItems.Length > 0)
                {
                    selectedInfos.Clear();
                    foreach (var a in selectedItems)
                    {
                        selectedInfos.Add(GetInfo(a));
                    }
                }
                Button1Click(this, null);
            }
        }

        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {
        }

        private void stateDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

public class ProcessInfo
{
    public Process Process;
	public string ProcessName;
	public string ProcessWindowTitle;
}
