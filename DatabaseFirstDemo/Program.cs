using System;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities();
            var post = new Post()
            {
                PostId = 1,
                DatePublished = DateTime.Now,
                Title = "Title",
                Body = "Body"
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
