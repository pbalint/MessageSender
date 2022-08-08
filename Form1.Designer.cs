namespace MessageSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tv_windows = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_refresh = new System.Windows.Forms.ToolStripButton();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.b_browse = new System.Windows.Forms.Button();
            this.b_send = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.l_filter = new System.Windows.Forms.Label();
            this.l_message = new System.Windows.Forms.Label();
            this.l_path = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_windows
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tv_windows, 6);
            this.tv_windows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_windows.HideSelection = false;
            this.tv_windows.Location = new System.Drawing.Point(3, 59);
            this.tv_windows.Name = "tv_windows";
            this.tv_windows.Size = new System.Drawing.Size(1086, 363);
            this.tv_windows.TabIndex = 0;
            this.tv_windows.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_windows_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_refresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1092, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_refresh
            // 
            this.tsb_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_refresh.Image = global::MessageSender.Properties.Resources.refresh_32;
            this.tsb_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_refresh.Name = "tsb_refresh";
            this.tsb_refresh.Size = new System.Drawing.Size(23, 22);
            this.tsb_refresh.Text = "toolStripButton1";
            this.tsb_refresh.Click += new System.EventHandler(this.tsb_refresh_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter.Location = new System.Drawing.Point(103, 3);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(360, 23);
            this.tb_filter.TabIndex = 2;
            this.tb_filter.Text = "SWT_Window_";
            this.tb_filter.TextChanged += new System.EventHandler(this.tb_filter_TextChanged);
            // 
            // tb_message
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tb_message, 2);
            this.tb_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_message.Location = new System.Drawing.Point(569, 3);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(440, 23);
            this.tb_message.TabIndex = 3;
            this.tb_message.Text = "SWT_OPENDOC";
            // 
            // tb_path
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tb_path, 4);
            this.tb_path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_path.Location = new System.Drawing.Point(103, 31);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(906, 23);
            this.tb_path.TabIndex = 4;
            // 
            // b_browse
            // 
            this.b_browse.AutoSize = true;
            this.b_browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_browse.Location = new System.Drawing.Point(1013, 29);
            this.b_browse.Margin = new System.Windows.Forms.Padding(1);
            this.b_browse.Name = "b_browse";
            this.b_browse.Size = new System.Drawing.Size(78, 26);
            this.b_browse.TabIndex = 5;
            this.b_browse.Text = "Browse...";
            this.b_browse.UseVisualStyleBackColor = true;
            this.b_browse.Click += new System.EventHandler(this.b_browse_Click);
            // 
            // b_send
            // 
            this.b_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_send.Location = new System.Drawing.Point(1013, 1);
            this.b_send.Margin = new System.Windows.Forms.Padding(1);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(78, 26);
            this.b_send.TabIndex = 6;
            this.b_send.Text = "Send";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.b_send, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_path, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tv_windows, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_browse, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_filter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_message, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_filter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_message, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_path, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1092, 425);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // l_filter
            // 
            this.l_filter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_filter.AutoSize = true;
            this.l_filter.Location = new System.Drawing.Point(3, 6);
            this.l_filter.Name = "l_filter";
            this.l_filter.Size = new System.Drawing.Size(33, 15);
            this.l_filter.TabIndex = 7;
            this.l_filter.Text = "Filter";
            // 
            // l_message
            // 
            this.l_message.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_message.AutoSize = true;
            this.l_message.Location = new System.Drawing.Point(469, 6);
            this.l_message.Name = "l_message";
            this.l_message.Size = new System.Drawing.Size(53, 15);
            this.l_message.TabIndex = 8;
            this.l_message.Text = "Message";
            // 
            // l_path
            // 
            this.l_path.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_path.AutoSize = true;
            this.l_path.Location = new System.Drawing.Point(3, 34);
            this.l_path.Name = "l_path";
            this.l_path.Size = new System.Drawing.Size(52, 15);
            this.l_path.TabIndex = 9;
            this.l_path.Text = "File path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "SWT Message Sender";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView tv_windows;
        private ToolStrip toolStrip1;
        private ToolStripButton tsb_refresh;
        private TableLayoutPanel tableLayoutPanel1;
        private Button b_send;
        private TextBox tb_path;
        private Button b_browse;
        private TextBox tb_filter;
        private TextBox tb_message;
        private Label l_filter;
        private Label l_message;
        private Label l_path;
    }
}