namespace MyWebApp.Models
{
    public class DiscussionPostViewModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public IFormFile Image { get; set; }  // For photo uploads
    }
}