using FontAwesome.Sharp;
using ModernFlatLayout.Forms;
using System.Runtime.InteropServices;

namespace ModernFlatLayout;
#pragma warning disable SYSLIB1054
#pragma warning disable CS8602
public partial class FirstScreen : Form
{
    // Attributes
    private IconButton CurrentButton;
    private readonly Panel LeftBorderButton;
    private Form? CurrentChildForm;
    private bool IsFullScreen;

    //Constructors
    public FirstScreen()
    {
        InitializeComponent();
        CurrentButton = new();
        LeftBorderButton = new()
        {
            Size = new Size(7, 60)
        };
        PanelMenu.Controls.Add(LeftBorderButton);
        // Form
        Text = string.Empty;
        ControlBox = false;

        MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        DoubleBuffered = false;
        IsFullScreen = false;
    }

    //Methods

    private void ActivateButton(object sender, Color color)
    {
        if (sender != null)
        {
            DisableButton();

            CurrentButton = (IconButton)sender;
            CurrentButton.BackColor = Color.FromArgb(37, 36, 81);
            CurrentButton.ForeColor = color;
            CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
            CurrentButton.IconColor = color;
            CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            CurrentButton.ImageAlign = ContentAlignment.MiddleRight;
            // Left border button
            LeftBorderButton.BackColor = color;
            LeftBorderButton.Location = new Point(0, CurrentButton.Location.Y);
            LeftBorderButton.Visible = true;
            LeftBorderButton.BringToFront();
            // Icon Current Child Form
            IconButtonHome.IconChar = CurrentButton.IconChar;
            IconButtonHome.IconColor = color;
        }
    }

    // Structs
    private struct RGBColors
    {
        public static Color Color1 = Color.FromArgb(172, 126, 241);
        public static Color Color2 = Color.FromArgb(249, 118, 176);
        public static Color Color3 = Color.FromArgb(253, 138, 114);
        public static Color Color4 = Color.FromArgb(95, 77, 221);
        public static Color Color5 = Color.FromArgb(249, 88, 155);
        public static Color Color6 = Color.FromArgb(24, 161, 251);
    }

    private void DisableButton()
    {
        if (CurrentButton != null)
        {
            CurrentButton.BackColor = Color.FromArgb(31, 30, 68);
            CurrentButton.ForeColor = Color.White;
            CurrentButton.TextAlign = ContentAlignment.MiddleLeft;
            CurrentButton.IconColor = Color.White;
            CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }

    private void OpenChildForm(Form childForm)
    {
        CurrentChildForm?.Close();
        CurrentChildForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        PanelDesktop.Controls.Add(childForm);
        PanelDesktop.Tag = childForm;
        childForm.BringToFront();
        LabelHome.Text = childForm.Text;
        CurrentChildForm.Show();
    }

    private void BtnDashboardClick(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.Color1);
        OpenChildForm(new DashboardForm());
    }
    private void BtnOrdersClick(object sender, EventArgs e) => ActivateButton(sender, RGBColors.Color2);
    private void BtnProductsClick(object sender, EventArgs e) => ActivateButton(sender, RGBColors.Color3);
    private void BtnMarketingClick(object sender, EventArgs e) => ActivateButton(sender, RGBColors.Color4);
    private void BtnSettingClick(object sender, EventArgs e) => ActivateButton(sender, RGBColors.Color5);
    private void PBBtnHomeClick(object sender, EventArgs e) => Reset();

    private void Reset()
    {
        DisableButton();
        LeftBorderButton.Visible = false;
        IconButtonHome.IconChar = IconChar.Home;
        IconButtonHome.IconColor = Color.MediumPurple;
        LabelHome.Text = "Home";
        CurrentChildForm?.Close();
    }


    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
    private void PanelHeaderMouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }
    private void BtnCloseClick(object sender, EventArgs e) => Application.Exit();

    private void BtnMaximizeClick(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Maximized) ExitMaximizedScreen();
        else EnterMaximizedScreen();
    }

    private void EnterMaximizedScreen()
    {
        WindowState = FormWindowState.Normal;
        FormBorderStyle = FormBorderStyle.None;
        WindowState = FormWindowState.Maximized;
        Bounds = Screen.PrimaryScreen.Bounds;
    }

    private void ExitMaximizedScreen()
    {
        WindowState = FormWindowState.Normal;
        FormBorderStyle = FormBorderStyle.Sizable;
        Size = new(1149, 679);
    }

    private void BtnFullScreenClick(object sender, EventArgs e)
    {
        if (IsFullScreen) DisableFullScreen();
        else ActivateFullScreen();
    }

    private void ActivateFullScreen()
    {
        FormBorderStyle = FormBorderStyle.None;
        WindowState = FormWindowState.Normal;

        Bounds = Screen.PrimaryScreen.Bounds;
        TopMost = IsFullScreen = true;
    }

    private void DisableFullScreen()
    {
        WindowState = FormWindowState.Normal;
        FormBorderStyle = FormBorderStyle.Sizable;
        Size = new(1149, 679);
        TopMost = false;
        IsFullScreen = false;
    }

    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(Keys vKey);

    private void FormKeyDown(object sender, KeyEventArgs e)
    {

    }

    private void TimerListener(object sender, EventArgs e)
    {
        if ((GetAsyncKeyState(Keys.F11) & 0x8000) == 0x8000)
        {
            if (IsFullScreen) DisableFullScreen();
            else ActivateFullScreen();
        }
    }

    private void BtnMinimizeClick(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
}
