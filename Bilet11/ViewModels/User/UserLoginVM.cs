using System.ComponentModel.DataAnnotations;

namespace Bilet11.ViewModels
{
    public class UserLoginVM
    {
        public string UsernameOrEmail { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsPersistence { get; set; }
    }
}
