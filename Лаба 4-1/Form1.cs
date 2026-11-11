namespace Лаба_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Figure.form1 = this;
            Circle circle = new Circle(50,50,50);
            circle.MoveRight();
        }
    }
}
