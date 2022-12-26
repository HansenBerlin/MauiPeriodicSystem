using MauiAppBlazorTest.Values;

namespace MauiAppBlazorTest.Models;

public class CategoryButtonModel
{
    public List<ButtonModel> Buttons { get; } = new()
    {
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.All, Color = CustomColor.White, Label="alle"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Alkalimetalle, Color = CustomColor.Red, Label="Alkalimetalle"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Erdalkalimetalle, Color = CustomColor.Orange, Label="Erdalkalimetalle"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Uebergangsmetalle, Color = CustomColor.Lime, Label="Übergangsmetalle"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Lanthanoide, Color = CustomColor.Brown, Label="Lanthanoide"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Actinoide, Color = CustomColor.Purple, Label="Actinoide"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Metalle, Color = CustomColor.LightGreen, Label="Metalle"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Halbmetalle, Color = CustomColor.Green, Label="Halbmetalle"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Nichtmetalle, Color = CustomColor.LightBlue, Label="Nichtmetalle"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Halogene, Color = CustomColor.Cyan, Label="Halogene"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Edelgase, Color = CustomColor.Amber, Label="Edelgase"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Unbekannt, Color = CustomColor.BlueGrey, Label="unbekannt"}
    };
}