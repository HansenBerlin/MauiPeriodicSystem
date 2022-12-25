using MauiAppBlazorTest.Values;

namespace MauiAppBlazorTest.Models;

public class ButtonGrid
{
    private readonly ButtonStateModel[] _rowOne = {
        new(){IsHalfHeight = true, IsHalfWidth = true},
        new(State.Inactive, "1", 121) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 1, 1 }, new []{ 2, 1 }, new []{ 3, 1 }, new []{ 4, 1 }, new []{ 5, 1 }, new []{ 6, 1 }, new []{ 7, 1 }}},
        new(State.Inactive, "2", 122) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 2, 2 }, new []{ 3, 2 }, new []{ 4, 2 }, new []{ 5, 2 }, new []{ 6, 2 }, new []{ 7, 2 }}},
        new(State.Inactive, "3", 123) {IsHalfHeight = true, ActivatesElementsWithColors = new(){CustomColor.Pink, CustomColor.Purple}, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 3 }, new []{ 5, 3 }, new []{ 6, 3 }, new []{ 7, 3 }}},
        new(State.Inactive, "4", 124) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 4 }, new []{ 5, 4 }, new []{ 6, 4 }, new []{ 7, 4 }}},
        new(State.Inactive, "5", 125) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 5 }, new []{ 5, 5 }, new []{ 6, 5 }, new []{ 7, 5 }}},
        new(State.Inactive, "6", 126) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 6 }, new []{ 5, 6 }, new []{ 6, 6 }, new []{ 7, 6 }}},
        new(State.Inactive, "7", 127) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 7 }, new []{ 5, 7 }, new []{ 6, 7 }, new []{ 7, 7 }}},
        new(State.Inactive, "8", 128) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 8 }, new []{ 5, 8 }, new []{ 6, 8 }, new []{ 7, 8 }}},
        new(State.Inactive, "9", 129) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 9 }, new []{ 5, 9 }, new []{ 6, 9 }, new []{ 7, 9 }}},
        new(State.Inactive, "10", 130) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 10 }, new []{ 5, 10 }, new []{ 6, 10 }, new []{ 7, 10 }}},
        new(State.Inactive, "11", 131) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 11 }, new []{ 5, 11 }, new []{ 6, 11 }, new []{ 7, 11 }}},
        new(State.Inactive, "12", 132) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 12 }, new []{ 5, 12 }, new []{ 6, 12 }, new []{ 7, 12 }}},
        new(State.Inactive, "13", 133) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 2, 13 }, new []{ 3, 13 }, new []{ 4, 13 }, new []{ 5, 13 }, new []{ 6, 13 }, new []{ 7, 13 }}},
        new(State.Inactive, "14", 134) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 2, 14 }, new []{ 3, 14 }, new []{ 4, 14 }, new []{ 5, 14 }, new []{ 6, 14 }, new []{ 7, 14 }}},
        new(State.Inactive, "15", 135) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 2, 15 }, new []{ 3, 15 }, new []{ 4, 15 }, new []{ 5, 15 }, new []{ 6, 15 }, new []{ 7, 15 }}},
        new(State.Inactive, "16", 136) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 2, 16 }, new []{ 3, 16 }, new []{ 4, 16 }, new []{ 5, 16 }, new []{ 6, 16 }, new []{ 7, 16 }}},
        new(State.Inactive, "17", 137) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 2, 17 }, new []{ 3, 17 }, new []{ 4, 17 }, new []{ 5, 17 }, new []{ 6, 17 }, new []{ 7, 17 }}},
        new(State.Inactive, "18", 138) {IsHalfHeight = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 1, 18 }, new []{ 2, 18 }, new []{ 3, 18 }, new []{ 4, 18 }, new []{ 5, 18 }, new []{ 6, 18 }, new []{ 7, 18 }}}
    };

    private readonly ButtonStateModel[] _rowTwo = {
        new(State.Inactive, "1", 120){IsHalfWidth = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 1, 1 }, new []{ 1, 18 }}},
        new(State.Inactive, "H", 119, CustomColor.LightBlue),
        new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(), new(),
        new(State.Inactive, "He", 139, CustomColor.Grey)
    };

    private readonly ButtonStateModel[] _rowThree = {
        new(State.Inactive, "2", 116) {IsHalfWidth = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 2, 1 }, new []{ 2, 2 }, new []{ 2, 13 },
            new []{ 2, 14 }, new []{ 2, 15 }, new []{ 2, 16 }, new []{ 2, 17 }, new []{ 2, 18 }}},
        new(State.Inactive, "Li", 117, CustomColor.Red),
        new(State.Inactive, "Be", 118, CustomColor.Orange),
        new(), new(), new(), new(), new(), new(), new(), new(), new(), new(),
        new(State.Inactive, "B", 140, CustomColor.Green),
        new(State.Inactive, "C", 141, CustomColor.LightBlue),
        new(State.Inactive, "N", 142, CustomColor.LightBlue),
        new(State.Inactive, "O", 143, CustomColor.LightBlue),
        new(State.Inactive, "F", 144, CustomColor.Blue),
        new(State.Inactive, "Ne", 145, CustomColor.Grey),
    };

    private readonly ButtonStateModel[] _rowFour = {
        new(State.Inactive, "3", 115) {IsHalfWidth = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 3, 1 }, new []{ 3, 2 }, new []{ 3, 13 },
            new []{ 3, 14 }, new []{ 3, 15 }, new []{ 3, 16 }, new []{ 3, 17 }, new []{ 3, 18 }}},
        new(State.Inactive, "Na", 114, CustomColor.Red),
        new(State.Inactive, "Mg", 113, CustomColor.Orange),
        new(), new(), new(), new(), new(), new(), new(), new(), new(), new(),
        new(State.Inactive, "Al", 112, CustomColor.LightGreen),
        new(State.Inactive, "Si", 111, CustomColor.Green),
        new(State.Inactive, "P", 110, CustomColor.LightBlue),
        new(State.Inactive, "S", 109, CustomColor.LightBlue),
        new(State.Inactive, "Cl", 108, CustomColor.Blue),
        new(State.Inactive, "Ar", 107, CustomColor.Grey)
    };

    private readonly ButtonStateModel[] _rowFive = {
        new(State.Inactive, "4", 88) {IsHalfWidth = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 4, 1 }, new []{ 4, 2 }, new []{ 4, 3 }, new []{ 4, 4 },
            new []{ 4, 5 }, new []{ 4, 6 }, new []{ 4, 7 }, new []{ 4, 8 }, new []{ 4, 9 }, new []{ 4, 10 }, new []{ 4, 11 }, new []{ 4, 12 },
            new []{ 4, 13 }, new []{ 4, 14 }, new []{ 4, 15 }, new []{ 4, 16 }, new []{ 4, 17 }, new []{ 4, 18 }}},
        new(State.Inactive, "K", 89, CustomColor.Red),
        new(State.Inactive, "Ca", 90, CustomColor.Orange),
        new(State.Inactive, "Sc", 91, CustomColor.Lime),
        new(State.Inactive, "Ti", 92, CustomColor.Lime),
        new(State.Inactive, "V", 93, CustomColor.Lime),
        new(State.Inactive, "Cr", 94, CustomColor.Lime),
        new(State.Inactive, "Mn", 95, CustomColor.Lime),
        new(State.Inactive, "Fe", 96, CustomColor.Lime),
        new(State.Inactive, "Co", 97, CustomColor.Lime),
        new(State.Inactive, "Ni", 98, CustomColor.Lime),
        new(State.Inactive, "Cu", 99, CustomColor.Lime),
        new(State.Inactive, "Zn", 100, CustomColor.Lime),
        new(State.Inactive, "Ga", 101, CustomColor.LightGreen),
        new(State.Inactive, "Ge", 102, CustomColor.Green),
        new(State.Inactive, "As", 103, CustomColor.Green),
        new(State.Inactive, "Se", 104, CustomColor.LightBlue),
        new(State.Inactive, "Br", 105, CustomColor.Blue),
        new(State.Inactive, "Kr", 106, CustomColor.Grey)
    };

    private readonly ButtonStateModel[] _rowSix = {
        new(State.Inactive, "5", 87) {IsHalfWidth = true, ActivatesElementsAtIndex = new List<int[]> { new []{ 5, 1 }, new []{ 5, 2 }, new []{ 5, 3 }, new []{ 5, 4 },
            new []{ 5, 5 }, new []{ 5, 6 }, new []{ 5, 7 }, new []{ 5, 8 }, new []{ 5, 9 }, new []{ 5, 10 }, new []{ 5, 11 }, new []{ 5, 12 },
            new []{ 5, 13 }, new []{ 5, 14 }, new []{ 5, 15 }, new []{ 5, 16 }, new []{ 5, 17 }, new []{ 5, 18 }}},
        new(State.Inactive, "Rb", 86, CustomColor.Red),
        new(State.Inactive, "Sr", 85, CustomColor.Orange),
        new(State.Inactive, "Y", 84, CustomColor.Lime),
        new(State.Inactive, "Zr", 83, CustomColor.Lime),
        new(State.Inactive, "Nb", 82, CustomColor.Lime),
        new(State.Inactive, "Mo", 81, CustomColor.Lime),
        new(State.Inactive, "Tc", 80, CustomColor.Lime),
        new(State.Inactive, "Ru", 79, CustomColor.Lime),
        new(State.Inactive, "Rh", 78, CustomColor.Lime),
        new(State.Inactive, "Pd", 77, CustomColor.Lime),
        new(State.Inactive, "Ag", 76, CustomColor.Lime),
        new(State.Inactive, "Cd", 75, CustomColor.Lime),
        new(State.Inactive, "In", 74, CustomColor.LightGreen),
        new(State.Inactive, "Sn", 73, CustomColor.LightGreen),
        new(State.Inactive, "Sb", 72, CustomColor.Green),
        new(State.Inactive, "Te", 71, CustomColor.Green),
        new(State.Inactive, "I", 70, CustomColor.Blue),
        new(State.Inactive, "Xe", 69, CustomColor.Grey)
    };

    private readonly ButtonStateModel[] _rowSeven = {
        new(State.Inactive, "6", 50) {IsHalfWidth = true, ActivatesElementsWithColors = new(){CustomColor.Pink}, ActivatesElementsAtIndex = new List<int[]> { new []{ 6, 1 }, new []{ 6, 2 }, new []{ 6, 3 }, new []{ 6, 4 },
            new []{ 6, 5 }, new []{ 6, 6 }, new []{ 6, 7 }, new []{ 6, 8 }, new []{ 6, 9 }, new []{ 6, 10 }, new []{ 6, 11 }, new []{ 6, 12 },
            new []{ 6, 13 }, new []{ 6, 14 }, new []{ 6, 15 }, new []{ 6, 16 }, new []{ 6, 17 }, new []{ 6, 18 }}},
        new(State.Inactive, "Cs", 51, CustomColor.Red),
        new(State.Inactive, "Ba", 52, CustomColor.Orange),
        new(State.Inactive, "*", 53, CustomColor.Pink){ActivatesElementsWithColors = new(){CustomColor.Pink}},
        new(State.Inactive, "Hf", 54, CustomColor.Lime),
        new(State.Inactive, "Ta", 55, CustomColor.Lime),
        new(State.Inactive, "W", 56, CustomColor.Lime),
        new(State.Inactive, "Re", 57, CustomColor.Lime),
        new(State.Inactive, "Os", 58, CustomColor.Lime),
        new(State.Inactive, "Ir", 59, CustomColor.Lime),
        new(State.Inactive, "Pt", 60, CustomColor.Lime),
        new(State.Inactive, "Au", 61, CustomColor.Lime),
        new(State.Inactive, "Hg", 62, CustomColor.Lime),
        new(State.Inactive, "Ti", 63, CustomColor.Green),
        new(State.Inactive, "Pb", 64, CustomColor.Green),
        new(State.Inactive, "Bi", 65, CustomColor.Green),
        new(State.Inactive, "Po", 66, CustomColor.Green),
        new(State.Inactive, "At", 67, CustomColor.Blue),
        new(State.Inactive, "Rn", 68, CustomColor.Grey)
    };

    private readonly ButtonStateModel[] _rowEight = {
        new(State.Inactive, "7", 49) {IsHalfWidth = true, ActivatesElementsWithColors = new(){CustomColor.Purple}, ActivatesElementsAtIndex = new List<int[]> { new []{ 7, 1 }, new []{ 7, 2 }, new []{ 7, 3 }, new []{ 7, 4 },
            new []{ 7, 5 }, new []{ 7, 6 }, new []{ 7, 7 }, new []{ 7, 8 }, new []{ 7, 9 }, new []{ 7, 10 }, new []{ 7, 11 }, new []{ 7, 12 },
            new []{ 7, 13 }, new []{ 7, 14 }, new []{ 7, 15 }, new []{ 7, 16 }, new []{ 7, 17 }, new []{ 7, 18 }}},
        new(State.Inactive, "Fr", 48, CustomColor.Red),
        new(State.Inactive, "Ra", 47, CustomColor.Orange),
        new(State.Inactive, "**", 46, CustomColor.Purple){ActivatesElementsWithColors = new(){CustomColor.Purple}},
        new(State.Inactive, "Rf", 45, CustomColor.Lime),
        new(State.Inactive, "Db", 44, CustomColor.Lime),
        new(State.Inactive, "Sg", 43, CustomColor.Lime),
        new(State.Inactive, "Bh", 42, CustomColor.Lime),
        new(State.Inactive, "Hs", 41, CustomColor.Lime),
        new(State.Inactive, "Mt", 40, CustomColor.BlueGrey),
        new(State.Inactive, "Ds", 39, CustomColor.BlueGrey),
        new(State.Inactive, "Rg", 38, CustomColor.BlueGrey),
        new(State.Inactive, "Cn", 37, CustomColor.Lime),
        new(State.Inactive, "Nh", 36, CustomColor.BlueGrey),
        new(State.Inactive, "Fl", 35, CustomColor.BlueGrey),
        new(State.Inactive, "Mc", 34, CustomColor.BlueGrey),
        new(State.Inactive, "Lv", 33, CustomColor.BlueGrey),
        new(State.Inactive, "Ts", 32, CustomColor.BlueGrey),
        new(State.Inactive, "Og", 31, CustomColor.BlueGrey)
    };

    private readonly ButtonStateModel[] _rowNine = {
        new(){IsHalfHeight = true, IsHalfWidth = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true},
        new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}, new(){IsHalfHeight = true}
    };

    private readonly ButtonStateModel[] _rowTen = {
        new() {IsHalfWidth = true}, new(), new(),
        new(State.Inactive, "La", 16, CustomColor.Pink),
        new(State.Inactive, "Ce", 17, CustomColor.Pink),
        new(State.Inactive, "Pr", 18, CustomColor.Pink),
        new(State.Inactive, "Nd", 19, CustomColor.Pink),
        new(State.Inactive, "Pm", 20, CustomColor.Pink),
        new(State.Inactive, "Sm", 21, CustomColor.Pink),
        new(State.Inactive, "Eu", 22, CustomColor.Pink),
        new(State.Inactive, "Gd", 23, CustomColor.Pink),
        new(State.Inactive, "Tb", 24, CustomColor.Pink),
        new(State.Inactive, "Dy", 25, CustomColor.Pink),
        new(State.Inactive, "Ho", 26, CustomColor.Pink),
        new(State.Inactive, "Er", 27, CustomColor.Pink),
        new(State.Inactive, "Tm", 28, CustomColor.Pink),
        new(State.Inactive, "Yb", 29, CustomColor.Pink),
        new(State.Inactive, "Lu", 30, CustomColor.Pink),
        new()
    };

    private readonly ButtonStateModel[] _rowEleven = {
        new(){IsHalfWidth = true}, new(), new(),
        new(State.Inactive, "Ac", 15, CustomColor.Purple),
        new(State.Inactive, "Th", 14, CustomColor.Purple),
        new(State.Inactive, "Pa", 13, CustomColor.Purple),
        new(State.Inactive, "U", 12, CustomColor.Purple),
        new(State.Inactive, "Np", 11, CustomColor.Purple),
        new(State.Inactive, "Pu", 10, CustomColor.Purple),
        new(State.Inactive, "Am", 9, CustomColor.Purple),
        new(State.Inactive, "Cm", 8, CustomColor.Purple),
        new(State.Inactive, "Bk", 7, CustomColor.Purple),
        new(State.Inactive, "Cf", 6, CustomColor.Purple),
        new(State.Inactive, "Es", 5, CustomColor.Purple),
        new(State.Inactive, "Fm", 4, CustomColor.Purple),
        new(State.Inactive, "Md", 3, CustomColor.Purple),
        new(State.Inactive, "No", 2, CustomColor.Purple),
        new(State.Inactive, "Lr", 1, CustomColor.Purple),
        new()
    };

    public ButtonStateModel[][] Grid { get; }
    public List<ButtonStateModel> AllButtons { get; } = new();

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
                if (col.State != State.Dummy)
                {
                    AllButtons.Add(col);
                }
            }
        }
    }
}
