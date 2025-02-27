﻿using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Http;
using Nop.Plugin.Api.DTO.Categories;
using Nop.Plugin.Api.Helpers;

namespace Nop.Plugin.Api.Validators
{
    public class CategoryDtoValidator : BaseDtoValidator<CategoryDto>
    {
        #region Constructors

        public CategoryDtoValidator(IHttpContextAccessor httpContextAccessor, IJsonHelper jsonHelper, Dictionary<string, object> requestJsonDictionary) :
            base(httpContextAccessor, jsonHelper, requestJsonDictionary)
        {
            SetNameRule();
        }

        #endregion

        #region Private Methods

        private void SetNameRule()
        {
            SetNotNullOrEmptyCreateOrUpdateRule(c => c.Name, "invalid name", "name");
        }

        #endregion
    }
}
