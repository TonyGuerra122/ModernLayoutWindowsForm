namespace ModernFlatLayout.Forms
{
    partial class DashboardForm
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
            PanelDesktop = new Panel();
            panel1 = new Panel();
            IconButtonHome = new FontAwesome.Sharp.IconButton();
            LabelHome = new Label();
            PanelDesktop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDesktop
            // 
            PanelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            PanelDesktop.Controls.Add(panel1);
            PanelDesktop.Location = new Point(0, 0);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(1028, 588);
            PanelDesktop.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(IconButtonHome);
            panel1.Controls.Add(LabelHome);
            panel1.Location = new Point(418, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // IconButtonHome
            // 
            IconButtonHome.Anchor = AnchorStyles.None;
            IconButtonHome.FlatAppearance.BorderSize = 0;
            IconButtonHome.FlatStyle = FlatStyle.Flat;
            IconButtonHome.ForeColor = SystemColors.ControlText;
            IconButtonHome.IconChar = FontAwesome.Sharp.IconChar.GaugeMed;
            IconButtonHome.IconColor = Color.MediumPurple;
            IconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonHome.Location = new Point(51, 38);
            IconButtonHome.Name = "IconButtonHome";
            IconButtonHome.Size = new Size(49, 47);
            IconButtonHome.TabIndex = 2;
            IconButtonHome.UseVisualStyleBackColor = true;
            // 
            // LabelHome
            // 
            LabelHome.Anchor = AnchorStyles.None;
            LabelHome.AutoSize = true;
            LabelHome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelHome.ForeColor = Color.White;
            LabelHome.Location = new Point(101, 51);
            LabelHome.Name = "LabelHome";
            LabelHome.Size = new Size(91, 20);
            LabelHome.TabIndex = 3;
            LabelHome.Text = "Dashboard";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 588);
            Controls.Add(PanelDesktop);
            Name = "DashboardForm";
            Text = "Dashboard";
            PanelDesktop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDesktop;
        private Label LabelHome;
        private FontAwesome.Sharp.IconButton IconButtonHome;
        private Panel panel1;
    }
}