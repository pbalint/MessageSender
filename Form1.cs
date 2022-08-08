using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace MessageSender
{
    public partial class Form1 : Form
    {
        private List<WindowNode> windows = new List<WindowNode>();

        public Form1()
        {
            InitializeComponent();
            RefreshWindows();
        }

        private void RefreshWindows()
        {
            windows.Clear();
            Win32.EnumWindows((IntPtr hWnd, ref IntPtr lParam) => {

                string window_text = Win32.GetWindowText(hWnd);
                string window_class = Win32.GetWindowClass(hWnd);
                windows.Add(new WindowNode(hWnd, window_class, window_text));
                return true;
            }, IntPtr.Zero);
            UpdateFilter();
        }

        private void UpdateFilter()
        {
            tv_windows.BeginUpdate();
            tv_windows.Nodes.Clear();
            tv_windows.Nodes.Add("Windows");
            string filter_text = tb_filter.Text.Trim();
            foreach (WindowNode window in windows)
            {
                if (filter_text.Length == 0 || filter_text.Length > 0 && window.Title.Contains(filter_text) || window.WindowClass.Contains(filter_text))
                {
                    tv_windows.Nodes[0].Nodes.Add(window);
                }
            }
            tv_windows.EndUpdate();
            tv_windows.ExpandAll();
        }

        private void tb_filter_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void b_send_Click(object sender, EventArgs e)
        {
            string path = tb_path.Text;
            int process_id = Process.GetCurrentProcess().Id;
            byte[] path_bytes = Encoding.Unicode.GetBytes(path);

            MemoryMappedFile memory_mapped_file = MemoryMappedFile.CreateNew(null, path_bytes.Length);
            int mapping_handle = memory_mapped_file.SafeMemoryMappedFileHandle.DangerousGetHandle().ToInt32();
            MemoryMappedViewAccessor view = memory_mapped_file.CreateViewAccessor();
            view.WriteArray(0, path_bytes, 0, path_bytes.Length);
            IntPtr hwnd = ((WindowNode)tv_windows.SelectedNode).Hwnd;
            nuint message_id = Win32.RegisterWindowMessage(tb_message.Text);
            Win32.SendMessage(hwnd, message_id, process_id, mapping_handle);

            memory_mapped_file.Dispose();
        }

        private void b_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = dialog.FileName;
            }
        }

        private void tsb_refresh_Click(object sender, EventArgs e)
        {
            RefreshWindows();
        }

        private void tv_windows_AfterSelect(object sender, TreeViewEventArgs e)
        {
            b_send.Enabled = tv_windows.SelectedNode is WindowNode;
        }
    }
}