﻿using System.ComponentModel;

namespace WebLuto.Models.Enums
{
    public enum EmailTemplateType
    {
        [Description("WebLuto")]
        Default = 0,
        [Description("Confirmação de Cadastro")]
        AccountCreation = 1,
        [Description("Exclusão de Conta")]
        AccountDeletion = 2,
        [Description("Alteração de Senha")]
        ChangedPassword = 3
    }
}