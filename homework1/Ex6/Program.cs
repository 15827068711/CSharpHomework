using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class Program : Form
{
    TextBox txt1 = new TextBox();
    TextBox txt2 = new TextBox();
    Button btn = new Button();
    Label lbl = new Label();
    public void init()
    {
        this.Controls.Add(txt1);
        this.Controls.Add(txt2);
        this.Controls.Add(btn);
        this.Controls.Add(lbl);
        txt1.Dock = System.Windows.Forms.DockStyle.Left;
        txt2.Dock = System.Windows.Forms.DockStyle.Right;
        btn.Dock = System.Windows.Forms.DockStyle.Fill;
        lbl.Dock = System.Windows.Forms.DockStyle.Bottom;

        btn.Text = "求两数之积：";
        btn.Text = "用于显示两数之积";


        btn.Click += new System.EventHandler(this.button1_Click);
    }


    public void button1_Click(object sender, EventArgs e)
    {
        string a = txt1.Text;
        double b = double.Parse(a);
        string c = txt2.Text;
        double d = double.Parse(c);
        double f = b * d;
        lbl.Text = "两数之积为：" + f;

    }

    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    static void Main()
    {
        Program R = new Program();
        R.init();
        Application.Run(R);
    }
}
