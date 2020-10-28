﻿using System;
using SimpleSoft.Mediator;

namespace IntroductionMediatorCQRS.Handlers.Products
{
    public class GetProductByIdQuery : Query<Product>
    {
        public Guid ProductId { get; set; }
    }
}
