using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furion.DatabaseAccessor;
using Tsjy.Core.Enums;

namespace Tsjy.Core.Entities;

// 在 Tsjy.Core.Entities 下新建 IEvalNode.cs
public interface IEvalNode
{
    long Id { get; set; }
    long TreeId { get; set; }
    long? ParentId { get; set; }
    string Path { get; set; }
    int Depth { get; set; }
    EvalNodeType Type { get; set; }
    string Name { get; set; }
    string Code { get; set; }
    decimal? MaxScore { get; set; }
    long? ScoringModelId { get; set; }
    int OrderIndex { get; set; }
    public bool IsDeleted { get; set; } 
    DateTime CreatedAt { get; set; }
}
