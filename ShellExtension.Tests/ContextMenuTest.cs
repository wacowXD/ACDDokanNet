// <copyright file="ContextMenuTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using ShellExtension;
using Xunit;
using System.Collections.Generic;

namespace ShellExtension.Tests
{
    public class ContextMenuTest : ContextMenu
    {
        override protected IEnumerable<string> SelectedItemPaths =>
            new[] { @"F:\Photos\2016\2016-02\2016-02-13 Daiba\Seoppi.MOV" };

        [Fact]
        public void TestOpenAsUrl()
        {
            OpenAsUrl(null, null);
        }
    }
}
