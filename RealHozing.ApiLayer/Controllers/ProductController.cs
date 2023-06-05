using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realhouzing.DtoLayer.ProductDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values= _productService.TGetList();
            return Ok(values);
        }
        [HttpGet("ProductListwithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var values = _productService.TGetProductswithCategories();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductDto addProductDto)
        {
            Product product = new Product()
            {
                BathCount = addProductDto.BathCount,
                BedroomCount = addProductDto.BedroomCount,
                CategoryID = addProductDto.CategoryID,
                ImageURL = addProductDto.ImageURL,
                ProductAddress = addProductDto.ProductAddress,
                ProductPrice = addProductDto.ProductPrice,
                ProductTitle = addProductDto.ProductTitle,
                ProductType = addProductDto.ProductType,
                Square = addProductDto.Square

            };
            _productService.TInsert(product);
            return Ok();


        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var values= _productService.TGetByID(id);
            _productService.TDelete(values);
            return Ok();
        }

        [HttpGet("id")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            Product product = new Product()
            {
                ProductID= updateProductDto.ProductID,
                BathCount = updateProductDto.BathCount,
                BedroomCount = updateProductDto.BedroomCount,
                CategoryID = updateProductDto.CategoryID,
                ImageURL = updateProductDto.ImageURL,
                ProductAddress = updateProductDto.ProductAddress,
                ProductPrice = updateProductDto.ProductPrice,
                ProductTitle = updateProductDto.ProductTitle,
                ProductType = updateProductDto.ProductType,
                Square = updateProductDto.Square
                
                

            };
            _productService.TUpdate(product);
            return Ok();
        }
    }
}
