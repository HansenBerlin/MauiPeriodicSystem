using MauiAppBlazorTest.Values;

namespace MauiAppBlazorTest.Models;

public class ButtonGrid : IButtonGrid
{
    public ElementButtonModel[][] Grid { get; }
    public List<ElementButtonModel> ActivatorButtons { get; } = new();
    public List<ElementButtonModel> PassiveButtons { get; } = new();
    public List<ElementButtonModel> AllButtons { get; } = new();

    public ButtonGrid()
    {
        Grid = new[]
        {
            _rowOne, _rowTwo, _rowThree, _rowFour, _rowFive, _rowSix, _rowSeven, _rowEight, _rowNine, _rowTen, _rowEleven
        };
        foreach (var row in Grid)
        {
            foreach (var col in row)
            {
                if (col.State == State.Dummy)
                {
                    continue;
                }
                AllButtons.Add(col);
                if (col.ActivatesTag != Tags.None)
                {
                    ActivatorButtons.Add(col);
                }
                if (col.OwnTags.Count > 0)
                {
                    PassiveButtons.Add(col);
                }
            }
        }
    }
    
    private readonly ElementButtonModel[] _rowOne = {
        new(){IsHalfHeight = true, IsHalfWidth = true},
        new(State.Inactive, "1", 121) {IsHalfHeight = true, ActivatesTag = Tags.GroupOne},
        new(State.Inactive, "2", 122) {IsHalfHeight = true, ActivatesTag = Tags.GroupTwo},
        new(State.Inactive, "3", 123) {IsHalfHeight = true, ActivatesTag = Tags.GroupThree},
        new(State.Inactive, "4", 124) {IsHalfHeight = true, ActivatesTag = Tags.GroupFour},
        new(State.Inactive, "5", 125) {IsHalfHeight = true, ActivatesTag = Tags.GroupFive},
        new(State.Inactive, "6", 126) {IsHalfHeight = true, ActivatesTag = Tags.GroupSix},
        new(State.Inactive, "7", 127) {IsHalfHeight = true, ActivatesTag = Tags.GroupSeven},
        new(State.Inactive, "8", 128) {IsHalfHeight = true, ActivatesTag = Tags.GroupEight},
        new(State.Inactive, "9", 129) {IsHalfHeight = true, ActivatesTag = Tags.GroupNine},
        new(State.Inactive, "10", 130) {IsHalfHeight = true, ActivatesTag = Tags.GroupTen},
        new(State.Inactive, "11", 131) {IsHalfHeight = true, ActivatesTag = Tags.GroupEleven},
        new(State.Inactive, "12", 132) {IsHalfHeight = true, ActivatesTag = Tags.GroupTwelve},
        new(State.Inactive, "13", 133) {IsHalfHeight = true, ActivatesTag = Tags.GroupThirteen},
        new(State.Inactive, "14", 134) {IsHalfHeight = true, ActivatesTag = Tags.GroupFourteen},
        new(State.Inactive, "15", 135) {IsHalfHeight = true, ActivatesTag = Tags.GroupFivteen},
        new(State.Inactive, "16", 136) {IsHalfHeight = true, ActivatesTag = Tags.GroupSixteen},
        new(State.Inactive, "17", 137) {IsHalfHeight = true, ActivatesTag = Tags.GroupSeventeen},
        new(State.Inactive, "18", 138) {IsHalfHeight = true, ActivatesTag = Tags.GroupEighteen}
    };

    private readonly ElementButtonModel[] _rowTwo = {
        new(State.Inactive, "1", 120){IsHalfWidth = true, ActivatesTag = Tags.PeriodOne},
        new(State.Inactive, "H", 119, CustomColor.LightBlue) {OwnTags = new List<Tags>{Tags.GroupOne, Tags.PeriodOne, Tags.DichteGering, Tags.AggregatGas, Tags.Nichtmetalle, Tags.Natuerlich}},
        new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(),
        new(State.Inactive, "He", 139, CustomColor.Amber){OwnTags = new List<Tags>{Tags.GroupEighteen, Tags.PeriodOne, Tags.DichteGering, Tags.AggregatGas, Tags.Edelgase, Tags.Natuerlich}}
    };

