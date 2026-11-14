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
            Circle circle = new Circle(50, 50, 50);
            Square square = new Square(50, 160, 50);
            Rhomb rhomb = new Rhomb(50, 210, 50,30);
            circle.MoveRight();
            square.MoveRight();
            rhomb.MoveRight();
        }
    }
}
