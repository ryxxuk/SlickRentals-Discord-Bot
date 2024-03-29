﻿using System;

namespace SlickRentals_Discord_Bot.Models
{
    public class AutoRoleDetails
    {
        public int Id { get; set; }
        public ulong DiscordId { get; set; }
        public ulong ChannelId { get; set; }
        public ulong RoleId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
    }
}