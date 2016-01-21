using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.Tests
{
    public class FakeApiModel
    {
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }
    }
}