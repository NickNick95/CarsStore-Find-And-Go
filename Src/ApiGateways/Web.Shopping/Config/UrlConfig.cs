using System.Collections.Generic;

namespace Web.Shopping.Config
{
    public class UrlsConfig
    {
        public class CatalogOperations
        {
            public static string GetItems() => $"/api/catalog/";
            public static string GetItemById(string id) => $"/api/catalog/{id}";
            public static string AddItem() => $"/api/catalog/add";
        }

        public class BasketOperations
        {
            public static string GetItemById(string id) => $"/api/v1/basket/{id}";
            public static string UpdateBasket() => "/api/v1/basket";
        }

        public class OrdersOperations
        {
            public static string GetOrderDraft() => "/api/v1/orders/draft";
        }

        public string Basket = "";
        public string Catalog = "http://localhost:59819";
        public string Orders = "";
    }
}
