using BradescoTest.Convert;
using BradescoTest.Data;
using BradescoTest.EvenOdd;
using BradescoTest.PositiveNegativeList;
using BradescoTest.Utililities;

namespace BradescoTest;

public partial class frmMainScreen : Form
{
    private readonly Util _util;
    private readonly EvenOrOdd _evenOrOdd;
    private readonly ConvertTemperatures _convertTemperatures;
    private readonly Birthday _birthday;
    private readonly ListNumber _listNumber;

    public frmMainScreen()
    {
        InitializeComponent();

        _util = new Util(this);
        _evenOrOdd = new EvenOrOdd();
        _convertTemperatures = new ConvertTemperatures(this);
        _birthday = new Birthday(this);
        _listNumber = new ListNumber(this);
    }

    private void btnEvenOrOdd_Click(object sender, EventArgs e)
    {
        _util.InitializeEvenOrOdd();
    }

    private void btnDate_Click(object sender, EventArgs e)
    {
        _util.InitializeDate();
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
        _util.InitializeConvert();
    }

    private void btnList_Click(object sender, EventArgs e)
    {
        _util.InitializeList();
    }

    private void btnToCheckEvenOrOdd_Click(object sender, EventArgs e)
    {
        _evenOrOdd.Execute(txtNumber.Text);
    }

    private void btnToCheckConvert_Click(object sender, EventArgs e)
    {
        _convertTemperatures.Execute();
    }

    private void btnToCheckDate_Click(object sender, EventArgs e)
    {
        _birthday.Execute();
    }

    private void btnToCheckList_Click(object sender, EventArgs e)
    {
        _listNumber.Execute();
    }
}
