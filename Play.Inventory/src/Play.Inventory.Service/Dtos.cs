using System;

namespace Play.Inventory.Service
{
    public record GraantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);
    public record InventoryItemDto(Guid CatalogItemId, int Quantity, DateTimeOffset AcquiredDate);
}