using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WSD
{
    public partial class WSD : Form
    {
        public WSD()
        {
            InitializeComponent();
            timer1.Start();
        }

        int i = 1;
        //начальное значение(одноразовое, благодаря i)
        private void begintoshuttime(object sender, EventArgs e)
        {
            if (i == 1 && timetoshutdowntext.Text == "") timetoshutdowntext.Text = "##:##"; i = 0;
        }

        private void tick(object sender, EventArgs e)
        {
            // время
            string currenttime = DateTime.Now.ToShortTimeString();
            // удаление лишнего 0
            if (timetoshutdowntext.Text.StartsWith("0") && timetoshutdowntext.Text.Length == 5 && timetoshutdowntext.Text.Contains(":"))
                timetoshutdowntext.Text = timetoshutdowntext.Text.Remove(0, 1);
            // сам код выключающий комп
            if (currenttime == timetoshutdowntext.Text)
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/c shutdown -s -t 00";
                p.Start();
                currenttime = "";
                timer1.Stop();
            }
        }

        // кнопка ?
        private void show2at(object sender, EventArgs e)
        {
            if (!gmail.Visible && !whomade.Visible)
            {
                gmail.Visible = true;
                whomade.Visible = true;
            } else
            {
                gmail.Visible = false;
                whomade.Visible = false;
            }
        }

        private void Twitter(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/NexusGenius");
        }

        private void Site(object sender, EventArgs e)
        {
            Process.Start("https://nexusgen.wordpress.com/");
        }
    }
}
