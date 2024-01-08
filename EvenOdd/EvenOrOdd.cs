using BradescoTest.Utililities;

namespace BradescoTest.EvenOdd;

public class EvenOrOdd
{

    private Util util;

    public EvenOrOdd()
    {
        util = new Util();
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
            util.MessageInfo("O número não pode ser vazio!");

            return;
        }

        if (!IsNumber(number))
        {
            util.MessageError(string.Format("{0} não é um número!", number));

            return;
        }

        if (IsEven(int.Parse(number)))
            util.MessageInfo(string.Format("O número {0} é par!", number));
        else
            util.MessageInfo(string.Format("O número {0} é ímpar!", number));
    }
}
