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

        }

        private void circle_button_Click(object sender, EventArgs e)
        {
            Circle c1 = new Circle(50, 50, 50);
            c1.MoveRight();
        }
        private void square_button_Click(object sender, EventArgs e)
        {
            Square s1 = new Square(50, 50, 50);
            s1.MoveRight();
        }

        private void rhomb_button_Click(object sender, EventArgs e)
        {
            Rhomb r1 = new Rhomb(50, 50, 50, 100);
            r1.MoveRight();
        }
    }
}
