﻿using Microsoft.AspNetCore.Mvc.Razor;
using System;

namespace Fornecedores.UI.Extensions
{
    public static class RezorExtensions
    {
        public static string FormataDocumento(this RazorPage page, int tipoPessoa, string documento)
        {
            return tipoPessoa == 1 ? Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00") : Convert.ToUInt64(documento).ToString(@"00\.000\.000\/.000\-00");
        }
    }
}