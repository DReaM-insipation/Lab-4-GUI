namespace Лаба_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Figure.form1 = this;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Circle c1 = new Circle(50, 50, 50);
            Square s1 = new Square(50, 150, 50);
            Rhomb r1 = new Rhomb(50, 250, 50,30);
            c1.MoveRight();
            s1.MoveRight();
            r1.MoveRight();
            Circle c2 = new Circle(100, 100, 100);
            c2.MoveRight();
            Square s2 = new Square(310, 200, 100);
            s2.MoveRight();
            Rhomb r2 = new Rhomb(200, 300, 100, 150);
            r2.MoveRight();
        }
    }
}
