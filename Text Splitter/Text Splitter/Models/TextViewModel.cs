using System.ComponentModel.DataAnnotations;

namespace Text_Splitter.Models
{
    public class TextViewModel
    {
        [StringLength(30, MinimumLength = 2)]
        public string Text { get; set; } = null!;
        public string SplitText { get; set; } = null!;

    }
}
