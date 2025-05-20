namespace BookStore.DtoLayer.BannerDtos
{
    public class InsertBannerDto
    {
        public int BannerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int ProductId { get; set; }
    }
}
