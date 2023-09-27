using TurtleGraphics;

namespace TurtlePaint
{
    internal class Draw
    {
        CTurtleGraphics Turtle;

        public Draw(Form1 form1)
        {

            Turtle = new CTurtleGraphics(form1);

        }
        public void Clear()
        {
            Turtle.Clear();
        }

        public void Line()
        {
            Turtle.Vor(100);

        }
        public void Triangle()
        {
            Turtle.Mitte();
            Turtle.Vor(100);
            Turtle.DreheLinks(120);
            Turtle.Vor(100);
            Turtle.DreheLinks(120);
            Turtle.Vor(100);
        }
        public void Flower()
        {
            Turtle.Mitte();
            int numSegments = 36;
            int segmentAngle = 360 / numSegments;

            for (int i = 0; i < numSegments; i++)
            {
                for (int j = 0; j < 360; j++)
                {
                    Turtle.Vor(1);
                    Turtle.DreheLinks(1);
                }


                Turtle.DreheLinks(segmentAngle);
            }
        }
        public void Circle()
        {
            Turtle.Mitte();
            for (int i = 0; i < 360; i++)
            {
                Turtle.Vor(1);
                Turtle.DreheLinks(1);
            }
        }
        public void Pic0()
        {

            Turtle.Vor(100);
            Turtle.DreheLinks(60);
            Turtle.Vor(100);
            Turtle.DreheRechts(120);
            Turtle.Vor(100);
            Turtle.DreheLinks(60);
            Turtle.Vor(100);
        }

        public void Kurve1(float laenge)
        {
            Turtle.Vor(laenge / 3);
            Turtle.DreheLinks(60);
            Turtle.Vor(laenge / 3);
            Turtle.DreheRechts(120);
            Turtle.Vor(laenge / 3);
            Turtle.DreheLinks(60);
            Turtle.Vor(laenge / 3);
        }
        public void Kurve2(float laenge)
        {
            Kurve1(laenge / 3);
            Turtle.DreheLinks(60);
            Kurve1(laenge / 3);
            Turtle.DreheRechts(120);
            Kurve1(laenge / 3);
            Turtle.DreheLinks(60);
            Kurve1(laenge / 3);
        }

        public void Kurve3(float laenge)
        {
            Kurve2(laenge / 3);
            Turtle.DreheLinks(60);
            Kurve2(laenge / 3);
            Turtle.DreheRechts(120);
            Kurve2(laenge / 3);
            Turtle.DreheLinks(60);
            Kurve2(laenge / 3);
        }

    }
}