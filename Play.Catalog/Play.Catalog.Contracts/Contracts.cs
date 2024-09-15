namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);
    public record CatalogItemUpd CatalogItemUpdated(Guid ItemId, string Name, string Desciption);
    public record CatalogItemDeleted(Guid ItemId);
}