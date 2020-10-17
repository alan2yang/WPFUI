using Prism.Mvvm;
using Prism.Commands;
using WpfAppDemo1.Entity;
using System.Collections.ObjectModel;

namespace WpfAppDemo1.ViewModel
{
    class MainWindowViewModel:BindableBase
    {
        public ObservableCollection<UserModel> UserModels { get; set; }

        public MainWindowViewModel()
        {
            InitUserModel();
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


    }
}
