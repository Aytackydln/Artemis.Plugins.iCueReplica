using System.Collections.Frozen;
using System.Collections.Generic;
using iCUE_ReverseEngineer;
using RGB.NET.Core;

namespace Artemis.Plugins.iCueReplica.LayerBrush;

public static class IcueArtemisKeyMapping
{
    public static FrozenDictionary<IcueLedId, LedId> KeyMapping { get; } = new Dictionary<IcueLedId, LedId>
    {
        { IcueLedId.Escape, LedId.Keyboard_Escape },
        { IcueLedId.F1, LedId.Keyboard_F1 },
        { IcueLedId.F2, LedId.Keyboard_F2 },
        { IcueLedId.F3, LedId.Keyboard_F3 },
        { IcueLedId.F4, LedId.Keyboard_F4 },
        { IcueLedId.F5, LedId.Keyboard_F5 },
        { IcueLedId.F6, LedId.Keyboard_F6 },
        { IcueLedId.F7, LedId.Keyboard_F7 },
        { IcueLedId.F8, LedId.Keyboard_F8 },
        { IcueLedId.F9, LedId.Keyboard_F9 },
        { IcueLedId.F10, LedId.Keyboard_F10 },
        { IcueLedId.F11, LedId.Keyboard_F11 },
        { IcueLedId.F12, LedId.Keyboard_F12 },

        { IcueLedId.PrintScreen, LedId.Keyboard_PrintScreen },
        { IcueLedId.ScrollLock, LedId.Keyboard_ScrollLock },
        { IcueLedId.PauseBreak, LedId.Keyboard_PauseBreak },

        { IcueLedId.Tilde, LedId.Keyboard_NonUsTilde },

        { IcueLedId.One, LedId.Keyboard_1 },
        { IcueLedId.Two, LedId.Keyboard_2 },
        { IcueLedId.Three, LedId.Keyboard_3 },
        { IcueLedId.Four, LedId.Keyboard_4 },
        { IcueLedId.Five, LedId.Keyboard_5 },
        { IcueLedId.Six, LedId.Keyboard_6 },
        { IcueLedId.Seven, LedId.Keyboard_7 },
        { IcueLedId.Eight, LedId.Keyboard_8 },
        { IcueLedId.Nine, LedId.Keyboard_9 },
        { IcueLedId.Zero, LedId.Keyboard_0 },

        { IcueLedId.Minus, LedId.Keyboard_MinusAndUnderscore },
        { IcueLedId.Equals, LedId.Keyboard_EqualsAndPlus },
        { IcueLedId.Backspace, LedId.Keyboard_Backspace },

        { IcueLedId.Insert, LedId.Keyboard_Insert },
        { IcueLedId.Home, LedId.Keyboard_Home },
        { IcueLedId.PageUp, LedId.Keyboard_PageUp },

        { IcueLedId.NumLock, LedId.Keyboard_NumLock },
        { IcueLedId.NumpadSlash, LedId.Keyboard_NumSlash },
        { IcueLedId.NumpadAsterisk, LedId.Keyboard_NumAsterisk },
        { IcueLedId.NumpadMinus, LedId.Keyboard_NumMinus },

        { IcueLedId.Tab, LedId.Keyboard_Tab },

        { IcueLedId.Q, LedId.Keyboard_Q },
        { IcueLedId.W, LedId.Keyboard_W },
        { IcueLedId.E, LedId.Keyboard_E },
        { IcueLedId.R, LedId.Keyboard_R },
        { IcueLedId.T, LedId.Keyboard_T },
        { IcueLedId.Y, LedId.Keyboard_Y },
        { IcueLedId.U, LedId.Keyboard_U },
        { IcueLedId.I, LedId.Keyboard_I },
        { IcueLedId.O, LedId.Keyboard_O },
        { IcueLedId.P, LedId.Keyboard_P },

        { IcueLedId.OpenBracket, LedId.Keyboard_BracketLeft },
        { IcueLedId.CloseBracket, LedId.Keyboard_BracketRight },
        { IcueLedId.Enter, LedId.Keyboard_Enter },

        { IcueLedId.Delete, LedId.Keyboard_Delete },
        { IcueLedId.End, LedId.Keyboard_End },
        { IcueLedId.PageDown, LedId.Keyboard_PageDown },

        { IcueLedId.CapsLock, LedId.Keyboard_CapsLock },

        { IcueLedId.A, LedId.Keyboard_A },
        { IcueLedId.S, LedId.Keyboard_S },
        { IcueLedId.D, LedId.Keyboard_D },
        { IcueLedId.F, LedId.Keyboard_F },
        { IcueLedId.G, LedId.Keyboard_G },
        { IcueLedId.H, LedId.Keyboard_H },
        { IcueLedId.J, LedId.Keyboard_J },
        { IcueLedId.K, LedId.Keyboard_K },
        { IcueLedId.L, LedId.Keyboard_L },

        { IcueLedId.Semicolon, LedId.Keyboard_SemicolonAndColon },
        { IcueLedId.SingleQuote, LedId.Keyboard_ApostropheAndDoubleQuote },
        // nonustilde
        //{ IcueLedId.NonUsTilde, LedId.Keyboard_NON_US_TILDE },

        { IcueLedId.ShiftLeft, LedId.Keyboard_LeftShift },
        { IcueLedId.Backslash, LedId.Keyboard_NonUsBackslash },
        { IcueLedId.Z, LedId.Keyboard_Z },
        { IcueLedId.X, LedId.Keyboard_X },
        { IcueLedId.C, LedId.Keyboard_C },
        { IcueLedId.V, LedId.Keyboard_V },
        { IcueLedId.B, LedId.Keyboard_B },
        { IcueLedId.N, LedId.Keyboard_N },
        { IcueLedId.M, LedId.Keyboard_M },

        { IcueLedId.Comma, LedId.Keyboard_CommaAndLessThan },
        { IcueLedId.Period, LedId.Keyboard_PeriodAndBiggerThan },
        { IcueLedId.ForwardSlash, LedId.Keyboard_SlashAndQuestionMark },

        { IcueLedId.RightShift, LedId.Keyboard_RightShift },

        { IcueLedId.UpArrow, LedId.Keyboard_ArrowUp },

        { IcueLedId.LeftControl, LedId.Keyboard_LeftCtrl },
        { IcueLedId.LeftWindows, LedId.Keyboard_Application },
        { IcueLedId.LeftAlt, LedId.Keyboard_LeftAlt },

        { IcueLedId.Space, LedId.Keyboard_Space },

        { IcueLedId.RightAlt, LedId.Keyboard_RightAlt },
        { IcueLedId.ContextMenu, LedId.Keyboard_RightGui },
        { IcueLedId.Fn, LedId.Keyboard_Function },
        { IcueLedId.RightControl, LedId.Keyboard_RightCtrl },

        { IcueLedId.LeftArrow, LedId.Keyboard_ArrowLeft },
        { IcueLedId.DownArrow, LedId.Keyboard_ArrowDown },
        { IcueLedId.RightArrow, LedId.Keyboard_ArrowRight },

        { IcueLedId.NumpadSeven, LedId.Keyboard_Num7 },
        { IcueLedId.NumpadEight, LedId.Keyboard_Num8 },
        { IcueLedId.NumpadNine, LedId.Keyboard_Num9 },
        { IcueLedId.NumpadPlus, LedId.Keyboard_NumPlus },

        { IcueLedId.NumpadFour, LedId.Keyboard_Num4 },
        { IcueLedId.NumpadFive, LedId.Keyboard_Num5 },
        { IcueLedId.NumpadSix, LedId.Keyboard_Num6 },

        { IcueLedId.NumpadOne, LedId.Keyboard_Num1 },
        { IcueLedId.NumpadTwo, LedId.Keyboard_Num2 },
        { IcueLedId.NumpadThree, LedId.Keyboard_Num3 },
        { IcueLedId.NumpadZero, LedId.Keyboard_Num9 },

        { IcueLedId.NumpadPeriod, LedId.Keyboard_NumPeriodAndDelete },
        { IcueLedId.NumpadEnter, LedId.Keyboard_NumEnter },
    }.ToFrozenDictionary();
}