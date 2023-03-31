using System.ComponentModel;

namespace SfTreeGridDemo
{
    public class EmployeeInfo: INotifyPropertyChanged
    {
        int _id;
        string _firstName;
        string _lastName;
        string _title;
        decimal _salary;
        int _reportsTo;
        bool isSelected;        

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set 
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set 
            { 
                isSelected = value; 
                OnPropertyChanged("IsSelected");
            }
        }
        
        public int ID
        {
            get { return _id; }
            set 
            {
                _id = value; 
                OnPropertyChanged("ID");
            }
        }

        public string Title
        {
            get { return _title; }
            set 
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public decimal Salary
        {
            get { return _salary; }
            set 
            {
                _salary = value;
                OnPropertyChanged("Salary"); 
            }
        }

        public int ReportsTo
        {
            get { return _reportsTo; }
            set 
            {
                _reportsTo = value; 
                OnPropertyChanged("ReportsTo"); 
            }
        }

        public EmployeeInfo()
        {
                
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

    }
}