﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OASystem.Entity
{
    [Table("schedules")]
    public class Schedule
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("department_id")]
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        [Column("to_user_id")]
        [ForeignKey("ToUser")]
        public int ToUserID { get; set; }
        public virtual User ToUser { get; set; }

        [Column("submittion_user_id")]
        [ForeignKey("SubmittionUser")]
        public int? SubmittionUserID { get; set; }
        public virtual User SubmittionUser { get; set; }

        [Column("time")]
        public DateTime Time { get; set; }


        [NotMapped]
        public string TimeAsString {  get{return Time.ToString();} }
    }
}
