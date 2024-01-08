using BradescoTest.Utililities;

namespace BradescoTest.Data;

public class Birthday
{
    private readonly frmMainScreen _frm;
    private readonly Util _util;
    public Birthday(frmMainScreen frm)
    {
        _frm = frm;
        _util = new Util();
    } 

    private bool IsDate(string number)
    {
        DateTime result;

        return DateTime.TryParse(number, out result);
    }

    public void Execute()
    {
        if (string.IsNullOrEmpty(_frm.mskDate.Text.Trim()))
        {
            _util.MessageInfo("A data não pode ser vazia!");
            return;
        }

        if (!IsDate(_frm.mskDate.Text.Trim()))
        {
            _util.MessageError(string.Format("{0} Data inválida!", _frm.mskDate.Text.Trim()));
            return;
        }

        var date = DateTime.Parse(_frm.mskDate.Text);

        if (date >= DateTime.Now)
        {
            _util.MessageError("Data inválida!");
            return;
        }

        int age = DateTime.Now.Year - date.Year;

        if (DateTime.Now.DayOfYear < date.DayOfYear) age -= 1;

        _util.MessageInfo(string.Format("você tem {0} anos.", age.ToString()));
    }
}
