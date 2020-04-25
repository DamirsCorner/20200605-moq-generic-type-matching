using FreshMvvm;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace MoqGenericTypeMatching
{
    public class Tests
    {
        [Test]
        public void PushSecondPageCommandShouldPushSecondPage()
        {
            var coreMethodsMock = new Mock<IPageModelCoreMethods>();
            coreMethodsMock
                .Setup(m => m.PushPageModel<IsFreshBasePageModel<SecondPageModel>>(It.Is<bool>(b => b)))
                .Returns(Task.CompletedTask)
                .Verifiable();

            var pageModel = new SamplePageModel();
            pageModel.CoreMethods = coreMethodsMock.Object;

            pageModel.PushSecondPageCommand.Execute(null);

            coreMethodsMock.VerifyAll();
        }
    }
}
