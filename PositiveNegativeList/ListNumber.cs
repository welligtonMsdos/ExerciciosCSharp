using BradescoTest.Utililities;

namespace BradescoTest.PositiveNegativeList;

public class ListNumber
{
    private readonly frmMainScreen _frm;
    private readonly Util _util;
    private List<int> lstNumber;
    private List<string> lstDescription;

    public ListNumber(frmMainScreen frm)
    {
        _frm = frm;
        _util = new Util();

        lstDescription = new List<string>();

        SetNumbers();
    }

    private void SetNumbers()
    {
        lstNumber = new List<int>();
        lstNumber.Add(-34);
        lstNumber.Add(77);
        lstNumber.Add(-89);
        lstNumber.Add(-25);
        lstNumber.Add(-19);
        lstNumber.Add(14);
        lstNumber.Add(-20);
        lstNumber.Add(46);
        lstNumber.Add(-32);
        lstNumber.Add(91);
    }

    public void Execute()
    {
        SetListDescription();

        _frm.lblListReturn.Text = GetListDescription(lstDescription);
    }

    private void SetListDescription()
    {
        lstDescription.Clear();

        lstNumber.ForEach(delegate (int item)
        {
            lstDescription.Add(item > 0 ? EDescription.POSITIVO : EDescription.NEGATIVO);
        });
    }

    private string GetListDescription(List<string> value)
    {
        var result = "Lista: [ ";

        value.ForEach(delegate (string item)
        {
            result += item + ", ";
        });

        result += "]";

        return result;
    }
}
