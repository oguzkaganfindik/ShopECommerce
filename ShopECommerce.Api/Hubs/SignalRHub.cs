using Microsoft.AspNetCore.SignalR;
using ShopECommerce.Business.Abstract;

namespace ShopECommerce.Api.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IBasketItemService _basketItemService;
        private readonly IUserService _userService;
        private readonly IMessageService _messageService;
        private readonly INotificationService _notificationService;
        private readonly IBasketService _basketService;


        public SignalRHub(ISubCategoryService subCategoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IBasketItemService basketItemService, IUserService userService, INotificationService notificationService, IMessageService messageService, IBasketService basketService)
        {
            _subCategoryService = subCategoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _basketItemService = basketItemService;
            _userService = userService;
            _notificationService = notificationService;
            _messageService = messageService;
            _basketService = basketService;
        }

        public static int clientCount { get; set; } = 0;

        public async Task SendStatistic()
        {
            var value = await _subCategoryService.TSubCategoryCountAsync();
            await Clients.All.SendAsync("ReceiveSubCategoryCount", value);

            var value2 = await _productService.TProductCountAsync();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = await _subCategoryService.TActiveSubCategoryCountAsync();
            await Clients.All.SendAsync("ReceiveActiveSubCategoryCount", value3);

            var value4 = await _subCategoryService.TPassiveSubCategoryCountAsync();
            await Clients.All.SendAsync("ReceivePassiveSubCategoryCount", value4);

            var value5 = await _productService.TProductCountBySubCategoryNameAppleAsync();
            await Clients.All.SendAsync("ReceiveProductCountBySubCategoryNameApple", value5);

            var value6 = await _productService.TProductCountBySubCategoryNameTomatoAsync();
            await Clients.All.SendAsync("ReceiveProductCountBySubCategoryNameTomato", value6);

            var value7 = await _productService.TProductPriceAvgAsync();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00") + " TL");

            var value8 = await _productService.TProductNameByMaxPriceAsync();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);

            var value9 = await _productService.TProductNameByMinPriceAsync();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

            var value10 = await _productService.TProductAvgPriceByAppleAsync();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByApple", value10.ToString("0.00") + " TL");

            var value11 = await _orderService.TTotalOrderCountAsync();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            var value12 = await _orderService.TActiveOrderCountAsync();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            var value13 = await _orderService.TLastOrderPriceAsync();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00") + " TL");

            var value14 = await _moneyCaseService.TTotalMoneyCaseAmountAsync();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00") + " TL");

            var value16 = await _basketItemService.TBasketItemCountAsync();
            await Clients.All.SendAsync("ReceiveBasketItemCount", value16);
        }

        public async Task SendProgress()
        {
            var value = await _moneyCaseService.TTotalMoneyCaseAmountAsync();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value.ToString("0.00") + " TL");

            var value2 = await _orderService.TActiveOrderCountAsync();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);

            var value3 = await _basketItemService.TBasketItemCountAsync();
            await Clients.All.SendAsync("ReceiveBasketItemCount", value3);

            var value5 = await _productService.TProductPriceAvgAsync();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value5);

            var value6 = await _productService.TProductAvgPriceByAppleAsync();
            await Clients.All.SendAsync("ReceiveAvgPriceByApple", value6);

            var value7 = await _productService.TProductCountBySubCategoryNameTomatoAsync();
            await Clients.All.SendAsync("ReceiveProductCountBySubCategoryNameTomato", value7);

            var value8 = await _orderService.TTotalOrderCountAsync();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value8);

            var value9 = await _productService.TProductPriceByNativeOrangesAsync();
            await Clients.All.SendAsync("ReceiveProductPriceByNativeOranges", value9);

            var value10 = await _productService.TTotalPriceByTomatoSubCategoryAsync();
            await Clients.All.SendAsync("ReceiveTotalPriceByTomatoSubCategory", value10);

            var value11 = await _productService.TTotalPriceByStrawberrySubCategoryAsync();
            await Clients.All.SendAsync("ReceiveTotalPriceByStrawberrySubCategory", value11);

            var notificationListByFalse = await _notificationService.TNotificationCountByStatusFalseAsync();
            await Clients.All.SendAsync("ReceiveNotificationCountByFalse", notificationListByFalse);
        }
        public async Task GetUserList()
        {
            var values = _userService.TGetListAll();
            await Clients.All.SendAsync("ReceiveUserList", values);
        }

        public async Task GetMessageList()
        {
            var values = _messageService.TGetListAll();
            await Clients.All.SendAsync("ReceiveMessageList", values);
        }

        public async Task SendNotification()
        {
            var value = await _notificationService.TNotificationCountByStatusFalseAsync();
            await Clients.All.SendAsync("ReceiveNotificationCountByFalse", value);

            var notificationListByTrue = await _notificationService.TGetAllNotificationsByTrueAsync();
            await Clients.All.SendAsync("ReceiveNotificationListByTrue", notificationListByTrue);

            var basketItemCount = await _basketService.TGetBasketItemCountAsync();
            if (basketItemCount > 0) 
            {
                await Clients.All.SendAsync("ReceiveBasketItemCount", basketItemCount);
            }
        }

        public async Task GetBasketItemStatus()
        {
            var value = _basketItemService.TGetListAll();
            await Clients.All.SendAsync("ReceiveBasketItemStatus", value);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override async Task OnConnectedAsync()
        {
            clientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}