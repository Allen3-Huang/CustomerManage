using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomerManage.Models
{
    public class PhoneValidation : DataTypeAttribute
    {
        public PhoneValidation():base(DataType.Text)
        {

        }
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            if (value is String)
                return Regex.IsMatch(value.ToString(), @"\d{4}-\d{6}");
            else
                return true;
        }
    }
}
