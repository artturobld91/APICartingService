﻿using CartingService.BLL.Dtos;
using CartingService.DAL.Database;

namespace CartingService.BLL.Application
{
    public class CartService : ICartService
    {
        private MongoUnitOfWork _mongo;
        public CartService()
        {
            _mongo = new MongoUnitOfWork();
        }

        public async Task CreateCart(CreateCartDto cart)
        {
            await _mongo._cartRepository.CreateCart(cart);
        }

        public async Task<IList<ItemDto>> GetCartItems(Guid id)
        {
            return await _mongo._cartRepository.GetCartItems(id);
        }

        public async Task<List<ItemDto>> GetItemListFromCart()
        {
            return await _mongo._cartRepository.GetItems();
        }

        public async Task AddItemToCart(AddItemDto item)
        {
            await _mongo._cartRepository.AddItem(item);
        }

        public async Task RemoveItemFromCart(RemoveItemDto item)
        {
            await _mongo._cartRepository.RemoveItem(item);
        }
    }
}
