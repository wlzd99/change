using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class BlogModel
    {
        [Display(Name = "博客名称")]
        [Required(ErrorMessage = "请输入你的博客名称！")]
        public string BlogName { get; set; }

        [Display(Name = "博客地址")]
        [Required(ErrorMessage = "请输入你的博客地址！")]
        public string BlogAddress { get; set; }

        [Display(Name = "博客图片")]
        [Required(ErrorMessage = "请上传你的博客图片！")]
        [ValidateFile]
        public HttpPostedFileBase BlogPhoto { get; set; }
    }

    public class ValidateFileAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int MaxContentLength = 1024 * 1024 * 4;
            string[] AllowedFileExtensions = new string[] { ".jpg", ".gif", ".png", ".pdf" };

            var file = value as HttpPostedFileBase;

            if (file == null)
                return false;
            else if (!AllowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
            {
                ErrorMessage = "请上传你的博客图片类型: " + string.Join(", ", AllowedFileExtensions);
                return false;
            }
            else if (file.ContentLength > MaxContentLength)
            {
                ErrorMessage = "上传图片过大，不能超过4兆 : " + (MaxContentLength / 1024).ToString() + "MB";
                return false;
            }
            else
                return true;
        }
    }
}