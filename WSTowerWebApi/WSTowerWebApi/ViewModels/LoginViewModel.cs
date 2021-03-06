﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSTowerWebApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        // Define que o tipo de dado
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário!")]
        // Define que o tipo de dado
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
