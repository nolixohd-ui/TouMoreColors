using MiraAPI.Colors;
using UnityEngine;

namespace MoreColors;

[RegisterCustomColors]
public static class MoreColorsPlayerColors
{
    public static CustomColor Mango { get; } = new("Mango",
        new Color32(255, 216, 0, byte.MaxValue),
        new Color32(255, 163, 0, byte.MaxValue))
    {
        ColorBrightness = CustomColorBrightness.Lighter
    };
    public static CustomColor Lavender { get; } = new("Lavender",
        new Color32(154, 125, 180, byte.MaxValue),
        new Color32(124, 87, 145, byte.MaxValue))
    {
        ColorBrightness = CustomColorBrightness.Lighter
    };
    public static CustomColor Wooden { get; } = new("Peach",
        new Color32(229, 177, 148, byte.MaxValue),
        new Color32(186, 127, 110, byte.MaxValue))
    {
        ColorBrightness = CustomColorBrightness.Lighter
    };
    public static CustomColor Bubblegum { get; } = new("Bubblegum",
        new Color32(186, 91, 146, 255),
        new Color32(134, 82, 136, 255))
    {
        ColorBrightness = CustomColorBrightness.Lighter
    };
    public static CustomColor Apricot { get; } = new("Apricot",
        new Color32(255, 160, 71, byte.MaxValue),
        new Color32(160, 100, 44, byte.MaxValue))
    {
        ColorBrightness = CustomColorBrightness.Darker
    };
    public static CustomColor Brick { get; } = new("Brick",
        new Color32(158, 35, 36, byte.MaxValue),
        new Color32(131, 24, 24, byte.MaxValue))
    {
        ColorBrightness = CustomColorBrightness.Darker
    };
    public static CustomColor Galaxy { get; } = new("Galaxy",
        new Color32(40, 0, 109, byte.MaxValue),
        new Color32(16, 0, 91, byte.MaxValue))
    {
        ColorBrightness = CustomColorBrightness.Darker
    };
    public static CustomColor Cherry { get; } = new("Cherry",
        new Color32(234, 164, 212, 255),
        new Color32(237, 130, 203, 255))
    {
        ColorBrightness = CustomColorBrightness.Lighter
    };
}
