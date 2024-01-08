namespace BradescoTest.Utililities;

public class Util
{
    private readonly frmMainScreen _frm;
    public Util(frmMainScreen frm) => _frm = frm;

    public Util()
    {            
    }

    public void InitializeEvenOrOdd()
    {
        _frm.pnlEvenOrOdd.Visible = true;
        _frm.pnlEvenOrOdd.Size = new Size(776, 324);       
        _frm.pnlEvenOrOdd.Location = new Point(12,114);

        _frm.pnlDate.Visible = false;
        _frm.pnlConvert.Visible = false;
        _frm.pnlList.Visible = false;
    }

    public void InitializeDate()
    {
        _frm.pnlDate.Visible = true;
        _frm.pnlDate.Size = new Size(776, 324);
        _frm.pnlDate.Location = new Point(12, 114);

        _frm.pnlEvenOrOdd.Visible = false;
        _frm.pnlConvert.Visible = false;
        _frm.pnlList.Visible = false;
    }

    public void InitializeConvert()
    {
        _frm.pnlConvert.Visible = true;
        _frm.pnlConvert.Size = new Size(776, 324);
        _frm.pnlConvert.Location = new Point(12, 114);
        _frm.cmbTemp.SelectedIndex = 0;

        _frm.pnlEvenOrOdd.Visible = false;
        _frm.pnlDate.Visible = false;
        _frm.pnlList.Visible = false;
    }

    public void InitializeList()
    {
        _frm.pnlList.Visible = true;
        _frm.pnlList.Size = new Size(776, 324);
        _frm.pnlList.Location = new Point(12, 114);

        _frm.pnlEvenOrOdd.Visible = false;
        _frm.pnlDate.Visible = false;
        _frm.pnlConvert.Visible = false;
    }

    public void  MessageError(string value)
    {
        MessageBox.Show(value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void MessageInfo(string value)
    {
        MessageBox.Show(value, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public bool IsNumberDouble(string number)
    {
        double result;

        return double.TryParse(number, out result);
    }
}
