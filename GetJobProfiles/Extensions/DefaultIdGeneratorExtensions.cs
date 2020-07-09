using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using MimeKit.Cryptography;
using OrchardCore.Entities;

namespace GetJobProfiles.Extensions
{
    public static class DefaultIdGeneratorExtensions
    {
        private static int nextId = 0;
        private static readonly string tokenPattern = "__TOKENISEDID[__ID__]__";
        private static readonly string tokenIdPart = "[__ID__]";
        public static bool UseTokenisation { get; set; } = false;

        public static string Generate(this DefaultIdGenerator gen)
        {
            return UseTokenisation ? tokenPattern.Replace(tokenIdPart,$"{nextId++}") : gen.Generate();
        }
    }
}
