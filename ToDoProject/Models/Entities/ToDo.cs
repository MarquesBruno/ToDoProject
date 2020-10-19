using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTest.Core.Entities
{
    public class ToDo
    {
        public int ToDoId { get; set; }
        public int UserId { get; set; }

        /// <summary>
        /// Description field required
        /// </summary>
        [Required(AllowEmptyStrings =false, ErrorMessage = "Description field required.")]
        public string Description { get; set; }
        public DateTime DateFinish { get; set; }
        public DateTime DatePost { get; set; }
        public DateTime DatePut { get; set; }
        public Boolean Situation { get; set; }


    }
}
