using Abp.Web.Mvc.Views;

namespace TestOriontec.Web.Views
{
    public abstract class TestOriontecWebViewPageBase : TestOriontecWebViewPageBase<dynamic>
    {

    }

    public abstract class TestOriontecWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestOriontecWebViewPageBase()
        {
            LocalizationSourceName = TestOriontecConsts.LocalizationSourceName;
        }
    }
}