using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoqGenericTypeMatching
{
    public class SamplePageModel : FreshBasePageModel
    {
        public ICommand PushSecondPageCommand { get; }

        public SamplePageModel()
        {
            PushSecondPageCommand = new Command(() => CoreMethods.PushPageModel<SecondPageModel>());
        }
    }
}
