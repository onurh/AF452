﻿
using Nop.Core.Configuration;

namespace Nop.Core.Domain.Catalog
{
    public class CatalogSettings : ISettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether to display product SKU
        /// </summary>
        public bool ShowProductSku { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to display manufacturer part number of a product
        /// </summary>
        public bool ShowManufacturerPartNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to display GTIN of a product
        /// </summary>
        public bool ShowGtin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether product sorting is enabled
        /// </summary>
        public bool AllowProductSorting { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to change product view mode
        /// </summary>
        public bool AllowProductViewModeChanging { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to change product view mode
        /// </summary>
        public string DefaultViewMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether number of products should be displayed beside each category
        /// </summary>
        public bool ShowCategoryProductNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we include subcategories (when 'ShowCategoryProductNumber' is 'true')
        /// </summary>
        public bool ShowCategoryProductNumberIncludingSubcategories { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether category breadcrumb is enabled
        /// </summary>
        public bool CategoryBreadcrumbEnabled { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether a 'Share button' is enabled
        /// </summary>
        public bool ShowShareButton { get; set; }

        /// <summary>
        /// Gets or sets a share code (e.g. AddThis button code)
        /// </summary>
        public string PageShareCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating product reviews must be approved
        /// </summary>
        public bool ProductReviewsMustBeApproved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the default rating value of the product reviews
        /// </summary>
        public int DefaultProductRatingValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to allow anonymous users write product reviews.
        /// </summary>
        public bool AllowAnonymousUsersToReviewProduct { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether notification of a store owner about new product reviews is enabled
        /// </summary>
        public bool NotifyStoreOwnerAboutNewProductReviews { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether product 'Email a friend' feature is enabled
        /// </summary>
        public bool EmailAFriendEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to allow anonymous users to email a friend.
        /// </summary>
        public bool AllowAnonymousUsersToEmailAFriend { get; set; }

        /// <summary>
        /// Gets or sets a number of "Recently viewed products"
        /// </summary>
        public int RecentlyViewedProductsNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether "Recently viewed products" feature is enabled
        /// </summary>
        public bool RecentlyViewedProductsEnabled { get; set; }

        /// <summary>
        /// Gets or sets a number of "Recently added products"
        /// </summary>
        public int RecentlyAddedProductsNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether "Recently added products" feature is enabled
        /// </summary>
        public bool RecentlyAddedProductsEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether "Compare products" feature is enabled
        /// </summary>
        public bool CompareProductsEnabled { get; set; }

        /// <summary>
        /// Gets or sets a minimum search term length
        /// </summary>
        public int ProductSearchTermMinimumLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show bestsellers on home page
        /// </summary>
        public bool ShowBestsellersOnHomepage { get; set; }

        /// <summary>
        /// Gets or sets a number of bestsellers on home page
        /// </summary>
        public int NumberOfBestsellersOnHomepage { get; set; }

        /// <summary>
        /// Gets or sets a number of products per page on search products page
        /// </summary>
        public int SearchPageProductsPerPage { get; set; }

        /// <summary>
        /// Gets or sets "List of products purchased by other customers who purchased the above" option is enable
        /// </summary>
        public bool ProductsAlsoPurchasedEnabled { get; set; }

        /// <summary>
        /// Gets or sets a number of products also purchased by other customers to display
        /// </summary>
        public int ProductsAlsoPurchasedNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dynamic price update is enabled
        /// </summary>
        public bool EnableDynamicPriceUpdate { get; set; }

        /// <summary>
        /// Gets or sets a number of product tags that appear in the tag cloud
        /// </summary>
        public int NumberOfProductTags { get; set; }

        /// <summary>
        /// Gets or sets a number of products per page on 'products by tag' page
        /// </summary>
        public int ProductsByTagPageSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers can select the page size for 'products by tag'
        /// </summary>
        public bool ProductsByTagAllowCustomersToSelectPageSize { get; set; }

        /// <summary>
        /// Gets or sets the available customer selectable page size options for 'products by tag'
        /// </summary>
        public string ProductsByTagPageSizeOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use small product boxes on home page
        /// </summary>
        public bool UseSmallProductBoxOnHomePage { get; set; }

        /// <summary>
        /// An option indicating whether products on category and manufacturer pages should include featured products as well
        /// </summary>
        public bool IncludeFeaturedProductsInNormalLists { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore tier prices (side-wide)
        /// </summary>
        public bool IgnoreTierPrices { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore discounts (side-wide)
        /// </summary>
        public bool IgnoreDiscounts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore featured products (side-wide)
        /// </summary>
        public bool IgnoreFeaturedProducts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether we need to ensure that we have at least one filterable product specification attribute mapping before load 'filter by specs' box on category details page. Set it to 'True' if you don't use them. It can really improve your performance
        /// </summary>
        public bool EnsureWeHaveFilterableSpecAttributes { get; set; }

        /// <summary>
        /// Gets or set the default value to use for Category page size options (for new Categories)
        /// </summary>
        public string DefaultCategoryPageSizeOptions { get; set; }

        /// <summary>
        /// Gets or set the default value to use for Manufacturer page size opitons (for new Manufacturers)
        /// </summary>
        public string DefaultManufacturerPageSizeOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating maximum number of 'back in stock' subscription
        /// </summary>
        public int MaximumBackInStockSubscriptions { get; set; }

        public bool HidePriceIfCallforPrice { get; set; }

        public int RandomRelatedProductCount { get; set; }

        public bool ShowProductsFromSubcategories { get; set; }

        public int ProductListBannerStartpoint { get; set; }

        public int ProductMaxAddCount { get; set; }

        public int NewProductAge { get; set; }

        public int RandomCrossSellProductCount { get; set; }

        public int ProductDetailDropDownValue { get; set; }

        public int  RecentlyAddedTotalProducts { get; set; }

        public int ProductSortingType { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether to ignore featured products (side-wide)
        /// </summary>
        public bool RecentlyAddedProductsAllowFiltering { get; set; }
    }
}