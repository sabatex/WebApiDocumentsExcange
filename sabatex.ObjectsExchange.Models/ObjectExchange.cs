﻿using Sabatex.Core;
using System.ComponentModel.DataAnnotations;

namespace sabatex.ObjectsExchange.Models;

public class ObjectExchange:IEntityBase
{
    public long Id { get; set; }
    public Guid Sender { get; set; }
    public Guid Destination { get; set; }

    [Required]
    [MaxLength(50)]
    public string ObjectId { get; set; } = default!; 
    [MaxLength(50)]
    public string ObjectType { get; set; } = default!; 

    /// <summary>
    /// внутрішня позначка часу створення обєкта
    /// </summary>
    public DateTime DateStamp { get; set; } = DateTime.Now;
    public string ObjectAsText { get; set; }=default!;

    string IEntityBase.KeyAsString()=> Id.ToString();

}
