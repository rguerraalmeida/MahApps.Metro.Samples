namespace MahApps.Metro.PanoramaExample
{
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ShellViewModel();
        }

        
    }
}
