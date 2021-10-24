using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestYungChing.Models.API
{
   /// <summary>
   /// 取得資料
   /// </summary>
    public class Get
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        public string _EmpId { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string _EmpName { get; set; }

        /// <summary>
        /// 員工生日
        /// </summary>
        public string _EmpBirth { get; set; }
    }
}
