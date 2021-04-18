using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);
        public List<ProductModel> items = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount, 
            Func<List<ProductModel>,decimal,decimal> calculateDiscountedTotal,
            Action<string> tellUserWeAreDiscounting
            )
        {
            decimal subTotal = items.Sum(x => x.Price);
            mentionDiscount(subTotal);
            tellUserWeAreDiscounting("We are applying discounts. ");
            return calculateDiscountedTotal(items, subTotal);
        }
    }
}