internal class Program
{
    private static void Main(string[] args)
    {
        Forwards forward1 = new Forwards()
        {
            Surename = "Stasik",
            Nickname = "Loshara",
            Age = 24,
            MatchesCount = 8,
            GoalsCount = 8,
        };
        Forwards forward2 = new Forwards()
        {
            Surename = "Kolyan",
            Nickname = "Lemour",
            Age = 24,
            MatchesCount = 5,
            GoalsCount = 3,
        };
        Forwards forward3 = new Forwards()
        {
            Surename = "Vanya",
            Nickname = "Kiborg",
            Age = 24,
            MatchesCount = 6,
            GoalsCount = 12,
        };
        Forwards forward4 = new Forwards()
        {
            Surename = "Dima",
            Nickname = "Diman",
            Age = 24,
            MatchesCount = 3,
            GoalsCount = 3,
        };
        Forwards forward5 = new Forwards()
        {
            Surename = "Vlad",
            Nickname = "Pyos",
            Age = 24,
            MatchesCount = 12,
            GoalsCount = 6,
        };
        Forwards[] forwards = new Forwards[5] { forward1, forward2, forward3, forward4, forward5 };
        var max = 0;
        for (int i = 0; i < forwards.Length; i++)
        {
            forwards[i].Print();
            if (forwards[i].MatchesCount < 5 && forwards[i].GoalsCount > max) max = i;
        }
        Console.Write("Статистика лучшего игрока: ");
        forwards[max].Print();
    }

    struct Forwards
    {
        public string Surename { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public int MatchesCount { get; set; }
        public int GoalsCount { get; set; }

        public Forwards(string surename, string nickname, int age, int matchesCount, int goalsCount)
        {
            Surename = surename;
            Nickname = nickname;
            Age = age;
            MatchesCount = matchesCount;
            GoalsCount = goalsCount;
        }

        public void Print()
        {
            Console.WriteLine($"Фамилия: {Surename}, Амплуа: {Nickname}, Возраст: {Age}, Матчей сыграно: {MatchesCount}, Кол-во голов: {GoalsCount}");
        }
    }
}