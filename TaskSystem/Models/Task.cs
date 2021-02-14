using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSystem.Models
{
    public class Task
    {
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }

        public int TaskId { get; set; }

        public TaskState State { get; set; }

        public string Description { get; set; }
    }
}