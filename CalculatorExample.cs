namespace MyNapespace
{
    public class MyCalculator
    {
        public int operationSelect { get; private set; }

        MyCalculator()
        {
            operationSelect = 0;
        }

        public void setOperation(int operationSelect)
        {
            if (operationSelect >= 0 && operationSelect <= 3)
                this.operationSelect = operationSelect;
            else
                throw new InvalidOperationException("Invalid Operation");
        }

        float operation(int number1, int number2)
        {
            float result = 0;

            switch(operationSelect)
            {
                case 0: //Addition
                    result = number1 + number2;
                    //a+b
                    break;
                case 1: //Subtraction
                    result = number1 - number2;
                    break;
                case 2: //Multiplication
                    result = number1 * number2;
                    break;
                case 3: //Division
                    result = number1 / number2;
                    break;
            }

            return result;
        }
    }

}