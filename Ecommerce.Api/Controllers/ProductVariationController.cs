﻿using Ecommerce.Data.DTOs;
using Ecommerce.Data.Models.ApiModel;
using Ecommerce.Data.Models.Entities;
using Ecommerce.Service.Services.ProductVariationService;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariationController : ControllerBase
    {
        private readonly IProductVariationService _productVariationService;
        public ProductVariationController(IProductVariationService _productVariationService)
        {
            this._productVariationService = _productVariationService;
        }

        [HttpGet("allproductvariations")]
        public async Task<IActionResult> GetAllProductVariationsAsync()
        {
            try
            {
                var response = await _productVariationService.GetAllProductVariationsAsync();
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status400BadRequest
                    , new ApiResponse<IEnumerable<ProductVariation>>
                    {
                        StatusCode = 400,
                        IsSuccess = false,
                        Message = "Unknown error",
                        ResponseObject = new List<ProductVariation>()
                    });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError
                    , new ApiResponse<IEnumerable<ProductVariation>>
                    {
                        StatusCode = 500,
                        IsSuccess = false,
                        Message = ex.Message,
                        ResponseObject = new List<ProductVariation>()
                    });
            }
        }

        [HttpGet("allproductvariationsbyvariationoptionid/{variationOptionId}")]
        public async Task<IActionResult> GetAllProductVariationsByVariationOptionIdAsync
            ([FromRoute]Guid variationOptionId)
        {
            try
            {
                var response = await _productVariationService
                    .GetAllProductVariationsByVariationOptionIdAsync(variationOptionId);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status400BadRequest
                    , new ApiResponse<IEnumerable<ProductVariation>>
                    {
                        StatusCode = 400,
                        IsSuccess = false,
                        Message = "Unknown error",
                        ResponseObject = new List<ProductVariation>()
                    });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError
                    , new ApiResponse<IEnumerable<ProductVariation>>
                    {
                        StatusCode = 500,
                        IsSuccess = false,
                        Message = ex.Message,
                        ResponseObject = new List<ProductVariation>()
                    });
            }
        }


        [HttpGet("allproductvariationsbyproductitemid/{productItemId}")]
        public async Task<IActionResult> GetAllProductVariationsByProductItemIdAsync
            ([FromRoute] Guid productItemId)
        {
            try
            {
                var response = await _productVariationService
                    .GetAllProductVariationsByProductItemIdAsync(productItemId);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status400BadRequest
                    , new ApiResponse<IEnumerable<ProductVariation>>
                    {
                        StatusCode = 400,
                        IsSuccess = false,
                        Message = "Unknown error",
                        ResponseObject = new List<ProductVariation>()
                    });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError
                    , new ApiResponse<IEnumerable<ProductVariation>>
                    {
                        StatusCode = 500,
                        IsSuccess = false,
                        Message = ex.Message,
                        ResponseObject = new List<ProductVariation>()
                    });
            }
        }

        [HttpPost("addproductvariation")]
        public async Task<IActionResult> AddProductVariationAsync
            ([FromBody] ProductVariationDto productVariationDto)
        {
            try
            {
                var response = await _productVariationService.AddProductVariationAsync(productVariationDto);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status400BadRequest
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 400,
                        IsSuccess = false,
                        Message = "Unknown error",
                        ResponseObject = new ProductVariation()
                    });

            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 500,
                        IsSuccess = false,
                        Message = ex.Message,
                        ResponseObject = new ProductVariation()
                    });
            }
        }


        [HttpPut("updateproductvariation")]
        public async Task<IActionResult> UpdateProductVariationAsync
            ([FromBody] ProductVariationDto productVariationDto)
        {
            try
            {
                var response = await _productVariationService.UpdateProductVariationAsync(productVariationDto);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status400BadRequest
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 400,
                        IsSuccess = false,
                        Message = "Unknown error",
                        ResponseObject = new ProductVariation()
                    });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 500,
                        IsSuccess = false,
                        Message = ex.Message,
                        ResponseObject = new ProductVariation()
                    });
            }
        }

        [HttpGet("getproductvariationbyid/{productVariationId}")]
        public async Task<IActionResult> GetProductVariationByIdAsync([FromRoute] Guid productVariationId)
        {
            try
            {
                var response = await _productVariationService.GetProductVariationByIdAsync(productVariationId);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status400BadRequest
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 400,
                        IsSuccess = false,
                        Message = "Unknown error",
                        ResponseObject = new ProductVariation()
                    });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 500,
                        IsSuccess = false,
                        Message = ex.Message,
                        ResponseObject = new ProductVariation()
                    });
            }
        }

        [HttpDelete("deleteproductvariationbyid/{productVariationId}")]
        public async Task<IActionResult> DeleteProductVariationByIdAsync([FromRoute] Guid productVariationId)
        {
            try
            {
                var response = await _productVariationService
                    .DeleteProductVariationByIdAsync(productVariationId);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status400BadRequest
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 400,
                        IsSuccess = false,
                        Message = "Unknown error",
                        ResponseObject = new ProductVariation()
                    });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError
                    , new ApiResponse<ProductVariation>
                    {
                        StatusCode = 500,
                        IsSuccess = false,
                        Message = ex.Message,
                        ResponseObject = new ProductVariation()
                    });
            }
        }


    }
}
