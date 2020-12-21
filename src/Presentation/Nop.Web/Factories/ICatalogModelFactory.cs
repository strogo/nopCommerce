﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Vendors;
using Nop.Web.Models.Catalog;

namespace Nop.Web.Factories
{
    public partial interface ICatalogModelFactory
    {
        #region Common

        //TODO: may be deleted from interface
        /// <summary>
        /// Prepare sorting options
        /// </summary>
        /// <param name="displayingModel">Products displaying model</param>
        /// <param name="command">Products displaying model</param>
        Task PrepareSortingOptionsAsync(CatalogProductsDisplayingModel displayingModel, CatalogProductsDisplayingModel command);

        //TODO: may be deleted from interface
        /// <summary>
        /// Prepare view modes
        /// </summary>
        /// <param name="displayingModel">Products displaying model</param>
        /// <param name="command">Products displaying model</param>
        Task PrepareViewModesAsync(CatalogProductsDisplayingModel displayingModel, CatalogProductsDisplayingModel command);

        //TODO: may be deleted from interface
        /// <summary>
        /// Prepare page size options
        /// </summary>
        /// <param name="productsModel">Catalog products model</param>
        /// <param name="command">Catalog products model</param>
        /// <param name="allowCustomersToSelectPageSize">Are customers allowed to select page size?</param>
        /// <param name="pageSizeOptions">Page size options</param>
        /// <param name="fixedPageSize">Fixed page size</param>
        Task PreparePageSizeOptionsAsync(CatalogProductsModel productsModel, CatalogProductsModel command,
            bool allowCustomersToSelectPageSize, string pageSizeOptions, int fixedPageSize);

        #endregion

        #region Categories

        /// <summary>
        /// Prepare category model
        /// </summary>
        /// <param name="category">Category</param>
        /// <param name="command">Catalog products model</param>
        /// <returns>Category model</returns>
        Task<CategoryModel> PrepareCategoryModelAsync(Category category, CatalogProductsModel command);

        /// <summary>
        /// Prepare category template view path
        /// </summary>
        /// <param name="templateId">Template identifier</param>
        /// <returns>Category template view path</returns>
        Task<string> PrepareCategoryTemplateViewPathAsync(int templateId);

        /// <summary>
        /// Prepare category navigation model
        /// </summary>
        /// <param name="currentCategoryId">Current category identifier</param>
        /// <param name="currentProductId">Current product identifier</param>
        /// <returns>Category navigation model</returns>
        Task<CategoryNavigationModel> PrepareCategoryNavigationModelAsync(int currentCategoryId,
            int currentProductId);

        /// <summary>
        /// Prepare top menu model
        /// </summary>
        /// <returns>Top menu model</returns>
        Task<TopMenuModel> PrepareTopMenuModelAsync();

        /// <summary>
        /// Prepare homepage category models
        /// </summary>
        /// <returns>List of homepage category models</returns>
        Task<List<CategoryModel>> PrepareHomepageCategoryModelsAsync();

        //TODO: may be deleted from interface
        /// <summary>
        /// Prepare category (simple) models
        /// </summary>
        /// <returns>List of category (simple) models</returns>
        Task<List<CategorySimpleModel>> PrepareCategorySimpleModelsAsync();

        //TODO: may be deleted from interface
        /// <summary>
        /// Prepare category (simple) models
        /// </summary>
        /// <param name="rootCategoryId">Root category identifier</param>
        /// <param name="loadSubCategories">A value indicating whether subcategories should be loaded</param>
        /// <returns>List of category (simple) models</returns>
        Task<List<CategorySimpleModel>> PrepareCategorySimpleModelsAsync(int rootCategoryId, bool loadSubCategories = true);

        //TODO: may be deleted from interface
        /// <summary>
        /// Prepare category (simple) xml document
        /// </summary>
        /// <returns>Xml document of category (simple) models</returns>
        Task<XDocument> PrepareCategoryXmlDocumentAsync();

        /// <summary>
        /// Prepare root categories for menu
        /// </summary>
        /// <returns>List of category (simple) models</returns>
        Task<List<CategorySimpleModel>> PrepareRootCategoriesAsync();

