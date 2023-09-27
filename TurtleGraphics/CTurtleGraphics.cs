using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleGraphics;

public class CTurtleGraphics
{
    //Attribute
    private Graphics g;
    private Pen p = new Pen(Color.Black);
    private Form view;
    private float meinTurtleX = 0;
    private float meinTurtleY = 0;
    private float meinTurtleW = 0;

    //Getter Setter
    public float X
    {
        get { return meinTurtleX; }
        set { meinTurtleX = value; }
    }
    public float Y
    {
        get { return meinTurtleY; }
        set { meinTurtleY = value; }
    }
    public int neuesX { get; set; }
    public int neuesY { get; set; }
    public float Winkel
    {
        get { return meinTurtleW; }
        set { meinTurtleW = value; }
    }

    //Konstruktor
    public CTurtleGraphics(Form view)
    {
        g = view.CreateGraphics();
        this.view = view;
        Mitte();
    }

    //Klassenmethoden
    public void Mitte()
    {
        meinTurtleX = view.Width / 2;
        meinTurtleY = view.Height / 2;
        meinTurtleW = 90;
    }

    public void Clear()
    {
        g = view.CreateGraphics();
        g.Clear(SystemColors.Control);
        Mitte();
    }
    public void Vor(float länge)
    {
        g = view.CreateGraphics();
        float neuesX = meinTurtleX + länge * (float)Math.Cos((meinTurtleW - 90) / 180 * Math.PI);
        float neuesY = meinTurtleY + länge * (float)Math.Sin((meinTurtleW - 90) / 180 * Math.PI);
        g.DrawLine(p, meinTurtleX, meinTurtleY, neuesX, neuesY);
        meinTurtleX = neuesX;
        meinTurtleY = neuesY;
    }
    public void DreheRechts(float winkel)
    {
        meinTurtleW += winkel;
        meinTurtleW %= 360;
    }
    public void DreheLinks(float winkel)
    {
        meinTurtleW -= winkel;
        meinTurtleW %= 360;
    }
    public void Neustart()
    {
        g = view.CreateGraphics();
        Mitte();
        g.Clear(SystemColors.Control);
    }
}