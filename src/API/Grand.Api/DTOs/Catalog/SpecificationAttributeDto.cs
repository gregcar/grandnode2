﻿using Grand.Api.Models;

namespace Grand.Api.DTOs.Catalog
{
    public class SpecificationAttributeDto : BaseApiEntityModel
    {
        public SpecificationAttributeDto()
        {
            SpecificationAttributeOptions = new List<SpecificationAttributeOptionDto>();
        }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public IList<SpecificationAttributeOptionDto> SpecificationAttributeOptions { get; set; }

    }
    public class SpecificationAttributeOptionDto : BaseApiEntityModel
    {
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string ColorSquaresRgb { get; set; }
    }
}
