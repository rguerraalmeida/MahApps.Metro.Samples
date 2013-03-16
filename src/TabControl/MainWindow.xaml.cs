namespace TabControlSample
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            DataContext = new ShellViewModel();
        }
    }
}
