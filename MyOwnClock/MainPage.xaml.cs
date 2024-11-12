using static System.Net.Mime.MediaTypeNames;

namespace MyOwnClock
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            InitTimer();
            StartTimer();
        }
        public void InitTimer()
        {
            var a = DateTime.Now.ToString("HH:mm:ss");
            var b = a.Split(":");
            InitHelper(b[0], ref hour1, ref hour2);
            InitHelper(b[1], ref minute1, ref minute2);
            InitHelper(b[2], ref second1, ref second2);
        }
        public async Task StartTimer()
        {
            PeriodicTimer minuteTimer = new PeriodicTimer(TimeSpan.FromSeconds(1));
            while (await minuteTimer.WaitForNextTickAsync())
            {
                InitTimer();
            }

        }
        private void InitHelper(string time_s, ref NewContent1 cur_symb, ref NewContent1 next_symb)
        {
            var time = int.Parse(time_s);
            cur_symb.SetNumber(time % 10);
            time /= 10;
            next_symb.SetNumber(time % 10);

        }


    }

}
