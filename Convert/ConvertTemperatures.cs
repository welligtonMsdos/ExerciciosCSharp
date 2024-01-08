using BradescoTest.Utililities;

namespace BradescoTest.Convert;

public class ConvertTemperatures
{

    private readonly frmMainScreen _frm;
    private readonly Util _util;
    private IConvertTemperatures convertTemperatures;

    public ConvertTemperatures(frmMainScreen frm)
    {
        _frm = frm;
        _util = new Util();
    }

    public void Execute()
    {
        string text = "";

        if (string.IsNullOrEmpty(_frm.txtCelsius.Text.Trim()))
        {
            _util.MessageError("O número não pode ser vazio!");

            return;
        } 
            

        if (!_util.IsNumberDouble(_frm.txtCelsius.Text))
        {
            _util.MessageInfo(string.Format("{0} não é um número!", _frm.txtCelsius.Text));

            return;
        }            
        
        if (string.Equals(_frm.cmbTemp.Text, "Kelvin", StringComparison.OrdinalIgnoreCase))
        {
            convertTemperatures = new Kelvin();

            var result = convertTemperatures.Convert(double.Parse(_frm.txtCelsius.Text));

            text = string.Format("{0} graus Celsius equivalem a {1} graus Kelvin", _frm.txtCelsius.Text, result.ToString());
        }
        else
        {
            convertTemperatures = new Fahrenheit();

            var result = convertTemperatures.Convert(double.Parse(_frm.txtCelsius.Text));

            text = string.Format("{0} graus Celsius equivalem a {1} graus Fahrenheit", _frm.txtCelsius.Text, result.ToString());
        }

        _util.MessageInfo(text);
    }
}
