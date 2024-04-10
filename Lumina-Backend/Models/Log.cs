﻿namespace Lumina_Backend.Models;

public class Log : BaseEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public ActionType Action { get; set; }
    public DateTime Timestamp { get; set; }
    public string IPAddress { get; set; }
}

public enum ActionType
{
    Login,
    Logout,
    Transaction
}
