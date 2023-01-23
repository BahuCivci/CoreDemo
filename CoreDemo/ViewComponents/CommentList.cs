using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "bahu"
                },
                new UserComment
                {
                    ID = 2,
                    Username = "mesut"
                },
                new UserComment
                {
                    ID = 2,
                    Username = "Merve"
                }

            };
            return View(commentvalues);  
        }
    }
}
