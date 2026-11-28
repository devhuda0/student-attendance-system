using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginform : Form
    {
        private const string UsernamePlaceholder = "Enter your Username or Email..";
        public loginform()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;

            // ڕێکخستنی ستایل و Placeholder لە کاتی کردنەوەی فۆرمەکە
            SetupDesignStyles();
            SetupUsernamePlaceholder();
            SetupPasswordField();

            // بەستنەوەی ڕووداوەکان (Events)
            this.Load += loginform_Load;
            this.Resize += LoginForm_Resize;
            pnlCard.Resize += PnlCard_Resize;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            btnLogin.Click += btnLogin_Click;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {
            MakePanelRounded(pnlCard, 25);
            ApplyRoundedCornersToMainPanel();
            EnsureFlagPanelLayout();
        }
        private void MakePanelRounded(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            Rectangle rect = panel.ClientRectangle;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
        private void LoginForm_Resize(object sender, EventArgs e)
        {
            ApplyRoundedCornersToMainPanel();
        }
        private void PnlCard_Resize(object sender, EventArgs e)
        {
            ApplyRoundedCornersToMainPanel();
        }
        private void SetupDesignStyles()
        {
            // ڕەنگی باکگراوەندی فۆرم و پەنێل
            this.BackColor = Color.FromArgb(232, 236, 242);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            lblStatus.AutoSize = false;
            lblStatus.Width = btnLogin.Width;
            lblStatus.Height = 32;
            lblStatus.Top = btnLogin.Bottom + 10;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Left = btnLogin.Left;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.None;

            // جوانکردنی دوگمەی Login
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(37, 99, 235);
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;

            // لەیبڵی دۆخ (هەڵە یان سەرکەوتن)
            lblStatus.Text = string.Empty;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }
        private void EnsureFlagPanelLayout()
        {
            // دڵنیابوون لەوەی پەنێلی ئاڵاکە هەموو پانیی خوارەوە بگرێتەوە
            pnlFlag.Dock = DockStyle.Bottom;
            if (pnlFlag.Height < 45)
            {
                pnlFlag.Height = 55;
            }

            // گەڕان بەدوای PictureBox لەناو pnlFlag و جێگیرکردنی
            foreach (Control ctrl in pnlFlag.Controls)
            {
                if (ctrl is PictureBox pb)
                {
                    pb.Dock = DockStyle.Fill;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        private void ApplyRoundedCornersToMainPanel()
        {
            if (pnlCard == null || pnlCard.Width <= 10 || pnlCard.Height <= 10)
                return;

            int radius = 24; // ڕادەی خڕبوونی گۆشەکان
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, pnlCard.Width, pnlCard.Height);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                pnlCard.Region?.Dispose();
                pnlCard.Region = new Region(path);
            }
        }
        private void SetupUsernamePlaceholder()
        {
            txtUsername.Text = UsernamePlaceholder;
            txtUsername.ForeColor = Color.Gray;

            txtUsername.Enter += (s, e) =>
            {
                if (txtUsername.Text == UsernamePlaceholder)
                {
                    txtUsername.Text = string.Empty;
                    txtUsername.ForeColor = Color.Black;
                }
            };

            txtUsername.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = UsernamePlaceholder;
                    txtUsername.ForeColor = Color.Gray;
                }
            };
        }
        private void SetupPasswordField()
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text == UsernamePlaceholder
                ? string.Empty
                : txtUsername.Text.Trim();

            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblStatus.ForeColor = Color.Crimson;
                lblStatus.Text = "تکایە ناوی بەکارهێنەر/ئیمەیڵ و وشەی نهێنی بنووسە.";
                return;
            }

            if (AuthenticateUser(username, password))
            {
                lblStatus.ForeColor = Color.SeaGreen;
                lblStatus.Text = "بە سەرکەوتوویی چوویتە ژوورەوە.";

                this.Hide();

                // لێرەدا فۆرمی سەرەکی پرۆژەکە بکەرەوە (بۆ نموونە MainForm)
                // using (var mainForm = new MainForm(username))
                // {
                //     mainForm.ShowDialog();
                // }

                this.Close();
            }
            else
            {
                lblStatus.ForeColor = Color.Crimson;
                lblStatus.Text = "ناوی بەکارهێنەر یان وشەی نهێنی هەڵەیە.";
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            // نموونەی سەرەتایی بۆ تاقیکردنەوە؛ دواتر بە SQL Server / داتابەیس بیگۆڕە
            return username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "1234";
        }
    }
}
