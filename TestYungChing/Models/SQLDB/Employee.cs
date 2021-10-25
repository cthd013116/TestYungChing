using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestYungChing.Models.SQLDB
{
    public class Employee
    {
      
        /// <summary>
        /// 員工編號
        /// </summary>
        public string EmpId { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// 員工生日
        /// </summary>
        public string EmpBirth { get; set; }
    }
}
