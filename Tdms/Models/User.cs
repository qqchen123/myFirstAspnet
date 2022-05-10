using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tdms.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name="E-mail")]
        public string Email { get; set; }
        public DateTime LoginTime { get; set; }

        public List<Data> Datas { get; set; }

    }

    public class Data { }
}