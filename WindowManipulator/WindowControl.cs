using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowManipulator
{
    public partial class WindowControl : UserControl
    {
        public static MainForm host => MainForm.self;

        public ColorDictionary dict;
        public NativeWindow window;
        public ProcessInfo info;

        static Color mainColor = Color.FromArgb(255, 0, 40, 40);
        static Color selectedColor = Color.FromArgb(255, 0, 60, 100);
        bool isUpdating;

        public WindowControl()
        {
            InitializeComponent();
            this.AddBorder();
            dict = this.ModernifyInteraction();
            ControlMoverOrResizer.Init(this);
        }

        public void SetSelected(bool to)
        {
            dict.Initialize(to ? selectedColor : mainColor);
            BackColor = to ? dict.hover : dict.main;
        }

        public void AssignInfo(NativeWindow window, ProcessInfo info)
        {
            this.info = info;
            this.window = window;
            RefreshTransform();
        }

        public void RefreshTransform()
        {
            isUpdating = true;
            WindowTitle.Text = info.ProcessWindowTitle;
            Location = MainForm.self.GetWindowPosition(window);
            Size = MainForm.self.GetWindowSize(window);
            isUpdating = false;
        }

        private void WindowControl_Move(object sender, EventArgs e)
        {
            if (isUpdating) return;
            window.position = MainForm.self.ReverseWindowPosition(this);
            host.UpdateIfSelected(this);
        }

        private void WindowControl_Resize(object sender, EventArgs e)
        {
            if (isUpdating) return;
            window.size = MainForm.self.ReverseWindowSize(this);
            host.UpdateIfSelected(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            window = null;
            CloseWindow();
        }

        public void CloseWindow()
        {
            isUpdating = true;
            host.UnregisterWindow(this);
            Dispose();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            host.SetWindowIndex(this, 0);
        }

        private void WindowControl_MouseUp(object sender, MouseEventArgs e)
        {
            host.RequestSelection(this);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshTransform();
            host.UpdateIfSelected(this);
        }
    }
}
