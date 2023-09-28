using System.Collections.Generic;
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
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Unbekannt, Color = CustomColor.BlueGrey, Label="unbekannt"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Radioaktiv, Color = CustomColor.BlueGrey, Label="radioaktiv"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.DichteUnbekannt, Color = CustomColor.BlueGrey, Label="Dichte unbekannt"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.DichteGering, Color = CustomColor.BlueGrey, Label="Dichte gering"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.DichteHoch, Color = CustomColor.BlueGrey, Label="Dichte hoch"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.AggregatUnbekannt, Color = CustomColor.BlueGrey, Label="Agg. unbekannt"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.AggregatFest, Color = CustomColor.BlueGrey, Label="Agg. fest"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.AggregatFlüssig, Color = CustomColor.BlueGrey, Label="Agg. flüssig"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.AggregatGas, Color = CustomColor.BlueGrey, Label="Agg. gasförmig"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Natuerlich, Color = CustomColor.BlueGrey, Label="natürlich"},
        new ButtonModel{State = State.Inactive, ActivatesTag = Tags.Kuenstlich, Color = CustomColor.BlueGrey, Label="künstlich"},
    };
}