using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary02
{
    abstract public class Pupil
    {
        abstract public void Study();

        abstract public void Read();

        abstract public void Write();

        abstract public void Relax();

    }

    public class ExcelentPupil: Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Этот ученик имеет отличную успеваемость, поэтому не мешайте ему получать знания!");
        }

        override public void Read()
        {
            Console.WriteLine("Великолепный навык чтения, 250 слов в минуту. Невероятно!!!");
        }

        override public void Write()
        {
            Console.WriteLine("Ему не нужны прописи, великолепно написал диктант!");
        }

        override public void Relax()
        {
            Console.WriteLine("Потрудился на славу! Заслуженный отдых...");
        }
    }

    public class GoodPupil : Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Он учится хорошо и сейчас занят. Попробуйте, может он вас выслушает.");
        }

        override public void Read()
        {
            Console.WriteLine("Читает, дай Бог каждому. 150 слов в минуту - достойный результат.");
        }

        override public void Write()
        {
            Console.WriteLine("Все прописи выполнил в каникулы. Молодец!");
        }

        override public void Relax()
        {
            Console.WriteLine("Хорошо потрудился, время и отдохнуть.");
        }
    }

    public class BadPupil : Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Бесполезно проводит время... Конечно, он рад гостям!");
        }

        override public void Read()
        {
            Console.WriteLine("50 слов в минуту... В 11 классе!!!");
        }

        override public void Write()
        {
            Console.WriteLine("Ладно, можешь не писать. Безнадёжно...");
        }

        override public void Relax()
        {
            Console.WriteLine("Теперь можно и отдохнуть... от отдыха");
        }
    }
}