namespace Bloggie.Web.Models.ViewModels
{
    public class AddLikeRequestcs
    {
        public Guid BlogPostId { get; set; }

        public Guid UserId { get; set; }
    }
}
