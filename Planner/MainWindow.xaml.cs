using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Runtime.CompilerServices;
using System;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Concurrent;

namespace Planner
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        string _connectionString = "Data Source=localhost;Initial Catalog=PlannerDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ObservableCollection<ListViewStruct> Monday { get; set; } = new ObservableCollection<ListViewStruct>();
        public ObservableCollection<ListViewStruct> Tuesday { get; set; }  = new ObservableCollection<ListViewStruct>();
        public ObservableCollection<ListViewStruct> Wednesday { get; set; }  = new ObservableCollection<ListViewStruct>();
        public ObservableCollection<ListViewStruct> Thursday { get; set; }  = new ObservableCollection<ListViewStruct>();
        public ObservableCollection<ListViewStruct> Friday { get; set; } = new ObservableCollection<ListViewStruct>();
        public ObservableCollection<ListViewStruct> Saturday { get; set; } = new ObservableCollection<ListViewStruct>();
        public ObservableCollection<ListViewStruct> Sunday { get; set; } = new ObservableCollection<ListViewStruct>();

        private string _mondaytitle;
        private string _tuesdaytitle;
        private string _wednesdaytitle;
        private string _thursdaytitle;
        private string _fridaytitle;
        private string _saturdaytitle;
        private string _sundaytitle;
        public string MondayTitle
        {
            get { return _mondaytitle; }
            set
            {
                if (_mondaytitle == value) return;
                _mondaytitle = value;
                OnPropertyChanged();
            }
        }
        public string TuesdayTitle
        {
            get { return _tuesdaytitle; }
            set
            {
                if (_tuesdaytitle == value) return;
                _tuesdaytitle = value;
                OnPropertyChanged();
            }
        }
        public string WednesdayTitle
        {
            get { return _wednesdaytitle; }
            set
            {
                if (_wednesdaytitle == value) return;
                _wednesdaytitle = value;
                OnPropertyChanged();
            }
        }
        public string ThursdayTitle
        {
            get { return _thursdaytitle; }
            set
            {
                if (_thursdaytitle == value) return;
                _thursdaytitle = value;
                OnPropertyChanged();
            }
        }
        public string FridayTitle
        {
            get { return _fridaytitle; }
            set
            {
                if (_fridaytitle == value) return;
                _fridaytitle = value;
                OnPropertyChanged();
            }
        }
        public string SaturdayTitle
        {
            get { return _saturdaytitle; }
            set
            {
                if (_saturdaytitle == value) return;
                _saturdaytitle = value;
                OnPropertyChanged();
            }
        }
        public string SundayTitle
        {
            get { return _sundaytitle; }
            set
            {
                if (_sundaytitle == value) return;
                _sundaytitle = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            SetDates();
                    LoadLists(MondayTitle, Monday);
                    LoadLists(TuesdayTitle, Tuesday);
                    LoadLists(WednesdayTitle, Wednesday);
                    LoadLists(ThursdayTitle, Thursday);
                    LoadLists(FridayTitle, Friday);
                    LoadLists(SaturdayTitle, Saturday);
                    LoadLists(SundayTitle, Sunday);
        }

        private bool CanGoToWeek = true;
        private ICommand _GoToNextWeek;
        public ICommand GoToNextWeek
        {
            get
            {
                return _GoToNextWeek ?? (_GoToNextWeek = new RelayCommand(async () =>
                {
                    CanGoToWeek = false;
                    NextWeek();
                    CanGoToWeek = true;
                }, () =>
                {
                    return CanGoToWeek;
                }
                ));
            }
        }
        private ICommand _GoToPreviousWeek;
        public ICommand GoToPreviousWeek
        {
            get
            {
                return _GoToPreviousWeek ?? (_GoToPreviousWeek = new RelayCommand(async () =>
                {
                    CanGoToWeek = false;
                        PreviousWeek();
                    CanGoToWeek = true;
                }, () =>
                {
                    return CanGoToWeek;
                }
                ));
            }
        }
        private string _SelectedItem;
        public string SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                value = _SelectedItem;
                OnPropertyChanged();
            }
        }      

        private void PreviousWeek()
        {
            MondayTitle = Convert.ToDateTime(MondayTitle).AddDays(-7).ToString("d");
            TuesdayTitle = Convert.ToDateTime(TuesdayTitle).AddDays(-7).ToString("d");
            WednesdayTitle = Convert.ToDateTime(WednesdayTitle).AddDays(-7).ToString("d");
            ThursdayTitle = Convert.ToDateTime(ThursdayTitle).AddDays(-7).ToString("d");
            FridayTitle = Convert.ToDateTime(FridayTitle).AddDays(-7).ToString("d");
            SaturdayTitle = Convert.ToDateTime(SaturdayTitle).AddDays(-7).ToString("d");
            SundayTitle = Convert.ToDateTime(SundayTitle).AddDays(-7).ToString("d");
            ClearLists();
            LoadLists(MondayTitle, Monday);
            LoadLists(TuesdayTitle, Tuesday);
            LoadLists(WednesdayTitle, Wednesday);
            LoadLists(ThursdayTitle, Thursday);
            LoadLists(FridayTitle, Friday);
            LoadLists(SaturdayTitle, Saturday);
            LoadLists(SundayTitle, Sunday);
        }

        private void SetDates()
        {
            DateTime input = DateTime.Today;
            int delta = DayOfWeek.Monday - input.DayOfWeek;
            DateTime monday = input.AddDays(delta);
            MondayTitle = monday.ToString("d");
            TuesdayTitle = monday.AddDays(1).ToString("d");
            WednesdayTitle = monday.AddDays(2).ToString("d");
            ThursdayTitle = monday.AddDays(3).ToString("d");
            FridayTitle = monday.AddDays(4).ToString("d");
            SaturdayTitle = monday.AddDays(5).ToString("d");
            SundayTitle = monday.AddDays(6).ToString("d");
        }
        private void NextWeek()
        {
            MondayTitle = Convert.ToDateTime(MondayTitle).AddDays(7).ToString("d");
            TuesdayTitle= Convert.ToDateTime(TuesdayTitle).AddDays(7).ToString("d");
            WednesdayTitle = Convert.ToDateTime(WednesdayTitle).AddDays(7).ToString("d");
            ThursdayTitle = Convert.ToDateTime(ThursdayTitle).AddDays(7).ToString("d");
            FridayTitle = Convert.ToDateTime(FridayTitle).AddDays(7).ToString("d");
            SaturdayTitle = Convert.ToDateTime(SaturdayTitle).AddDays(7).ToString("d");
            SundayTitle = Convert.ToDateTime(SundayTitle).AddDays(7).ToString("d");
            ClearLists();
            LoadLists(MondayTitle, Monday);
            LoadLists(TuesdayTitle, Tuesday);
            LoadLists(WednesdayTitle, Wednesday);
            LoadLists(ThursdayTitle, Thursday);
            LoadLists(FridayTitle, Friday);
            LoadLists(SaturdayTitle, Saturday);
            LoadLists(SundayTitle, Sunday);
        }
        private void ClearLists()
        {
            Monday.Clear();
            Tuesday.Clear();
            Wednesday.Clear();
            Thursday.Clear();
            Friday.Clear();
            Saturday.Clear();
            Sunday.Clear();
        }
        private async void LoadLists(string day, ObservableCollection<ListViewStruct> listview)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DateTime date = Convert.ToDateTime(day);
                string queryString = "SELECT * FROM PlannerTable WHERE Date = '" + date.ToString("yyyy-MM-dd") + "'";
                SqlCommand command = new SqlCommand(queryString, connection);
                await command.Connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    listview.Add(new ListViewStruct
                    {
                        Title = reader[0].ToString(),
                        Description = reader[1].ToString(),
                        Time = reader[2].ToString()
                    });
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _Day;
        public string Day
        {
            get { return _Day; }
            set
            {
                value = _Day;
                OnPropertyChanged();
            }
        }
        private async void DialogHost_DialogClosing(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {
            if (!Equals(eventArgs.Parameter, true)) return;
            if (TaskTitle.Text != null && TaskDescription.Text != null && DialogTime.Text != null)
                switch (DialogDays.Text)
                {
                    case "Monday":
                        Monday.Add(new ListViewStruct
                        {
                            Title = TaskTitle.Text,
                            Description = TaskDescription.Text,
                            Time = DialogTime.Text,
                        });
                        await AddToDatabase(Convert.ToDateTime(MondayTitle));
                        break;
                    case "Tuesday":
                       Tuesday.Add(new ListViewStruct
                        {
                            Title = TaskTitle.Text,
                            Description = TaskDescription.Text,
                            Time = DialogTime.Text,
                        });
                        await AddToDatabase(Convert.ToDateTime(TuesdayTitle));
                        break;
                    case "Wednesday":
                        Wednesday.Add(new ListViewStruct
                        {
                            Title = TaskTitle.Text,
                            Description = TaskDescription.Text,
                            Time = DialogTime.Text,
                        });
                        await AddToDatabase(Convert.ToDateTime(WednesdayTitle));
                        break;
                    case "Thursday":
                       Thursday.Add(new ListViewStruct
                        {
                            Title = TaskTitle.Text,
                            Description = TaskDescription.Text,
                            Time = DialogTime.Text,
                        });
                        await AddToDatabase(Convert.ToDateTime(ThursdayTitle));
                        break;
                    case "Friday":
                        Friday.Add(new ListViewStruct
                        {
                            Title = TaskTitle.Text,
                            Description = TaskDescription.Text,
                            Time = DialogTime.Text,
                        });
                        await AddToDatabase(Convert.ToDateTime(FridayTitle));
                        break;
                    case "Saturday":
                        Saturday.Add(new ListViewStruct
                        {
                            Title = TaskTitle.Text,
                            Description = TaskDescription.Text,
                            Time = DialogTime.Text,
                        });
                        await AddToDatabase(Convert.ToDateTime(SaturdayTitle));
                        break;
                    case "Sunday":
                        Sunday.Add(new ListViewStruct
                        {
                            Title = TaskTitle.Text,
                            Description = TaskDescription.Text,
                            Time = DialogTime.Text,
                        });
                        await AddToDatabase(Convert.ToDateTime(SundayTitle));
                        break;
                }
        }
        private async Task AddToDatabase(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string queryString = "INSERT INTO PlannerTable VALUES('" + TaskTitle.Text + "', '" + TaskDescription.Text + "', '" + DialogTime.Text + "', '" + date.ToString("yyyy-MM-dd") + "')";
                SqlCommand command = new SqlCommand(queryString, connection);
                await command.Connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
