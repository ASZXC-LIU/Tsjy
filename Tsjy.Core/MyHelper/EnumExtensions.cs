using System.ComponentModel;
using System.Reflection;
using System;
namespace Tsjy.Core.MyHelper;

public static class EnumExtensions
{
    /// <summary>
    /// 获取枚举上的 Description 特性值，如果没有则返回枚举名称
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetDescription(this Enum value)
    {
        if (value == null) return string.Empty;

        var field = value.GetType().GetField(value.ToString());
        if (field == null) return value.ToString();

        var attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? value.ToString();
    }
}