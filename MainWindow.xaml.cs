using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.ObjectModel;


namespace DataGrid_Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            // Create DataGrid Items Info
            members.Add(new Member { Number = "1", Character = "G", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "Alice", Position="Coach", Email="alice@abc.com", Phone = "123-456-7890"});
            members.Add(new Member { Number = "2", Character = "H", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Bob", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "3", Character = "I", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Charlie", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "4", Character = "J", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ram", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "5", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Shyam", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "6", Character = "L", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Yoda", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "7", Character = "M", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Turtle", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "8", Character = "N", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Becky", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "9", Character = "O", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Rani", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "10", Character = "P", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Joe", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });

            members.Add(new Member { Number = "1", Character = "G", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "Alice", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "2", Character = "H", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Bob", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "3", Character = "I", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Charlie", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "4", Character = "J", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ram", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "5", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Shyam", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "6", Character = "L", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Yoda", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "7", Character = "M", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Turtle", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "8", Character = "N", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Becky", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "9", Character = "O", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Rani", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "10", Character = "P", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Joe", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });

            members.Add(new Member { Number = "1", Character = "G", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "Alice", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "2", Character = "H", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Bob", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "3", Character = "I", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Charlie", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "4", Character = "J", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Ram", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "5", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Shyam", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "6", Character = "L", BgColor = (Brush)converter.ConvertFromString("#6741D9"), Name = "Yoda", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "7", Character = "M", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), Name = "Turtle", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "8", Character = "N", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Becky", Position = "Administrator", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "9", Character = "O", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Rani", Position = "Manager", Email = "alice@abc.com", Phone = "123-456-7890" });
            members.Add(new Member { Number = "10", Character = "P", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Joe", Position = "Coach", Email = "alice@abc.com", Phone = "123-456-7890" });

            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaximized = false;
                } else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
            }

        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Brush BgColor { get; set; }

    }
}
