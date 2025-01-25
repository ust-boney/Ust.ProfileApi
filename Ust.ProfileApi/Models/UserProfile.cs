using System.ComponentModel.DataAnnotations;

namespace Ust.ProfileApi.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description {  get; set; }
        public  string City {  get; set; }
        public string Address {  get; set; }
        public string SkypeId { get; set; }
    }
}
