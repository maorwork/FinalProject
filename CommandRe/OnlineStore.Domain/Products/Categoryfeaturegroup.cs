﻿using System;
using System.Collections.Generic;

namespace CommandRe.Domain.Products
{
    public partial class Categoryfeaturegroup
    {
        public Categoryfeaturegroup()
        {
            CategoryfeaturegroupFeaturegroup = new HashSet<CategoryfeaturegroupFeaturegroup>();
            ProductCategoryfeaturegroup = new HashSet<ProductCategoryfeaturegroup>();
        }

        public long CategoryFeatureGroupId { get; set; }

        public virtual ICollection<CategoryfeaturegroupFeaturegroup> CategoryfeaturegroupFeaturegroup { get; set; }
        public virtual ICollection<ProductCategoryfeaturegroup> ProductCategoryfeaturegroup { get; set; }
    }
}
