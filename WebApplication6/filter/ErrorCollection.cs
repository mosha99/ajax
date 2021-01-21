using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.filter
{
    public class ErrorCollection
    {
        public string error_box(int error_code ,bool error)
        {
            string Text_error;
            if (!error)
            {
                string D_error;
                switch(error_code)
                {
                    case 1:
                        D_error = "نام باید به صورت فارسی و بیش از 3 حرف باشد";
                        break;
                    case 2:
                        D_error = "نام خانوادگی باید به صورت فارسی و بیش از 3 حرف باشد";
                        break;
                    case 3:
                        D_error = "شماره وارد شده نامعتبر";
                        break;
                    case 4:
                        D_error = "گذرواژه باید دارای حروف کوچک و بزرگ اینگلیسی و عدد و بیش از 8 کارکتر  باشد";
                        break;
                    case 5:
                        D_error = "پسورد و تکرار آن یکسان نیستند";
                        break;
                    case 6:
                        D_error = "پست الکترونیکی معتبر نیست";
                        break;
                    case 7:
                        D_error = "نام کاربری باید بیش از 8 کارکتر وانگلیسی باشد";
                        break;
                    case 8:
                        D_error = "نام کاربری تکراری است";
                        break;
                    case 9:
                        D_error = "شماره تلفن تکراری است";
                        break;
                    case 10:
                        D_error = "ایمیل تکراری است";
                        break;
                    case 11:
                        D_error = "این فیلد اجباری است";
                        break;
                    case 12:
                        D_error = "خطای ناشناخته";
                        break;
                    default:
                        D_error = "خطای ناشناخته";
                        break;
                }

                Text_error = D_error;
            }
            else
            {
                Text_error = null;
            }
            return Text_error;
        }
    }
}