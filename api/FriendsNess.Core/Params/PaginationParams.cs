using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Params
{
    public class PaginationParams
    {
        private const int _maxPageItemsCount = 50;
        private int _pageItemsCount;

        public int Page { get; set; } = 1;
        public int PageItemsCount
        {
            get => _pageItemsCount;
            set => _pageItemsCount = value > _maxPageItemsCount ? _maxPageItemsCount : value;
        }
    }
}
