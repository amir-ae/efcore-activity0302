﻿namespace InventoryModels.DTOs
{
    public class ItemDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int? CategoryId { get; set; }

        public override string ToString()
        {
            return $"{Name,-35} | {Description}";
        }
    }
}