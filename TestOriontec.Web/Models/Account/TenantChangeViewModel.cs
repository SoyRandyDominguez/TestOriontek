using Abp.AutoMapper;
using TestOriontec.Sessions.Dto;

namespace TestOriontec.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}