using Prism.Mvvm;
using Prism.Commands;
using WpfAppDemo1.Entity;
using System.Collections.ObjectModel;
using System;


namespace WpfAppDemo1.ViewModel
{
    class MainWindowViewModel:BindableBase
    {
        public ObservableCollection<UserModel> UserModels { get; set; }
        public ObservableCollection<TransactionViewModel> TransactionViewModels { get; set; }

        public MainWindowViewModel()
        {
            InitUserModel();
            InitTransactionModel();
        }

        public void InitUserModel()
        {
            UserModels = new ObservableCollection<UserModel>();
            UserModels.Add(new UserModel() { FilePath = "Images/Image1.jpg", UserName = "James Bloor", Content = "What's up", SignTime = "32 min" });
            UserModels.Add(new UserModel() { FilePath = "Images/Image2.jpg", UserName = "Fionn Withehead", Content = "Nice one", SignTime = "2 days" });
            UserModels.Add(new UserModel() { FilePath = "Images/Image3.jpg", UserName = "Damien Bonnard", Content = "Go on in comi", SignTime = "1 weeks" });
            UserModels.Add(new UserModel() { FilePath = "Images/Image4.jpg", UserName = "Aneurin Barnard", Content = "I am coming", SignTime = "2 weeks" });
            UserModels.Add(new UserModel() { FilePath = "Images/Image5.jpg", UserName = "James Bloor", Content = "What's up", SignTime = "32 min" });
            UserModels.Add(new UserModel() { FilePath = "Images/Image6.jpg", UserName = "Fionn Withehead", Content = "Nice one", SignTime = "2 days" });
            UserModels.Add(new UserModel() { FilePath = "Images/Image7.jpg", UserName = "Damien Bonnard", Content = "Go on in comi", SignTime = "1 weeks" });
            UserModels.Add(new UserModel() { FilePath = "Images/Image8.jpg", UserName = "Aneurin Barnard", Content = "I am coming", SignTime = "2 weeks" });
        }

        public void InitTransactionModel()
        {
            TransactionViewModels = new ObservableCollection<TransactionViewModel>();
            TransactionViewModels.Add(new TransactionViewModel() { ID = 100, UserName = "James Bloor",FilePath= "Images/Image1.jpg", TDate = new DateTime(2020,1,1), Price = "$120" });
            TransactionViewModels.Add(new TransactionViewModel() { ID = 101, UserName = "Fionn Withehead", FilePath = "Images/Image2.jpg", TDate = new DateTime(2020,1,1), Price = "$10" });
            TransactionViewModels.Add(new TransactionViewModel() { ID = 102, UserName = "Damien Bonnard", FilePath = "Images/Image4.jpg", TDate = new DateTime(2020,1,10), Price = "$211" });
            TransactionViewModels.Add(new TransactionViewModel() { ID = 103, UserName = "Damien Bonnard", FilePath = "Images/Image6.jpg", TDate = new DateTime(2020,1,21), Price = "$10" });
            TransactionViewModels.Add(new TransactionViewModel() { ID = 104, UserName = "Aneurin Barnard", FilePath = "Images/Image8.jpg", TDate = new DateTime(2020, 10, 1), Price = "$2121" });

        }

    }
}
