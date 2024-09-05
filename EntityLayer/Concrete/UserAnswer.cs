using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserAnswer
    {
        [Key]
        public int UserAnswerID { get; set; }

        public string Answer { get; set; }

        public DateTime SubmitDate { get; set; }
    }
}
