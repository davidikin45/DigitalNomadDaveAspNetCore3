using DND.Domain.CMS.ContentHtmls;
using System;
using System.Linq;

namespace DND.Data
{
    public class DbSeed
    {
        //This will run each time the application launches so make you check to see if data already exists in db.
        public static void Seed(AppContext context)
        {
            AddContentHtml(context);
        }

        private static void AddContentText(AppContext context)
        {

        }

        private static void AddContentHtml(AppContext context)
        {
            AddContentHTML(context, Constants.ContentHtml.About, "<p>About Me</p>");
            AddContentHTML(context, Constants.ContentHtml.SideBarAbout, "<p>About Me</p>");
            AddContentHTML(context, Constants.ContentHtml.WorkWithMe, "<p>Work With Me</p>");
            AddContentHTML(context, Constants.ContentHtml.MyWebsite, "<p>My Website</p>");
            AddContentHTML(context, Constants.ContentHtml.Affiliates, "<p>Affiliates</p>");
            AddContentHTML(context, Constants.ContentHtml.Resume, "<p>Resume</p>");
            AddContentHTML(context, Constants.ContentHtml.Contact, "<p>Contact</p>");
            AddContentHTML(context, Constants.ContentHtml.Head, "");
            AddContentHTML(context, Constants.ContentHtml.Main, "");
            AddContentHTML(context, Constants.ContentHtml.PrivacyPolicy, "");
        }

        private static void AddContentHTML(AppContext context, string id, string content)
        {
            if (!context.ContentHtml.Any(c => c.Id == id))
            {
                context.ContentHtml.Add(new ContentHtml() { Id = id, HTML = content, PreventDelete = true, CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            }
        }
    }
}
