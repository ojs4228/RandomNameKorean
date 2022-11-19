using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("이름추첨기");
        Console.WriteLine("몇개의 이름을 뽑을까요?");

        int runNumber = 0;

        try
        { 
            int runNumber1 = int.Parse(Console.ReadLine());
            runNumber = runNumber1;
        }
        catch(FormatException e)
        {
            Console.WriteLine("올바른 숫자를 입력 해주세요");
            return;
        }

        foreach (var e in DropName.DropNameList(runNumber))
        {
            Console.WriteLine(e);
        }
    }
}

class DropName
{

    public static List<string> DropNameList(int runNumber)
    {

        List<string> names = new List<string>();

        for (int i = 0; i < runNumber; i++)
        {

            string name = DropName.DropRandomName(DropName.DropChar());
            int nameLeght = name.Length;
            names.Add(name);
        }

        return names;
    }


    public static string DropRandomName(char surname)
    {
        string fullName = surname + DropChar().ToString() + DropChar().ToString();
        return fullName;
    }

    public static char DropChar()
    {

        Random random = new Random();
        int randomInt = random.Next(0, 14);

        switch (randomInt)
        {
            case 0:
                return '오';
            case 1:
                return '정';
            case 2:
                return '유';
            case 3:
                return '성';
            case 4:
                return '호';
            case 5:
                return '은';
            case 6:
                return '정';
            case 7:
                return '이';
            case 8:
                return '보';
            case 9:
                return '경';
            case 10:
                return '하';
            case 11:
                return '주';
            case 12:
                return '석';
            case 13:
                return '남';
            case 14:
                return '신';
            default:
                return '우';

        }
        
    }

}


