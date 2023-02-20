using System;
namespace PostsService.Contracts.V1
{
    public class PostRequest
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }

    public class UpdateRequest
    {
        public Guid PostId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

    }
}

