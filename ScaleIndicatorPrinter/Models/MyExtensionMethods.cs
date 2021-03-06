using System;
using Microsoft.SPOT;

using NetMf.CommonExtensions;
using Json.NETMF;
using NetduinoRGBLCDShield;
using Microsoft.SPOT.Net.NetworkInformation;


namespace ScaleIndicatorPrinter.Models
{
    public static class MyExtensionMethods
    {
        public static string SetParameters(this string source, string[] Params)
        {
            var strTemp = source;

            for (int intCounter = Params.Length - 1; intCounter > -1; intCounter--)
                strTemp = strTemp.Replace("~p" + intCounter, Params[intCounter]);

            return strTemp;
        }

        public static string GetName(this BacklightColor source)
        {
            switch (source)
            {
                case BacklightColor.Off:
                    return "Off";
                case BacklightColor.Red:
                    return "Red";
                case BacklightColor.Yellow:
                    return "Yellow";
                case BacklightColor.Green:
                    return "Green";
                case BacklightColor.Teal:
                    return "Teal";
                case BacklightColor.Blue:
                    return "Blue";
                case BacklightColor.Violet:
                    return "Violet";
                case BacklightColor.White:
                    return "White";
                default:
                    return "Undefined";
            }
        }

        public static string GetName(this NetworkInterfaceType source)
        {
            switch (source)
            {
                case NetworkInterfaceType.Ethernet:
                    return "Ethernet";
                case NetworkInterfaceType.Wireless80211:
                    return "Wireless802.11";
                case NetworkInterfaceType.Unknown:
                    return "Unknown";
                default:
                    return "Undefined";
            }
        }

        public static string GetName(this RecievedData source)
        {
            switch (source)
            {
                case RecievedData.ScaleIndicator:
                    return "ScaleIndicator";
                case RecievedData.ScannerJobAndSuffix:
                    return "ScannerJobAndSuffix";
                case RecievedData.ScannerOperation:
                    return "ScannerOperation";
                case RecievedData.None:
                    return "None";
                default:
                    return "Undefined";
            }
        }

        public static BacklightColor GetBackLightColor(this string source)
        {
            switch (source.ToUpper())
            {
                case "OFF":
                    return BacklightColor.Off;
                case "RED":
                    return BacklightColor.Red;
                case "YELLOW":
                    return BacklightColor.Yellow;
                case "GREEN":
                    return BacklightColor.Green;
                case "TEAL":
                    return BacklightColor.Teal;
                case "BLUE":
                    return BacklightColor.Blue;
                case "VIOLET":
                    return BacklightColor.Violet;
                case "WHITE":
                    return BacklightColor.White;
                default:
                    return BacklightColor.Off;
            }
        }

        public static string Flatten(this string[] source)
        {
            var strTemp = string.Empty;

            foreach (var str in source)
                strTemp += str + ", ";
            return strTemp.Substring(0, strTemp.Length - 2);
        }

        public static string EscapeSingleQuotes(this string source)
        {
            return source.Replace("\'", @"''");
        }
        public static string EscapeDoubleQuotes(this string source)
        {
            return source.Replace("\"", @"""");
        }
        public static string EscapeNewLineCarriageReturn(this string source)
        {
            return source.Replace("\r\n", "\\r\\n");
        }
    }

}
