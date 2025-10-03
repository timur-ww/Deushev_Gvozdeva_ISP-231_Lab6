/*try {
    // Код в котором может возникнуть искл
}
catch (ExceptionType ex) {
    // Блок обработки искл
}
finally {
    // Блок, выполняющийся всегда
}*/

/*try {
    int x = int.Parse(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());

    int res = x / y;
    Console.WriteLine($"Результат: {res}");
} 
catch (DivideByZeroException ex) {
    Console.WriteLine($"ошибка: {ex.Message}");
} 
catch (FormatException ex) {
    Console.WriteLine($"ошибка: {ex.Message}");
} 
catch (Exception ex) {
    Console.WriteLine($"ошибка: {ex.Message}");
}
finally {
    Console.WriteLine("продолжение...");
}
Console.WriteLine("конец программы");*/


/*while (true) {
    try {
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Введите операцию(+, -, *, /): ");
        string? operation = Console.ReadLine();

        double res = 0;

        switch (operation) {
            case "+": res = num1 + num2; break;
            case "-": res = num1 - num2; break;
            case "*": res = num1 * num2; break;
            case "/":
                if (num2 == 0)
                    throw new DivideByZeroException("Делить на ноль нельзя");
                    res = num1 / num2; break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
        Console.WriteLine($"Результат: {res}");
    }
    catch (FormatException ex) {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    catch (DivideByZeroException ex) {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    catch (Exception ex) {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    finally {

    }
    Console.WriteLine("Конец программы");

}*/

// Шаг 3. Преобразование значений

/*int num = 12;
Console.WriteLine(num.ToString());
Console.WriteLine(num.GetType());

bool test = true;
Console.WriteLine(test.ToString());

DateTime now = DateTime.Now;
Console.WriteLine(now.ToString());

object me = new();
Console.WriteLine(me.ToString());*/

/*int age = int.Parse("asdasd");
Console.WriteLine(age);

DateTime brithday = DateTime.Parse("31 May 2005");
Console.WriteLine(brithday);
Console.WriteLine($"{brithday:D}");*/

/*string input = Console.ReadLine();
if (int.TryParse(input, out int res)) {
    Console.WriteLine(res);
}
else {
    Console.WriteLine("Ошибка ввода");
}*/
/*checked {
    byte num = byte.MaxValue - 1;
    Console.WriteLine(num);
    num++;
    Console.WriteLine(num);
    num++;
    Console.WriteLine(num);
}*/

/*double Add(double a, double b) {
    return a * b;
}

double a = 4.5;
double b = 2.5;
Console.WriteLine(Add(a, b));*/

// Шаг 5. Перехват с помощью фильтров 

/*Console.WriteLine("Введите сумму: ");
string? amount = Console.ReadLine();
try {
    decimal amountValue = decimal.Parse(amount);
}
catch (FormatException) when (amount.Contains("$")) {
    Console.WriteLine("В суммах нельзя использовать знак доллара!");
}
catch {
    Console.WriteLine("Сумма должны содержать только цифры");
}*/

// Самостоятельные задания

// Задание 1. Расширение функциональности калькулятора


static double Add(double a, double b) { return a + b; }
static double Subtract(double a, double b) { return a - b; }
static double Mul(double a, double b) { return a * b; }
static double Div(double a, d   ouble b) { return a / b; }
static double Step(double a, double b) { return Math.Pow(a, b); }

while (true)
{
    Console.Write("Чтобы покинуть калькулятор напишите (exit): ");
    string? input = Console.ReadLine();
    if (input == "exit")
    {
        Console.WriteLine("Конец работы");
        break;
    }
    else
    {
        try
        {
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Введите операцию(+, -, *, /, ^): ");
            string? operation = Console.ReadLine();

            double res = 0;

            switch (operation)
            {
                case "+": res = Add(num1, num2); break;
                case "-": res = Subtract(num1, num2); break;
                case "*": res = Mul(num1, num2); break;
                case "/":
                    if (num2 == 0)
                        throw new DivideByZeroException("Делить на ноль нельзя");
                    res = Div(num1, num2); break;
                case "^": res = Step(num1, num2); break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
            Console.WriteLine($"Результат: {res}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {

        }
        Console.WriteLine("Конец программы");

    }
}

// Задание 3. Проверка деления с защитой от ошибок

while (true)
{
    Console.Write("Чтобы покинуть калькулятор напишите (exit): ");
    if (Console.ReadLine() == "exit")
    {
        Console.WriteLine("Конец работы");
        break;
    }
    try
    {
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        double res = 0;

        if (num2 == 0)
        {
            throw new DivideByZeroException("На ноль делить нельзя. Повторите ввод делителя");
        }

        res = num1 / num2;
        Console.WriteLine(res);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    finally
    {

    }
}

// Задание 4. Проверка корректности ввода 

while (true)
{
    try
    {
        Console.Write("Введите целое число: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("Ошибка: Введена пустая строка \n");
        }
        if (int.TryParse(input, out int num))
        {
            Console.WriteLine($"Вы ввели корректное число: {num}");
            break;
        }
        else
        {
            throw new FormatException("Ошибка: Введен текст или нечисленное значение \n");
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Введите корректное число \n");
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Введите корректное число \n");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибкв: {ex.Message} \n");
        Console.WriteLine("Введите корректное число \n");
    }
}

// Задание 5. Отладка калькулятора с ошибками

static double Add(double a, double b) { return a + b; }
static double Subtract(double a, double b) { return a - b; }
static double Mul(double a, double b) { return a * b; }
static double Div(double a, double b) { return a / b; }
static double Step(double a, double b) { return Math.Pow(a, b); }

while (true)
{
    Console.Write("Чтобы покинуть калькулятор напишите (exit): ");
    string? input = Console.ReadLine();
    if (input == "exit")
    {
        Console.WriteLine("Конец работы");
        break;
    }
    else
    {
        try
        {
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine()); // обработка double.Parse без проверки

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine()); // обработка double.Parse без проверки

            Console.Write("Введите операцию(+, -, *, /, ^): ");
            string? operation = Console.ReadLine();

            double res = 0;

            switch (operation)
            {
                case "+": res = Add(num1, num2); break; // присваивание неверной переменной num2 + num2
                case "-": res = Subtract(num1, num2); break;
                case "*": res = Mul(num1, num2); break;
                case "/":
                    if (num2 == 0) // отсутствие проверки на деление на ноль
                        throw new DivideByZeroException("Делить на ноль нельзя");
                    res = Div(num1, num2); break;
                case "^": res = Step(num1, num2); break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
            Console.WriteLine($"Результат: {res}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {

        }
        Console.WriteLine("Конец программы");

    }
}

Console.WriteLine("Пограмма завершила работу");