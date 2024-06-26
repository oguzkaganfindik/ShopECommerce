﻿namespace ShopECommerce.DTOs.MessageDto
{
    public class ResultMessageDto
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
		public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
