namespace API.Entities
{
    public class UserLike
    {
        public AppUsers SourceUser { get; set; }
        public int SourceUserId { get; set; }
        public AppUsers TargetUser { get; set; }
        public int TargetUserId { get; set; }
    }
}