        /// <summary>
        /// Prepare subcategories for menu
        /// </summary>
        /// <param name="id">Id of category to get subcategory</param>
        /// <returns></returns>
        Task<List<CategorySimpleModel>> PrepareSubCategoriesAsync(int id);

        /// <summary>
        /// Prepares the category products filtering model
        /// </summary>
        /// <param name="categoryId">The category id</param>
        /// <returns>The category products filtering model</returns>
        Task<CatalogProductsFilteringModel> PrepareCategoryFilteringModelAsync(int categoryId);

        #endregion

        #region Manufacturers

        /// <summary>
        /// Prepare manufacturer model
        /// </summary>
        /// <param name="manufacturer">Manufacturer identifier</param>
        /// <param name="command">Catalog products model</param>
        /// <returns>Manufacturer model</returns>
        Task<ManufacturerModel> PrepareManufacturerModelAsync(Manufacturer manufacturer, CatalogProductsModel command);

        /// <summary>
        /// Prepare manufacturer template view path
        /// </summary>
        /// <param name="templateId">Template identifier</param>
        /// <returns>Manufacturer template view path</returns>
        Task<string> PrepareManufacturerTemplateViewPathAsync(int templateId);

        /// <summary>
        /// Prepare manufacturer all models
        /// </summary>
        /// <returns>List of manufacturer models</returns>
        Task<List<ManufacturerModel>> PrepareManufacturerAllModelsAsync();

        /// <summary>
        /// Prepare manufacturer navigation model
        /// </summary>
        /// <param name="currentManufacturerId">Current manufacturer identifier</param>
        /// <returns>Manufacturer navigation model</returns>
        Task<ManufacturerNavigationModel> PrepareManufacturerNavigationModelAsync(int currentManufacturerId);

        /// <summary>
        /// Prepares the manufacturer products filtering model
        /// </summary>
        /// <param name="manufacturerId">The manufacturer id</param>
        /// <returns>The manufacturer products filtering model</returns>
        Task<CatalogProductsFilteringModel> PrepareManufacturerFilteringModelAsync(int manufacturerId);

        #endregion

        #region Vendors

        /// <summary>
        /// Prepare vendor model
        /// </summary>
        /// <param name="vendor">Vendor</param>
        /// <param name="command">Catalog products model</param>
        /// <returns>Vendor model</returns>
        Task<VendorModel> PrepareVendorModelAsync(Vendor vendor, CatalogProductsModel command);

        /// <summary>
        /// Prepare vendor all models
        /// </summary>
        /// <returns>List of vendor models</returns>
        Task<List<VendorModel>> PrepareVendorAllModelsAsync();

        /// <summary>
        /// Prepare vendor navigation model
        /// </summary>
        /// <returns>Vendor navigation model</returns>
        Task<VendorNavigationModel> PrepareVendorNavigationModelAsync();

        #endregion

        #region Product tags

        /// <summary>
        /// Prepare popular product tags model
        /// </summary>
        /// <returns>Product tags model</returns>
        Task<PopularProductTagsModel> PreparePopularProductTagsModelAsync();

        /// <summary>
        /// Prepare products by tag model
        /// </summary>
        /// <param name="productTag">Product tag</param>
        /// <param name="command">Catalog products model</param>
        /// <returns>Products by tag model</returns>
        Task<ProductsByTagModel> PrepareProductsByTagModelAsync(ProductTag productTag, CatalogProductsModel command);

        /// <summary>
        /// Prepare product tags all model
        /// </summary>
        /// <returns>Popular product tags model</returns>
        Task<PopularProductTagsModel> PrepareProductTagsAllModelAsync();

        #endregion

        #region Searching

        /// <summary>
        /// Prepare search model
        /// </summary>
        /// <param name="model">Search model</param>
        /// <param name="command">Catalog products model</param>
        /// <returns>Search model</returns>
        Task<SearchModel> PrepareSearchModelAsync(SearchModel model, CatalogProductsModel command);

        /// <summary>
        /// Prepare search box model
        /// </summary>
        /// <returns>Search box model</returns>
        Task<SearchBoxModel> PrepareSearchBoxModelAsync();

        #endregion
    }
}