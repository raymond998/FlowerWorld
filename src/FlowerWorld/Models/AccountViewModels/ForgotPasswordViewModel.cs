﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerWorld.Models.AccountViewModels
{
    //public class LocalPasswordModel
    //{
    //    [Required]
    //    [DataType(DataType.Password)]
    //    [Display(Name = "当前密码")]
    //    public string OldPassword { get; set; }

    //    [Required]
    //    [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
    //    [DataType(DataType.Password)]
    //    [Display(Name = "新密码")]
    //    public string NewPassword { get; set; }

    //    [DataType(DataType.Password)]
    //    [Display(Name = "确认新密码")]
    //    [Compare("NewPassword", ErrorMessage = "新密码和确认密码不匹配。")]
    //    public string ConfirmPassword { get; set; }
    //}
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }
    }
}
