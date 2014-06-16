using System.Web.Mvc;

namespace website.Areas.BackGround
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "BackGround";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "BackGround_default",
                "BackGround/{controller}/{action}/{id}",
                new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
