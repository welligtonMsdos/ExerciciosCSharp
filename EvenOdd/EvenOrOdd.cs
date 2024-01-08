using BradescoTest.Utililities;

namespace BradescoTest.EvenOdd;

public class EvenOrOdd
{

    private readonly Util _util;

    public EvenOrOdd()
    {
        _util = new Util();
    }

    private bool IsNumber(string number)
    {
        int result;

        return int.TryParse(number, out result);
    }   

    private bool IsEven(int number)
    {
        return number % 2 == 0 ? true : false;
    }

    public void Execute(string number)
    {
        if (string.IsNullOrEmpty(number.Trim()))
        {
            _util.MessageInfo("O número não pode ser vazio!");

            return;
        }

        if (!IsNumber(number))
        {
            _util.MessageError(string.Format("{0} não é um número!", number));

            return;
        }

        if (IsEven(int.Parse(number)))
            _util.MessageInfo(string.Format("O número {0} é par!", number));
        else
            _util.MessageInfo(string.Format("O número {0} é ímpar!", number));
    }
}
