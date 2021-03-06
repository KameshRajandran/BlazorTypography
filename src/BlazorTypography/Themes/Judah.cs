﻿using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class Judah : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Judah";
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = (5 / 3f).ToString("F3");
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Roboto Condensed", Styles = new List<string>{ "400", "400i" } } },
            { new GoogleFont{ Name = "Vollkorn", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Vollkorn", "Georgia", "serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,1)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Roboto Condensed", "sans-serif" };
        public override string HeaderWeight { get; set; } = "400";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("a", $@"
                    color: #e51937;
                    text-decoration: none;
                ");
                styles.Add("a:hover,a:active", $@"
                    color: {options.BodyColor};
                    text-decoration: none;
                ");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(3 / 16f)} solid {vr.Gray(80)};
                    color: {vr.Gray(0)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(13 / 16f)};
                    margin-left: 0;
                ");
                styles.Add("blockquote > :last-child", "margin-bottom: 0;");
                styles.Add("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.Add("blockquote cite:before", @"content: ""-"";");
                styles.Add("ul", "list-style: disc;");
                styles.Add(vr.MOBILE_MEDIA_QUERY, $@"
                    ul,ol {{
                        margin-left: {vr.Rhythm(1)};
                    }}
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                    h5,h6 {{
                        text-transform: uppercase;
                        font-style: italic;
                    }}
                ");
            });
    }
}
