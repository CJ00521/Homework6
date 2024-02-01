namespace Homework6.Models.DTO
{
    public class UserDTO
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }

        //2-1  (圖)檔上傳
        public IFormFile? Avatar { get; set; }
    }
}
