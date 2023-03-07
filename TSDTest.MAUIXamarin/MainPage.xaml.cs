namespace TSDTest.MAUIXamarin {
    public partial class MainPage : ContentPage {
        int count = 0;

        public MainPage() {
            InitializeComponent();
            ScanningTransmitterTest.Notify += TestNotify;
        }

        private void TestNotify(string scanData) {
            textScan.Text = scanData;
        }
        private void OnCounterClicked(object sender, EventArgs e) {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}