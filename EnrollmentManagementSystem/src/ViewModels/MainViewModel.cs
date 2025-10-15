using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EnrollmentManagementSystem.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _studentName;
        private string _courseName;
        private DateTime _enrollmentDate;

        public string StudentName
        {
            get => _studentName;
            set
            {
                if (_studentName != value)
                {
                    _studentName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CourseName
        {
            get => _courseName;
            set
            {
                if (_courseName != value)
                {
                    _courseName = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime EnrollmentDate
        {
            get => _enrollmentDate;
            set
            {
                if (_enrollmentDate != value)
                {
                    _enrollmentDate = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}