    private readonly ElementButtonModel[] _rowThree = {
        new(State.Inactive, "2", 116) {IsHalfWidth = true, ActivatesTag = Tags.PeriodTwo},
        new(State.Inactive, "Li", 117, CustomColor.Red){OwnTags = new List<Tags>{Tags.GroupOne, Tags.PeriodTwo, Tags.DichteHoch, Tags.AggregatFest, Tags.Alkalimetalle, Tags.Natuerlich}},
        new(State.Inactive, "Be", 118, CustomColor.Orange){OwnTags = new List<Tags>{Tags.GroupTwo, Tags.PeriodTwo, Tags.DichteHoch, Tags.AggregatFest, Tags.Erdalkalimetalle, Tags.Natuerlich}},
        new(), new(), new(), new(), new(), new(), new(), new(), new(), new(),
        new(State.Inactive, "B", 140, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupThirteen, Tags.PeriodTwo, Tags.DichteHoch, Tags.AggregatFest, Tags.Halbmetalle, Tags.Natuerlich}},
        new(State.Inactive, "C", 141, CustomColor.LightBlue){OwnTags = new List<Tags>{Tags.GroupFourteen, Tags.PeriodTwo, Tags.DichteHoch, Tags.AggregatFest, Tags.Nichtmetalle, Tags.Natuerlich}},
        new(State.Inactive, "N", 142, CustomColor.LightBlue){OwnTags = new List<Tags>{Tags.GroupFivteen, Tags.PeriodTwo, Tags.DichteGering, Tags.AggregatGas, Tags.Nichtmetalle, Tags.Natuerlich}},
        new(State.Inactive, "O", 143, CustomColor.LightBlue){OwnTags = new List<Tags>{Tags.GroupSixteen, Tags.PeriodTwo, Tags.DichteGering, Tags.AggregatGas, Tags.Nichtmetalle, Tags.Natuerlich}},
        new(State.Inactive, "F", 144, CustomColor.Cyan){OwnTags = new List<Tags>{Tags.GroupSeventeen, Tags.PeriodTwo, Tags.DichteGering, Tags.AggregatGas, Tags.Halogene, Tags.Natuerlich}},
        new(State.Inactive, "Ne", 145, CustomColor.Amber){OwnTags = new List<Tags>{Tags.GroupEighteen, Tags.PeriodTwo, Tags.DichteGering, Tags.AggregatGas, Tags.Edelgase, Tags.Natuerlich}}
    };

    private readonly ElementButtonModel[] _rowFour = {
        new(State.Inactive, "3", 115) {IsHalfWidth = true, ActivatesTag = Tags.PeriodThree},
        new(State.Inactive, "Na", 114, CustomColor.Red){OwnTags = new List<Tags>{Tags.GroupOne, Tags.PeriodThree, Tags.DichteHoch, Tags.AggregatFest, Tags.Alkalimetalle, Tags.Natuerlich}},
        new(State.Inactive, "Mg", 113, CustomColor.Orange){OwnTags = new List<Tags>{Tags.GroupTwo, Tags.PeriodThree, Tags.DichteHoch, Tags.AggregatFest, Tags.Erdalkalimetalle, Tags.Natuerlich}},
        new(), new(), new(), new(), new(), new(), new(), new(), new(), new(),
        new(State.Inactive, "Al", 112, CustomColor.LightGreen){OwnTags = new List<Tags>{Tags.GroupThirteen, Tags.PeriodThree, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich}},
        new(State.Inactive, "Si", 111, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupFourteen, Tags.PeriodThree, Tags.DichteHoch, Tags.AggregatFest, Tags.Halbmetalle, Tags.Natuerlich}},
        new(State.Inactive, "P", 110, CustomColor.LightBlue){OwnTags = new List<Tags>{Tags.GroupFivteen, Tags.PeriodThree, Tags.DichteHoch, Tags.AggregatFest, Tags.Nichtmetalle, Tags.Natuerlich}},
        new(State.Inactive, "S", 109, CustomColor.LightBlue){OwnTags = new List<Tags>{Tags.GroupSixteen, Tags.PeriodThree, Tags.DichteHoch, Tags.AggregatFest, Tags.Nichtmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Cl", 108, CustomColor.Cyan){OwnTags = new List<Tags>{Tags.GroupSeventeen, Tags.PeriodThree, Tags.DichteGering, Tags.AggregatGas, Tags.Halogene, Tags.Natuerlich}},
        new(State.Inactive, "Ar", 107, CustomColor.Amber){OwnTags = new List<Tags>{Tags.GroupEighteen, Tags.PeriodThree, Tags.DichteGering, Tags.AggregatGas, Tags.Edelgase, Tags.Natuerlich}}
    };

    private readonly ElementButtonModel[] _rowFive = {
        new(State.Inactive, "4", 88) {IsHalfWidth = true, ActivatesTag = Tags.PeriodFour},
        new(State.Inactive, "K", 89, CustomColor.Red){OwnTags = new List<Tags>{Tags.GroupOne, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Alkalimetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ca", 90, CustomColor.Orange){OwnTags = new List<Tags>{Tags.GroupTwo, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Erdalkalimetalle, Tags.Natuerlich}},
        new(State.Inactive, "Sc", 91, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ti", 92, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFour, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "V", 93, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFive, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Cr", 94, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSix, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Mn", 95, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSeven, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Fe", 96, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEight, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Co", 97, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupNine, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ni", 98, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTen, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Cu", 99, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEleven, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Zn", 100, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTwelve, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ga", 101, CustomColor.LightGreen){OwnTags = new List<Tags>{Tags.GroupThirteen, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich}},
        new(State.Inactive, "Ge", 102, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupFourteen, Tags.PeriodFour, Tags.Halbmetalle, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich}},
        new(State.Inactive, "As", 103, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupFivteen, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Halbmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Se", 104, CustomColor.LightBlue){OwnTags = new List<Tags>{Tags.GroupSixteen, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFest, Tags.Halbmetalle, Tags.Nichtmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Br", 105, CustomColor.Cyan){OwnTags = new List<Tags>{Tags.GroupSeventeen, Tags.PeriodFour, Tags.DichteHoch, Tags.AggregatFlüssig, Tags.Halogene, Tags.Natuerlich}},
        new(State.Inactive, "Kr", 106, CustomColor.Amber){OwnTags = new List<Tags>{Tags.GroupEighteen, Tags.PeriodFour, Tags.DichteGering, Tags.AggregatGas, Tags.Edelgase, Tags.Natuerlich}}
    };

    private readonly ElementButtonModel[] _rowSix = {
        new(State.Inactive, "5", 87) {IsHalfWidth = true, ActivatesTag = Tags.PeriodFive},
        new(State.Inactive, "Rb", 86, CustomColor.Red){OwnTags = new List<Tags>{Tags.GroupOne, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Alkalimetalle, Tags.Natuerlich}},
        new(State.Inactive, "Sr", 85, CustomColor.Orange){OwnTags = new List<Tags>{Tags.GroupTwo, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Erdalkalimetalle, Tags.Natuerlich}},
        new(State.Inactive, "Y", 84, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Zr", 83, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFour, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Nb", 82, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFive, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Mo", 81, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSix, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Tc", 80, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSeven, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Ru", 79, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEight, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Rh", 78, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupNine, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Pd", 77, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTen, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ag", 76, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEleven, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Cd", 75, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTwelve, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "In", 74, CustomColor.LightGreen){OwnTags = new List<Tags>{Tags.GroupThirteen, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich}},
        new(State.Inactive, "Sn", 73, CustomColor.LightGreen){OwnTags = new List<Tags>{Tags.GroupFourteen, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich}},
        new(State.Inactive, "Sb", 72, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupFivteen, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich, Tags.Halbmetalle}},
        new(State.Inactive, "Te", 71, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupSixteen, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Halbmetalle, Tags.Natuerlich}},
        new(State.Inactive, "I", 70, CustomColor.Cyan){OwnTags = new List<Tags>{Tags.GroupSeventeen, Tags.PeriodFive, Tags.DichteHoch, Tags.AggregatFest, Tags.Halogene, Tags.Natuerlich}},
        new(State.Inactive, "Xe", 69, CustomColor.Amber){OwnTags = new List<Tags>{Tags.GroupEighteen, Tags.PeriodFive, Tags.DichteGering, Tags.AggregatGas, Tags.Edelgase, Tags.Natuerlich}}
    };

    private readonly ElementButtonModel[] _rowSeven = {
        new(State.Inactive, "6", 50) {IsHalfWidth = true, ActivatesTag = Tags.PeriodSix},
        new(State.Inactive, "Cs", 51, CustomColor.Red){OwnTags = new List<Tags>{Tags.GroupOne, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Alkalimetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ba", 52, CustomColor.Orange){OwnTags = new List<Tags>{Tags.GroupTwo, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Erdalkalimetalle, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "*", 53, CustomColor.Brown){ActivatesTag = Tags.Lanthanoide, OwnTags = new List<Tags>{Tags.Lanthanoide, Tags.GroupThree, Tags.PeriodSix}},
        new(State.Inactive, "Hf", 54, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFour, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ta", 55, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFive, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "W", 56, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSix, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Re", 57, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSeven, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Os", 58, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEight, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Ir", 59, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupNine, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Pt", 60, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTen, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Au", 61, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEleven, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Hg", 62, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTwelve, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFlüssig, Tags.Uebergangsmetalle, Tags.Natuerlich}},
        new(State.Inactive, "Tl", 63, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupThirteen, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich}},
        new(State.Inactive, "Pb", 64, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupFourteen, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich}},
        new(State.Inactive, "Bi", 65, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupFivteen, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Po", 66, CustomColor.Green){OwnTags = new List<Tags>{Tags.GroupSixteen, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Metalle, Tags.Natuerlich, Tags.Radioaktiv, Tags.Halbmetalle}},
        new(State.Inactive, "At", 67, CustomColor.Cyan){OwnTags = new List<Tags>{Tags.GroupSeventeen, Tags.PeriodSix, Tags.Unbekannt, Tags.AggregatFest, Tags.Halogene, Tags.Natuerlich, Tags.Radioaktiv, Tags.Halbmetalle}},
        new(State.Inactive, "Rn", 68, CustomColor.Amber){OwnTags = new List<Tags>{Tags.GroupEighteen, Tags.PeriodSix, Tags.DichteGering, Tags.AggregatGas, Tags.Edelgase, Tags.Natuerlich, Tags.Radioaktiv}}
    };

    private readonly ElementButtonModel[] _rowEight = {
        new(State.Inactive, "7", 49) {IsHalfWidth = true, ActivatesTag = Tags.PeriodSeven},
        new(State.Inactive, "Fr", 48, CustomColor.Red){OwnTags = new List<Tags>{Tags.GroupOne, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Alkalimetalle, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Ra", 47, CustomColor.Orange){OwnTags = new List<Tags>{Tags.GroupTwo, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Erdalkalimetalle, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "**", 46, CustomColor.Purple){ActivatesTag = Tags.Actinoide, OwnTags = new List<Tags>{Tags.Actinoide, Tags.GroupThree, Tags.PeriodSeven}},
        new(State.Inactive, "Rf", 45, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFour, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Db", 44, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupFive, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Sg", 43, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSix, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Bh", 42, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupSeven, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Hs", 41, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEight, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Mt", 40, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupNine, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Ds", 39, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTen, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Rg", 38, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupEleven, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatFest, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Cn", 37, CustomColor.Lime){OwnTags = new List<Tags>{Tags.GroupTwelve, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatUnbekannt, Tags.Uebergangsmetalle, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Nh", 36, CustomColor.BlueGrey){OwnTags = new List<Tags>{Tags.GroupThirteen, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatUnbekannt, Tags.Unbekannt, Tags.Kuenstlich, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Fl", 35, CustomColor.BlueGrey){OwnTags = new List<Tags>{Tags.GroupFourteen, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatUnbekannt, Tags.Unbekannt, Tags.Kuenstlich, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Mc", 34, CustomColor.BlueGrey){OwnTags = new List<Tags>{Tags.GroupFivteen, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatUnbekannt, Tags.Unbekannt, Tags.Kuenstlich, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Lv", 33, CustomColor.BlueGrey){OwnTags = new List<Tags>{Tags.GroupSixteen, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatUnbekannt, Tags.Unbekannt, Tags.Kuenstlich, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Ts", 32, CustomColor.BlueGrey){OwnTags = new List<Tags>{Tags.GroupSeventeen, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatUnbekannt, Tags.Unbekannt, Tags.Kuenstlich, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Og", 31, CustomColor.BlueGrey){OwnTags = new List<Tags>{Tags.GroupEighteen, Tags.PeriodSeven, Tags.DichteUnbekannt, Tags.AggregatUnbekannt, Tags.Unbekannt, Tags.Kuenstlich, Tags.Natuerlich, Tags.Radioaktiv}}
    };

    private readonly ElementButtonModel[] _rowNine = {
        new(){IsHalfHeight = true, IsHalfWidth = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}
    };

    private readonly ElementButtonModel[] _rowTen = {
        new() {IsHalfWidth = true}, new(), new(),
        new(State.Inactive, "La", 16, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Ce", 17, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Pr", 18, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Nd", 19, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Pm", 20, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Sm", 21, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Eu", 22, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Gd", 23, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Tb", 24, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Dy", 25, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Ho", 26, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Er", 27, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Tm", 28, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Yb", 29, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new(State.Inactive, "Lu", 30, CustomColor.Brown){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSix, Tags.DichteHoch, Tags.AggregatFest, Tags.Lanthanoide, Tags.Natuerlich}},
        new()
    };

    private readonly ElementButtonModel[] _rowEleven = {
        new(){IsHalfWidth = true}, new(), new(),
        new(State.Inactive, "Ac", 15, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Th", 14, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Pa", 13, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "U", 12, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Np", 11, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Pu", 10, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Natuerlich, Tags.Radioaktiv}},
        new(State.Inactive, "Am", 9, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Cm", 8, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Bk", 7, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Cf", 6, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Es", 5, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Fm", 4, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Md", 3, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "No", 2, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new(State.Inactive, "Lr", 1, CustomColor.Purple){OwnTags = new List<Tags>{Tags.GroupThree, Tags.PeriodSeven, Tags.DichteHoch, Tags.AggregatFest, Tags.Actinoide, Tags.Kuenstlich, Tags.Radioaktiv}},
        new()
    };
}
