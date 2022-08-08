namespace MessageSender
{
    internal class WindowNode : TreeNode
    {
        private IntPtr hwnd;
        private string window_class;
        private string title;

        public IntPtr Hwnd { get => hwnd; set => hwnd = value; }
        public string WindowClass { get => window_class; set => window_class = value; }
        public string Title { get => title; set => title = value; }

        public WindowNode(IntPtr hwnd, string window_class, string title)
        {
            this.hwnd = hwnd;
            this.window_class = window_class;
            this.title = title;

            Text = hwnd.ToInt32().ToString("X8") + " [" + window_class + "] " + title;
        }
    }
}
