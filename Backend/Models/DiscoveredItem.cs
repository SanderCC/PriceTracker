﻿using Domain;

namespace Models;

public class DiscoveredItem
{
    public Shop Shop { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public decimal Price { get; set; } = -1;
}