using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurtleGraphics;

namespace TurtlePaint;

public partial class Form1 : Form
{

    Draw draw;
    public Form1()
    {
        InitializeComponent();

        draw = new Draw(this);
    }


    private void button1_Click(object sender, EventArgs e)
    {
        button1.Enabled = false;
        draw.Clear();
        button1.Enabled = true;

    }

    private void button2_Click(object sender, EventArgs e)
    {
        button2.Enabled = false;
        draw.Clear();
        draw.Line();
        button2.Enabled = true;

    }

    private void button3_Click(object sender, EventArgs e)
    {
        button3.Enabled = false;
        draw.Clear();
        draw.Triangle();
        button3.Enabled = true;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        button4.Enabled = false;
        draw.Clear();
        draw.Circle();
        button4.Enabled = true;

    }

    private void button5_Click(object sender, EventArgs e)
    {
        button5.Enabled = false;
        draw.Clear();
        draw.Flower();
        button5.Enabled = true;
    }

    private void button6_Click(object sender, EventArgs e)
    {
        button6.Enabled = false;
        draw.Clear();
        draw.Line();
        button6.Enabled = true;
    }

    private void button7_Click(object sender, EventArgs e)
    {
        button7.Enabled = false;
        draw.Clear();
        draw.Kurve1(100);
        button7 .Enabled = true;
    }

    private void button8_Click(object sender, EventArgs e)
    {
        button8.Enabled = false;
        draw.Clear();
        draw.Kurve2(300);
        button8 .Enabled = true;
    }

    private void button9_Click(object sender, EventArgs e)
    {
        button9 .Enabled = false;
        draw.Clear();
        draw.Kurve3(300);
        button9 .Enabled = true;
    }
}
