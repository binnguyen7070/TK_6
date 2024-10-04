namespace TK_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myclass myclass = new myclass();
            MessageBox.Show(myclass.PrintOut("Object"));
            IIfc1 ifc1 = (IIfc1)myclass;
            MessageBox.Show(ifc1.PrintOut("Salala"));
        }
    }
}
