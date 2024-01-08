using BradescoTest.Convert;
using BradescoTest.EvenOdd;
using BradescoTest.Utililities;

namespace BradescoTest;

public partial class frmMainScreen : Form
{
    private Util util;
    private EvenOrOdd evenOrOdd;
    private ConvertTemperatures convertTemperatures;

    public frmMainScreen()
    {
        InitializeComponent();

        util = new Util(this);
        evenOrOdd = new EvenOrOdd();
        convertTemperatures = new ConvertTemperatures(this);
    }

    private void btnEvenOrOdd_Click(object sender, EventArgs e)
    {
        util.InitializeEvenOrOdd();
    }

    private void btnDate_Click(object sender, EventArgs e)
    {
        util.InitializeDate();
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
        util.InitializeConvert();
    }

    private void btnList_Click(object sender, EventArgs e)
    {
        util.InitializeList();
    }

    private void btnToCheckEvenOrOdd_Click(object sender, EventArgs e)
    {
        evenOrOdd.Execute(txtNumber.Text);
    }

    private void btnToCheckConvert_Click(object sender, EventArgs e)
    {
        convertTemperatures.Execute();
    }
}
