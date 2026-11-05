namespace LAB05
{
    internal class CustomTime
    {
        private int hour;
        private int minutes;

        public int Hour
        {
            get => hour;
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentException("Часы должны быть в диапазоне от 0 до 23.");
                hour = value;
            }
        }

        public int Minutes
        {
            get => minutes;
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Минуты должны быть в диапазоне от 0 до 59.");
                minutes = value;
            }
        }

        public CustomTime(int hour, int minutes)
        {
            Hour = hour;
            Minutes = minutes;
        }

        public void AddMinutes(int n)
        {
            // всё время переводим в минуты от начала суток
            int total = Hour * 60 + Minutes + n;

            // сутки = 1440 минут; % даёт остаток, а для отрицательных n добавляем 1440
            total = ((total % 1440) + 1440) % 1440;

            Hour = total / 60;
            Minutes = total % 60;
        }

        public void PrintTime()
        {
            Console.WriteLine($"{Hour:D2}:{Minutes:D2}");
        }
    }
}
