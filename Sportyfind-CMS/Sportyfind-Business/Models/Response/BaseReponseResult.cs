using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportyfind_Business.Models.Response
{
    public class BaseResponseResult
    {
        public dynamic data { get; set; }
        /// <summary>
        /// 
        /// <para>0 Thành công</para>
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Nội dung thông báo hiển thị lên ứng dụng cho người dùng
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// Nội dung thông báo lỗi phục vụ cho dev (ko hiển thị lên cho người dùng)
        /// </summary>
        public string errormessage { get; set; }
        public string serverName { get; set; }
        /// <summary>
        /// Dữ liệu trả về
        /// </summary>
        public BaseResponseResult()
        {
            message = string.Empty;
            errormessage = string.Empty;
            serverName = string.Empty;
        }

        public BaseResponseResult SetError(int code = -1, string errorMess = "Failed")
        {
            this.code = code;
            this.errormessage = errorMess;
            return this;
        }
    }
}
