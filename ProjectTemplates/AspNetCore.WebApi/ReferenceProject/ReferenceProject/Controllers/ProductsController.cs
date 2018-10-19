﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReferenceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Repo.IProductsRepo ProductsRepo { get; }
        IMapper Mapper { get; }

        public ProductsController(Repo.IProductsRepo productsRepo, IMapper mapper)
        {
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            ProductsRepo = productsRepo ?? throw new ArgumentNullException(nameof(productsRepo));
        }

        [HttpGet]
        public IEnumerable<Dto.Product> Get()
        {
            return ProductsRepo.Get().Select(Mapper.Map<Dto.Product>);
        }

        [HttpGet("action")]
        public void Action()
        {
            throw new Exception("aaa");
        }
    }
}